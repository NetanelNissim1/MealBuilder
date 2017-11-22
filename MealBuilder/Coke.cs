﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealBuilder
{
   public class Coke: ColdDrink
    {
        public override float price()
        {
            return 30.0f;
        }

        public override string Name()
        {
            return "Coke";
        }
    }
}
