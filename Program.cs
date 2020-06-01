using System;
using LibaryV1._0.JobWithInf;
using LibaryV1._0.Modules;
using System.Collections.Generic;
using System.Text;

namespace LibaryV1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var commandsPro = new Processing();
                var commandsRep = new repository();
                Console.WriteLine("Enter Command");
                string ReadLine = Console.ReadLine();
                switch (ReadLine)
                {
                    case "Add User":
                        commandsPro.AddUser();
                        break;
                    case "Add Author":
                        commandsPro.AddAuthor();
                        break;
                    case "Print All db":
                        commandsRep.AllDB();
                        break;
                }
            }
        }
    }
}
