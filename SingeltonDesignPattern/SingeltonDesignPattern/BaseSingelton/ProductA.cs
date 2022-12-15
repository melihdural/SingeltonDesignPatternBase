namespace SingeltonDesignPattern;

public class ProductA : Singleton<ProductA>
{
    private string name = "A";

    public string Name
    {
        get => name;
        set => name = value;
    }

    public void Main()
    {
        var productA = GetInstance;
        var name = productA.name;
        Console.WriteLine(name);
    }
}