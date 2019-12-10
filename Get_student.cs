using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDApp
{
    class Get_student
    {
        public List<Student> students = new List<Student>();


        public void get_table(string connectionString)
        {
            DataTable Table = new DataTable();
            // создаем объект OleDbConnection для соединения с Бд и передаем его конструктору строку с параметрами подключения
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            // создаем объект OleDbCommand
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
            // задаем SQL-запрос к базе данных в свойстве CommandText объекта OleDbCommand
            // Результатом запроса должны быть данные клинета с именем Кто-то
            myOleDbCommand.CommandText = "SELECT * FROM Specialties";
            // открываем соединение с БД с помощью метода Open() объекта OleDbConnection
            myOleDbConnection.Open();
            // создаем объект OleDbDataReader и вызываем метод ExecuteReader() для выполнения введенного SQL-запроса
            OleDbDataReader myOleDbDataReader = myOleDbCommand.ExecuteReader();
            while (myOleDbDataReader.Read())
            {

                students.Add(new Student
                {
                    name = (string)myOleDbDataReader[0],
                    fam = (string)myOleDbDataReader[1],
                    bull = (int)myOleDbDataReader[2],

                });
                //students.Add(new Student() { id_student=i[0]. });
                //students.Add(i);
            }
            
        }
    }
}
