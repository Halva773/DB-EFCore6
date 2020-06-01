using LibaryV1._0.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibaryV1._0
{
    class repository
    {
        public void AllDB()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Console.WriteLine("Все авторы:");
                foreach (Author u in db.Authors.ToList())
                {
                    Console.WriteLine($"{u.name} {u.surname} {u.middleName} {u.born}");
                }

                Console.WriteLine("Все пользователи:");
                foreach (User u in db.Users.ToList())
                {
                    Console.WriteLine($"{u.ID} {u.Mail} {u.Password}");
                }

                Console.WriteLine("Все книги:");
                foreach (Book u in db.Books.ToList())
                {
                    Console.WriteLine($"{u.name} {u.author} {u.year}");
                }

                Console.WriteLine("Все Читатели со страницами, на которых остановились:");
                foreach (Reader u in db.Readers.ToList())
                {
                    Console.WriteLine($"{u.user} {u.book} {u.page}");
                }
            }
        }

        public void Add(User user)
        {
            using ApplicationContext db = new ApplicationContext();
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void Add(Book book)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }
        }

        public void Add(Author author)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Authors.Add(author);
                db.SaveChanges();
            }
        }

        public void Add(Reader reader)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Readers.Add(reader);
                db.SaveChanges();
            }
        }
    }
}
