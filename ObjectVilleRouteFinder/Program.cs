using ObjectVilleRouteFinder.Core;
using ObjectVilleRouteFinder.SubwayModule;

namespace ObjectVilleRouteFinder
{
    class Program
    {
        static void TestDirections(Subway subway, string[] args)
        {
            // foreach (var connection in subway.GetConnections())
            // {
            //     Console.WriteLine(
            //         $"{connection.GetLineName()}: "
            //             + $"{connection.GetStation1().GetName()} -> {connection.GetStation2().GetName()}"
            //     );
            // }

            if (args.Length != 2)
            {
                Console.Error.WriteLine("Usage: SubwayTester <startStation> <endStation>");
                Environment.Exit(-1);
            }
            try
            {
                if (!subway.HasStation(args[0]))
                {
                    Console.Error.WriteLine(args[0] + " is not a station in objectville");
                    Environment.Exit(-1);
                }
                else if (!subway.HasStation(args[1]))
                {
                    Console.Error.WriteLine(args[1] + " is not a station in objectville");
                    Environment.Exit(-1);
                }
                List<Connection> route = subway.GetDirections(args[0], args[1]);
                SubwayPrinter printer = new(Console.Out);
                printer.PrintDirections(route);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
        }

        static void Main()
        {
            try
            {
                SubwayLoader _subwayLoader = new();
                Subway subway = _subwayLoader.LoadFromFile(
                    "../ObjectVilleRouteFinder/Core/ObjectVilleSubway.txt"
                );
                Console.WriteLine("Testing stations...");
                if (
                    subway.HasStation("DRY Drive")
                    && subway.HasStation("Weather-O-Rama, Inc.")
                    && subway.HasStation("Boards 'R' Us")
                )
                {
                    Console.WriteLine("Station test passed successfully");
                }
                else
                {
                    Console.WriteLine("Station test failed");
                    Environment.Exit(-1);
                }
                Console.WriteLine("\n Testing Connections");
                if (
                    subway.HasConnection("Meyer Line", "DRY Drive", "Boards 'R' Us")
                    && subway.HasConnection("Wirth-Brock Line", "DRY Drive", "Weather-O-Rama, Inc.")
                    && subway.HasConnection(
                        "Rumbaugh Line",
                        "Head First Theater",
                        "Infinite Circle"
                    )
                )
                {
                    Console.WriteLine("...connections test passed successfully.");
                }
                else
                {
                    Console.WriteLine("...connections test FAILED.");
                    Environment.Exit(-1);
                }
                string[] args =  [ "Ajax Rapids", "Boards 'R' Us" ];
                TestDirections(subway, args);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
