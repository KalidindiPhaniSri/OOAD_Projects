namespace InventoryConsoleApp.BLL
{
    public class Instrument(string serialNumber, double price, UserSpecs specs)
    {
        private string _serialNumber = serialNumber;
        private double _price = price;
        private UserSpecs _specs = specs;

        public string GetSerialNumber()
        {
            return _serialNumber;
        }

        public double GetPrice()
        {
            return _price;
        }

        public UserSpecs GetUserSpecs()
        {
            return _specs;
        }
    }
}
