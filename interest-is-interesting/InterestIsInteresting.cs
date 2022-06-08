using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float rate;
        if (balance < 0)
        {
            rate = 3.213f;
        }
        else if (balance < 1000)
        {
            rate = 0.5f;
        }
        else if (balance < 5000)
        {
            rate = 1.621f;
        }
        else
        {
            rate = 2.475f;
        }
        return rate;
    }

    public static decimal Interest(decimal balance) =>
        balance * ((decimal)InterestRate(balance) / 100m);

    public static decimal AnnualBalanceUpdate(decimal balance) =>
        balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}
