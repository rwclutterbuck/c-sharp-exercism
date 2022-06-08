using System;

class RemoteControlCar
{
    int distance = 0;
    int battery = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
        string batMessage = (battery == 0) ?  "empty" : $"at {battery}%";
        return $"Battery {batMessage}";
    }

    public void Drive()
    {
        if (battery > 0)
        {
        distance = distance + 20;
        battery = battery - 1;
        }
    }
}
