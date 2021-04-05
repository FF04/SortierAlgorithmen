﻿//FF - SortierAlgorithmen
using System;
using System.Collections.Generic;

namespace SortierAlgorithmen
{
    class Program
    {
  
        
        static void Main(string[] args)
        {
            SortClass sortClass = new SortClass();

            var normalList = new List<int>() { 8,5,4,3,9,1,7,2,6};
            var list = RandomList(50,0,50);


           // sortClass.Bogosort(list);

            Console.WriteLine();

            sortClass.Bubblesort(list);




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
