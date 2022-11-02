using Launcher;
using Launcher.Launchables;

    public class LaunchEngine
    {
        private List<ILaunchable> _Launchables = new List<ILaunchable>();
        
        public void LaunchAll()
        {
            var duration = 0;
            foreach (var launchable in _Launchables)
            {
                duration = duration + launchable.MissionDurationInHours;
                launchable.Launch();
            }
            Console.WriteLine($"Total duration is {duration} hours!");

        }
        public void QueueLaunchables()
        {
            Console.WriteLine("Press c to queue a career, r to queue a rocket, q to quit");
            while (true)
            {
                var key = Console.ReadKey();
                if (key.KeyChar == 'q')
                    return;
                if (key.KeyChar == 'r')
                {
                    _Launchables.Add(new Rocket());
                    Console.WriteLine("A rocket has been queued");
                }
                if (key.KeyChar == 'c')
                {
                    Console.WriteLine("Your name please");
                    var name = Console.ReadLine();
                    _Launchables.Add(new Career(name));
                    Console.WriteLine($"A career for {name} has been queued");
                }

            }
        }
    }
