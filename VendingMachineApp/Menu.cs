using System;
using System.Xml.Xsl.Runtime;

namespace VendingMachineApp {
    public class Menu {
        

        public static void Display(ProductsBuilder pb, Products allProducts) {
            
            
            WriteLineColored("\t\t\t === Vending Machine ===", ConsoleColor.Blue);
            Console.WriteLine(allProducts);
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
                    allProducts = pb.FillMachine();
                    break;
                case "2":
                    Console.WriteLine(allProducts);
                    break;
                case "3":
                    WriteLineColored("Product index: ", ConsoleColor.Black);
                    string index = Console.ReadLine();
                    WriteLineColored("Product quantity: ", ConsoleColor.Black);
                    string quantity = Console.ReadLine();
                    // select an id and quantity after that will actualized stock
                    ProductPurchase(allProducts, Int32.Parse(money), Int32.Parse(index),Int32.Parse(quantity));
                    Console.WriteLine(allProducts);
                    break;
                case "4":
                    WriteLineColored("Refund money " + money + "$\n", ConsoleColor.Green);
                    Environment.Exit(0);
                    break;
                default:
                    WriteLineColored("Invalid option !!!", ConsoleColor.Red);
                    break;
            }
        }
        
        public static void WriteLineColored(string text, ConsoleColor color) {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static void ProductPurchase(Products produs, int money, int index, int quantity) {
            if (money >= produs.getItem(index).price() * quantity && produs.getItem(index).GetQuantity() >= quantity) {
                var computeMoney = money - produs.getItem(index).price() * quantity;
                produs.getItem(index).RemoveQuantity(quantity);
                WriteLineColored("Transaction with successfully and your rest is " + computeMoney + "$\n", ConsoleColor.Green);
                Log.WriteLine("Deposit sum of: " + produs.getItem(index).price() * quantity);
            }
            else {
                WriteLineColored("Not enough money or not enough quantity in stock\n", ConsoleColor.Red);
                WriteLineColored("Refund money " + money + "$\n", ConsoleColor.Green);
            }
        }
    }
}