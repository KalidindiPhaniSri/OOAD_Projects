// See https://aka.ms/new-console-template for more information
using DogDoorConsoleApp.Core;

namespace DogDoorConsoleApp
{
    class Program
    {
        static void Main()
        {
            var app = new DogDoorSimulator();
            app.Start();
        }
    }
}
