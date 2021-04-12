//FF - SortierAlgorithmen
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortierAlgorithmen
{
    class Program
    {

        public const int ARRAYLENGTH = 20;
        public const int MINVALUES = 1;
        public const int MAXVALUES = 30;


        static void Main(string[] args)
        {
          
      
       

            SortClass sortClass = new SortClass(); // object der sortclass erstellen

            var list = RandomList(ARRAYLENGTH, MINVALUES, MAXVALUES); // erzeugung einer zufälligen liste





            Stopwatch sw = new Stopwatch(); // erzeugung der Stopwatch um die zeit zu mässen


            #region start
            Console.WriteLine("*Sortier-Algorithmen*");
            Console.WriteLine("Alle Angaben in ms\n");
            Console.WriteLine("Press Enter to start Bubblesort");


            bool start = false;
            while (!start)
            {
                if (Console.KeyAvailable)
                    switch (Console.ReadKey(true).Key)
                    {

                        case ConsoleKey.Enter:
                            start = true;
                            if (MAXVALUES > 50 || ARRAYLENGTH > 50)
                                sortClass.visualize = false;
                            break;
                        case ConsoleKey.Spacebar:
                            sortClass.visualize = !sortClass.visualize;
                            Console.SetCursorPosition(0, 3);
                            if (sortClass.visualize)
                                Console.WriteLine("Press Enter to start Bubblesort!");
                            else
                                Console.WriteLine("Press Enter to start Bubblesort ");
                            break;
                        default:
                            break;
                    }
            }
            #endregion



            /////////////////////////// BUBBLESORT ////////////////////////////////////

            Console.WriteLine("starting Bubblesort...");
            sw.Start();
            sortClass.Bubblesort(list);
            Console.WriteLine("Bubblesort " + sw.ElapsedMilliseconds);


            /////////////////////// INSERTIONSORT /////////////////////////////////
         
            Console.WriteLine("Press enter to start Insertionsort");
            Console.ReadLine();
            Console.Clear();

            list = RandomList(ARRAYLENGTH, MINVALUES, MAXVALUES);

            Console.WriteLine("starting Intersiosort...");
            sw.Restart();
            sortClass.Insertionsort(list);
            Console.WriteLine("Insertionsort " + sw.ElapsedMilliseconds);


            ////////////////////////// QUICKSORT //////////////////////////////

            Console.WriteLine("Press enter to start Quicksort");
            Console.ReadLine();
            Console.Clear();

            list = RandomList(ARRAYLENGTH, MINVALUES, MAXVALUES);

            Console.WriteLine("starting Quicksort...");
            sw.Restart();
            sortClass.Quicksort(list);
            // Console.WriteLine(string.Join(", ", sortClass.Quicksort(list)));
            Console.WriteLine("Quicksort " + sw.ElapsedMilliseconds);


            /////////////////////// BOGOSORT ///////////////////////////////////

            Console.WriteLine("Press enter to start Bogosort");
            Console.ReadLine();
            Console.Clear();

            list = RandomList(ARRAYLENGTH, MINVALUES, MAXVALUES);

            Console.WriteLine("starting Bogosort...");
            sw.Restart();
            sortClass.Bogosort(list);
            // Console.WriteLine(string.Join(", ", sortClass.Quicksort(list)));
            Console.WriteLine("Bogosort " + sw.ElapsedMilliseconds);





            list = RandomList(ARRAYLENGTH, MINVALUES, MAXVALUES);

            var arraylist = list.ToArray();


            //  // hat probleme mit duplicates
            //  sw.Restart();
            //  sortClass.Quick_Sort(arraylist, 0, arraylist.Length - 1);          
            //  Console.WriteLine(string.Join(", ", arraylist));
            //  Console.WriteLine("Quicksort aus dem Internet " + sw.ElapsedMilliseconds);


            //sw.Restart();
            //sortClass.sort(ref arraylist);
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


            for (int i = 0; i < (Length ?? 10); i++)
            {
                list.Add(rnd.Next(minValue ?? 0, maxValue ?? 100));
            }

            return list;

        }
    }
}
