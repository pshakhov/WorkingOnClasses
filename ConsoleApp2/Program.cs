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
            float f_res = 0, f_cur = 0;

            Console.WriteLine("Введите значение сопротивления: ");

            try
            {
                f_res = Convert.ToSingle(Console.ReadLine());
            }

            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message);
                Console.WriteLine("\n");
            }

            finally
            {
                Console.WriteLine("Введите значение силы тока: ");

                try
                {
                    f_cur = Convert.ToSingle(Console.ReadLine());
                }
                catch (FormatException ex2)
                {
                    Console.WriteLine(ex2.Message);
                    Console.WriteLine("\n");
                }

                finally
                {
                    float resistence = f_res;
                    float current = f_cur;

                    Voltage vol0 = new Voltage(resistence, current);
                    Console.WriteLine("Значение напряжения: ");
                    Console.WriteLine(vol0.VoltageCalculation());
                    Voltage vol1 = new Voltage(1, 6);
                    Voltage vol2 = new Voltage(7, 2);
                    Voltage vol3 = new Voltage(3, 8);
                    Voltage vol4 = new Voltage(9, 4);
                    Voltage vol5 = new Voltage(5, 10);

                    List<Voltage> newList = new List<Voltage>();

                    newList.Add(vol0);
                    newList.Add(vol1);
                    newList.Add(vol2);
                    newList.Add(vol3);
                    newList.Add(vol4);
                    newList.Add(vol5);

                    var ordered = newList
                        .OrderBy(u => u.resistence).ThenBy(u => u.current);

                    // Random rnd = new Random();

                    foreach (Voltage i in ordered)
                    {
                        // i.id = rnd.Next(0,newList.Count);

                        Convert.ToString(i.resistence);
                        Convert.ToString(i.current);
                        Console.WriteLine("\n Resistence = " + i.resistence + "; Current = " + i.current + /* "; id:" + i.id + */ "\n");
                    }

                    Console.ReadKey();
                }
            }
        }
    }
}
