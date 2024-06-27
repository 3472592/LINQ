namespace Versatile_LINQ;

public class Program
{
    public static void Main(string[] args)
    {
        string[] sandwiches = { "ham and cheese", "salami with mayo",
                                "turkey and swiss", "chicken cutlet" };

        var sandwichesOnRye =
            from sandwich in sandwiches
            select sandwich + " on rye";

        foreach (var sandwich in sandwichesOnRye)
        {
            Console.WriteLine(sandwich);
            Console.ReadLine();
        }
    }
}