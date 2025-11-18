namespace InventoryConsoleApp.Core.Enums
{
    public enum Builder
    {
        FENDER,
        MARTIN,
        GIBSON,
        COLLINGS
    }

    public static class BuilderExtentions
    {
        public static string ToFriendlyString(this Builder builder)
        {
            return builder switch
            {
                Builder.FENDER => "Fender",
                Builder.MARTIN => "Martin",
                Builder.GIBSON => "Gibson",
                Builder.COLLINGS => "Collings",
                _ => "Unknown Builder"
            };
        }
    }
}
