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
    public class MasterScheduleManager
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();
        private int _masterId;

        public MasterScheduleManager(int masterId)
        {
            _masterId = masterId;
        }

        public List<Appointment> GetAppointmentsByDate(DateTime date)
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
                WHERE a.""MasterId"" = @masterId AND a.""Date"" = @date
                ORDER BY a.""Time""";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@masterId", _masterId),
                new NpgsqlParameter("@date", date)
            };

            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);
            foreach (DataRow row in dt.Rows)
            {
                appointments.Add(MapRowToAppointment(row));
            }
            return appointments;
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
