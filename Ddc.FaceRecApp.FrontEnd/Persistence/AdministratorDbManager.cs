using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ddc.FaceRecApp.FrontEnd.Domain;
using static Ddc.FaceRecApp.FrontEnd.Shared.MessageBoxes;

namespace Ddc.FaceRecApp.FrontEnd.Persistence
{
    public class AdministratorDbManager
    {
        private MySqlConnection _connection;

        public AdministratorDbManager(string connectionString)
        {
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
        }

        public Administrator FindAdministrator(string eeId)
        {
            //_connection.Open();
            try
            {
                using (MySqlDataReader reader = new MySqlCommand($"SELECT * FROM auth_users WHERE ee_id='{eeId}' LIMIT 1;", _connection).ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        return new Administrator()
                        {
                            Id = reader.GetInt32("id"),
                            EEId = reader.GetString("ee_id"),
                            DateAdded = reader.GetDateTime("date_added")
                        };
                    }
                }
            }
            catch (Exception ex) { Error(ex.Message, ex.Source); }
            //finally { _connection.Close(); }

            return null;
        }

        public IEnumerable<Administrator> LoadAdministrators(int limit = 1000)
        {
            List<Administrator> users = new List<Administrator>();
            //_connection.Open();
            try
            {
                using (MySqlDataReader reader = new MySqlCommand($"SELECT * FROM auth_users LIMIT {limit};", _connection).ExecuteReader())
                    while (reader.Read())
                        users.Add(new Administrator()
                        {
                            Id = reader.GetInt32("id"),
                            EEId = reader.GetString("ee_id"),
                            DateAdded = reader.GetDateTime("date_added")
                        });
                return users;
            }
            catch (Exception ex) { Error(ex.Message, ex.Source); }
            //finally { _connection.Close(); }

            return null;
        }
        public int GetAdministratorCount()
        {
            int count = 0;
            //_connection.Open();
            try
            {
                using (MySqlDataReader reader = new MySqlCommand($"SELECT COUNT(*) AS count FROM auth_users;", _connection).ExecuteReader())
                {
                    reader.Read();
                    count = reader.GetInt32("count");
                }
                return count;
            }
            catch (Exception ex) { Error(ex.Message, ex.Source); }
            //finally { _connection.Close(); }

            return count;
        }


        public void SaveAdmin(Administrator admin)
        {
            //_connection.Open();
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO auth_users (ee_id) VALUES (@ee_id) ON DUPLICATE KEY UPDATE ee_id=@ee_id;", _connection);
                command.Parameters.AddWithValue("ee_id", admin.EEId);
                command.ExecuteNonQuery();
            }
            catch (Exception ex) { Error(ex.Message, ex.Source); }
            //finally { _connection.Close(); }
        }

        public void DeleteAdmin(Administrator admin)
        {
            //_connection.Open();
            try
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM auth_users WHERE ee_id=@ee_id;", _connection);
                command.Parameters.AddWithValue("ee_id", admin.EEId);
                command.ExecuteNonQuery();
            }
            catch (Exception ex) { Error(ex.Message, ex.Source); }
            //finally { _connection.Close(); }
        }
    }
}
