using BeautySalonLib.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonLib.Managers
{
    public class AppointmentManager
    {
        private DatabaseHelper dbHelper;
        private List<Appointment> allAppointments;

        public AppointmentManager()
        {
            dbHelper = new DatabaseHelper();
            LoadAllAppointments();
        }

        private void LoadAllAppointments()
        {
            allAppointments = dbHelper.GetAppointments();
        }

        public List<Appointment> GetAllAppointments()
        {
            LoadAllAppointments(); // Обновляем перед возвратом
            return allAppointments;
        }

        /// <summary>
        /// Проверка, свободен ли мастер в указанное время
        /// </summary>
        public bool IsTimeAvailable(int masterId, DateTime date, TimeSpan time)
        {
            string query = @"SELECT COUNT(*) FROM Appointments 
                            WHERE MasterId = @masterId AND Date = @date AND Time = @time 
                            AND Status NOT IN ('Отменена администратором', 'Клиент не пришёл', 'Клиент заболел')";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@masterId", masterId),
                new NpgsqlParameter("@date", date.Date),
                new NpgsqlParameter("@time", time)
            };

            int count = Convert.ToInt32(dbHelper.ExecuteScalar(query, parameters));
            return count == 0;
        }

        /// <summary>
        /// Создание новой записи
        /// </summary>
        public bool CreateAppointment(Appointment appointment)
        {
            // Проверяем, свободно ли время
            if (!IsTimeAvailable(appointment.MasterId, appointment.Date, appointment.Time))
            {
                return false;
            }

            string query = @"INSERT INTO Appointments (ClientId, ServiceId, MasterId, Date, Time, Status, ClientComment) 
                            VALUES (@clientId, @serviceId, @masterId, @date, @time, @status, @clientComment)";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@clientId", appointment.ClientId),
                new NpgsqlParameter("@serviceId", appointment.ServiceId),
                new NpgsqlParameter("@masterId", appointment.MasterId),
                new NpgsqlParameter("@date", appointment.Date.Date),
                new NpgsqlParameter("@time", appointment.Time),
                new NpgsqlParameter("@status", appointment.Status ?? "Записана"),
                new NpgsqlParameter("@clientComment", appointment.ClientComment ?? "")
            };

            int result = dbHelper.ExecuteNonQuery(query, parameters);

            if (result > 0)
            {
                LoadAllAppointments(); // Обновляем кэш
                return true;
            }
            return false;
        }

        /// <summary>
        /// Отмена записи с указанием причины
        /// </summary>
        public bool CancelAppointment(int appointmentId, string reason)
        {
            string query = "UPDATE Appointments SET Status = @status WHERE Id = @id";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@status", reason),
                new NpgsqlParameter("@id", appointmentId)
            };

            int result = dbHelper.ExecuteNonQuery(query, parameters);

            if (result > 0)
            {
                LoadAllAppointments(); // Обновляем кэш
                return true;
            }
            return false;
        }

        /// <summary>
        /// Изменение статуса записи
        /// </summary>
        public bool UpdateStatus(int appointmentId, string newStatus)
        {
            string query = "UPDATE Appointments SET Status = @status WHERE Id = @id";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@status", newStatus),
                new NpgsqlParameter("@id", appointmentId)
            };

            int result = dbHelper.ExecuteNonQuery(query, parameters);

            if (result > 0)
            {
                LoadAllAppointments(); // Обновляем кэш
                return true;
            }
            return false;
        }

        /// <summary>
        /// Поиск записей по тексту (имя клиента, имя мастера, название услуги)
        /// </summary>
        public List<Appointment> SearchAppointments(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return GetAllAppointments();
            }

            string searchLower = searchText.ToLower();

            return allAppointments.Where(a =>
                (a.ClientName != null && a.ClientName.ToLower().Contains(searchLower)) ||
                (a.MasterName != null && a.MasterName.ToLower().Contains(searchLower)) ||
                (a.ServiceName != null && a.ServiceName.ToLower().Contains(searchLower))
            ).ToList();
        }

        /// <summary>
        /// Поиск по дате
        /// </summary>
        public List<Appointment> SearchByDate(DateTime date)
        {
            return allAppointments.Where(a => a.Date.Date == date.Date).ToList();
        }

        /// <summary>
        /// Получение записи по ID
        /// </summary>
        public Appointment GetAppointmentById(int id)
        {
            return allAppointments.FirstOrDefault(a => a.Id == id);
        }

        /// <summary>
        /// Удаление записи (полное удаление, не рекомендуется)
        /// </summary>
        public bool DeleteAppointment(int appointmentId)
        {
            string query = "DELETE FROM Appointments WHERE Id = @id";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id", appointmentId)
            };

            int result = dbHelper.ExecuteNonQuery(query, parameters);

            if (result > 0)
            {
                LoadAllAppointments();
                return true;
            }
            return false;
        }
    }
}
