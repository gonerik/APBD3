namespace APBD2.Class;

public class CoCooling: Contain
{
    public string type;
    public double temperature;
    private static Dictionary<String, double> sortOfProduct = new()
    {
        {"Banana",13.3},
        {"Chocolate",18},
        {"Fish",2},
        {"Meat",-15},
        {"Ice Cream",-18},
        {"Frozen Pizza",-30},
        {"Cheeze",7.2},
        {"Sausage",5},
        {"Butter",20.5},
        {"Eggs",19}
        
    };
    public CoCooling(double maxMase, double weight, double height, string type) : base(maxMase, weight, height)
    {
        id = "KON-" + "C-" + nextId;
        this.type = type;
        temperature = sortOfProduct[type];
    }
    public override string ToString()
    {
        return
            $"ID: {id}, Weight: {weight}, Height: {height}, MaxWieght: {maxMase}, TotalWeight: {maseOfProduct}, Type: {type}, Temperature: {temperature}";
    }
    
}