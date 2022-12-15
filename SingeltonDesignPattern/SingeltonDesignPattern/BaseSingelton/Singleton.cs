namespace SingeltonDesignPattern;

public class Singleton<T> where T : class, new()
{
    public Singleton() { }

    class SingletonCreator
    {
        static SingletonCreator() { }
        // Private object instantiated with private constructor
        internal static readonly T instance = new T();
    }

    public static T GetInstance
    {
        get { return SingletonCreator.instance; }
    }
}