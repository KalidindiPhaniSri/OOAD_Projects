namespace InventoryConsoleApp.BLL
{
    public class Guitar(string serialNumber, double price, GuitarSpecs specs)
        : Instrument(serialNumber, price)
    {
        private GuitarSpecs _specs = specs;

        public GuitarSpecs GetSpecs()
        {
            return _specs;
        }
    }
}
