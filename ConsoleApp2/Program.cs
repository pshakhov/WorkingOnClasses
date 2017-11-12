using System;
using System.Collections.Generic;
using static System.Random;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingOnClasses;

namespace WorkingOnClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение сопротивления: ");
            float resistence = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите значение силы тока: ");
            float current = Convert.ToSingle(Console.ReadLine());

            Voltage vol0 = new Voltage(resistence, current);
            Console.WriteLine("Значение напряжения: ");
            Console.WriteLine(vol0.VoltageCalculation());

            Voltage vol1 = new Voltage(1, 6);
            Voltage vol2 = new Voltage(7, 2);
            Voltage vol3 = new Voltage(3, 8);
            Voltage vol4 = new Voltage(9, 4);
            Voltage vol5 = new Voltage(5, 10);

            List <Voltage> newList = new List <Voltage>();

            newList.Add(vol0);
            newList.Add(vol1);
            newList.Add(vol2);
            newList.Add(vol3);
            newList.Add(vol4);
            newList.Add(vol5);

            var ordered = newList
                .OrderBy(u => u.Resistence).ThenBy(u => u.Current);

            Random rnd = new Random();

            foreach (Voltage i in ordered)
            {
                // i.id = rnd.Next(0,newList.Count);

                Convert.ToString(i.Resistence);
                Convert.ToString(i.Current);
                Console.WriteLine("\n Resistence = " + i.Resistence + "; Current = " + i.Current + /* "; id:" + i.id + */ "\n");
            }

            Console.ReadKey();
        }
    }
}
