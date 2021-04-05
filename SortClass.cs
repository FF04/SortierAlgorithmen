#define visualize

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


        public List<int> Quicksort(List<int> liste)
        {
#warning effizienter machen

            if (liste.Count <= 1) return liste;

            int pivotelement = liste[0]; // das pivotelement ist ein zufälliges element der liste, daher kann man auch das erste nehmen

            List<int> kleiner = new List<int>();
            List<int> größer = new List<int>();
            List<int> same = new List<int>();

            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i] < pivotelement)
                {
                    kleiner.Add(liste[i]);

                }
                else if (liste[i] > pivotelement)
                {
                    größer.Add(liste[i]);

                }
                else
                {
                    same.Add(liste[i]);
                }
            }



            liste = new List<int>();
            liste = Quicksort(kleiner);
            liste.AddRange(same);
            liste.AddRange(Quicksort(größer));


       
            return liste;



        }

        public void Bubblesort(List<int> liste)
        {
#if ausgabe
            Console.WriteLine($"\nSorting ({string.Join(", ", liste)}) with {nameof(Bubblesort)}");
#endif
            while (!Check(liste))
            {
                for (int i = 0; i < liste.Count - 1; i++)
                {
                    if (liste[i] > liste[i + 1])
                    {
                        int zwischenspeicher = liste[i];

                        liste[i] = liste[i + 1];
                        liste[i + 1] = zwischenspeicher;

                    }

                }
#if visualize
                Visualize(liste);
#endif
            }
            #if ausgabe
            Console.WriteLine($"Sorted!\n{string.Join(", ", liste)}");
#endif
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
            List<int> list2 = new List<int>(liste); // erzeugung einer identischen liste




            // die schleife geht so lange bis die reinfolge richtig ist
            while (!Check(list2))
            {
                // zuweisung der derzeitigen Random-Variable, da an der selben stelle in der anderen liste der inhalt gelöscht werden muss

                // da nach jeder wiederholung "liste" leer ist, wird sie auf den stand von list2 gebracht (dies macht keinen unterschied da Bogosort sowieso Random íst)
                liste = new List<int>(list2);
                list2.Clear();


                // Alle positionen werden neu angeordnet
                while (liste.Count > 0)
                {
                    int currentRND = rnd.Next(0, liste.Count);

                    list2.Add(liste[currentRND]);
                    liste.RemoveAt(currentRND);
                }

            }


            Console.WriteLine($"Sorted!\n{string.Join(", ", list2)}");

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



        public void Visualize(List<int> list)
        {
            Console.WriteLine();
            foreach (var item in list)
            {

                for (int i = 0; i < item; i++)
                {
                    Console.Write(item);
                }
                Console.WriteLine();

            }

        }





















































        //https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-9.php
        public void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }
            
        }

        public int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }








        //http://csharpexamples.com/c-quick-sort-algorithm-implementation/
        #region Internet


        public void sort(ref int[] array)
        {
            quicksort(0, array.Length - 1, ref array);
        }
        private void quicksort(int links, int rechts, ref int[] daten)
        {
            if (links < rechts)
            {
                int teiler = teile(links, rechts, ref daten);
                quicksort(links, teiler - 1, ref daten);
                quicksort(teiler + 1, rechts, ref daten);
            }
        }
        private int teile(int links, int rechts, ref int[] daten)
        {
            int i = links;
            //Starte mit j links vom Pivotelement
            int j = rechts - 1;
            int pivot = daten[rechts];

            do
            {
                //Suche von links ein Element, welches größer als das Pivotelement ist
                while (daten[i] <= pivot && i < rechts)
                    i += 1;

                //Suche von rechts ein Element, welches kleiner als das Pivotelement ist
                while (daten[j] >= pivot && j > links)
                    j -= 1;

                if (i < j)
                {
                    int z = daten[i];
                    daten[i] = daten[j];
                    // tausche daten[i] mit daten[j]
                    daten[j] = z;
                }

            } while (i < j);
            //solange i an j nicht vorbeigelaufen ist 

            // Tausche Pivotelement (daten[rechts]) mit neuer endgültiger Position (daten[i])

            if (daten[i] > pivot)
            {
                int z = daten[i];
                daten[i] = daten[rechts];
                // tausche daten[i] mit daten[rechts]
                daten[rechts] = z;
            }
            return i; // gib die Position des Pivotelements zurück
        }
        #endregion
    }
}
