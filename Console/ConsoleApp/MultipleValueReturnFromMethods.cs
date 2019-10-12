namespace ConsoleApp
{
    public class MultipleValueReturnFromMethods
    {
        public static (int, string) GetPosition()
        {
            return (1, "Usman");
        }
        public static (int postion, string name) GetOtherPosition()
        {
            return (1, "Usman");
        }
    }
}
