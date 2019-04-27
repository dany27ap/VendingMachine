using System;
using System.Collections.Generic;

namespace VendingMachineApp {
    public class ProductsBuilder {
        public Products FillMachine() {
            Products products = new Products();
            products.addItem(new Chio(27));
            products.addItem(new Lays(21));
            products.addItem(new Coke(69));
            products.addItem(new Pepsi(4));
            return products;
        }
    }
}