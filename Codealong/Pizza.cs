using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Codealong
{
    internal class Pizza : Recipe
    {
        public Pizza(string name, int difficulty) : base()
        {
            Categories = new List<EnumCategories>()
            {
                EnumCategories.Helgekos,
                EnumCategories.Middag
            };
        }


    }
}
