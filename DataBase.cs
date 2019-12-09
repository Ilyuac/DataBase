using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BDApp
{
    public abstract class DataBase
    {
        static string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\VS Project\BDApp\Database.mdb";
        static OleDbConnection connection;
        static OleDbCommand dbCommand;
        static OleDbDataReader dataReader;
        private static DataTable Table = new DataTable();

        public static DataTable GetTable()
        {
            return Table;
        }

        public static void Connection(string command)
        {
            connection = new OleDbConnection(connectionString);
            ConnectionOpen();

            dbCommand = new OleDbCommand(command, connection);
            dataReader = dbCommand.ExecuteReader();

            if (dataReader.HasRows)
            {
                DataTable schemaTable = dataReader.GetSchemaTable();
                foreach (DataRow row in schemaTable.Rows)
                {
                    string colName = row.Field<string>("ColumnName");
                    Type t = row.Field<Type>("DataType");
                    Table.Columns.Add(colName, t);
                }
                while (dataReader.Read())
                {
                    var newRow = Table.Rows.Add();
                    foreach (DataColumn col in Table.Columns)
                    {
                        newRow[col.ColumnName] = dataReader[col.ColumnName];
                    }
                }
            }
            else
            {
                MessageBox.Show("Запрос не вернул строк.","Предупреждение!");
            }

            dataReader.Close();
            ConnectionClose();
        }

        public static void DBCommand(string command)
        {
            dbCommand = new OleDbCommand(command, connection);
            dbCommand.ExecuteNonQuery();
        }

        public static void ConnectionOpen()
        {
            connection.Open();
        }
        public static void ConnectionClose()
        {
            connection.Close();
        }
    }
}
