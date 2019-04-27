namespace VendingMachineApp {
    public abstract class Snacks : Item {
        
        public abstract string name();
        public abstract double price();
        public abstract int GetQuantity();
        public abstract void SetQuantity(int quantity);
        public Packing packing() {
            return new Wrapper();
        }
    }
}