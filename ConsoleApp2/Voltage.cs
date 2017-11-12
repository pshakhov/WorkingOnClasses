using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingOnClasses
{
    class Voltage : Value, IPowerable
    {
        // public float Resistence { get; set; }
        // public float Current { get; set; }

        public Voltage(float Resistence, float Current)
        {
            this.Resistence = Resistence;
            this.Current = Current;
            id = id;
        }

        public void PowerCalculation()
        {
            Console.WriteLine();
        }

        // переопределение получения напряжения
        public override float VoltageCalculation() => Resistence * Current;
    }
}

