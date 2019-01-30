using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Surname { get; set; }
        public static bool operator==(Person obj1, Person obj2)
        {
            return obj1.Age == obj2.Age;
        }
        public static bool operator!=(Person obj1,Person obj2)
        {
            return obj1.Age != obj2.Age;
        }
    }
}
