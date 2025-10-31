namespace DogDoorConsoleApp.BLL
{
    public class Remote(DogDoor door)
    {
        private readonly DogDoor _door = door;

        public void PressButton()
        {
            _door.Open();
        }
    }
}
