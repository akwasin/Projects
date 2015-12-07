using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7
{
    class Runsten
    {
        public string name;
        public int weight;
        public int age;

        private int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                var runstenValue = value >= 100 && value <= 1000;
                if (runstenValue)
                    weight = value;
                else
                {
                    throw new Exception("Your runsten doesnt weight enough");
                }
            }
        }

        private string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        private int Age
        {
            get
            {
                return age;
            }

            set
            {
                var ageValue = value >= 400 && value <= 1200;
                if (ageValue)
                    age = value;
                else
                {
                    throw new Exception("Your runsten isnt old enough");
                }
            }
        }

        public Runsten() // kontruktorn, två typer
        {
            Weight = 400;
            Age = 500;
            Name = "Rune";
        }

        public Runsten(int weight, int age = 400, string name = "Runnesten")
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"Weight: {Weight}, Name: {Name}, Age: {Age}";
        }
    }

}
