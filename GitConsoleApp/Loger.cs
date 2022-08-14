namespace GitConsoleApp;

public class Loger : ILoger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
    
    public void Log2(string message)
    {
        Console.WriteLine(message);
    }
}
