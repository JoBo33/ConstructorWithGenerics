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
            this.a = Convert.ToDouble(a);
        }
        public Calculate(T a, T b) : this(a)
        {
            this.b = Convert.ToDouble(b);
        }


        public double GetA() => a;
        
        public void SetA(T a)
        {
            this.a = Convert.ToDouble(a);
        }

        public double GetB() => b;
        
        public void SetB(T b) 
        {
            this.b = Convert.ToDouble(b);    
        }

        public double Add() => a + b;
        public double Sub() => a - b;
        public double Multiply() => a * b;
        public double Divide() => a / b;

    }
}
