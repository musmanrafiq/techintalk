namespace FeaturesExplore.Records
{
    public record Employee
    {
        public string FullName { get; set; }
        public Employee(string name) => (FullName) = (name);
    }
}
