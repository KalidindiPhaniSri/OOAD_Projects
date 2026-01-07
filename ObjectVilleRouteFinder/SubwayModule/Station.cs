namespace ObjectVilleRouteFinder.SubwayModule
{
    public class Station(string name)
    {
        private readonly string _name = name;

        public string GetName()
        {
            return _name;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Station other)
                return false;
            return string.Equals(_name, other.GetName(), StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return _name.ToLower().GetHashCode();
        }
    }
}
