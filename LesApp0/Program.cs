using LesApp0.Context;
using LesApp0.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    class Program
    {
        static Random rnd = new Random();

        static void Main()
        {
            // join Unicode
            Console.OutputEncoding = Encoding.Unicode;

            using (LesApp0Context db = new LesApp0Context())
            {
                // створюємо декілька дітей
                Child[] children = new Child[]
                {
                    #region children
                    new Child()
                    {
                        FullName = "Олексій",
                        Type = TypeChild.Son,
                        Year = rnd.Next(2017, 2019),
                    },
                    new Child()
                    {
                        FullName = "Олександр",
                        Type = TypeChild.Son,
                        Year = rnd.Next(2017, 2019),
                    },
                    new Child()
                    {
                        FullName = "Люда",
                        Type = TypeChild.Daughter,
                        Year = rnd.Next(2017, 2019),
                    },
                    new Child()
                    {
                        FullName = "Оля",
                        Type = TypeChild.Daughter,
                        Year = rnd.Next(2017, 2019),
                    }
                    #endregion
                };

                // додаємо в БД
                db.Children.AddRange(children);
                // зберігаємо в БД
                db.SaveChanges();

                // прописуємо батьків
                Parent[] parents = new Parent[]
                {
                    #region parents
                    new Parent()
                    {
                        FullName = "Bogdan",
                        Type = TypeParent.Father,
                        Year = rnd.Next(1990, 1999),
                        Children = new List<Child>() { children[0], children[1] }
                    },
                    new Parent()
                    {
                        FullName = "Nastya",
                        Type = TypeParent.Mother,
                        Year = rnd.Next(1990, 1999),
                        Children = new List<Child>() { children[2], children[3] }
                    }, 
                    #endregion
                };

                 // додаємо в БД
                db.Parents.AddRange(parents);
                // зберігаємо в БД
                db.SaveChanges();

                // Виводимо дані в консоль
                Console.WriteLine("Батьки та їх діти:");

                // завантаження даних
                db.Parents.Load();

                // виведення дітей
                foreach (var i in db.Parents.Local)
                {
                    Console.WriteLine("\n" + i.ToString());
                    // виведення батьків
                    foreach (var j in i.Children)
                    {
                        Console.WriteLine("\n\t=> " + j.ToString());
                    }
                }
            }

            // delay
            Console.ReadKey(true);
        }
    }
}
