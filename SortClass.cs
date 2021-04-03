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
        /// liste soll immer sortiert werden und kann ein array/liste sein mit dem datentyp int/double/decimal
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

        public void Bogosort<T>(List<T> liste)
        {

        }
        


        /// <summary>
        /// Schaut nach ob die mitgegebene liste sortiert is
        /// </summary>
        /// <typeparam name="T">int, decimal oder double</typeparam>
        /// <param name="liste"> die liste welche überprüft werden soll</param>
        /// <returns>
        /// true = die liste ist sortiert
        /// false = die liste ist nicht richtig sortiert
        /// </returns>   // IEnumerable da man nicht ändert
        public bool Check<T>(IEnumerable<T> liste)
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
