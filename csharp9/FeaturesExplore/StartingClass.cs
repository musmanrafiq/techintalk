using FeaturesExplore.Records;
using System;

var e = new Employee("Usman", "IBD");
var e2 = e with { Address = "IBD" };
Employee e3 = new("", "");
Console.WriteLine(e == e2);
