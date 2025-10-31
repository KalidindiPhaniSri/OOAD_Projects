namespace DogDoorConsoleApp.BLL
{
    public class DogDoor
    {
        private readonly List<Bark> _allowedBarks =  [ ];
        private bool _open = false;

        public void Open()
        {
            _open = true;
            Console.WriteLine("The dog door opens");
            Task.Run(async () =>
            {
                await Task.Delay(2000);
                Close();
            });
        }

        public void Close()
        {
            _open = false;
            Console.WriteLine("The dog door closes");
        }

        public bool IsOpen()
        {
            return _open;
        }

        public List<Bark> GetAllowedBarks()
        {
            return _allowedBarks;
        }

        public void AddAllowedBarks(Bark bark)
        {
            _allowedBarks.Add(bark);
        }
    }
}
