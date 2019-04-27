using System;

namespace VendingMachineApp {
    public class Menu {
        

        public static void Display() {
            
            ProductsBuilder pp = new ProductsBuilder();
            Products coke = pp.FillMachine();
            
            
            WriteLineColored("\t\t\t === Vending Machine ===", ConsoleColor.Blue);
            Console.WriteLine(coke);
            Console.WriteLine("1. Fill machine");
            Console.WriteLine("2. Show products");
            Console.WriteLine("3. Purchase product");
            Console.WriteLine("4. Exit and return money\n");

            Console.Write("Introduce money : ");
            string money = Console.ReadLine();
            Console.Write("Option: ");
            string option = Console.ReadLine();

            switch (option) {
                
                case "1":
                    coke = pp.FillMachine();
                    break;
                case "2":
                    Console.WriteLine(coke);
                    break;
                case "3":
                    WriteLineColored("ID: ", ConsoleColor.Black);
                    // select an id and quantity after that will actualized stock
                    if (money != null) ProductPurchase(coke, Int32.Parse(money));
                    break;
                case "4":
                    Console.WriteLine("Refund money " + money + "$");
                    Environment.Exit(0);
                    break;
            }
        }
        
        static void WriteLineColored(string text, ConsoleColor color) {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static void ProductPurchase(Products produse, int money) {
            
        }
    }
}