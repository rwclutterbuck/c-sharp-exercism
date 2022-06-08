using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        return (speed == 0) ? 0
        : (1 <= speed && speed <= 4) ? 1
        : (5 <= speed && speed <= 8) ? 0.9
        : (speed == 9) ? 0.8 : 0.77;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        int productionRate = 221;
        return SuccessRate(speed) * speed * productionRate;
    }

    public static int WorkingItemsPerMinute(int speed) =>
        (int)ProductionRatePerHour(speed) / 60; // 1hr / 60 gives 1 minute
}
