using Microsoft.CSharp.RuntimeBinder;

namespace WarGameFramework.Modules.Units
{
    public class Unit(int id)
    {
        private int _id = id;
        private string _name = string.Empty;
        private string _type = string.Empty;

        private readonly List<Dictionary<string, object>> _weapons =  [ ];
        private readonly Dictionary<string, object> _properties =  [ ];

        public string GetName() => _name;

        public void SetName(string name) => _name = name;

        public int GetId() => _id;

        public string GetUnitType() => _type;

        public void SetUnitType(string type) => _type = type;

        public List<Dictionary<string, object>> GetWeapons() => _weapons;

        public void SetWeapon(Dictionary<string, object> weapon) => _weapons.Add(weapon);

        public Dictionary<string, object> GetProperties() => _properties;

        public void SetProperty(string name, object value) => _properties[name] = value;

        public object? GetProperty(string name)
        {
            if (_properties.TryGetValue(name, out var value))
                return value;

            throw new RuntimeBinderException("Request for non-existed property");
        }
    }
}
