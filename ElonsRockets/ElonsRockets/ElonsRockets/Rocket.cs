struct Rocket
{
    private bool _Launched = false;
    private bool _Landed = false;
    private DateTime _LaunchedTime;

    public Rocket()
    {
        _LaunchedTime = DateTime.MinValue;
    }

    private TimeSpan MissionDuration
    {
        get
        {
            return DateTime.Now - _LaunchedTime;
        }
    }
    public RocketStatus Status
    {
        get
        {
            if (!_Launched)
                return RocketStatus.NotLaunched;
            if (_Landed)
                return RocketStatus.Landed;
            if (MissionDuration.TotalSeconds < 10)
                return RocketStatus.TakingOff;
            else
                return RocketStatus.Orbit;
        }
    }

    public void Launch()
    {
        _Launched = true;
        _LaunchedTime = DateTime.Now;
    }

    public void Land()
    {
        _Landed = true;
    }
}