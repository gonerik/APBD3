using APBD2.Exception;

namespace APBD2.Class;

public class Ship
{
    public List<Contain> contains= new List<Contain>();
    public double maxSpeed;
    public int maxContain;
    public double maxWeight;

    public Ship(double maxSpeed, int maxContain, double maxWeight)
    {
        this.maxSpeed = maxSpeed;
        this.maxContain = maxContain;
        this.maxWeight = maxWeight;
    }

    public void board(List<Contain> list)
    {
        double sum = 0;
        foreach (Contain c in list)
        {
            sum += c.maseOfProduct;
        }

        if (sum + getWieght() > maxWeight || maxContain<list.Count+this.contains.Count)
            throw new OverfillException("This is too much");
        foreach (Contain c in list)
            contains.Add(c); 
    }

    public double getWieght()
    {
        double sum = 0;
        foreach (Contain c in  contains)
        {
            sum += c.maseOfProduct+c.weight;
        }

        return sum;
    }

    public void board(Contain c)
    {
        if (c.maseOfProduct + c.weight + getWieght() > maxWeight || maxContain < 1 + this.contains.Count)
            throw new OverfillException("This is too much");
        contains.Add(c);
    }

    public void unboard(String id)
    {
        var conToRemove = contains.FirstOrDefault(x => x.id == id);
        if (conToRemove == null) return;
        contains.Remove(conToRemove);
    }

    public void swapContainers(Contain c, string id)
    {
        unboard(id);
        board(c);
    }

    public void swapShips(Contain c, Ship ship)
    {
        unboard(c.id);
        ship.board(c);
    }

    public override string ToString()
    {
        return $"Speed: {this.maxSpeed}, Weight: {this.getWieght()}, MaxWeight: {this.maxWeight}";
    }
}