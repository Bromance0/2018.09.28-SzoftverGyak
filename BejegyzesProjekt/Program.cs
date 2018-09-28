using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BejegyzesProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            var bejegyzesLista = new List<string> { "Kecskét megenni", "Kecskét megint megenni" };

            Console.WriteLine("Adja meg hány bejegyzést akar: ");
            int darabszam = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < darabszam; i++)
            {
                Console.WriteLine("Adja meg a bejegyzést");
                string bejegyzes = Convert.ToString(Console.ReadLine());
                bejegyzesLista.Add(bejegyzes);
            }

        }


    }
}
