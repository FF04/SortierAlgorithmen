using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortierAlgorithmen
{
    class SortClass
    {

        /// <summary>
        /// liste soll immer sortiert werden mit dem datentyp int/double/decimal
        /// </summary>
      

        public void Quicksort<T>(List<T> liste)
        {


        }

        public void Bubblesort<T>(List<T> liste)
        {

        }

        public void Intersionsort<T>(List<T> liste)
        {

        }

        // Sorting Bogosort
        public void Bogosort<T>(List<T> liste)
        {
            // Ausgabe was gerade gesortet wird
            Console.WriteLine($"\nSorting ({string.Join(", ", liste)}) with {nameof(Bogosort)}");
            
            // Überprüfung ob Liste schon gesortet ist
            if (Check(liste))
            {
                Console.WriteLine("List already sorted");
                return;
            }

            
            Random rnd = new Random();
            List<T> list2 = liste; // erzeugung einer identischen liste
      

       

         // die schleife geht so lange bis die reinfolge richtig ist
            while (!Check(list2))
            {
                // zuweisung der derzeitigen Random-Variable, da an der selben stelle in der anderen liste der inhalt gelöscht werden muss
                int currentRND = rnd.Next(0, liste.Count);

                // da nach jeder wiederholung "liste" leer ist, wird sie auf den stand von list2 gebracht (dies macht keinen unterschied da Bogosort sowieso Random íst)
                liste = list2;
                list2.Clear(); 

                // Alle positionen werden neu angeordnet
                while (liste.Count > 0)
                {
                    list2.Add(liste[currentRND]);
                    liste.RemoveAt(currentRND);
                }

            }


            Console.WriteLine($"Sorted!\n{string.Join(", ",list2)}");

        }
        


        /// <summary>
        /// Schaut nach ob die mitgegebene liste sortiert is
        /// </summary>
        /// <typeparam name="T">int, decimal oder double</typeparam>
        /// <param name="liste"> die liste welche überprüft werden soll</param>
        /// <returns>
        /// true = die liste ist sortiert
        /// false = die liste ist nicht richtig sortiert
        /// </returns>
        public bool Check<T>(List<T> liste)
        {
            try
            {
                decimal? lastitem = null;
                foreach (var item in liste)
                {
                    if (lastitem != null && item != null)
                        if (lastitem > Convert.ToDecimal(item))
                        {
                            return false;
                        }
                    lastitem = Convert.ToDecimal(item);
                }

                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Fehler bei der Überprüfung der Liste");
            }
            return false;
        }



    }
}
