//FF - SortierAlgorithmen
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortierAlgorithmen
{
    class Program
    {
        public const int range = 30;
        public const int min = 1;
        public const int max = 30;
        
        static void Main(string[] args)
        {
        
            Console.CursorVisible=false; // macht den curser unsichtbar, (geht bei .net core nicht(?))
        
            SortClass sortClass = new SortClass(); // object der sortclass erstellen
  
            var list = RandomList(range, min,max); // erzeugung einer zufälligen liste


           


            Stopwatch sw = new Stopwatch(); // erzeugung der Stopwatch um die zeit zu mässen

            bool start = false;


            Console.WriteLine("Press Enter to start Bubblesort");
            while (!start)
            {
                if(Console.KeyAvailable)
                switch (Console.ReadKey(true).Key)
                {

                    case ConsoleKey.Enter:
                        start = true;
                        break;
                    case ConsoleKey.Spacebar:
                        sortClass.visualize = !sortClass.visualize;
                            Console.SetCursorPosition(0, 0);
                            if(sortClass.visualize)
                                Console.WriteLine("Press Enter to start Bubblesort!");
                            else
                                Console.WriteLine("Press Enter to start Bubblesort ");
                            break;
                    default:
                        break;
                }
            }
            Console.WriteLine("starting Bubblesort...");
            sw.Start();
            sortClass.Bubblesort(list);
            Console.WriteLine("Bubblesort " + sw.ElapsedMilliseconds);







            Console.WriteLine("Press enter to start Intersionsort");
            Console.ReadLine();

            list = RandomList(range, min, max);

            Console.WriteLine("starting Intersiosort...");
            sw.Restart();
            sortClass.Insertionsort(list);
            Console.WriteLine("Intersionsort "+sw.ElapsedMilliseconds);






            Console.WriteLine("Press enter to start Quicksort");
            Console.ReadLine();

            list = RandomList(range, min, max);

            Console.WriteLine("starting Quicksort...");
            sw.Restart();
            sortClass.Quicksort(list);
            // Console.WriteLine(string.Join(", ", sortClass.Quicksort(list)));
            Console.WriteLine("Quicksort Selfmade " + sw.ElapsedMilliseconds);





            Console.WriteLine("Press enter to start Bogosort");
            Console.ReadLine();

            list = RandomList(range, min, max);

            Console.WriteLine("starting Bogosort...");
            sw.Restart();
            sortClass.Bogosort(list);
            // Console.WriteLine(string.Join(", ", sortClass.Quicksort(list)));
            Console.WriteLine("Bogosort " + sw.ElapsedMilliseconds);



            list = RandomList(range, min, max);



            var a = list.ToArray();


            //  // hat probleme mit duplicates
            //  sw.Restart();
            //  sortClass.Quick_Sort(a, 0, a.Length - 1);          
            //  Console.WriteLine(string.Join(", ", a));
            //  Console.WriteLine("Quicksort aus dem Internet " + sw.ElapsedMilliseconds);


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
