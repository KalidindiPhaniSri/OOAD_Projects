using InventoryConsoleApp.BLL;

namespace InventoryConsoleApp.Core
{
    public class Inventory()
    {
        private List<Instrument> _inventory =  [ ];

        public void AddInstrument(Instrument instrument)
        {
            if (instrument is Guitar g)
            {
                var newGuitar = new Guitar(
                    g.GetSerialNumber(),
                    g.GetPrice(),
                    (GuitarSpecs)g.GetSpecs()
                );
                _inventory.Add(newGuitar);
            }
            else if (instrument is Mandolin m)
            {
                var newMandolin = new Mandolin(
                    m.GetSerialNumber(),
                    m.GetPrice(),
                    (MandolinSpecs)m.GetSpecs()
                );
                _inventory.Add(newMandolin);
            }
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
