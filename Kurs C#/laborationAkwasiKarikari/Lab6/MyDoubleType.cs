using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class MyDoubleType
    {
        public double DoubleValue { get; set; }
        public MyDoubleType(double doubleValue)
        {
            DoubleValue = doubleValue;
        }
        public static MyDoubleType operator +(MyDoubleType myDouble, double tal)
        {
            var result = new MyDoubleType(myDouble.DoubleValue + tal);
            return result;
        }
        public static MyDoubleType operator -(MyDoubleType myDouble, double tal)
        {
            var result = new MyDoubleType(myDouble.DoubleValue - tal);
            return result;
        }
        public static MyDoubleType operator /(MyDoubleType myDouble, double tal)
        {
            var result = new MyDoubleType(myDouble.DoubleValue / tal);
            if (tal == 0)
            {
                throw new Exception("Can't be divided by zero");
            }
            else
                return result;
        }
        public static MyDoubleType operator *(MyDoubleType myDouble, double tal)
        {
            var result = new MyDoubleType(myDouble.DoubleValue * tal);
            return result;
        }
        public static MyDoubleType operator +(MyDoubleType tal, MyDoubleType myDouble)
        {
            var result = new MyDoubleType(tal.DoubleValue + myDouble.DoubleValue);
            return result;
        }
        public static MyDoubleType operator -(MyDoubleType tal, MyDoubleType myDouble)
        {
            var result = new MyDoubleType(tal.DoubleValue - myDouble.DoubleValue);
            return result;
        }
        public static MyDoubleType operator /(MyDoubleType tal, MyDoubleType myDouble)
        {
            var result = new MyDoubleType(tal.DoubleValue / myDouble.DoubleValue);
            if (tal.DoubleValue != 0)
            {
                return result;
            }
            else
                throw new Exception("Can't be divided by zero");
        }
        public static MyDoubleType operator *(MyDoubleType tal, MyDoubleType myDouble)
        {
            var result = new MyDoubleType(tal.DoubleValue * myDouble.DoubleValue);
            return result;
        }
        public static bool operator ==(MyDoubleType myDouble, MyDoubleType tal)
        {
            var result = (myDouble.DoubleValue == tal.DoubleValue);
            return result;
        }
        public static bool operator !=(MyDoubleType myDouble, MyDoubleType tal)
        {
            var result = (myDouble.DoubleValue != tal.DoubleValue);
            return result;
        }
        public static bool operator <(MyDoubleType myDouble, MyDoubleType stuff)
        {
            var result = (myDouble.DoubleValue < stuff.DoubleValue);
            return result;
        }
        public static bool operator >(MyDoubleType myDouble, MyDoubleType myDouble2)
        {
            var result = (myDouble.DoubleValue > myDouble2.DoubleValue);
            return result;
        }
        public static bool operator <=(MyDoubleType myDouble, MyDoubleType tal)
        {
            var result = (myDouble.DoubleValue <= tal.DoubleValue);
            return result;
        }
        public static bool operator >=(MyDoubleType myDouble, MyDoubleType tal)
        {
            var result = (myDouble.DoubleValue >= tal.DoubleValue);
            return result;
        }
        public override string ToString()
        {
            return string.Format($"{DoubleValue}");
        }
    }
}
