using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealBuilder
{
   public interface Item
    {
         string Name();
         Packing packing();
         float price();
    }
}
