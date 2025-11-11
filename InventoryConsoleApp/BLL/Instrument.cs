namespace InventoryConsoleApp.BLL
{
    public class Instrument(string serialNumber, double price, InstrumentSpecs specs)
    {
        private string _serialNumber = serialNumber;
        private double _price = price;

        private InstrumentSpecs _specs = specs;

        public string GetSerialNumber()
        {
            return _serialNumber;
        }

        public double GetPrice()
        {
            return _price;
        }

        public InstrumentSpecs GetSpecs()
        {
            return _specs;
        }
    }
}
