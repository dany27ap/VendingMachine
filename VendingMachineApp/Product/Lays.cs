namespace VendingMachineApp {
    public class Lays : Snacks {
        
        private int quantity;

        public Lays(int quantity) {
            SetQuantity(quantity);
        }
        public override string name() {
            return "Lays";
        }

        public override double price() {
            return 1.23;
        }

        public override int GetQuantity() {
            return this.quantity;
        }

        public override void RemoveQuantity(int quantity) {
            
        }

        public override void SetQuantity(int quantity) {
            this.quantity = quantity;
        }
    }
}