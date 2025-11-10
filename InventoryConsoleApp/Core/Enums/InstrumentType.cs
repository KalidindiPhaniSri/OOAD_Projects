namespace InventoryConsoleApp.Core.Enums
{
    public enum InstrumentType
    {
        ACOUSTIC,
        ELECTRIC
    }

    public static class InstrumentTypeExtensions
    {
        public static string ToString(this InstrumentType type)
        {
            return type switch
            {
                InstrumentType.ACOUSTIC => "Acoustic",
                InstrumentType.ELECTRIC => "Electric",
                _ => "Unknown Type"
            };
        }
    }
}
