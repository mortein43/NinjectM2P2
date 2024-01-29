namespace NinjectM2P2;

public class ConsoleOutput : IOutputService
{
    public void Display(string output)
    {
        Console.WriteLine(output);
    }
}
