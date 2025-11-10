namespace InventoryConsoleApp.Core.Enums
{
    public enum Style
    {
        A,
        F
    }

    public static class StyleExtensions
    {
        public static string ToString(this Style style)
        {
            return style switch
            {
                Style.A => "A",
                Style.F => "F",
                _ => "Unknown"
            };
        }
    }
}
