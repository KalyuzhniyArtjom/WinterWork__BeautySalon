using BeautySalonLib.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySalonLib.Model;

namespace BeautySalonLib.Managers
{
    public class UserManager
    {
        private DatabaseHelper dbHelper;
        private User currentUser;

        public UserManager()
        {
            dbHelper = new DatabaseHelper();
        }

        public User Authenticate(string login, string password)
        {
            // Данные по умолчанию для тестирования (если нет БД)
            if (login == "admin" && password == "123")
            {
                currentUser = new User
                {
                    Id = 1,
                    Login = "admin",
                    Password = "123",
                    Role = "Admin",
                    FullName = "Администратор",
                    Phone = "+7-999-111-22-33",
                    Email = "admin@salon.ru"
                };
                return currentUser;
            }

            if (login == "master" && password == "123")
            {
                currentUser = new User
                {
                    Id = 2,
                    Login = "master",
                    Password = "123",
                    Role = "Master",
                    FullName = "Анна Петрова",
                    Phone = "+7-999-111-22-34",
                    Email = "anna@salon.ru"
                };
                return currentUser;
            }

            // Проверка в базе данных
            string query = "SELECT * FROM Users WHERE Login = @login AND Password = @password";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@login", login),
                new NpgsqlParameter("@password", password)
            };

            DataTable dt = dbHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                currentUser = new User
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Login = row["Login"].ToString(),
                    Password = row["Password"].ToString(),
                    Role = row["Role"].ToString(),
                    FullName = row["FullName"].ToString(),
                    Phone = row["Phone"].ToString(),
                    Email = row["Email"].ToString()
                };
                return currentUser;
            }
            return null;
        }

        public User GetCurrentUser()
        {
            return currentUser;
        }

        public string GetCurrentUserRole()
        {
            return currentUser?.Role;
        }

        public void Logout()
        {
            currentUser = null;
        }
    }
}
