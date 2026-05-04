using BeautySalonLib.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace BeautySalonLib
{
    public class DatabaseHelper
    {
        private string connectionString;

        // Пользователи по умолчанию для тестирования
        private bool useDefaultData = true;

        public DatabaseHelper()
        {
            // Настройки подключения к PostgreSQL
            connectionString = "Host=localhost;Port=5432;Database=BeautySalonDB;Username=postgres;Password=123456";
        }

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }

        public DataTable ExecuteQuery(string query, NpgsqlParameter[] parameters = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public int ExecuteNonQuery(string query, NpgsqlParameter[] parameters = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public object ExecuteScalar(string query, NpgsqlParameter[] parameters = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }

        // Методы для получения списков (используются при отсутствии БД)
        public List<Service> GetServices()
        {
            var services = new List<Service>();

            if (useDefaultData)
            {
                services.Add(new Service { Id = 1, Name = "Стрижка женская", Price = 1500, DurationMinutes = 60 });
                services.Add(new Service { Id = 2, Name = "Стрижка мужская", Price = 1000, DurationMinutes = 45 });
                services.Add(new Service { Id = 3, Name = "Маникюр", Price = 1200, DurationMinutes = 90 });
                services.Add(new Service { Id = 4, Name = "Педикюр", Price = 1800, DurationMinutes = 90 });
                services.Add(new Service { Id = 5, Name = "Окрашивание волос", Price = 3500, DurationMinutes = 120 });
                services.Add(new Service { Id = 6, Name = "Укладка", Price = 800, DurationMinutes = 30 });
                services.Add(new Service { Id = 7, Name = "Чистка лица", Price = 2000, DurationMinutes = 60 });
                services.Add(new Service { Id = 8, Name = "Массаж спины", Price = 2500, DurationMinutes = 60 });
                return services;
            }

            string query = "SELECT * FROM Services ORDER BY Id";
            DataTable dt = ExecuteQuery(query);
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

        public List<Master> GetMasters()
        {
            var masters = new List<Master>();

            if (useDefaultData)
            {
                masters.Add(new Master { Id = 1, EmployeeId = 3, FullName = "Анна Петрова", Specialization = "Парикмахер", SkillLevel = "Professional", Phone = "+7-999-123-45-67" });
                masters.Add(new Master { Id = 2, EmployeeId = 4, FullName = "Елена Смирнова", Specialization = "Маникюр", SkillLevel = "Professional", Phone = "+7-999-123-45-68" });
                masters.Add(new Master { Id = 3, EmployeeId = 5, FullName = "Ольга Иванова", Specialization = "Косметолог", SkillLevel = "Intermediate", Phone = "+7-999-123-45-69" });
                masters.Add(new Master { Id = 4, EmployeeId = 6, FullName = "Мария Сидорова", Specialization = "Визажист", SkillLevel = "Professional", Phone = "+7-999-123-45-70" });
                masters.Add(new Master { Id = 5, EmployeeId = 7, FullName = "Дмитрий Козлов", Specialization = "Парикмахер", SkillLevel = "Intern", Phone = "+7-999-123-45-71" });
                return masters;
            }

            string query = "SELECT * FROM Masters ORDER BY Id";
            DataTable dt = ExecuteQuery(query);
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

        public List<Client> GetClients()
        {
            var clients = new List<Client>();

            if (useDefaultData)
            {
                clients.Add(new Client { Id = 1, Name = "Иван Петров", Phone = "+7-912-345-67-89" });
                clients.Add(new Client { Id = 2, Name = "Мария Иванова", Phone = "+7-912-345-67-90" });
                clients.Add(new Client { Id = 3, Name = "Сергей Смирнов", Phone = "+7-912-345-67-91" });
                clients.Add(new Client { Id = 4, Name = "Екатерина Кузнецова", Phone = "+7-912-345-67-92" });
                clients.Add(new Client { Id = 5, Name = "Алексей Попов", Phone = "+7-912-345-67-93" });
                return clients;
            }

            string query = "SELECT * FROM Clients ORDER BY Id";
            DataTable dt = ExecuteQuery(query);
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

        public List<Appointment> GetAppointments()
        {
            var appointments = new List<Appointment>();

            if (useDefaultData)
            {
                appointments.Add(new Appointment
                {
                    Id = 1,
                    ClientId = 1,
                    ServiceId = 1,
                    MasterId = 1,
                    Date = DateTime.Today.AddDays(1),
                    Time = new TimeSpan(10, 0, 0),
                    Status = "Записана",
                    ClientComment = "",
                    ClientName = "Иван Петров",
                    ServiceName = "Стрижка женская",
                    MasterName = "Анна Петрова",
                    ServicePrice = 1500
                });
                appointments.Add(new Appointment
                {
                    Id = 2,
                    ClientId = 2,
                    ServiceId = 3,
                    MasterId = 2,
                    Date = DateTime.Today.AddDays(1),
                    Time = new TimeSpan(12, 0, 0),
                    Status = "Записана",
                    ClientComment = "",
                    ClientName = "Мария Иванова",
                    ServiceName = "Маникюр",
                    MasterName = "Елена Смирнова",
                    ServicePrice = 1200
                });
                appointments.Add(new Appointment
                {
                    Id = 3,
                    ClientId = 3,
                    ServiceId = 2,
                    MasterId = 5,
                    Date = DateTime.Today.AddDays(1),
                    Time = new TimeSpan(14, 0, 0),
                    Status = "Выполнена",
                    ClientComment = "",
                    ClientName = "Сергей Смирнов",
                    ServiceName = "Стрижка мужская",
                    MasterName = "Дмитрий Козлов",
                    ServicePrice = 1000
                });
                return appointments;
            }

            string query = @"SELECT a.*, c.Name as ClientName, s.Name as ServiceName, 
                            s.Price as ServicePrice, m.FullName as MasterName
                            FROM Appointments a
                            JOIN Clients c ON a.ClientId = c.Id
                            JOIN Services s ON a.ServiceId = s.Id
                            JOIN Masters m ON a.MasterId = m.Id
                            ORDER BY a.Date, a.Time";
            DataTable dt = ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                appointments.Add(new Appointment
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
                    ServiceName = row["ServiceName"].ToString(),
                    MasterName = row["MasterName"].ToString(),
                    ServicePrice = Convert.ToDecimal(row["ServicePrice"])
                });
            }
            return appointments;
        }
    }
}
