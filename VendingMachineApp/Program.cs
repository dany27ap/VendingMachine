using System;
using System.Collections.Generic;

namespace VendingMachineApp {
    internal class Program {
        public static void Main(string[] args) {
 
            ProductsBuilder pb = new ProductsBuilder();
            Products allProducts = pb.FillMachine();

            bool continueOperation = true;

            while (continueOperation) {
                Menu.Display(pb, allProducts);
                Menu.WriteLineColored("You want still buy ? [Y/N]", ConsoleColor.Cyan);
                string inputUser = Console.ReadLine();
                if (!inputUser.Equals("Y")) {
                    continueOperation = false;
                }
            }
        }
    }
}