namespace ObjectVilleRouteFinder.SubwayModule
{
    public class Connection(Station station1, Station station2, string lineName)
    {
        private readonly Station _station1 = station1,
            _station2 = station2;
        private readonly string _lineName = lineName;

        public Station GetStation1()
        {
            return _station1;
        }

        public Station GetStation2()
        {
            return _station2;
        }

        public string GetLineName()
        {
            return _lineName;
        }
    }
}
