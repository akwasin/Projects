using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Har_ligger_Main(string[] args)
        {
            // testa person
            Person akwasi = new Person();
            akwasi.SetName("Akwasi");
            //Console.WriteLine(Akwasi.GetName());

            // testa circel
            Point newPoint = new Point();
            newPoint.SetX(10);
            newPoint.SetY(20);

            Circle nyCircel = new Circle();

            nyCircel.SetCenter(newPoint);
            nyCircel.SetDiameter(20);
            //Console.WriteLine(nyCircel.GetCircumference());
            //Console.WriteLine(nyCircel.GetCenter());
            //Console.WriteLine(Akwasi.GetHashCode());

            nyCircel.SetCenter(null);
            Console.WriteLine(nyCircel);

            System.Threading.Thread.Sleep(8000);
        }
    }


    public class Person
    {
        private string name;
        public void SetName(string name)
        {
            if (name != null)
            {
                this.name = name;
            }
            else
            {
                this.name = "Default Name";
            }
        }
        public string GetName() { return name; }

    }

    /*public class Circle
    {
        private double diameter;

        public void SetDiameter(double diameter) { this.diameter = diameter; }

        public double GetDiameter() { return diameter; }

        public double GetCircumference() { return 3.14 * diameter; }
    }*/

    public class Point
    {
        private int y;
        private int x;

        public void SetX(int x) { this.x = x; }
        public int GetX() { return x; }

        public void SetY(int y) { this.y = y; }

        public int GetY() { return y; }
    }

    public class Circle
    {
        private double diameter;
        private Point center;

        public void SetDiameter(double diameter) { if (diameter > 0) { this.diameter = diameter; } }

        public double GetDiameter() { return diameter; }

        public double GetCircumference() { return Math.PI * diameter; }

        public void SetCenter(Point p)
        {
            if (p != null)
            {
                center = p;
            }
            else
            {
                Point tempP = new Point();
                tempP.SetX(10); // default värde
                tempP.SetY(10); // default värde
                center = tempP;
            }
        }
        public override string ToString()
        {
            return diameter.ToString();
        }
        public Point GetCenter() { return center; }
    }

    public class Wheel
    {
        private int amountWheel;

    }
    public class Car
    {
        private string brandName;
        private string modelName;
        private string fuelType;
        private int maxTank;
        private int consumption;
        private int wheel;

        // 
        public void SetBrandName(string brandName) { this.brandName = brandName; }
        public string GetBrandname() { return brandName; }
        public void SetModelName(string modelName) { this.modelName = modelName; }
        public string GetModelName() { return modelName; }
        public void SetFuelType(string fuelType) { this.fuelType = fuelType; }
        public string GetFuelType() { return fuelType; }
        public void SetMaxTank(int maxTank) { this.maxTank = maxTank; }
        public int GetMaxTank() { return maxTank; }

        public void SetConsumption(int consumption) { this.consumption = consumption; }
        public int GetConsumption() { return consumption; }

        public double GetRange() { return (maxTank / consumption) * 10; }

        public void SetWheel(int wheel) {
            if (wheel < 2) {
                this.wheel = wheel;
            }
            else
            {
                this.wheel = 4;
            }
            
        }

        public int GetWheel() { return wheel; }

    }
}