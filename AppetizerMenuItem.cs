using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class AppetizerMenuItem : MenuItem
    // наследява класа MenuItem. Този клас добавя appetizer в tostring метода. Типа данни е Appettizer.
    {
        //конструктор.Автоматично генераиран Празен, няма нужда да се пише нищо. Call the base Constructor.
        public AppetizerMenuItem(string name, string description, decimal price) : base(name, description, price)
        {
        }

        public override string ToString()
        {
            return $"Appetizer: {base.ToString()}";
        }
    }
}
