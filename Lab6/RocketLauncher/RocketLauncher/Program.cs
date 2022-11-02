using Launcher.Launchables;
using Launcher;

namespace RocketLauncher
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            var launcher = new LaunchEngine();

            Console.WriteLine("Press c to queue a career, r to queue a rocket, q to quit");
            while (true)
            {
                var key = Console.ReadKey();
                if (key.KeyChar == 'q')
                    break;
                if (key.KeyChar == 'r')
                {
                    var rocket = new Rocket();
                    launcher.QueueLaunchable(rocket);
                    Console.WriteLine($"{rocket.NameOfLaunchable} has been queued");
                }
                if (key.KeyChar == 'c')
                {
                    Console.WriteLine("Your name please");
                    var name = Console.ReadLine();
                    var career = new Career(name);
                    launcher.QueueLaunchable(career);
                    Console.WriteLine($"{career.NameOfLaunchable} has been queued");
                }

            }
    
            var duration = launcher.LaunchAll();
            Console.WriteLine($"The total duration is {duration}");
        }
    }
}