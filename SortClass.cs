

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortierAlgorithmen
{
    class SortClass
    {




        public bool visualize; // wenn true werden alle algorithmen visualisiert

        public SortClass()
        {        
            Console.CursorVisible = false; // mach curser unsichtbar - wird hier zugewiesen da dies die methode ist die alles visualisiert
        }

        /// <summary>
        /// liste soll immer sortiert werden mit dem datentyp intt
        /// </summary>


     


        public List<int> Quicksort(List<int> liste) // konnte ich nicht visualisieren, da die methode rekursiv ist, und somit die einzelnen bestandteile an verschiedenen "orten" sind
        {

            if (liste.Count <= 1) return liste;

            int pivotelement = liste[0]; // das pivotelement ist ein zufälliges element der liste, daher kann man auch das erste nehmen

            List<int> kleiner = new List<int>();
            List<int> größer = new List<int>();
            List<int> same = new List<int>(); // same = alle die gleich groß wie das privot sind (mindestens immer 1 (privot))

            //Die ganze liste wird durchgelaufen
            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i] < pivotelement) //falls das derzeitige Element < als das privot ist, wird es der dementsprechenden Liste hinzugefügt (kleiner)
                    kleiner.Add(liste[i]);
                else if (liste[i] > pivotelement)
                    größer.Add(liste[i]);
                else
                    same.Add(liste[i]);

            }



            liste = new List<int>();
            liste = Quicksort(kleiner); // Die originale Liste wird jetzt zu der kleineren "hälfte" der liste, welche davor durch Rekursionen geholt wird
            liste.AddRange(same); 
            liste.AddRange(Quicksort(größer));



            return liste;



        }






      
        public void Bubblesort(List<int> liste)
        {

            while (!Check(liste)) // checken ob die liste sortiert ist
            {
                // jedes element durchghen
                for (int i = 0; i < liste.Count - 1; i++)
                {
                    //Wenn das derzeitige element kleiner als das nächste ist sollen beide platz tauschen
                    if (liste[i] > liste[i + 1])
                    {


                        int zwischenspeicher = liste[i];

                        liste[i] = liste[i + 1];
                        liste[i + 1] = zwischenspeicher;

                    }

                                                                                                                                                                       if (visualize)
                                                                                                                                                                           Visualize(liste, i);

                }

            }

        }



        public void Insertionsort(List<int> liste)
        {


            while (!Check(liste)) // checken ob die liste sortiert ist (Bei diesem Sortierverfahren reicht es, wenn einmal die for-schleife durchrennt)
            {
                for (int i = 0; i < liste.Count - 1; i++)
                {

                    //Wie bei Bubblesort werden hier jeweils 2 elemente verglichen, falls das derzeitige elemet kleiner als das nächste ist, tauschen beide platz und man schaut die 2 elemente davor an
                    if (liste[i] > liste[i + 1])
                    {
                        int zwischenspeicher = liste[i];

                        liste[i] = liste[i + 1];
                        liste[i + 1] = zwischenspeicher;




                                                                                                                                                            if (visualize)
                                                                                                                                                                Visualize(liste, i);


                        if (i != 0)
                            i -= 2; // änderung der laufvariable, weil die vorigen zahlen jetzt auch verglichen werden




                    }



                }

            }

            Console.WriteLine($"Sorted!");

        }




        // Sorting Bogosort
        public void Bogosort(List<int> liste)
        {
            // Überprüfung ob Liste schon gesortet ist
            if (Check(liste))
            {
                Console.WriteLine("List already sorted");
                return;
            }


            Random rnd = new Random();
            List<int> list2 = new List<int>(liste); // erzeugung einer identischen liste in welcher die zufälligen werte der originalen liste gespeichert werden




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

                if (visualize)
                    Visualize(list2, null);
            }


            Console.WriteLine($"Sorted!");

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
                int lastitem = -1; // zur überprüfung ob das derzeitig überprüfte item <= als das derzeitige ist
                foreach (var item in liste) // alle elemente werden überprüft
                {

                    if (lastitem > item)
                        return false;

                    lastitem = item;
                }

                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Fehler bei der Überprüfung der Liste");
            }

            return false;
        }












        public int cooldown = 500; //zeit in ms bis der nächste schritt des algorithmus angezeigt wird
        /// <summary>
        /// Zur Grafischen darstellung der Algroithmen
        /// </summary>
        /// <param name="list">die liste welche dargestellt werden soll</param>
        /// <param name="active_line">die zeile(n) welche rot markiert werden sollen</param>
        public void Visualize(List<int> list, int? active_line)
        {
            int line = active_line ?? -10; // -10 da negative zahlen nie dran kommen
            //  Console.WriteLine("\n");
            Console.SetCursorPosition(0, 0);
            for (int i2 = 0; i2 < list.Count; i2++)
            {

                if (i2 == line || i2 == line + 1)
                    Console.ForegroundColor = ConsoleColor.Red;


                for (int i = 0; i < list[i2]; i++)
                {
                    Console.Write(list[i2]);
                }

                while (Console.CursorLeft + 10 < Console.WindowWidth)
                {
                    Console.Write("     ");
                }
                Console.WriteLine("");
                Console.ResetColor();
            }



            Console.WriteLine();
            Point cooldownpoint = new Point(Console.CursorLeft, Console.CursorTop); // zur festhaltung in welcher Zeile der Cooldown ausgegeben wird um dies zu überschreiben
            Console.WriteLine(cooldown + " cooldown");

            Stopwatch sw = new Stopwatch();
            sw.Start();

            // Timeout - da kein thread.Sleep verwendet wurde, kann ich in dieser zeitspanne beliebig die zeit ändern
            while (sw.ElapsedMilliseconds < cooldown)
            {
                if (Console.KeyAvailable)
                {

                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.UpArrow:
                            cooldown += 50;
                            break;
                        case ConsoleKey.DownArrow:

                            cooldown -= 50;
                            if (cooldown <= 0)
                                cooldown = 1;
                            break;
                        default:
                            break;
                    }
                    Console.SetCursorPosition(cooldownpoint.X, cooldownpoint.Y);
                    Console.WriteLine(cooldown + " cooldown");
                }

            }
            sw.Stop();



        }




























        //https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-9.php
        #region internet

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

        #endregion





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
