namespace VendingMachineApp {
    public class Chio : Snacks {
        
        private int quantity;

        public Chio(int quantity) {
            SetQuantity(quantity);
        }
        public override string name() {
            return "Chio";
        }

        public override double price() {
            return 1.89;
        }

        public override int GetQuantity() {
            return this.quantity;
        }

        public override void RemoveQuantity(int quantity) {
            this.quantity -= quantity;
        }

        public override void SetQuantity(int quantity) {
            this.quantity = quantity;
        }
    }
}