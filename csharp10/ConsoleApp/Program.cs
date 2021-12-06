public class Program
{
    private static string? name;

    public static void Main(string[] args)
    {
        SayHi(name);
    }

    private static void SayHi(string name)
    {
        // before csharp 10
        /*if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException(nameof(name));
        }*/

        // now in csharp 10
        ArgumentNullException.ThrowIfNull(name, "name");

        Console.WriteLine(name);    
    }
}
