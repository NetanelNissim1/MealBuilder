using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealBuilder
{
   public class ChickenBurger: Burger
    {
        public override float price()
        {
            return 50.5f;
        }

        public override string Name()
        {
            return "Chicken Burger";
        }
    }
}
