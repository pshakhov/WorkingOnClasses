using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingOnClasses
{
    [forValue]
    abstract class Value// абстрактный класс "Значение"
    {
            // абстрактный метод для калькуляции напряжения
            public abstract float VoltageCalculation();
            
            // public abstract float PowerCalcuation();
            public float resistence { get; set; } // задаем переменную и ее параметры для сопротивления
            public float current { get; set; } // задаем переменную и ее параметры для силы тока
            public int id { get; set; }
    }
}
