using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new BlackCoffee(2, "Black coffee"),
                new Cortado(5, "Cortado"),
                new Latte(3, "Latte"),
                new FlatWhite(0, "Flat No")

            };


            foreach (var coffee in orderList)
            {
                Console.WriteLine($"the Price of the {coffee.Name} is : {coffee.price()}, {coffee.Strength()}" );
            }

            Console.WriteLine();

            List<Coffee> MilkyCoffee = new List<Coffee>();

            MilkyCoffee.Add(new Latte(3, "MilkyLatte"));
            MilkyCoffee.Add(new Cortado(5, "MilkyCortado"));

            foreach (var milkyList in MilkyCoffee)
            {
                Console.WriteLine($"the  {milkyList.Name} | strength is : {milkyList.Strength()} | and the price is: {milkyList.price()} | and the discount is: {milkyList.Discount} ");
            }


        }
    }
}
