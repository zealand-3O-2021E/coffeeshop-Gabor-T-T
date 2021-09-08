using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class FlatWhite : Coffee
    {
        public FlatWhite(int discount, string name) : base(discount, name)
        {
        }

        public override string Strength()
        {
            return "hellNO!";
        }
        






    }
}
