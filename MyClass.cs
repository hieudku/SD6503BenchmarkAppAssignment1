using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD6503BenchmarkAppAssignment1
{
    public class MyClass
    {
        // Properties
        public int StaffId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public decimal AnnualSalary { get; set; }

        // Convert class object into string to display data
        public override string ToString()
        {
            return $"{StaffId} {Name} {DateOfBirth:dd/MM/yyyy} {Email} {AnnualSalary:N0}";
        }
    }
}
