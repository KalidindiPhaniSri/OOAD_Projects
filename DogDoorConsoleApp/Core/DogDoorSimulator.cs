using DogDoorConsoleApp.BLL;

namespace DogDoorConsoleApp.Core
{
    public class DogDoorSimulator
    {
        public void Start()
        {
            Console.WriteLine("OM");
            DogDoor door = new();
            door.AddAllowedBarks(new Bark("rowlf"));
            door.AddAllowedBarks(new Bark("rooowlf"));
            door.AddAllowedBarks(new Bark("rawlf"));
            door.AddAllowedBarks(new Bark("woof"));
            BarkRecognizer barkRecognizer = new(door);
            Remote remote = new(door);

            //Simulate the hardware hearing the bark
            Console.WriteLine("Bruce starts barking");
            barkRecognizer.Recognize(new Bark("rowlf"));
            Console.WriteLine("\nBruce has gone outside");

            try
            {
                Thread.Sleep(5000);
            }
            catch (ThreadInterruptedException error)
            {
                Console.WriteLine(error);
            }
            Console.WriteLine("\nBruce's all done , ...but he is stuck outside");

            //Simulate the hardware hearing a bark (not Bruce )
            Console.WriteLine("A small dog starts barking");
            barkRecognizer.Recognize(new("yip"));

            try
            {
                Thread.Sleep(5000);
            }
            catch (ThreadInterruptedException error)
            {
                Console.WriteLine(error);
            }

            //Simulate the hardware hearing the bark again
            Console.WriteLine("Bruce starts barking");
            barkRecognizer.Recognize(new Bark("rooowlf"));
            Console.WriteLine("\nBruce back inside");
        }
    }
}
