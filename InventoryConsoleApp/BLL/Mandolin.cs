namespace InventoryConsoleApp.BLL
{
    public class Mandolin(string serialNumber, double price, MandolinSpecs specs)
        : Instrument(serialNumber, price, specs) { }
}
