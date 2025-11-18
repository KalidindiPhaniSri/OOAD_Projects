using InventoryConsoleApp.Core.Enums;

namespace InventoryConsoleApp.BLL
{
    public class InstrumentSpecs(Dictionary<string, object> properties)
    {
        private Dictionary<string, object> _properties = new(properties);

        private static string ConvertToString(object? value)
        {
            try
            {
                if (value == null)
                    return string.Empty;
                return value switch
                {
                    Builder b => b.ToFriendlyString(),
                    InstrumentName n => n.ToFriendlyString(),
                    InstrumentType t => t.ToFriendlyString(),
                    Style s => s.ToFriendlyString(),
                    Wood w => w.ToFriendlyString(),
                    Enum e => e.ToString(),
                    _ => Convert.ToString(value) ?? string.Empty
                };
            }
            catch
            {
                return string.Empty;
            }
        }

        public object? GetProperty(string propertyName)
        {
            _properties.TryGetValue(propertyName, out var value);
            return value;
        }

        public string GetStringValue(string propertyName)
        {
            _properties.TryGetValue(propertyName, out var value);
            return ConvertToString(value);
        }

        public Dictionary<string, object> GetAllProperties()
        {
            return _properties;
        }

        public bool Matches(InstrumentSpecs otherSpecs)
        {
            foreach (var pair in otherSpecs.GetAllProperties())
            {
                if (!_properties.TryGetValue(pair.Key, out var value))
                    return false;

                if (!ConvertToString(value).Equals(ConvertToString(pair.Value)))
                    return false;
            }
            return true;
        }
    }
}
