using Ddc.TimelogAggregatorApp.WebApi.Enums;
using Ddc.TimelogAggregatorApp.WebApi.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ddc.TimelogAggregatorApp.WebApi.Persistence
{
    public class TimelogDbManager
    {
        private MySqlConnection _connection;

        public TimelogDbManager(string connectionString)
        {
            _connection = new MySqlConnection(connectionString);
        }


        public IEnumerable<Timelog> GetTimelogs(int limit = 100)
        {
            var timelogs = new List<Timelog>();
            _connection.Open();
            try
            {
                using (MySqlDataReader reader = new MySqlCommand($"SELECT * FROM timelogs ORDER BY timestamp DESC LIMIT {limit};", _connection).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        timelogs.Add(new Timelog()
                        {
                            Id = reader.GetString("id"),
                            EEId = reader.GetString("ee_id"),
                            LogDate = reader.GetDateTime("log_date"),
                            Timestamp = reader.GetDateTime("timestamp"),
                            DateSent = reader.GetDateTime("date_sent"),
                            Status = (TimelogStatus)reader.GetInt32("timelog_status"),
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                //Error(ex.Message, ex.Source);
            }
            finally { _connection.Close(); }

            return timelogs;
        }

        public Timelog GetLastTimelog(string eeId)
        {
            var timelogs = new Timelog();
            _connection.Open();
            try
            {
                using (MySqlDataReader reader = new MySqlCommand($"SELECT * FROM timelogs WHERE ee_id={eeId} ORDER BY timestamp DESC LIMIT 1;", _connection).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        timelogs = new Timelog()
                        {
                            Id = reader.GetString("id"),
                            EEId = reader.GetString("ee_id"),
                            LogDate = reader.GetDateTime("log_date"),
                            Timestamp = reader.GetDateTime("timestamp"),
                            DateSent = reader.GetDateTime("date_sent"),
                            Status = (TimelogStatus)reader.GetInt32("timelog_status"),
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                //Error(ex.Message, ex.Source);
            }
            finally { _connection.Close(); }

            return timelogs;
        }


        public void SaveTimelog(Timelog timelog)
        {
            _connection.Open();
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO timelogs (id, ee_id, log_date, timestamp, timelog_status) VALUES (@id, @ee_id, @log_date, @timestamp, @timelog_status)", _connection);
                command.Parameters.AddWithValue("id", timelog.GenerateId());
                command.Parameters.AddWithValue("ee_id", timelog.EEId);
                command.Parameters.AddWithValue("log_date", timelog.LogDate);
                command.Parameters.AddWithValue("timestamp", timelog.Timestamp);
                command.Parameters.AddWithValue("timelog_status", timelog.Status);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //Error(ex.Message, ex.Source);
            }
            finally { _connection.Close(); }
        }
    }
}
