using InventoryConsoleApp.Core.Enums;

namespace InventoryConsoleApp.BLL
{
    public class GuitarSpecs(
        int numStrings,
        string model,
        Builder builder,
        InstrumentType type,
        Wood backwood,
        Wood topwood
    ) : InstrumentSpecs(model, builder, type, backwood, topwood)
    {
        private int _numStrings = numStrings;

        public int GetNumStrings()
        {
            return _numStrings;
        }

        public override bool Matches(InstrumentSpecs otherSpecs)
        {
            if (otherSpecs is not GuitarSpecs guitarSpecs)
                return false;
            if (!otherSpecs.Matches(otherSpecs))
                return false;
            return _numStrings == guitarSpecs._numStrings;
        }
    }
};
