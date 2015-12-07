using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_4
{

    public class Person
    {
        private string name;
        private int age;
        private Address adress;

        public string GetName() { return name; }
        public void Setname(string name) { this.name = name; }

        public int GetAge() { return age; }
        public void SetAge(int age) { this.age = age; }
    }
}
