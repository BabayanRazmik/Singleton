
////////////////
///SINGLETON///
//////////////

class Singleton
{
    static Singleton uniqueInstance;
    string singletondata = string.Empty;
    protected Singleton()
    {
    }
    // only 1 instance
    public static Singleton Instance()
    {
        if (uniqueInstance == null)
        {
            uniqueInstance = new Singleton();
        }
        return uniqueInstance;
    }
    public void SingletonOperation()
    {
        singletondata = "SingletonData";
    }
    public string GetSingletonData()
    {
        return singletondata;
    }
}

class Program
{
    static void Main()
    {
        Singleton instance1 = Singleton.Instance();
        Singleton instance2 = Singleton.Instance();
        Console.WriteLine("Is  the instance1 and instance2 has the same referance -> " + ReferenceEquals(instance1, instance2));

        instance1.SingletonOperation();
        string singletonData =instance1.GetSingletonData();
        Console.WriteLine(singletonData);
    }
}