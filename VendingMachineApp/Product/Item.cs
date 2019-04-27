namespace VendingMachineApp {
    public interface Item {

        string name();
        double price();
        int GetQuantity();
        void RemoveQuantity(int quantity);
        Packing packing();
    }
}