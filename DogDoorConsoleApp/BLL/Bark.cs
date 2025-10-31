namespace DogDoorConsoleApp.BLL
{
    public class Bark(string bark)
    {
        private readonly string _bark = bark;

        public string GetBark()
        {
            return _bark;
        }

        public static bool Equals(Bark bark, DogDoor door)
        {
            List<Bark> allowedBarks = door.GetAllowedBarks();
            foreach (Bark barkObj in allowedBarks)
            {
                if (barkObj.GetBark().Equals(bark.GetBark()))
                    return true;
            }
            return false;
        }
    }
}
