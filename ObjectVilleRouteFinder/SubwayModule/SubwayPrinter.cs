namespace ObjectVilleRouteFinder.SubwayModule
{
    public class SubwayPrinter(TextWriter output)
    {
        private TextWriter _out = output;

        public void PrintDirections(List<Connection> route)
        {
            Connection connection = route[0];
            string lineName = connection.GetLineName();
            _out.WriteLine("Start out at " + connection.GetStation1().GetName() + ".");
            _out.WriteLine(
                "Get on the "
                    + lineName
                    + " heading towards "
                    + connection.GetStation2().GetName()
                    + "."
            );

            for (int i = 1; i < route.Count; i++)
            {
                connection = route[i];
                string currentLine = connection.GetLineName();
                if (currentLine.Equals(lineName))
                {
                    _out.WriteLine("Continue past" + connection.GetStation1().GetName() + "...");
                }
                else
                {
                    _out.WriteLine(
                        "When you get to "
                            + connection.GetStation1().GetName()
                            + " , get off the previous line"
                            + "."
                    );
                    _out.WriteLine(
                        "Switch over to the "
                            + currentLine
                            + " heading towards "
                            + connection.GetStation2().GetName()
                            + "."
                    );
                }
                lineName = currentLine;
            }
            _out.WriteLine(
                "Get off at " + connection.GetStation2().GetName() + " and enjoy yourself!"
            );
        }
    }
}
