namespace VendingMachineApp {
    public class Pepsi : ColdDrinks {
        private int quantity;

        public Pepsi(int quantity) {
            SetQuantity(quantity);
        }
        public override string name() {
            return "Pepsi";
        }

        public override double price() {
            return 2.39;
        }

        public override void SetQuantity(int qunatity) {
            this.quantity = qunatity;
        }

        public override int GetQuantity() {
            return this.quantity;
        }
    }
}