class Lasagna
{
    int Duration = 40;
    int TimePerLayer = 2;

    public int ExpectedMinutesInOven() => Duration;
    public int RemainingMinutesInOven(int TimeInOven)
    {
        return ExpectedMinutesInOven() - TimeInOven;
    }
    public int PreparationTimeInMinutes(int Layers) => Layers * TimePerLayer;
    
    public int ElapsedTimeInMinutes(int Layers, int TimeInOven)
    {
        return PreparationTimeInMinutes(Layers) + TimeInOven;
    }
}
