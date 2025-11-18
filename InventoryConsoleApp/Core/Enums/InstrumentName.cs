namespace InventoryConsoleApp.Core.Enums
{
    public enum InstrumentName
    {
        GUITAR,
        BANJO,
        DOBRO,
        FIDDLE,
        BASS,
        MANDOLIN
    }

    public static class InstrumentNameExtensions
    {
        public static string ToFriendlyString(this InstrumentName name)
        {
            return name switch
            {
                InstrumentName.GUITAR => "Guitar",
                InstrumentName.BANJO => "Banjo",
                InstrumentName.DOBRO => "Dobro",
                InstrumentName.FIDDLE => "Fiddle",
                InstrumentName.BASS => "Bass",
                InstrumentName.MANDOLIN => "Mandolin",
                _ => "Unknown Instrument"
            };
        }
    }
}
