namespace FeaturesExplore.AnOverview
{
    public class GenericIntro
    {

        // Records
        public record Animal
        {
            public string Name { get; set; }
        }

        // pattern matching improvements
        public bool Patterns(int number)
        {
            int? a = null;
            bool result = number is > 0;
            result = number is >= 0 and <= 10;
            result = number is (> 0 and < 10) or (>= 100 and <= 200);
            if (a is not null)
            {

            }
            return result;
        }

        public void NewExpression()
        {
            // new expression
            GenericIntro intro = new();
        }

        // init only properies
        public class Employee
        {
            public string Address { get; init; }
            public string Name { get; init; }
        }

        // with expression
        public void WithExpression()
        {
            Animal a = new();
            Animal b = a with { };
        }
    }
}
