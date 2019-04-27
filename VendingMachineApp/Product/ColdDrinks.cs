namespace VendingMachineApp {
    public abstract class ColdDrinks : Item {
        public abstract string name();
        public abstract double price();
        public abstract void SetQuantity(int qunatity);
        public abstract int GetQuantity();
        public abstract void RemoveQuantity(int quantity);
        public Packing packing() {
            return new Bottle();
        }
    }
}