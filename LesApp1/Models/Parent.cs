using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1.Models
{
    /// <summary>
    /// Тип рідних
    /// </summary>
    public enum TypeParent
    {
        /// <summary>
        /// Мати
        /// </summary>
        Mother,
        /// <summary>
        /// Батько
        /// </summary>
        Father
    }
    /// <summary>
    /// Хтось із рідних (мати, батько)
    /// </summary>
    public class Parent
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Хто саме - мати чи батько
        /// </summary>
        public TypeParent Type { get; set; }
        /// <summary>
        /// Рік народження
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// ПІБ
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Діти
        /// </summary>
        public ICollection<Child> Children { get; set; }

        public Parent()
        {
            Children = new List<Child>();
        }

        public override string ToString()
            => $"{Type}: {FullName}, {Math.Abs(DateTime.Now.Year - Year)}";

    }
}
