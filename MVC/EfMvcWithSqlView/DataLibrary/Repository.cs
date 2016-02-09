using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary;

namespace DataLibrary
{
    public static class Repository
    {
        public static IEnumerable<Current_Product_List> GetProductLists()
        {
            NorthwindEntities context = new NorthwindEntities();
            return context.Current_Product_Lists;
        }
    }
}
