using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealBuilder
{
    public abstract class Burger : Item
    {
        public abstract string Name();

        public Packing packing()
        {
            return new Wrapper();
        }
 
        public abstract float price();

    }
}
