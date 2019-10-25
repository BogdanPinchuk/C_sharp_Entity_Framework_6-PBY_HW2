using LesApp1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1.Context
{
    /// <summary>
    /// Контекст
    /// </summary>
    public class LesApp1Context : DbContext
    {
        static LesApp1Context()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<LesApp1Context>());
        }
        public LesApp1Context()
            : base("LesApp1Connection") { }

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
