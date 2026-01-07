using ObjectVilleRouteFinder.SubwayModule;

namespace ObjectVilleRouteFinder.Core
{
    public class SubwayLoader
    {
        private Subway _subway;

        public SubwayLoader()
        {
            _subway = new Subway();
        }

        public Subway LoadFromFile(string filePath)
        {
            using var reader = new StreamReader(filePath);

            LoadStations(reader);
            LoadLines(reader);
            return _subway;
        }

        public void LoadLines(StreamReader reader)
        {
            var lineName = reader.ReadLine()?.Trim();
            while (!string.IsNullOrEmpty(lineName))
            {
                AddLines(reader, lineName);
                lineName = reader.ReadLine()?.Trim();
            }
        }

        public void LoadStations(StreamReader reader)
        {
            string? station = reader.ReadLine()?.Trim();
            while (!string.IsNullOrEmpty(station))
            {
                _subway.AddStation(new Station(station));
                station = reader.ReadLine()?.Trim();
            }
        }

        public void AddLines(StreamReader reader, string lineName)
        {
            string? station1 = reader.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(station1))
                return;
            string? station2 = reader.ReadLine()?.Trim();
            while (!string.IsNullOrEmpty(station2))
            {
                _subway.AddConnection(station1, station2, lineName);
                station1 = station2;
                station2 = reader.ReadLine()?.Trim();
            }
        }
    }
}
