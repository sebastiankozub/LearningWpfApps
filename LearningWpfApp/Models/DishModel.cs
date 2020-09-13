using System;
using System.Collections.Generic;
using System.Text;

namespace LearningWpfApp.Models
{
    public class DishModel : IComparable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(object obj)
        {
            if (!(obj is DishModel))
            {
                throw new ArgumentException("Compared Object is not of DishModel");
            }
            var d = obj as DishModel;
            return Name.CompareTo(d.Name);
        }

        public override string ToString()
        {
            // not nice that model methods used to format view - moreover making app harder to internationalize
            return $"{Name} - {Price} zł";
        }
    }
}
