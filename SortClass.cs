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
        /// liste soll immer sortiert werden mit dem datentyp intt
        /// </summary>
      

        public void Quicksort(List<int> liste)
        {


        }

        public void Bubblesort(List<int> liste)
        {
            Console.WriteLine($"\nSorting ({string.Join(", ", liste)}) with {nameof(Bubblesort)}");
            while (!Check(liste))
            {
                for (int i = 0; i < liste.Count-1; i++)
                {
                    if (liste[i]>liste[i+1])
                    {
                        int zwischenspeicher = liste[i];

                        liste[i] = liste[i + 1];
                        liste[i + 1] = zwischenspeicher;

                    }
                }
            }

            Console.WriteLine($"Sorted!\n{string.Join(", ", liste)}");

        }

        public void Intersionsort(List<int> liste)
        {

        }




        // Sorting Bogosort
        public void Bogosort(List<int> liste)
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
            List<T> list2 = new List<T>(liste); // erzeugung einer identischen liste


   

            // die schleife geht so lange bis die reinfolge richtig ist
            while (!Check(list2))
            {
                // zuweisung der derzeitigen Random-Variable, da an der selben stelle in der anderen liste der inhalt gelöscht werden muss
            
                // da nach jeder wiederholung "liste" leer ist, wird sie auf den stand von list2 gebracht (dies macht keinen unterschied da Bogosort sowieso Random íst)
                liste = new List<T>(list2);
                list2.Clear();

     
                // Alle positionen werden neu angeordnet
                while (liste.Count > 0)
                {
                    int currentRND = rnd.Next(0, liste.Count);

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
        public bool Check(List<int> liste)
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
