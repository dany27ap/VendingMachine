namespace VendingMachineApp {
    public interface Item {

        string name();
        double price();
        int GetQuantity();

        Packing packing();
    }
}