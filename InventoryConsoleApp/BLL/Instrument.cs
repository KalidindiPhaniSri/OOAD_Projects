namespace InventoryConsoleApp.BLL
{
    public class Instrument(string serialNumber, double price)
    {
        private string _serialNumber = serialNumber;
        private double _price = price;

        public string GetSerialNumber()
        {
            return _serialNumber;
        }

        public double GetPrice()
        {
            return _price;
        }
    }
}
