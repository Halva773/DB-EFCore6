using LibaryV1._0.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibaryV1._0.JobWithInf
{
    class Processing
    {
        public void AddUser()
        { 
            var commands = new repository();
            Console.WriteLine("Enter mail, password and ID");

            // считываем данные пользователя
            string mail = Console.ReadLine();
            string password = Console.ReadLine();
            int iD = int.Parse(Console.ReadLine());

            commands.Add(new User { Password = password, Mail = mail, ID = iD });
        }

        public void AddAuthor()
        {
            var commands = new repository();
            Console.WriteLine("Enter Name, Surname, Middle Nane and year born");

            // считываем данные автора
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string middleName = Console.ReadLine();
            int born = int.Parse(Console.ReadLine());

            commands.Add(new Author { name = name, surname = surname, middleName = middleName, born = born });
        }

        public void AddBook()
        {
            var commands = new repository();
            Console.WriteLine("Enter Name and year");

            // считываем данные книги
            string name = Console.ReadLine();
            //Author author = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());

            commands.Add(new Book { name = name, year = year });
        }
    }
}
