using InventoryConsoleApp.Core.Enums;

namespace InventoryConsoleApp.BLL
{
    public class MandolinSpecs(
        Style style,
        string model,
        Builder builder,
        InstrumentType type,
        Wood wood
    ) : InstrumentSpecs(model, builder, type, wood)
    {
        private Style _style = style;

        public string GetStyle()
        {
            return _style.ToString();
        }
    }
}
