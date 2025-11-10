namespace InventoryConsoleApp.Core.Enums
{
    public enum Wood
    {
        INDIAN_ROSEWOOD,
        BRAZILIAN_ROSEWOOD,
        MAPLE,
        CEDAR,
        ALDAR,
        SITKA
    }

    public static class WoodExtensions
    {
        public static string ToString(this Wood wood)
        {
            return wood switch
            {
                Wood.INDIAN_ROSEWOOD => "Indian Rose Wood",
                Wood.BRAZILIAN_ROSEWOOD => "Brazilian Rose Wood",
                Wood.MAPLE => "Maple",
                Wood.CEDAR => "Cedar",
                Wood.ALDAR => "Aldar",
                Wood.SITKA => "Sitka",
                _ => "Unknown Wood"
            };
        }
    }
}
