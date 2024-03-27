
using APBD2.Exception;

namespace APBD2.Class;

public class CoLiquid: Contain, IHazardNotifier
{
    private bool _isDanger;
    public  CoLiquid(double maxMase, double weight, double height, bool isDanger):base(maxMase, weight, height)
    {
        id = "KON-" + "L-" + nextId;
        _isDanger = isDanger;

    }

    public void printNotification(string s)
    {
        Console.WriteLine(s);
    }

    public override void load(double mase)
    {
        if (_isDanger)
        {
            if (mase + maseOfProduct > maxMase * 0.5)
            {
                printNotification("This container can`t hold so much");
                throw new OverfillException($"Max weight: {maxMase}, Weight after: {maseOfProduct + mase}, ID: {id}");
            }

            maseOfProduct += mase;
        }
        else
        {
            if (mase + maseOfProduct > maxMase * 0.9)
            {
                printNotification("This container can`t hold so much");
                throw new OverfillException($"Max weight: {maxMase}, Weight after: {maseOfProduct + mase}, ID: {id}");
            }

            maseOfProduct += mase;
        }
    }

    public override string ToString()
    {
        return
            $"ID: {id}, Weight: {weight}, Height: {height}, MaxWieght: {maxMase}, TotalWeight: {maseOfProduct}, IsDangerous: {_isDanger}";
    }
}