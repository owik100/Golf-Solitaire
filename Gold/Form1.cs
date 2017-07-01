using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Gold
{
    public partial class Form1 : Form
    {
        Karta[] karta = new Karta[52];

        Random rnd = new Random();
        PictureBox[] pic = new PictureBox[52];

        int x = 40;
        int timeCounter = 0;
        bool[] wygrana = new bool[8];
        bool juzPrzegrales = false;
        bool przegrales = false;
        bool kartySkonczone = false;
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i <= 51; i++)
            {
                karta[i] = new Karta();
                pic[i] = new PictureBox();
            }

            int b = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    karta[b].Utworz(i, j);
                    b++;
                }


            }





            #region Przypisanie referencji obrazka do obiektu w tablicy obrazkow

            pic[0] = pictureBox0;
            pic[1] = pictureBox1;
            pic[2] = pictureBox2;
            pic[3] = pictureBox3;
            pic[4] = pictureBox4;
            pic[5] = pictureBox5;
            pic[6] = pictureBox6;
            pic[7] = pictureBox7;
            pic[8] = pictureBox8;
            pic[9] = pictureBox9;
            pic[10] = pictureBox10;
            pic[11] = pictureBox11;
            pic[12] = pictureBox12;
            pic[13] = pictureBox13;
            pic[14] = pictureBox14;
            pic[15] = pictureBox15;
            pic[16] = pictureBox16;
            pic[17] = pictureBox17;
            pic[18] = pictureBox18;
            pic[19] = pictureBox19;
            pic[20] = pictureBox20;
            pic[21] = pictureBox21;
            pic[22] = pictureBox22;
            pic[23] = pictureBox23;
            pic[24] = pictureBox24;
            pic[25] = pictureBox25;
            pic[26] = pictureBox26;
            pic[27] = pictureBox27;
            pic[28] = pictureBox28;
            pic[29] = pictureBox29;
            pic[30] = pictureBox30;
            pic[31] = pictureBox31;
            pic[32] = pictureBox32;
            pic[33] = pictureBox33;
            pic[34] = pictureBox34;
            pic[35] = pictureBox35;
            pic[36] = pictureBox36;
            pic[37] = pictureBox37;
            pic[38] = pictureBox38;
            pic[39] = pictureBox39;
            pic[51] = pictureBoxTarget;
            
            #endregion

            new Random().Shuffle(karta);

            #region Ustawienie obrazka kart

            for (int i = 0; i <= 51; i++)
            {
                switch (karta[i].wartosc)
                {
                    case 1: switch (karta[i].kolor)
                        {
                            case 0: pic[i].Image = Properties.Resources.ace_of_clubs; break;
                            case 1: pic[i].Image = Properties.Resources.ace_of_diamonds; break;
                            case 2: pic[i].Image = Properties.Resources.ace_of_hearts; break;
                            case 3: pic[i].Image = Properties.Resources.ace_of_spades; break;
                        } break;
                    case 2:
                        switch (karta[i].kolor)
                        {
                            case 0: pic[i].Image = Properties.Resources._2_of_clubs; break;
                            case 1: pic[i].Image = Properties.Resources._2_of_diamonds; break;
                            case 2: pic[i].Image = Properties.Resources._2_of_hearts; break;
                            case 3: pic[i].Image = Properties.Resources._2_of_spades; break;
                        }
                        break;
                    case 3:
                        switch (karta[i].kolor)
                        {
                            case 0: pic[i].Image = Properties.Resources._3_of_clubs; break;
                            case 1: pic[i].Image = Properties.Resources._3_of_diamonds; break;
                            case 2: pic[i].Image = Properties.Resources._3_of_hearts; break;
                            case 3: pic[i].Image = Properties.Resources._3_of_spades; break;
                        }
                        break;
                    case 4:
                        switch (karta[i].kolor)
                        {
                            case 0: pic[i].Image = Properties.Resources._4_of_clubs; break;
                            case 1: pic[i].Image = Properties.Resources._4_of_diamonds; break;
                            case 2: pic[i].Image = Properties.Resources._4_of_hearts; break;
                            case 3: pic[i].Image = Properties.Resources._4_of_spades; break;
                        }
                        break;
                    case 5:
                        switch (karta[i].kolor)
                        {
                            case 0: pic[i].Image = Properties.Resources._5_of_clubs; break;
                            case 1: pic[i].Image = Properties.Resources._5_of_diamonds; break;
                            case 2: pic[i].Image = Properties.Resources._5_of_hearts; break;
                            case 3: pic[i].Image = Properties.Resources._5_of_spades; break;
                        }
                        break;
                    case 6:
                        switch (karta[i].kolor)
                        {
                            case 0: pic[i].Image = Properties.Resources._6_of_clubs; break;
                            case 1: pic[i].Image = Properties.Resources._6_of_diamonds; break;
                            case 2: pic[i].Image = Properties.Resources._6_of_hearts; break;
                            case 3: pic[i].Image = Properties.Resources._6_of_spades; break;
                        }
                        break;
                    case 7:
                        switch (karta[i].kolor)
                        {
                            case 0: pic[i].Image = Properties.Resources._7_of_clubs; break;
                            case 1: pic[i].Image = Properties.Resources._7_of_diamonds; break;
                            case 2: pic[i].Image = Properties.Resources._7_of_hearts; break;
                            case 3: pic[i].Image = Properties.Resources._7_of_spades; break;
                        }
                        break;
                    case 8:
                        switch (karta[i].kolor)
                        {
                            case 0: pic[i].Image = Properties.Resources._8_of_clubs; break;
                            case 1: pic[i].Image = Properties.Resources._8_of_diamonds; break;
                            case 2: pic[i].Image = Properties.Resources._8_of_hearts; break;
                            case 3: pic[i].Image = Properties.Resources._8_of_spades; break;
                        }
                        break;
                    case 9:
                        switch (karta[i].kolor)
                        {
                            case 0: pic[i].Image = Properties.Resources._9_of_clubs; break;
                            case 1: pic[i].Image = Properties.Resources._9_of_diamonds; break;
                            case 2: pic[i].Image = Properties.Resources._9_of_hearts; break;
                            case 3: pic[i].Image = Properties.Resources._9_of_spades; break;
                        }
                        break;
                    case 10:
                        switch (karta[i].kolor)
                        {
                            case 0: pic[i].Image = Properties.Resources._10_of_clubs; break;
                            case 1: pic[i].Image = Properties.Resources._10_of_diamonds; break;
                            case 2: pic[i].Image = Properties.Resources._10_of_hearts; break;
                            case 3: pic[i].Image = Properties.Resources._10_of_spades; break;
                        }
                        break;
                    case 11:
                        switch (karta[i].kolor)
                        {
                            case 0: pic[i].Image = Properties.Resources.jack_of_clubs2; break;
                            case 1: pic[i].Image = Properties.Resources.jack_of_diamonds2; break;
                            case 2: pic[i].Image = Properties.Resources.jack_of_hearts2; break;
                            case 3: pic[i].Image = Properties.Resources.jack_of_spades2; break;
                        }
                        break;
                    case 12:
                        switch (karta[i].kolor)
                        {
                            case 0: pic[i].Image = Properties.Resources.queen_of_clubs2; break;
                            case 1: pic[i].Image = Properties.Resources.queen_of_diamonds2; break;
                            case 2: pic[i].Image = Properties.Resources.queen_of_hearts2; break;
                            case 3: pic[i].Image = Properties.Resources.queen_of_spades2; break;
                        }
                        break;
                    case 13:
                        switch (karta[i].kolor)
                        {
                            case 0: pic[i].Image = Properties.Resources.king_of_clubs2; break;
                            case 1: pic[i].Image = Properties.Resources.king_of_diamonds2; break;
                            case 2: pic[i].Image = Properties.Resources.king_of_hearts2; break;
                            case 3: pic[i].Image = Properties.Resources.king_of_spades2; break;
                        }
                        break;

                }
            }

            #endregion


            for(int i=0;i<=39;i++)
            {
                karta[i].picture = pic[i];
            }

            for(int i =0; i<=31;i++)
            {
                karta[i].odkryte = false;
            }

            for(int j=32; j<=51;j++)
            {
                karta[j].odkryte = true;
            }



            karta[51].picture = pictureBoxTarget;

        }
      

    #region Klikniecia Kart
    private void pictureBox0_Click(object sender, EventArgs e)
        {
            if (karta[0].odkryte && (karta[0].wartosc == karta[51].wartosc - 1 || karta[0].wartosc == karta[51].wartosc + 1 || (karta[0].wartosc == 1 && karta[51].wartosc == 13) || (karta[0].wartosc == 13 && karta[51].wartosc == 1)))
            {

                    karta[51].picture = karta[0].picture;
                    karta[51].wartosc = karta[0].wartosc;
                    pictureBoxTarget.Image = pictureBox0.Image;
                    karta[0].picture.Enabled = false;
                    pictureBox0.Visible = false;
                    pictureBox0.Enabled = false;
                    KoniecGry();
                    Debug.Print("warunek spelniony" + "karta o wartosci " + karta[0].wartosc + " oraz o kolorze " + karta[0].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc "+ karta[0].wartosc +" oraz o kolorze " + karta[0].kolor);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (karta[1].odkryte && (karta[1].wartosc == karta[51].wartosc - 1 || karta[1].wartosc == karta[51].wartosc + 1 || (karta[1].wartosc == 1 && karta[51].wartosc == 13) || (karta[1].wartosc == 13 && karta[51].wartosc == 1)))
            {

                    karta[51].picture = karta[1].picture;
                    karta[51].wartosc = karta[1].wartosc;
                    pictureBoxTarget.Image = pictureBox1.Image;
                    karta[1].picture.Enabled = false;
                    pictureBox1.Visible = false;
                    pictureBox1.Enabled = false;
                    KoniecGry();
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[1].wartosc + " oraz o kolorze " + karta[1].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[1].wartosc + " oraz o kolorze " + karta[1].kolor);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (karta[2].odkryte && (karta[2].wartosc == karta[51].wartosc - 1 || karta[2].wartosc == karta[51].wartosc + 1 || (karta[2].wartosc == 1 && karta[51].wartosc == 13) || (karta[2].wartosc == 13 && karta[51].wartosc == 1)))
            {

                    karta[51].picture = karta[2].picture;
                    karta[51].wartosc = karta[2].wartosc;
                    pictureBoxTarget.Image = pictureBox2.Image;
                    karta[2].picture.Enabled = false;
                    pictureBox2.Visible = false;
                    pictureBox2.Enabled = false;
                KoniecGry();
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[2].wartosc + " oraz o kolorze " + karta[2].kolor);

            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[2].wartosc + " oraz o kolorze " + karta[2].kolor);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (karta[3].odkryte && ( karta[3].wartosc == karta[51].wartosc - 1 || karta[3].wartosc == karta[51].wartosc + 1 || (karta[3].wartosc == 1 && karta[51].wartosc == 13) || (karta[3].wartosc == 13 && karta[51].wartosc == 1)))
            {

                    karta[51].picture = karta[3].picture;
                    karta[51].wartosc = karta[3].wartosc;
                    pictureBoxTarget.Image = pictureBox3.Image;
                    karta[3].picture.Enabled = false;
                    pictureBox3.Visible = false;
                    pictureBox3.Enabled = false;
                KoniecGry();
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[3].wartosc + " oraz o kolorze " + karta[3].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[3].wartosc + " oraz o kolorze " + karta[3].kolor);
            }
        }

       
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (karta[4].odkryte && ( karta[4].wartosc == karta[51].wartosc - 1 || karta[4].wartosc == karta[51].wartosc + 1 || (karta[4].wartosc == 1 && karta[51].wartosc == 13) || (karta[4].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[4].picture;
                karta[51].wartosc = karta[4].wartosc;
                pictureBoxTarget.Image = pictureBox4.Image;
                karta[4].picture.Enabled = false;
                pictureBox4.Visible = false;
                pictureBox4.Enabled = false;
                KoniecGry();
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[4].wartosc + " oraz o kolorze " + karta[4].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[4].wartosc + " oraz o kolorze " + karta[4].kolor);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (karta[5].odkryte && ( karta[5].wartosc == karta[51].wartosc - 1 || karta[5].wartosc == karta[51].wartosc + 1 || (karta[5].wartosc == 1 && karta[51].wartosc == 13) || (karta[5].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[5].picture;
                karta[51].wartosc = karta[5].wartosc;
                pictureBoxTarget.Image = pictureBox5.Image;
                karta[5].picture.Enabled = false;
                pictureBox5.Visible = false;
                pictureBox5.Enabled = false;
                KoniecGry();
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[5].wartosc + " oraz o kolorze " + karta[5].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[5].wartosc + " oraz o kolorze " + karta[5].kolor);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (karta[6].odkryte && (karta[6].wartosc == karta[51].wartosc - 1 || karta[6].wartosc == karta[51].wartosc + 1 || (karta[6].wartosc == 1 && karta[51].wartosc == 13) || (karta[6].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[6].picture;
                karta[51].wartosc = karta[6].wartosc;
                pictureBoxTarget.Image = pictureBox6.Image;
                karta[6].picture.Enabled = false;
                pictureBox6.Visible = false;
                pictureBox6.Enabled = false;
                KoniecGry();
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[6].wartosc + " oraz o kolorze " + karta[6].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[6].wartosc + " oraz o kolorze " + karta[6].kolor);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (karta[7].odkryte && (karta[7].wartosc == karta[51].wartosc - 1 || karta[7].wartosc == karta[51].wartosc + 1 || (karta[7].wartosc == 1 && karta[51].wartosc == 13) || (karta[7].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[7].picture;
                karta[51].wartosc = karta[7].wartosc;
                pictureBoxTarget.Image = pictureBox7.Image;
                karta[7].picture.Enabled = false;
                pictureBox7.Visible = false;
                pictureBox7.Enabled = false;
                KoniecGry();
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[7].wartosc + " oraz o kolorze " + karta[7].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[7].wartosc + " oraz o kolorze " + karta[7].kolor);
            }
        }

       

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (karta[8].odkryte && (karta[8].wartosc == karta[51].wartosc - 1 || karta[8].wartosc == karta[51].wartosc + 1 || (karta[8].wartosc == 1 && karta[51].wartosc == 13) || (karta[8].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[8].picture;
                karta[51].wartosc = karta[8].wartosc;
                pictureBoxTarget.Image = pictureBox8.Image;
                karta[8].picture.Enabled = false;
                pictureBox8.Visible = false;
                pictureBox8.Enabled = false;
                karta[0].odkryte = true;
                KoniecGry();
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[8].wartosc + " oraz o kolorze " + karta[8].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[8].wartosc + " oraz o kolorze " + karta[8].kolor);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (karta[9].odkryte && (karta[9].wartosc == karta[51].wartosc - 1 || karta[9].wartosc == karta[51].wartosc + 1 || (karta[9].wartosc == 1 && karta[51].wartosc == 13) || (karta[9].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[9].picture;
                karta[51].wartosc = karta[9].wartosc;
                pictureBoxTarget.Image = pictureBox9.Image;
                karta[9].picture.Enabled = false;
                pictureBox9.Visible = false;
                pictureBox9.Enabled = false;
                karta[1].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[9].wartosc + " oraz o kolorze " + karta[9].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[9].wartosc + " oraz o kolorze " + karta[9].kolor);
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (karta[10].odkryte && (karta[10].wartosc == karta[51].wartosc - 1 || karta[10].wartosc == karta[51].wartosc + 1 || (karta[10].wartosc == 1 && karta[51].wartosc == 13) || (karta[10].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[10].picture;
                karta[51].wartosc = karta[10].wartosc;
                pictureBoxTarget.Image = pictureBox10.Image;
                karta[10].picture.Enabled = false;
                pictureBox10.Visible = false;
                pictureBox10.Enabled = false;
                karta[2].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[10].wartosc + " oraz o kolorze " + karta[10].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[10].wartosc + " oraz o kolorze " + karta[10].kolor);
            }
        
    }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (karta[11].odkryte && (karta[11].wartosc == karta[51].wartosc - 1 || karta[11].wartosc == karta[51].wartosc + 1 || (karta[11].wartosc == 1 && karta[51].wartosc == 13) || (karta[11].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[11].picture;
                karta[51].wartosc = karta[11].wartosc;
                pictureBoxTarget.Image = pictureBox11.Image;
                karta[11].picture.Enabled = false;
                pictureBox11.Visible = false;
                pictureBox11.Enabled = false;
                karta[3].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[11].wartosc + " oraz o kolorze " + karta[11].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[11].wartosc + " oraz o kolorze " + karta[11].kolor);
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (karta[12].odkryte && (karta[12].wartosc == karta[51].wartosc - 1 || karta[12].wartosc == karta[51].wartosc + 1 || (karta[12].wartosc == 1 && karta[51].wartosc == 13) || (karta[12].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[12].picture;
                karta[51].wartosc = karta[12].wartosc;
                pictureBoxTarget.Image = pictureBox12.Image;
                karta[12].picture.Enabled = false;
                pictureBox12.Visible = false;
                pictureBox12.Enabled = false;
                karta[4].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[12].wartosc + " oraz o kolorze " + karta[12].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[12].wartosc + " oraz o kolorze " + karta[12].kolor);
            }
        }

        

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (karta[13].odkryte && (karta[13].wartosc == karta[51].wartosc - 1 || karta[13].wartosc == karta[51].wartosc + 1 || (karta[13].wartosc == 1 && karta[51].wartosc == 13) || (karta[13].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[13].picture;
                karta[51].wartosc = karta[13].wartosc;
                pictureBoxTarget.Image = pictureBox13.Image;
                karta[13].picture.Enabled = false;
                pictureBox13.Visible = false;
                pictureBox13.Enabled = false;
                karta[5].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[13].wartosc + " oraz o kolorze " + karta[13].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[13].wartosc + " oraz o kolorze " + karta[13].kolor);
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (karta[14].odkryte && (karta[14].wartosc == karta[51].wartosc - 1 || karta[14].wartosc == karta[51].wartosc + 1 || (karta[14].wartosc == 1 && karta[51].wartosc == 13) || (karta[14].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[14].picture;
                karta[51].wartosc = karta[14].wartosc;
                pictureBoxTarget.Image = pictureBox14.Image;
                karta[14].picture.Enabled = false;
                pictureBox14.Visible = false;
                pictureBox14.Enabled = false;
                karta[6].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[14].wartosc + " oraz o kolorze " + karta[14].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[14].wartosc + " oraz o kolorze " + karta[14].kolor);
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (karta[15].odkryte && (karta[15].wartosc == karta[51].wartosc - 1 || karta[15].wartosc == karta[51].wartosc + 1 || (karta[15].wartosc == 1 && karta[51].wartosc == 13) || (karta[15].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[15].picture;
                karta[51].wartosc = karta[15].wartosc;
                pictureBoxTarget.Image = pictureBox15.Image;
                karta[15].picture.Enabled = false;
                pictureBox15.Visible = false;
                pictureBox15.Enabled = false;
                karta[7].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[15].wartosc + " oraz o kolorze " + karta[15].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[15].wartosc + " oraz o kolorze " + karta[15].kolor);
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (karta[16].odkryte && (karta[16].wartosc == karta[51].wartosc - 1 || karta[16].wartosc == karta[51].wartosc + 1 || (karta[16].wartosc == 1 && karta[51].wartosc == 13) || (karta[16].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[16].picture;
                karta[51].wartosc = karta[16].wartosc;
                pictureBoxTarget.Image = pictureBox16.Image;
                karta[16].picture.Enabled = false;
                pictureBox16.Visible = false;
                pictureBox16.Enabled = false;
                karta[8].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[16].wartosc + " oraz o kolorze " + karta[16].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[16].wartosc + " oraz o kolorze " + karta[16].kolor);
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (karta[17].odkryte && (karta[17].wartosc == karta[51].wartosc - 1 || karta[17].wartosc == karta[51].wartosc + 1 || (karta[17].wartosc == 1 && karta[51].wartosc == 13) || (karta[17].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[17].picture;
                karta[51].wartosc = karta[17].wartosc;
                pictureBoxTarget.Image = pictureBox17.Image;
                karta[17].picture.Enabled = false;
                pictureBox17.Visible = false;
                pictureBox17.Enabled = false;
                karta[9].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[17].wartosc + " oraz o kolorze " + karta[17].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[17].wartosc + " oraz o kolorze " + karta[17].kolor);
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (karta[18].odkryte && (karta[18].wartosc == karta[51].wartosc - 1 || karta[18].wartosc == karta[51].wartosc + 1 || (karta[18].wartosc == 1 && karta[51].wartosc == 13) || (karta[18].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[18].picture;
                karta[51].wartosc = karta[18].wartosc;
                pictureBoxTarget.Image = pictureBox18.Image;
                karta[18].picture.Enabled = false;
                pictureBox18.Visible = false;
                pictureBox18.Enabled = false;
                karta[10].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[18].wartosc + " oraz o kolorze " + karta[18].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[18].wartosc + " oraz o kolorze " + karta[18].kolor);
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (karta[19].odkryte && (karta[19].wartosc == karta[51].wartosc - 1 || karta[19].wartosc == karta[51].wartosc + 1 || (karta[19].wartosc == 1 && karta[51].wartosc == 13) || (karta[19].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[19].picture;
                karta[51].wartosc = karta[19].wartosc;
                pictureBoxTarget.Image = pictureBox19.Image;
                karta[19].picture.Enabled = false;
                pictureBox19.Visible = false;
                pictureBox19.Enabled = false;
                karta[11].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[19].wartosc + " oraz o kolorze " + karta[19].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[19].wartosc + " oraz o kolorze " + karta[19].kolor);
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (karta[20].odkryte && (karta[20].wartosc == karta[51].wartosc - 1 || karta[20].wartosc == karta[51].wartosc + 1 || (karta[20].wartosc == 1 && karta[51].wartosc == 13) || (karta[20].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[20].picture;
                karta[51].wartosc = karta[20].wartosc;
                pictureBoxTarget.Image = pictureBox20.Image;
                karta[20].picture.Enabled = false;
                pictureBox20.Visible = false;
                pictureBox20.Enabled = false;
                karta[12].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[20].wartosc + " oraz o kolorze " + karta[20].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[20].wartosc + " oraz o kolorze " + karta[20].kolor);
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (karta[21].odkryte && (karta[21].wartosc == karta[51].wartosc - 1 || karta[21].wartosc == karta[51].wartosc + 1 || (karta[21].wartosc == 1 && karta[51].wartosc == 13) || (karta[21].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[21].picture;
                karta[51].wartosc = karta[21].wartosc;
                pictureBoxTarget.Image = pictureBox21.Image;
                karta[21].picture.Enabled = false;
                pictureBox21.Visible = false;
                pictureBox21.Enabled = false;
                karta[13].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[21].wartosc + " oraz o kolorze " + karta[21].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[21].wartosc + " oraz o kolorze " + karta[21].kolor);
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (karta[22].odkryte && (karta[22].wartosc == karta[51].wartosc - 1 || karta[22].wartosc == karta[51].wartosc + 1 || (karta[22].wartosc == 1 && karta[51].wartosc == 13) || (karta[22].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[22].picture;
                karta[51].wartosc = karta[22].wartosc;
                pictureBoxTarget.Image = pictureBox22.Image;
                karta[22].picture.Enabled = false;
                pictureBox22.Visible = false;
                pictureBox22.Enabled = false;
                karta[14].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[22].wartosc + " oraz o kolorze " + karta[22].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[22].wartosc + " oraz o kolorze " + karta[22].kolor);
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (karta[23].odkryte && (karta[23].wartosc == karta[51].wartosc - 1 || karta[23].wartosc == karta[51].wartosc + 1 || (karta[23].wartosc == 1 && karta[51].wartosc == 13) || (karta[23].wartosc == 13 && karta[51].wartosc == 1)))
            {
                karta[51].picture = karta[23].picture;
                karta[51].wartosc = karta[23].wartosc;
                pictureBoxTarget.Image = pictureBox23.Image;
                karta[23].picture.Enabled = false;
                pictureBox23.Visible = false;
                pictureBox23.Enabled = false;
                karta[15].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[23].wartosc + " oraz o kolorze " + karta[23].kolor);
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[23].wartosc + " oraz o kolorze " + karta[23].kolor);
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (karta[24].odkryte && (karta[24].wartosc == karta[51].wartosc - 1 || karta[24].wartosc == karta[51].wartosc + 1 || (karta[24].wartosc == 1 && karta[51].wartosc == 13) || (karta[24].wartosc == 13 && karta[51].wartosc == 1)))
            {

              
                
                    karta[51].picture = karta[24].picture;
                    karta[51].wartosc = karta[24].wartosc;
                    pictureBoxTarget.Image = pictureBox24.Image;
                    karta[24].picture.Enabled = false;
                    pictureBox24.Visible = false;
                    pictureBox24.Enabled = false;
                    karta[16].odkryte = true;
                    Debug.Print("warunek spelniony" + "karta o wartosci " + karta[24].wartosc + " oraz o kolorze " + karta[24].kolor);
                
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[24].wartosc + " oraz o kolorze " + karta[24].kolor);
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            if (karta[25].odkryte && (karta[25].wartosc == karta[51].wartosc - 1 || karta[25].wartosc == karta[51].wartosc + 1 || (karta[25].wartosc == 1 && karta[51].wartosc == 13) || (karta[25].wartosc == 13 && karta[51].wartosc == 1)))
            {
               
                


                    karta[51].picture = karta[25].picture;
                    karta[51].wartosc = karta[25].wartosc;
                    pictureBoxTarget.Image = pictureBox25.Image;
                    karta[25].picture.Enabled = false;
                    pictureBox25.Visible = false;
                    pictureBox25.Enabled = false;
                    karta[17].odkryte = true;
                    Debug.Print("warunek spelniony" + "karta o wartosci " + karta[25].wartosc + " oraz o kolorze " + karta[25].kolor);
      
            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[25].wartosc + " oraz o kolorze " + karta[25].kolor);
            }
        }

        

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            if (karta[26].odkryte && (karta[26].wartosc == karta[51].wartosc - 1 || karta[26].wartosc == karta[51].wartosc + 1 || (karta[26].wartosc == 1 && karta[51].wartosc == 13) || (karta[26].wartosc == 13 && karta[51].wartosc == 1)))
            {



                karta[51].picture = karta[26].picture;
                karta[51].wartosc = karta[26].wartosc;
                pictureBoxTarget.Image = pictureBox26.Image;
                karta[26].picture.Enabled = false;
                pictureBox26.Visible = false;
                pictureBox26.Enabled = false;
                karta[18].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[26].wartosc + " oraz o kolorze " + karta[26].kolor);

            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[26].wartosc + " oraz o kolorze " + karta[26].kolor);
            }
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            if (karta[27].odkryte && (karta[27].wartosc == karta[51].wartosc - 1 || karta[27].wartosc == karta[51].wartosc + 1 || (karta[27].wartosc == 1 && karta[51].wartosc == 13) || (karta[27].wartosc == 13 && karta[51].wartosc == 1)))
            {



                karta[51].picture = karta[27].picture;
                karta[51].wartosc = karta[27].wartosc;
                pictureBoxTarget.Image = pictureBox27.Image;
                karta[27].picture.Enabled = false;
                pictureBox27.Visible = false;
                pictureBox27.Enabled = false;
                karta[19].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[27].wartosc + " oraz o kolorze " + karta[27].kolor);

            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[27].wartosc + " oraz o kolorze " + karta[27].kolor);
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            if (karta[28].odkryte && (karta[28].wartosc == karta[51].wartosc - 1 || karta[28].wartosc == karta[51].wartosc + 1 || (karta[28].wartosc == 1 && karta[51].wartosc == 13) || (karta[28].wartosc == 13 && karta[28].wartosc == 1)))
            {



                karta[51].picture = karta[28].picture;
                karta[51].wartosc = karta[28].wartosc;
                pictureBoxTarget.Image = pictureBox28.Image;
                karta[28].picture.Enabled = false;
                pictureBox28.Visible = false;
                pictureBox28.Enabled = false;
                karta[20].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[28].wartosc + " oraz o kolorze " + karta[28].kolor);

            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[28].wartosc + " oraz o kolorze " + karta[28].kolor);
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            if (karta[29].odkryte && (karta[29].wartosc == karta[51].wartosc - 1 || karta[29].wartosc == karta[51].wartosc + 1 || (karta[29].wartosc == 1 && karta[51].wartosc == 13) || (karta[29].wartosc == 13 && karta[51].wartosc == 1)))
            {



                karta[51].picture = karta[29].picture;
                karta[51].wartosc = karta[29].wartosc;
                pictureBoxTarget.Image = pictureBox29.Image;
                karta[29].picture.Enabled = false;
                pictureBox29.Visible = false;
                pictureBox29.Enabled = false;
                karta[21].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[29].wartosc + " oraz o kolorze " + karta[29].kolor);

            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[29].wartosc + " oraz o kolorze " + karta[29].kolor);
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            if (karta[30].odkryte && (karta[30].wartosc == karta[51].wartosc - 1 || karta[30].wartosc == karta[51].wartosc + 1 || (karta[30].wartosc == 1 && karta[51].wartosc == 13) || (karta[30].wartosc == 13 && karta[51].wartosc == 1)))
            {



                karta[51].picture = karta[30].picture;
                karta[51].wartosc = karta[30].wartosc;
                pictureBoxTarget.Image = pictureBox30.Image;
                karta[30].picture.Enabled = false;
                pictureBox30.Visible = false;
                pictureBox30.Enabled = false;
                karta[22].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[30].wartosc + " oraz o kolorze " + karta[30].kolor);

            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[30].wartosc + " oraz o kolorze " + karta[30].kolor);
            }
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            if (karta[31].odkryte && (karta[31].wartosc == karta[51].wartosc - 1 || karta[31].wartosc == karta[51].wartosc + 1 || (karta[31].wartosc == 1 && karta[51].wartosc == 13) || (karta[31].wartosc == 13 && karta[51].wartosc == 1)))
            {



                karta[51].picture = karta[31].picture;
                karta[51].wartosc = karta[31].wartosc;
                pictureBoxTarget.Image = pictureBox31.Image;
                karta[31].picture.Enabled = false;
                pictureBox31.Visible = false;
                pictureBox31.Enabled = false;
                karta[23].odkryte = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[31].wartosc + " oraz o kolorze " + karta[31].kolor);

            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[31].wartosc + " oraz o kolorze " + karta[31].kolor);
            }
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            if (karta[32].odkryte && (karta[32].wartosc == karta[51].wartosc - 1 || karta[32].wartosc == karta[51].wartosc + 1 || (karta[32].wartosc == 1 && karta[51].wartosc == 13) || (karta[32].wartosc == 13 && karta[51].wartosc == 1)))
            {



                karta[51].picture = karta[32].picture;
                karta[51].wartosc = karta[32].wartosc;
                pictureBoxTarget.Image = pictureBox32.Image;
                karta[32].picture.Enabled = false;
                pictureBox32.Visible = false;
                pictureBox32.Enabled = false;
                karta[24].odkryte = true;
                licznikCzasu.Enabled = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[32].wartosc + " oraz o kolorze " + karta[32].kolor);

            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[32].wartosc + " oraz o kolorze " + karta[32].kolor);
            }
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            if (karta[33].odkryte && (karta[33].wartosc == karta[51].wartosc - 1 || karta[33].wartosc == karta[51].wartosc + 1 || (karta[33].wartosc == 1 && karta[51].wartosc == 13) || (karta[33].wartosc == 13 && karta[51].wartosc == 1)))
            {



                karta[51].picture = karta[33].picture;
                karta[51].wartosc = karta[33].wartosc;
                pictureBoxTarget.Image = pictureBox33.Image;
                karta[33].picture.Enabled = false;
                pictureBox33.Visible = false;
                pictureBox33.Enabled = false;
                karta[25].odkryte = true;
                licznikCzasu.Enabled = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[33].wartosc + " oraz o kolorze " + karta[33].kolor);

            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[33].wartosc + " oraz o kolorze " + karta[33].kolor);
            }
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            if (karta[34].odkryte && (karta[34].wartosc == karta[51].wartosc - 1 || karta[34].wartosc == karta[51].wartosc + 1 || (karta[34].wartosc == 1 && karta[51].wartosc == 13) || (karta[34].wartosc == 13 && karta[51].wartosc == 1)))
            {



                karta[51].picture = karta[34].picture;
                karta[51].wartosc = karta[34].wartosc;
                pictureBoxTarget.Image = pictureBox34.Image;
                karta[34].picture.Enabled = false;
                pictureBox34.Visible = false;
                pictureBox34.Enabled = false;
                karta[26].odkryte = true;
                licznikCzasu.Enabled = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[34].wartosc + " oraz o kolorze " + karta[34].kolor);

            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[34].wartosc + " oraz o kolorze " + karta[34].kolor);
            }
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            if (karta[35].odkryte && (karta[35].wartosc == karta[51].wartosc - 1 || karta[35].wartosc == karta[51].wartosc + 1 || (karta[35].wartosc == 1 && karta[51].wartosc == 13) || (karta[35].wartosc == 13 && karta[51].wartosc == 1)))
            {



                karta[51].picture = karta[35].picture;
                karta[51].wartosc = karta[35].wartosc;
                pictureBoxTarget.Image = pictureBox35.Image;
                karta[35].picture.Enabled = false;
                pictureBox35.Visible = false;
                pictureBox35.Enabled = false;
                karta[27].odkryte = true;
                licznikCzasu.Enabled = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[35].wartosc + " oraz o kolorze " + karta[35].kolor);

            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[35].wartosc + " oraz o kolorze " + karta[35].kolor);
            }
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            if (karta[36].odkryte && (karta[36].wartosc == karta[51].wartosc - 1 || karta[36].wartosc == karta[51].wartosc + 1 || (karta[36].wartosc == 1 && karta[51].wartosc == 13) || (karta[36].wartosc == 13 && karta[51].wartosc == 1)))
            {



                karta[51].picture = karta[36].picture;
                karta[51].wartosc = karta[36].wartosc;
                pictureBoxTarget.Image = pictureBox36.Image;
                karta[36].picture.Enabled = false;
                pictureBox36.Visible = false;
                pictureBox36.Enabled = false;
                karta[28].odkryte = true;
                licznikCzasu.Enabled = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[36].wartosc + " oraz o kolorze " + karta[36].kolor);

            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[36].wartosc + " oraz o kolorze " + karta[36].kolor);
            }
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            if (karta[37].odkryte && (karta[37].wartosc == karta[51].wartosc - 1 || karta[37].wartosc == karta[51].wartosc + 1 || (karta[37].wartosc == 1 && karta[51].wartosc == 13) || (karta[37].wartosc == 13 && karta[51].wartosc == 1)))
            {



                karta[51].picture = karta[37].picture;
                karta[51].wartosc = karta[37].wartosc;
                pictureBoxTarget.Image = pictureBox37.Image;
                karta[37].picture.Enabled = false;
                pictureBox37.Visible = false;
                pictureBox37.Enabled = false;
                karta[29].odkryte = true;
                licznikCzasu.Enabled = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[37].wartosc + " oraz o kolorze " + karta[37].kolor);

            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[37].wartosc + " oraz o kolorze " + karta[37].kolor);
            }
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            if (karta[38].odkryte && (karta[38].wartosc == karta[51].wartosc - 1 || karta[38].wartosc == karta[51].wartosc + 1 || (karta[38].wartosc == 1 && karta[51].wartosc == 13) || (karta[38].wartosc == 13 && karta[51].wartosc == 1)))
            {



                karta[51].picture = karta[38].picture;
                karta[51].wartosc = karta[38].wartosc;
                pictureBoxTarget.Image = pictureBox38.Image;
                karta[38].picture.Enabled = false;
                pictureBox38.Visible = false;
                pictureBox38.Enabled = false;
                karta[30].odkryte = true;
                licznikCzasu.Enabled = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[38].wartosc + " oraz o kolorze " + karta[38].kolor);

            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[38].wartosc + " oraz o kolorze " + karta[38].kolor);
            }
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            if (karta[39].odkryte && (karta[39].wartosc == karta[51].wartosc - 1 || karta[39].wartosc == karta[51].wartosc + 1 || (karta[39].wartosc == 1 && karta[51].wartosc == 13) || (karta[39].wartosc == 13 && karta[51].wartosc == 1)))
            {



                karta[51].picture = karta[39].picture;
                karta[51].wartosc = karta[39].wartosc;
                pictureBoxTarget.Image = pictureBox39.Image;
                karta[39].picture.Enabled = false;
                pictureBox39.Visible = false;
                pictureBox39.Enabled = false;
                karta[31].odkryte = true;
                licznikCzasu.Enabled = true;
                Debug.Print("warunek spelniony" + "karta o wartosci " + karta[39].wartosc + " oraz o kolorze " + karta[39].kolor);

            }
            else
            {
                Debug.Print("warunek nie spelniony bo wartosc " + karta[39].wartosc + " oraz o kolorze " + karta[39].kolor);
            }
        }

        #endregion


        private void pictureBoxStos_Click(object sender, EventArgs e)
        {
        
           while(x<=51)
            {
                if (karta[x].odkryte)
                {
                    karta[51].wartosc = karta[x].wartosc;
                    karta[51].kolor = karta[x].kolor;
                    pictureBoxTarget.Image = pic[x].Image;
                    karta[x].odkryte = false;
                    licznikCzasu.Enabled = true;
                    Debug.Print("Podmienilem karte " + karta[x].wartosc + " " + karta[x].kolor + "To jest karta o indeksie " + x);
                    x++;
                    if (x == 51)
                    {
                        kartySkonczone = true;
                        Debug.Print("Karty skonczone " + x);
                        pictureBoxStos.Visible = false;
                        pictureBoxStos.Enabled = false;
                        break;

                    }
                    break;
                }
             
                
                
            }

           
        }

        private void licznikCzasu_Tick(object sender, EventArgs e)
        {
            timeCounter++;
            laberTimer.Text = "Czas gry : " + timeCounter;
            CzyPrzegrales();
            {
                if(przegrales==true && juzPrzegrales==false)
                {
                    juzPrzegrales = true;
                    licznikCzasu.Enabled = false;
                    var result = MessageBox.Show("Niestety przegrałeś. Chcesz spróbować ponownie? ", "Przegrana!", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                   

                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(Application.ExecutablePath);
                        Application.Exit();
                    }
                    else if(result==DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
                else
                {

                }
            }


        }

        void CzyPrzegrales()
        {
            if (kartySkonczone==true)
            {

                for (int i = 0; i <= 39; i++)
                {
                    if (karta[i].odkryte && pic[i].Visible && (karta[i].wartosc == karta[51].wartosc - 1 || karta[i].wartosc == karta[51].wartosc + 1 || (karta[i].wartosc == 1 && karta[51].wartosc == 13) || (karta[i].wartosc == 13 && karta[51].wartosc == 1)))
                    {
                        przegrales = false;
                        break;
                    }
                    else
                    {
                        przegrales = true;


                    }
                }
            }
            else
            {
                przegrales = false;
            }
        }

        void KoniecGry()
        {

            for (int i=0;i<=7;i++)
            {
                if(pic[i].Enabled == false)
                {
                    wygrana[i] = true;
                }
                
               
            }

            if (wygrana[0] == true && wygrana[1] == true && wygrana[2] == true && wygrana[3] == true && wygrana[4] == true && wygrana[5] == true && wygrana[6] == true && wygrana[7] == true)
            {
                licznikCzasu.Enabled = false;
                var result = MessageBox.Show("Gratulacje, wygrałes, " + "twój czas: " + timeCounter + " Czy chcesz zagrać ponownie? ", "Wygrana", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           Help frm = new Help();
            frm.Show();
        }
    }

}



    
    

