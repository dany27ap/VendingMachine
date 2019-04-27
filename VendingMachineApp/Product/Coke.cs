namespace VendingMachineApp {
    public class Coke : ColdDrinks {
        
        private int quantity;

        public Coke(int qunatity) {
            SetQuantity(qunatity);
        }
        public override string name() {
            return "Coke";
        }

        public override double price() {
            return 1.69;
        }

        public override void SetQuantity(int qunatity) {
            this.quantity = qunatity;
        }

        public override int GetQuantity() {
            return this.quantity;
        }

        public override void RemoveQuantity(int quantity) {
            this.quantity -= quantity;
        }
    }
}