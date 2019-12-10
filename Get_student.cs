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
            myOleDbCommand.CommandText = "SELECT Students.Name, Students.Family, Tables.Mark  FROM Students,Tables WHERE Students.IDStudent=Tables.IDStudent";
            // открываем соединение с БД с помощью метода Open() объекта OleDbConnection
            myOleDbConnection.Open();
            // создаем объект OleDbDataReader и вызываем метод ExecuteReader() для выполнения введенного SQL-запроса
            OleDbDataReader myOleDbDataReader = myOleDbCommand.ExecuteReader();
            while (myOleDbDataReader.Read())
            {
                
                students.Add(new Student
                {
                    name = Convert.ToString(myOleDbDataReader[0]),
                    fam = Convert.ToString(myOleDbDataReader[1]),
                    bull = Convert.ToInt32(myOleDbDataReader[2])

                });
            }
            
        }
    }
}
