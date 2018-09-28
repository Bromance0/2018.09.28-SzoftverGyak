using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Bejegyzes
    {
        public string szerzo;
        public string tartalom;
        public int likeok = 0;
        public DateTime letrejott = DateTime.Now;
        public DateTime szerkesztve = DateTime.Now;

        
        public string Szerzo
        {
            get
            {
                return this.szerzo;
            }
        }

        public string Tartalom
        {
            get
            {
                return this.tartalom;
            }
            set
            {
                if (this.tartalom != value)
                {
                    this.szerkesztve = DateTime.Now;
                }
            }
        }

        public int Likeok
        {
            get
            {
                return this.likeok;
            }
        }

        public DateTime Letrejott
        {
            get
            {
                return this.letrejott;
            }
        }

        public DateTime Szerkesztve
        {
            get
            {
                return this.szerkesztve;
            }
        }
        
        public void Like()
        {
            likeok++;
        }

        public void Kiir()
        {
            if (szerkesztve == letrejott)
            {
                Console.WriteLine("Szerzo" + szerzo + "Likeok" + likeok + "letrjeott" + letrejott + "\nTartalom" + tartalom);
            }
            Console.WriteLine("Szerzo" + szerzo + "Likeok" + likeok + "letrjeott" + letrejott +"\nSzerkesztve" + szerkesztve+"\nTartalom" + tartalom);
        }
    }
}
