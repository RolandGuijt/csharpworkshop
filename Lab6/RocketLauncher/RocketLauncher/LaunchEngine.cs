using Launcher;
using Launcher.Launchables;

    public class LaunchEngine
    {
        private List<ILaunchable> _Launchables = new List<ILaunchable>();
        
        public int LaunchAll()
        {
            var duration = 0;
            foreach (var launchable in _Launchables)
            {
                duration = duration + launchable.MissionDurationInHours;
                launchable.Launch();
            }
            return duration;

        }
        public void QueueLaunchable(ILaunchable launchable)
        {
            _Launchables.Add(launchable);
  
        }
    }
