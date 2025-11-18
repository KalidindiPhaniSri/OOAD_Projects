namespace InventoryConsoleApp.BLL
{
    public class Inventory()
    {
        private List<Instrument> _inventory =  [ ];

        public void AddInstrument(string serialNumer, double price, InstrumentSpecs specs)
        {
            var instrument = new Instrument(serialNumer, price, specs);
            _inventory.Add(instrument);
        }

        public Instrument? GetInstrument(string serialNumber)
        {
            foreach (var instrument in _inventory)
            {
                if (instrument.GetSerialNumber() == serialNumber)
                {
                    return instrument;
                }
            }
            return null;
        }

        public List<Instrument> Search(InstrumentSpecs searchSpecs)
        {
            var matchingInstruments = new List<Instrument>();
            foreach (var instrument in _inventory)
            {
                if (instrument.GetSpecs().Matches(searchSpecs))
                {
                    matchingInstruments.Add(instrument);
                }
            }
            return matchingInstruments;
        }
    }
}
