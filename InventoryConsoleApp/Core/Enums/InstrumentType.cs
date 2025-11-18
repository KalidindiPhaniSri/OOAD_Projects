namespace InventoryConsoleApp.Core.Enums
{
    public enum InstrumentType
    {
        ACOUSTIC,
        ELECTRIC
    }

    public static class InstrumentTypeExtensions
    {
        public static string ToFriendlyString(this InstrumentType type)
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
