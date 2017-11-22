using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealBuilder
{
    public abstract class ColdDrink: Item
    {
        public abstract string Name();
    
        public  Packing packing()
        {
            return new Bottle();
        }

        public abstract float price();
    }

}
