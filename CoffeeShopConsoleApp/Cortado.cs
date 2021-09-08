﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Cortado : Coffee, IMilk
    {
        public Cortado(int discount, string name) : base(discount, name)
        {
        }

        public int mIMilk()
        {
            return 40;
        }

        public override int price()
        {
            
            return 25-Discount;
        }

        public override string Strength()
        {
            return "Medium";
        }

        
    }
}
