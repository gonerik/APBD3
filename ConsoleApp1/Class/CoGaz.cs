using APBD2.Exception;

namespace APBD2.Class;

public class CoGaz: Contain, IHazardNotifier
{
    public CoGaz(double maxMase, double weight, double height) : base(maxMase, weight, height)
    {
        id = "KON-" + "G-" + nextId;
    }

    public void printNotification(string s)
    {
        Console.WriteLine(s);
    }

    public override void empty()
    {
        this.maseOfProduct *= 0.05;
    }

    public override void load(double mase)
    {
        if (maseOfProduct + mase > maxMase)
        {
            printNotification("This container can`t hold so much");
            throw new OverfillException($"Max wieght: {maxMase}, Wieght after: {maseOfProduct + mase}, ID: {id}");
        }

        maseOfProduct += mase;
        Console.WriteLine(this);
    }
}