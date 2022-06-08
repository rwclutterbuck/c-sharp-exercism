using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double rate;
        if (speed == 0) 
        {
            rate = 0;
        }
        else if (1 <= speed && speed <= 4) 
        {
            rate = 1;
        }
        else if (5 <= speed && speed <= 8)
        {
            rate = 0.9;
        }
        else if (speed == 9)
        {
            rate = 0.8;
        }
        else
        {
            rate = 0.77;
        }
        return rate;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        int productionRate = 221;
        return SuccessRate(speed) * speed * productionRate;
    }

    public static int WorkingItemsPerMinute(int speed) =>
        (int)ProductionRatePerHour(speed) / 60;
}
