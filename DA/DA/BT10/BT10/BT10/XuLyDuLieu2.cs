using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace kiet
{
    class XuLyDuLieu2
    {
        public static String connectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-I9JAO4N;Integrated Security=SSPI;Initial Catalog=QuanLyQuanAn";

        public static DataTable docBang(String sql)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connectionString);
            adapter.Fill(dt);
            return dt;
        }

        public static void ghiBang(String tenBang, DataTable dt)
        {
            String selectSql = "Select * from " + tenBang;
            OleDbDataAdapter adapter = new OleDbDataAdapter(selectSql, connectionString);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.Update(dt);
        }
        public static DataTable docDuLieu(String sql)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connectionString);
            adapter.FillSchema(dt, SchemaType.Source);
            return dt;
        }
    }
}
