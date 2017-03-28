using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Aborag
{
    public class Oblasti
    {
        int[,,] vojacioblasti;
        int[] podminky;
        int[] kamen;


        public Oblasti()
        {
            vojacioblasti = new int[9,9,2];
            podminky = new int[9];
            kamen = new int[9];

            for (int i = 0; i < 9; i++)
            {
                podminky[i] = 1; //zmenit
            }
            for (int i = 0; i < 9; i++)
            {
                kamen[i] = 20;
            }


        }

        public void pridejjednotky(int oblast, int typ, int pocet, int hrac)
        {
            vojacioblasti[oblast, typ, hrac] += pocet;
        }

        public void odeberjednotky(int oblast, int typ, int pocet, int hrac)
        {
            vojacioblasti[oblast, typ, hrac] -= pocet;
        }

        public void vytezkamen(int oblast)
        {
            kamen[oblast]--;
        }

        public int ziskejpocet(int oblast, int typ, int hrac)
        {
            return vojacioblasti[oblast, typ, hrac];
        }

        public int ziskejpodminky(int oblast)
        {
            return podminky[oblast];
        }


        public void Update(int x/*x-ová souradnice mysi*/, int y/*y-ová souradnice mysi*/, bool klik /*informace o kliknuti*/)
        {
            //zjisteni pozice mysi pri kliknuti
            //zobrazení nabídky moznosti
        }


        public void Draw(SpriteBatch batch)
        {
            //vykresleni pozadi
            //vykresleni nabidky moznosti
        }


    }
}
