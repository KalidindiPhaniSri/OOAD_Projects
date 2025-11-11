using InventoryConsoleApp.Core.Enums;

namespace InventoryConsoleApp.BLL
{
    public class MandolinSpecs(
        Style style,
        string model,
        Builder builder,
        InstrumentType type,
        Wood backwood,
        Wood topwood
    ) : InstrumentSpecs(model, builder, type, backwood, topwood)
    {
        private Style _style = style;

        public string GetStyle()
        {
            return _style.ToString();
        }

        public override bool Matches(InstrumentSpecs otherSpecs)
        {
            if (otherSpecs is not MandolinSpecs mandolinSpecs)
                return false;
            if (!otherSpecs.Matches(otherSpecs))
                return false;
            return _style == mandolinSpecs._style;
        }
    }
}
