namespace Launcher
{
    public interface ILaunchable
    {
        string NameOfLaunchable { get; }
        int MissionDurationInHours { get; }
        void Launch();
    }
}
