namespace SingeltonDesignPattern;

public class ProductB : Singleton<ProductA>
{
    private string name = "B";

    public string Name
    {
        get => name;
        set => name = value;
    }

    public void Main()
    {
        var productB = GetInstance;
        var name = productB.Name;
        Console.WriteLine(name);
    }
}