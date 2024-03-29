﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BDApp
{
    public abstract class DataBase
    {
        public static string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\VS Project\BDApp\Database.mdb";//строка подключения
        public static OleDbConnection connection;
        static OleDbCommand dbCommand;
        static OleDbDataReader dataReader;
        private static DataTable Table;
        public static List<DataTable> Tables = new List<DataTable>(); 

        public static DataTable GetTable()
        {
            return Table;
        }
        
        public static void Connection(string command)//считывание данных из бд
        {
            Table = new DataTable();
            connection = new OleDbConnection(connectionString);
            ConnectionOpen();

            dbCommand = new OleDbCommand(command, connection);
            dataReader = dbCommand.ExecuteReader();

            if (dataReader.HasRows)
            {
                DataTable schemaTable = dataReader.GetSchemaTable();
                schemaTable.TableName = command.Split(' ')[3];
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
                Table.TableName = dataReader.GetSchemaTable().TableName;

                Tables.Add(Table);
            }
            else
            {
                MessageBox.Show("Запрос не вернул строк.","Предупреждение!");
            }

            dataReader.Close();
            ConnectionClose();
        }

        public static DataTable SelectCommand(string command)//комманда select
        {
            Table = new DataTable();
            connection = new OleDbConnection(connectionString);
            ConnectionOpen();

            dbCommand = new OleDbCommand(command, connection);
            dataReader = dbCommand.ExecuteReader();

            if (dataReader.HasRows)
            {
                DataTable schemaTable = dataReader.GetSchemaTable();
                schemaTable.TableName = command.Split(' ')[3];
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
                Table.TableName = dataReader.GetSchemaTable().TableName;
            }
            else
            {
                MessageBox.Show("Запрос не вернул строк.", "Предупреждение!");
            }

            dataReader.Close();
            ConnectionClose();

            return Table;
        }

        public static void DBCommand(OleDbCommand command)//Выполненение запросов Update, Insert, Delete
        {
            ConnectionOpen();
            dbCommand = command;
            dbCommand.ExecuteNonQuery();
            ConnectionClose();
        }

        public static void ConnectionOpen()//открытие подключения
        {
            connection.Open();
        }
        public static void ConnectionClose()//закрытие подключение
        {
            connection.Close();
        }

        public static void UPdate()//Загрузка таблиц из БД
        {
            DataBase.Tables.Clear();
            DataBase.Connection("SELECT * FROM Specialty");
            DataBase.Connection("SELECT * FROM Students");
            DataBase.Connection("SELECT * FROM Subjects");
            DataBase.Connection("SELECT * FROM Tables");
        }
    }
}
