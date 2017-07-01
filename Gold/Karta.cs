using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gold
{
   public class Karta
    {
        public int wartosc;
        public int kolor;
        public PictureBox picture;
        public bool odkryte;

      public void Utworz(int i, int j)
        {
            wartosc = (j);
            kolor = (i);
        }
    }
}
