namespace InventoryConsoleApp.BLL
{
    public class Mandolin(string serialNumber, double price, MandolinSpecs specs)
        : Instrument(serialNumber, price)
    {
        private MandolinSpecs _specs = specs;

        public MandolinSpecs GetSpecs()
        {
            return _specs;
        }
    }
}
