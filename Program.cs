class Singleton
{
    private static Singleton _instance;
    public static Singleton Instance => _instance ??= new Singleton();
    private Singleton() { }
    public void Show() => Console.WriteLine("Singleton works");
}

class Program { static void Main() => Singleton.Instance.Show(); }
