using BeautySalonLib.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonLib.Managers
{
    public class UserManager
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();
        public User CurrentUser { get; private set; }

        public User Authenticate(string login, string password)
        {
            string query = @"SELECT * FROM ""Users"" WHERE ""Login"" = @login AND ""Password"" = @password";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@login", login),
                new NpgsqlParameter("@password", password)
            };

            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count == 0)
                return null;

            var row = dt.Rows[0];
            CurrentUser = new User
            {
                Id = Convert.ToInt32(row["Id"]),
                Login = row["Login"].ToString(),
                Password = row["Password"].ToString(),
                Role = row["Role"].ToString(),
                FullName = row["FullName"].ToString(),
                Phone = row["Phone"].ToString(),
                Email = row["Email"].ToString()
            };
            return CurrentUser;
        }
    }
}
