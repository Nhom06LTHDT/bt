﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT10.DTO
{
    public class DataProvider
    {
        private string connectionSTR = "Data Source=BOY;Initial Catalog=QuanLyQuanAn;Integrated Security=True";
        public DataTable ExecuteQuery(string query)
        {
            string connectionSTR = "Data Source=BOY;Initial Catalog=QuanLyQuanAn;Integrated Security=True";

            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
    }
}
