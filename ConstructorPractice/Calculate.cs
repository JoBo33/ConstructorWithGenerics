using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorPractice
{
    public class Calculate<T>
    {
        double a;
        double b;

        public Calculate()
        {
        }
        public Calculate(T a) :this()
        {
            if (!double.TryParse(a.ToString(), out this.a))
            {
                Console.WriteLine("Wrong constructor input. Now set to default.");
                this.a = 0;
            }
        }

        public Calculate(T a, T b) : this(a)
        {
            if (!double.TryParse(b.ToString(), out this.b))
            {
                Console.WriteLine("Wrong constructor input. Now set to default.");
                this.b = 0;
            }
        }


        public double GetA() => a;
        
        public void SetA(T a)
        {
            if (!double.TryParse(a.ToString(), out this.a))
            {
                Console.WriteLine("Wrong input. Now set to default.");
                this.a = 0;
            }
        }

        public double GetB() => b;
        
        public void SetB(T b) 
        {
            if (!double.TryParse(b.ToString(), out this.b))
            {
                Console.WriteLine("Wrong input. Now set to default.");
                this.b = 0;
            }
        }

        public double Add() => a + b;
        public double Sub() => a - b;
        public double Multiply() => a * b;
        public double Divide() => a / b;

    }
}
