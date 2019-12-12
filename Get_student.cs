using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace BDApp
{
    class Get_student
    {
        public List<Student> students = new List<Student>();
        public List<string> subjects= new List<string>();

        public string connectionString = DataBase.connectionString;
            //@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\jadeo\source\repos\DataBase\Database.mdb";
        public void get_table()
        {
            DataTable Table = new DataTable();
            // создаем объект OleDbConnection для соединения с Бд и передаем его конструктору строку с параметрами подключения
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            // создаем объект OleDbCommand
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
            // задаем SQL-запрос к базе данных в свойстве CommandText объекта OleDbCommand
            // Результатом запроса должны быть данные клинета с именем Кто-то
            myOleDbCommand.CommandText = "SELECT Students.Name, Students.Family, Tables.Mark, Subjects.SubjectName  FROM Students,Tables,Subjects WHERE Students.IDStudent=Tables.IDStudent and Subjects.IDSubject=Tables.IDStudent";
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
                    bull = Convert.ToInt32(myOleDbDataReader[2]),
                    name_subject = Convert.ToString(myOleDbDataReader[3])
                });
            }
            
        }

        public void get_predmet()
        {
            DataTable Table = new DataTable();
            // создаем объект OleDbConnection для соединения с Бд и передаем его конструктору строку с параметрами подключения
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            // создаем объект OleDbCommand
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
            // задаем SQL-запрос к базе данных в свойстве CommandText объекта OleDbCommand
            // Результатом запроса должны быть данные клинета с именем Кто-то
            myOleDbCommand.CommandText = "SELECT DISTINCT SubjectName  FROM Subjects";
            // открываем соединение с БД с помощью метода Open() объекта OleDbConnection
            myOleDbConnection.Open();
            // создаем объект OleDbDataReader и вызываем метод ExecuteReader() для выполнения введенного SQL-запроса
            OleDbDataReader myOleDbDataReader = myOleDbCommand.ExecuteReader();
            int i = 0;
            while (myOleDbDataReader.Read())
            {
                subjects.Add(Convert.ToString(myOleDbDataReader[0]));
                //  subjects[i] = Convert.ToString(myOleDbDataReader[i]);
            }

        }

}
}
