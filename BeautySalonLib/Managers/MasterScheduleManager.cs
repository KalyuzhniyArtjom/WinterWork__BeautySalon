using BeautySalonLib.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonLib.Managers
{
    public class MasterScheduleManager
    {
        private DatabaseHelper dbHelper;
        private int masterId;
        private string masterName;

        public MasterScheduleManager(int masterId, string masterName)
        {
            this.dbHelper = new DatabaseHelper();
            this.masterId = masterId;
            this.masterName = masterName;
        }

        /// <summary>
        /// Получить расписание мастера на конкретную дату
        /// </summary>
        public List<Appointment> GetAppointmentsByDate(DateTime date)
        {
            var allAppointments = dbHelper.GetAppointments();
            return allAppointments
                .Where(a => a.MasterId == masterId && a.Date.Date == date.Date)
                .OrderBy(a => a.Time)
                .ToList();
        }

        /// <summary>
        /// Получить расписание на неделю
        /// </summary>
        public Dictionary<DateTime, List<Appointment>> GetWeekSchedule(DateTime startDate)
        {
            var schedule = new Dictionary<DateTime, List<Appointment>>();
            var allAppointments = dbHelper.GetAppointments();

            for (int i = 0; i < 7; i++)
            {
                DateTime currentDate = startDate.AddDays(i);
                var dayAppointments = allAppointments
                    .Where(a => a.MasterId == masterId && a.Date.Date == currentDate.Date)
                    .OrderBy(a => a.Time)
                    .ToList();

                schedule.Add(currentDate, dayAppointments);
            }

            return schedule;
        }

        /// <summary>
        /// Обновить статус записи
        /// </summary>
        public bool UpdateStatus(int appointmentId, string newStatus)
        {
            string query = "UPDATE Appointments SET Status = @status WHERE Id = @id";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@status", newStatus),
                new NpgsqlParameter("@id", appointmentId)
            };

            int result = dbHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        /// <summary>
        /// Отметить запись как выполненную
        /// </summary>
        public bool MarkAsCompleted(int appointmentId)
        {
            return UpdateStatus(appointmentId, "Выполнена");
        }

        /// <summary>
        /// Проверить, может ли мастер отметить запись
        /// </summary>
        public bool CanChangeStatus(string currentStatus)
        {
            // Нельзя изменить уже выполненную или отменённую запись
            return currentStatus != "Выполнена" &&
                   currentStatus != "Отменена администратором" &&
                   currentStatus != "Клиент не пришёл" &&
                   currentStatus != "Клиент заболел";
        }

        /// <summary>
        /// Получить информацию о мастере
        /// </summary>
        public string GetMasterInfo()
        {
            return masterName;
        }

        /// <summary>
        /// Получить ID мастера
        /// </summary>
        public int GetMasterId()
        {
            return masterId;
        }
    }
}
