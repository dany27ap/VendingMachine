using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp {
    public class Products {
        
        private List<Item> items = new List<Item>();

        public void addItem(Item item) {
            this.items.Add(item);
        }

        public double getCost() {
            double total = 0.0;

            foreach (Item it in items) {
                total += it.price() * it.GetQuantity();
            }

            return total;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            foreach (Item it in items) {
                sb.Append("Item: " + it.name());
                sb.Append(", Packing : " + it.packing().pack());
                sb.Append(" , Quantity : " + it.GetQuantity());
                sb.AppendLine(", Price : " + it.price());
            }

            return sb.ToString();
        }
    }
}