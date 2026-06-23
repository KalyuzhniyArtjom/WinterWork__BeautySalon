using BeautySalonLib.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace BeautySalonLib.Managers
{
    public class AppointmentManager
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();

        public List<Appointment> GetAllAppointments()
        {
            var appointments = new List<Appointment>();
            string query = @"
                SELECT a.*, c.""Name"" AS ClientName, c.""Phone"" AS ClientPhone,
                       s.""Name"" AS ServiceName, s.""Price"",
                       m.""FullName"" AS MasterName
                FROM ""Appointments"" a
                JOIN ""Clients"" c ON a.""ClientId"" = c.""Id""
                JOIN ""Services"" s ON a.""ServiceId"" = s.""Id""
                JOIN ""Masters"" m ON a.""MasterId"" = m.""Id""
                ORDER BY a.""Date"", a.""Time""";

            DataTable dt = _dbHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                appointments.Add(MapRowToAppointment(row));
            }
            return appointments;
        }

        public List<Service> GetAllServices()
        {
            var services = new List<Service>();
            string query = "SELECT * FROM \"Services\" ORDER BY \"Name\"";
            DataTable dt = _dbHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                services.Add(new Service
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    Price = Convert.ToDecimal(row["Price"]),
                    DurationMinutes = Convert.ToInt32(row["DurationMinutes"])
                });
            }
            return services;
        }

        public List<Master> GetAllMasters()
        {
            var masters = new List<Master>();
            string query = "SELECT * FROM \"Masters\" ORDER BY \"FullName\"";
            DataTable dt = _dbHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                masters.Add(new Master
                {
                    Id = Convert.ToInt32(row["Id"]),
                    EmployeeId = Convert.ToInt32(row["EmployeeId"]),
                    FullName = row["FullName"].ToString(),
                    Specialization = row["Specialization"].ToString(),
                    SkillLevel = row["SkillLevel"].ToString(),
                    Phone = row["Phone"].ToString()
                });
            }
            return masters;
        }

        public List<Client> GetAllClients()
        {
            var clients = new List<Client>();
            string query = "SELECT * FROM \"Clients\" ORDER BY \"Name\"";
            DataTable dt = _dbHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                clients.Add(new Client
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    Phone = row["Phone"].ToString()
                });
            }
            return clients;
        }

        public bool CreateAppointment(Appointment appointment)
        {
            if (!IsTimeAvailable(appointment.MasterId, appointment.Date, appointment.Time))
                return false;

            string query = @"INSERT INTO ""Appointments"" 
                            (""ClientId"", ""ServiceId"", ""MasterId"", ""Date"", ""Time"", ""Status"", ""ClientComment"") 
                            VALUES (@clientId, @serviceId, @masterId, @date, @time, @status, @comment)";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@clientId", appointment.ClientId),
                new NpgsqlParameter("@serviceId", appointment.ServiceId),
                new NpgsqlParameter("@masterId", appointment.MasterId),
                new NpgsqlParameter("@date", appointment.Date),
                new NpgsqlParameter("@time", appointment.Time),
                new NpgsqlParameter("@status", appointment.Status ?? "Записана"),
                new NpgsqlParameter("@comment", (object)appointment.ClientComment ?? DBNull.Value)
            };

            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool IsTimeAvailable(int masterId, DateTime date, TimeSpan time)
        {
            string query = @"
                SELECT COUNT(*) FROM ""Appointments"" 
                WHERE ""MasterId"" = @masterId AND ""Date"" = @date AND ""Time"" = @time 
                AND ""Status"" NOT IN ('Отменена', 'Клиент не пришёл')";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@masterId", masterId),
                new NpgsqlParameter("@date", date),
                new NpgsqlParameter("@time", time)
            };

            DataTable dt = _dbHelper.ExecuteQuery(query);
            return Convert.ToInt32(dt.Rows[0][0]) == 0;
        }

        public bool CancelAppointment(int appointmentId, string reason)
        {
            string query = @"UPDATE ""Appointments"" SET ""Status"" = @status WHERE ""Id"" = @id";
            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@status", reason),
                new NpgsqlParameter("@id", appointmentId)
            };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateStatus(int appointmentId, string status)
        {
            string query = @"UPDATE ""Appointments"" SET ""Status"" = @status WHERE ""Id"" = @id";
            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@status", status),
                new NpgsqlParameter("@id", appointmentId)
            };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public List<Appointment> SearchAppointments(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return GetAllAppointments();

            var appointments = new List<Appointment>();
            string query = @"
                SELECT a.*, c.""Name"" AS ClientName, c.""Phone"" AS ClientPhone,
                       s.""Name"" AS ServiceName, s.""Price"",
                       m.""FullName"" AS MasterName
                FROM ""Appointments"" a
                JOIN ""Clients"" c ON a.""ClientId"" = c.""Id""
                JOIN ""Services"" s ON a.""ServiceId"" = s.""Id""
                JOIN ""Masters"" m ON a.""MasterId"" = m.""Id""
                WHERE c.""Name"" ILIKE @search OR c.""Phone"" ILIKE @search
                ORDER BY a.""Date"", a.""Time""";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@search", $"%{searchText}%")
            };

            DataTable dt = _dbHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                appointments.Add(MapRowToAppointment(row));
            }
            return appointments;
        }

        private Appointment MapRowToAppointment(DataRow row)
        {
            return new Appointment
            {
                Id = Convert.ToInt32(row["Id"]),
                ClientId = Convert.ToInt32(row["ClientId"]),
                ServiceId = Convert.ToInt32(row["ServiceId"]),
                MasterId = Convert.ToInt32(row["MasterId"]),
                Date = Convert.ToDateTime(row["Date"]),
                Time = TimeSpan.Parse(row["Time"].ToString()),
                Status = row["Status"].ToString(),
                ClientComment = row["ClientComment"]?.ToString(),
                ClientName = row["ClientName"].ToString(),
                ClientPhone = row["ClientPhone"].ToString(),
                ServiceName = row["ServiceName"].ToString(),
                MasterName = row["MasterName"].ToString(),
                Price = Convert.ToDecimal(row["Price"])
            };
        }
    }
}
