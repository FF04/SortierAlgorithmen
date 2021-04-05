//FF - SortierAlgorithmen
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortierAlgorithmen
{
    class Program
    {
  
        
        static void Main(string[] args)
        {
            SortClass sortClass = new SortClass();

            var normalList = new List<int>() { 8,3,4,9,1,6,5,2 };
            var list = RandomList(30,0,99);


           // sortClass.Bogosort(list);

            Console.WriteLine();

            Stopwatch sw = new Stopwatch();





            sw.Start();
            //sortClass.Bubblesort(list);
            //Console.WriteLine("Bubblesort "+sw.ElapsedMilliseconds);



            var a = list.ToArray();


            sw.Restart();
          //  sortClass.Quicksort(normalList);
          Console.WriteLine(string.Join(", ",sortClass.Quicksort(list)));
            Console.WriteLine("Quicksort Selfmade " + sw.ElapsedMilliseconds);


            // hat probleme mit duplicates
            sw.Restart();
            sortClass.Quick_Sort(a, 0, a.Length - 1);          
            Console.WriteLine(string.Join(", ", a));
            Console.WriteLine("Quicksort aus dem Internet " + sw.ElapsedMilliseconds);



            //sw.Restart();
            //sortClass.sort(ref a);
            //Console.WriteLine("Quicksort aus dem Internet " + sw.ElapsedMilliseconds);



            Console.ReadLine();
        }


        /// <summary>
        /// Generiert eine Zufällige Liste
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Length">Die Länge der Liste - falls null wird automatisch 10 genommen</param>
        /// <param name="minValue">Der kleinste erlaubte wert - falls null wird automatisch 0 genommen</param>
        /// <param name="maxValue">Der größte erlaubte wert - falls null wird automatisch 100 genommen</param>
        /// <param name="datatype">Gibt an aus welchen Datentypen die Liste bestehen soll - falls null wird int genommen</param>
        /// <returns></returns>
        public static List<int> RandomList(int? Length, int? minValue, int? maxValue)
        {

            Random rnd = new Random();

        
                    var list = new List<int>();
              

                    for (int i = 0; i < (Length??10); i++)
                    {
                        list.Add(rnd.Next(minValue??0,maxValue??100));
                    }

                    return list;
             
        }
    }
}
