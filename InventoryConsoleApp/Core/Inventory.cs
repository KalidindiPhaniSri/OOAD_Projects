using System.Diagnostics.Metrics;

namespace InventoryConsoleApp.BLL
{
    public class Inventory(Instrument inventory)
    {
        private List<Instrument> _inventory = inventory;
    }
}
