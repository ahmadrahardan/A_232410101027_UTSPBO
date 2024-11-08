using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_PBO.App.Core;
using UTS_PBO.App.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UTS_PBO.App.Context
{
    internal class KontakContext : Database
    {
        private static string table = "kontak";
        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";

            DataTable dataKontak = queryExecutor(query);
            return dataKontak;
        }

        public static void AddKontak(Kontak kontakBaru)
        {
            string query = $"INSERT INTO {table} (nama, email, no_hp) VALUES(@nama, @email, @no_hp)";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@nama", kontakBaru.nama),
                new NpgsqlParameter("@email", kontakBaru.email),
                new NpgsqlParameter("@no_hp", kontakBaru.no_hp),
            };

            commandExecutor(query, parameters);
        }
    }
}
