using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä02
{
    class CD
    {
        /// <summary>
        /// Luodaan lista
        /// </summary>
        private List<Biisit> cd;

        /// <summary>
        /// Alustetaan lista
        /// </summary>
        public CD()
        {
            cd = new List<Biisit>();
        } 

        /// <summary>
        /// Lisätään kappale listaan
        /// </summary>
        /// <param name="biisit"></param>
        public void AddBiisi(Biisit biisit)
        {
            cd.Add(biisit);
        }
    
        /// <summary>
        /// Tulostaa listan, eli cd-levyn
        /// </summary>
        public void PrintLevyt()
        {
            foreach (Biisit biisit in cd)
            {
                Console.WriteLine(biisit.ToString());
            }
        }
    }
}
