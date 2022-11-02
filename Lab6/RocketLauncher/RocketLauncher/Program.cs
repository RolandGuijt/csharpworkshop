namespace RocketLauncher
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            var launcher = new LaunchEngine();
            launcher.QueueLaunchables();
            launcher.LaunchAll();
        }
    }
}