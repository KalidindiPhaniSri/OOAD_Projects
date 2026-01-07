using ObjectVilleRouteFinder.SubwayModule;

namespace ObjectVilleRouteFinder.Core
{
    public class Subway
    {
        private List<Station> _stations =  [ ];
        private List<Connection> _connections =  [ ];

        private Dictionary<Station, List<Station>> _network = new();

        public bool HasStation(string name)
        {
            return _stations.Contains(new Station(name));
        }

        public bool HasConnection(string lineName, string station1, string station2)
        {
            Station station1Obj = new(station1);
            Station station2Obj = new(station2);
            foreach (var connection in _connections)
            {
                if (
                    connection.GetLineName() == lineName
                    && connection.GetStation1().Equals(station1Obj)
                    && connection.GetStation2().Equals(station2Obj)
                )
                    return true;
            }
            return false;
        }

        public void AddStation(object? obj)
        {
            if (obj is Station other && !HasStation(other.GetName()))
            {
                _stations.Add(other);
            }
        }

        public void AddConnection(string station1, string station2, string lineName)
        {
            if (HasStation(station1) && HasStation(station2))
            {
                Station station1Obj = new(station1);
                Station station2Obj = new(station2);
                Connection connection = new(station1Obj, station2Obj, lineName);
                _connections.Add(connection);
                AddNetwork(station1Obj, station2Obj);
                Connection reverseConnection =
                    new(station2Obj, station1Obj, connection.GetLineName());
                _connections.Add(reverseConnection);
            }
        }

        public void AddNetwork(Station station1Obj, Station station2Obj)
        {
            if (_network.ContainsKey(station1Obj))
            {
                List<Station> connectingStations = _network[station1Obj];
                if (!connectingStations.Contains(station2Obj))
                {
                    connectingStations.Add(station2Obj);
                }
            }
            else
            {
                List<Station> connectingStations =  [ ];
                connectingStations.Add(station2Obj);
                _network.Add(station1Obj, connectingStations);
            }
        }

        public List<Connection> GetDirections(string startStationName, string endStationName)
        {
            if (!HasStation(startStationName) || !HasStation(endStationName))
            {
                throw new InvalidOperationException("Stations doesn't exist on this subway");
            }
            List<Connection> route =  [ ];
            Station start = new(startStationName);
            Station end = new(endStationName);
            List<Station> neighbors = _network[start];
            List<Station> toVisit =  [ ];
            Dictionary<Station, Station> visited =  [ ];

            foreach (Station station in neighbors)
            {
                if (station.Equals(end))
                {
                    route.Add(GetConnection(start, end));
                    return route;
                }
                toVisit.Add(station);
                visited.Add(station, start);
            }

            List<Station> nextStations = neighbors;
            // Station currentStation=start;

            //Breadth-first search
            for (int i = 0; i < neighbors.Count; i++)
            {
                List<Station> temporaryNextStations =  [ ];
                foreach (Station station in nextStations)
                {
                    Station currentStation = station;
                    List<Station> currentNeighbors = _network[currentStation];
                    foreach (Station neighbor in currentNeighbors)
                    {
                        if (neighbor.Equals(end))
                        {
                            visited.Add(end, neighbor);
                            goto BuildPath;
                        }
                        else if (!toVisit.Contains(neighbor))
                        {
                            visited.Add(end, neighbor);
                            toVisit.Add(neighbor);
                            temporaryNextStations.Add(neighbor);
                        }
                    }
                }
                nextStations = temporaryNextStations;
            }
            BuildPath:
            bool keepLooping = true;
            Station keyStation = end;
            while (keepLooping)
            {
                Station station = visited[keyStation];
                route.Add(GetConnection(station, keyStation));
                if (station.Equals(start))
                {
                    keepLooping = false;
                }
                keyStation = station;
            }
            route.Reverse();
            return route;
        }

        public Connection GetConnection(Station start, Station end)
        {
            foreach (var connection in _connections)
            {
                if (connection.GetStation1().Equals(start) && connection.GetStation2().Equals(end))
                {
                    return connection;
                }
            }
            throw new InvalidOperationException($"Connection not found : {start} -> {end}");
        }

        public List<Connection> GetConnections()
        {
            return _connections;
        }
    }
}
