namespace DogDoorConsoleApp.BLL
{
    public class BarkRecognizer(DogDoor door)
    {
        private readonly DogDoor _door = door;

        public void Recognize(Bark bark)
        {
            Console.WriteLine($"Bark Recognizer : Heard a `{bark.GetBark()}`");

            if (Bark.Equals(bark, _door))
            {
                _door.Open();
            }
            else
            {
                Console.WriteLine("This dog is not allowed");
            }
        }
    }
}
