namespace InventoryConsoleApp.BLL
{
    public class Guitar(string serialNumber, double price, GuitarSpecs specs)
        : Instrument(serialNumber, price, specs) { }
}
