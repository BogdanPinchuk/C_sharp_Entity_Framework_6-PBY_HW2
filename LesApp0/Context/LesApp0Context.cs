using LesApp0.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0.Context
{
    /// <summary>
    /// Контекст
    /// </summary>
    public class LesApp0Context : DbContext
    {
        static LesApp0Context()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<LesApp0Context>());
        }
        public LesApp0Context()
            : base("LesApp0Connection") { }

        /// <summary>
        /// Діти
        /// </summary>
        public virtual DbSet<Child> Children { get; set; }
        /// <summary>
        /// Батьки
        /// </summary>
        public virtual DbSet<Parent> Parents { get; set; }

    }

}
