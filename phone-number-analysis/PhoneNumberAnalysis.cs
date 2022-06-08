using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] splitNumber = phoneNumber.Split('-');
        
        bool IsNewYork = "212" == splitNumber[0];
        bool IsFake = "555" == splitNumber[1];
        string LocalNumber = splitNumber[2];

        return (IsNewYork, IsFake, LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
    
}
