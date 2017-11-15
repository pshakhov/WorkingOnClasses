using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingOnClasses
{
    [forVoltage]
    class Voltage : Value, IPowerable
    {
        // public float Resistence { get; set; }
        // public float Current { get; set; }

        public Voltage(float resistence, float current)
        {
            this.resistence = resistence;
            this.current = current;
            id = id;
        }

        public void PowerCalculation()
        {
            Console.WriteLine();
        }

        // переопределение получения напряжения
        public override float VoltageCalculation() => resistence * current;

    }
}

