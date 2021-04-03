//FF - SortierAlgorithmen
using System;
using System.Collections.Generic;

namespace SortierAlgorithmen
{
    class Program
    {
        /// <summary>
        /// Enum der datentypen welche bei RandomList() erlaubt sind
        /// </summary>
        public enum allowedDatatypes
        {
            Typeint,
            Typedouble,
            Typedecimal
        }

        
        static void Main(string[] args)
        {
            SortClass sortClass = new SortClass();



            Console.ReadLine();
        }

        /// <summary>
        /// Generiert eine Zufällige Liste
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Length">Die Länge der Liste - falls null wird automatisch 10 genommen</param>
        /// <param name="minValue">Der kleinste erlaubte wert - falls null wird automatisch 0 genommen</param>
        /// <param name="Maxvalue">Der größte erlaubte wert - falls null wird automatisch 100 genommen</param>
        /// <param name="allowduplicates">Gibt an ob zahlen 2x vorkommen dürfen - falls null wird true genommen</param>
        /// <param name="datatype">Gibt an aus welchen Datentypen die Liste bestehen soll - falls null wird int genommen</param>
        /// <param name="generateArray">gibt an ob liste oder array genommen werden soll, falls false wird liste genommen - falls null wird array genommen</param>
        /// <returns></returns>
        public static List<T> RandomList<T>(int? Length, int? minValue, int? Maxvalue, bool? allowduplicates,allowedDatatypes? datatype , bool? generateArray)
        {



            return null;

        }
    }
}
