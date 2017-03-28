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
    class Souboj
    {
        int pocethrac0;
        int pocethrac1;
        int podminky;
        Oblasti oblasti;
        

        public Souboj(int oblast)
        {
            oblasti = Game1.oblasti;
            podminky = oblasti.ziskejpodminky(oblast);
            for (int i = 0; i < 9; i++)
            {
                pocethrac0 = oblasti.ziskejpocet(/*oblast*/ oblast, /*typ*/ i, /*hrac*/ 0);
                pocethrac1 = oblasti.ziskejpocet(/*oblast*/ oblast, /*typ*/ i, /*hrac*/ 1);
            }

            //usporadani jednotek v poli
        }

        public void Update(int oblast)
        {
            //zjistovani označení jednotek, poslani
            //výpocet boje(utok, umirani)
            //vyhra, konecny vysledky


        }


        public void Draw(SpriteBatch batach,int oblast)
        {
            //vykresleni pozadi
            //vykresleni jednotek

        }

    }
}
