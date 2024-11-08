using Microsoft.VisualBasic.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_PBO.App.Core;
using UTS_PBO.App.Models;
using UTS_PBO.Views;

namespace Tugas_Akhir_PBO.App.Context
{
    internal class LoginContext
    {
        public Akun Validate(string username, string password)
        {
            Akun loginAdmin = null;
            string query = "SELECT * FROM admin WHERE email = @email AND password = @password";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@username", username),
                new NpgsqlParameter("@password", password)
            };

            DataTable resultTable = Database.queryExecutor(query, parameters);

            if (resultTable.Rows.Count > 0)
            {
                DataRow row = resultTable.Rows[0];
                loginAdmin = new Akun
                {
                    username = row["email"].ToString(),
                    password = row["password"].ToString()
                };
            }

            return loginAdmin;
        }
    }
}

