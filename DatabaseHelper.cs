using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SecureBotWPF
{
     

    public class DatabaseHelper
    {
        private string connectionString =

@"Server=LABVM2049939\SQLEXPRESS;
Database=SecureBotDB;
Trusted_Connection=True;
TrustServerCertificate=True;";


        public void AddTask(TaskItem task)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query =
                    @"INSERT INTO Tasks
                (Title, Description, ReminderDate)
                VALUES
                (@title,@description,@reminder)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@title", task.Title);
                cmd.Parameters.AddWithValue("@description", task.Description);
                cmd.Parameters.AddWithValue("@reminder", task.ReminderDate);

                cmd.ExecuteNonQuery();
            }
        }
    }
}