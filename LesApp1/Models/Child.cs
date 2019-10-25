using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1.Models
{
    public enum TypeChild
    {
        /// <summary>
        /// Дочка
        /// </summary>
        Daughter,
        /// <summary>
        /// Син
        /// </summary>
        Son
    }

    /// <summary>
    /// Дитина
    /// </summary>
    public class Child
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Рік народження
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// ПІБ
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Хто саме, син чи дочка
        /// </summary>
        public TypeChild Type { get; set; }

        /// <summary>
        /// Хтось із батьків
        /// </summary>
        public ICollection<Parent> Parents { get; set; }

        public Child()
        {
            Parents = new List<Parent>();
        }

        public override string ToString()
            => $"{Type}: {FullName}, {Math.Abs(DateTime.Now.Year - Year)}";
    }
}
