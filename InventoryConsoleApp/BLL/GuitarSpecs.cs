using InventoryConsoleApp.Core.Enums;

namespace InventoryConsoleApp.BLL
{
    public class GuitarSpecs(
        int numStrings,
        string model,
        Builder builder,
        InstrumentType type,
        Wood wood
    ) : InstrumentSpecs(model, builder, type, wood)
    {
        private int _numStrings = numStrings;

        public int GetNumStrings()
        {
            return _numStrings;
        }
    }
};
