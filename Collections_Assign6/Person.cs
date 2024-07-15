using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_and_Dictionaries6
{
    internal class Person
    {
        public string Firstname {  get; set; }
        public string Lastname { get; set; }
        public Person(string firstName, string lastName)
        {
            Firstname = firstName;
            Lastname = lastName;
        }
    }
}
