using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class Human : FamilyMembers, IAge, ISalary,IFamily
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMaried { get; set; }
        public string Family { get; set; }
        public int Salary { get; set; }
        decimal ISalary.Salary { get ; set ; }

    }
}
