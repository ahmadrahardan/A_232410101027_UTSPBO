using Microsoft.Win32;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_PBO.App.Core;
using UTS_PBO.App.Models;

namespace Tugas_Akhir_PBO.App.Context
{
    internal class RegisterContext
    {
        public bool Register(Akun register)
        {
            string query = "INSERT INTO admin (username, password) VALUES (@username, @password)";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@username", register.username),
                new NpgsqlParameter("@password", register.password)
            };

            try
            {
                Database.commandExecutor(query, parameters);
                return true;
            }
            catch (NpgsqlException npgsqlEx)
            {
                Console.WriteLine("Database Error: " + npgsqlEx.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
    }
}
