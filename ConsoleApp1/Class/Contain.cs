using APBD2.Exception;

namespace APBD2.Class;

public class Contain
{
    public static int nextId = 0;
    public double maseOfProduct=0;
    public double height;
    public double weight;
    public string id;
    public double maxMase;

    public Contain(double maxMase, double weight, double height)
    {
        this.maxMase = maxMase;
        this.weight = weight;
        this.height = height;
        id = "";
    }

    public virtual void empty()
    {
        this.maseOfProduct = 0;
    }

    public virtual void load(double mase)
    {
       if(maseOfProduct+mase>maxMase)
           throw new OverfillException($"Max weight: {maxMase}, Weight after: {maseOfProduct + mase}, ID: {id}");
       maseOfProduct += mase;
    }
    public override string ToString()
    {
        return
            $"ID: {id}, Weight: {weight}, Height: {height}, MaxWieght: {maxMase}, TotalWeight: {maseOfProduct}";
    }
}