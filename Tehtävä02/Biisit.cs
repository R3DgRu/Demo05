using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä02
{
    class Biisit
    {
        /// <summary>
        /// Biisiluokka jossa määritetään mitä muuttujia niille annetaan
        /// </summary>
        public string SongName { get; set; }
        public string Length { get; set; }

        public override string ToString()
        {
            return "- " + SongName + ", " + Length;
        }
    }
}
