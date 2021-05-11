namespace VehicleLot {
    public class Vehicle {
        protected string manufacturer = "Honda";
        protected string countryOfOrigin;
        protected string wheelCount;
        protected string horsePower;
        protected string engineType;

        public string getManufacturer() {
            return this.manufacturer;
        }
    }
}