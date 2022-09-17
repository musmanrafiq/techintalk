public class Program
{
    const string channelName = "TechInTalk";

    private const string channelTitle = $"This is {channelName}";

    public static void Main(string[] args)
    {
        var Usman = "Usman Rafiq";

    }

    public static string ListPattern(int? input)
    {
        // c#10
        if(input is null)
        {
            throw new ArgumentNullException(nameof(input));
        }

        ArgumentNullException.ThrowIfNull(input, "input");  
        ////

        return string.Empty;
    }
}

