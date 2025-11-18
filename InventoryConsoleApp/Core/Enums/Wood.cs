namespace InventoryConsoleApp.Core.Enums
{
    public enum Wood
    {
        INDIAN_ROSEWOOD,
        BRAZILIAN_ROSEWOOD,
        MAPLE,
        CEDAR,
        ALDAR,
        SITKA,
        MAHOGANY,
        ADIRONDACK
    }

    public static class WoodExtensions
    {
        public static string ToFriendlyString(this Wood wood)
        {
            return wood switch
            {
                Wood.INDIAN_ROSEWOOD => "Indian Rose Wood",
                Wood.BRAZILIAN_ROSEWOOD => "Brazilian Rose Wood",
                Wood.MAPLE => "Maple",
                Wood.CEDAR => "Cedar",
                Wood.ALDAR => "Aldar",
                Wood.SITKA => "Sitka",
                Wood.MAHOGANY => "Mahogany",
                Wood.ADIRONDACK => "Adirondack",
                _ => "Unknown Wood"
            };
        }
    }
}
