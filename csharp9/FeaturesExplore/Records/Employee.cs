using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeaturesExplore.Records
{
    public record Employee
    {
        public string FullName { get; set; }
        public Employee(string name) => (FullName) = (name);
    }
}
