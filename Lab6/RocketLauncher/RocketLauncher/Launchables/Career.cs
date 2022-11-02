namespace Launcher.Launchables
{
    public class Career : ILaunchable
    {
        private readonly string _YourName;
        private bool _CareerStarted;

        public Career(string yourName)
        {
            _YourName = yourName;
        }
        public string NameOfLaunchable {
            get
            {
                return $"The career of {_YourName}";
            }
        }
        public int MissionDurationInHours 
        { 
            get 
            { 
                return 48345; 
            } 
        }

        public void Launch()
        {
            _CareerStarted = true;
        }
    }
}
