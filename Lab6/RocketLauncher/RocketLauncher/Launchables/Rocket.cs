namespace Launcher.Launchables
{
    public class Rocket: ILaunchable
    {
        private bool _Launched = false;
        public string NameOfLaunchable 
        { 
            get
            {
                return "Rocket";
            }
        }
        public int MissionDurationInHours
        {
            get
            {
                return 343;
            }
        }

        public void Launch()
        {
            _Launched = true;
        }
    }
}
