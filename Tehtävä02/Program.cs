using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan kappaleet
            Biisit kappale1 = new Biisit
            {
                SongName = "Before Time",
                Length = "2:18"
            };

            Biisit kappale2 = new Biisit
            {
                SongName = "Creation of Earth",
                Length = "5:45"
            };

            Biisit kappale3 = new Biisit
            {
                SongName = "Sun",
                Length = "4:08"
            };

            Biisit kappale4 = new Biisit
            {
                SongName = "Cry",
                Length = "4:06"
            };

            Biisit kappale5 = new Biisit
            {
                SongName = "Our Destiny",
                Length = "3:52"
            };

            Biisit kappale6 = new Biisit
            {
                SongName = "New Life",
                Length = "4:46"
            };

            Biisit kappale7 = new Biisit
            {
                SongName = "Final Frontier",
                Length = "4:48"
            };

            Biisit kappale8 = new Biisit
            {
                SongName = "Starchild",
                Length = "3:20"
            };

            Biisit kappale9 = new Biisit
            {
                SongName = "Cassandra",
                Length = "3:06"
            };

            Biisit kappale10 = new Biisit
            {
                SongName = "Colors of Love",
                Length = "6:29"
            };

            Biisit kappale11 = new Biisit
            {
                SongName = "Always Mine",
                Length = "3:21"
            };

            Biisit kappale12 = new Biisit
            {
                SongName = "Dragonland",
                Length = "5:11"
            };

            Biisit kappale13 = new Biisit
            {
                SongName = "Fearless",
                Length = "3:59"
            };

            Biisit kappale14 = new Biisit
            {
                SongName = "Empire of Angels",
                Length = "5:14"
            };

            Biisit kappale15 = new Biisit
            {
                SongName = "Two Hearts",
                Length = "4:16"
            };

            Biisit kappale16 = new Biisit
            {
                SongName = "In Paradisum",
                Length = "5:30"
            };

            // Tulostaa albumin esittäjän ja hinnan
            Console.WriteLine("CD data: \n- Artist: Thomas Bergersen \n- Price: 25,90 \n- Songs: \n");

            // Lisätään cd
            CD albumi1 = new CD();

            // Lisätään kappaleet cd:lle
            albumi1.AddBiisi(kappale1);
            albumi1.AddBiisi(kappale2);
            albumi1.AddBiisi(kappale3);
            albumi1.AddBiisi(kappale4);
            albumi1.AddBiisi(kappale5);
            albumi1.AddBiisi(kappale6);
            albumi1.AddBiisi(kappale7);
            albumi1.AddBiisi(kappale8);
            albumi1.AddBiisi(kappale9);
            albumi1.AddBiisi(kappale10);
            albumi1.AddBiisi(kappale11);
            albumi1.AddBiisi(kappale12);
            albumi1.AddBiisi(kappale13);
            albumi1.AddBiisi(kappale14);
            albumi1.AddBiisi(kappale15);
            albumi1.AddBiisi(kappale16);

            // Tulostaa tallennetut cd-levyt
            albumi1.PrintLevyt();

        }
    }
}
