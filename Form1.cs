using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanoiTowers
{
    public partial class Form1 : Form
    {
        public int vez1_red_X1, vez1_red_Y1, vez1_orange_X1, vez1_orange_Y1, vez1_green_X1, vez1_green_Y1;

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            SystemSounds.Question.Play();
            MessageBox.Show($"Aplikace HanoiTowers\n2023 © Petr Vurm\n\nVytvořeno jako domácí úkol z předmětu PROGRAMOVÁNÍ na SPŠ Hradební.", "O aplikaci", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool vez1_nahoru_1, vez1_vlevo_1, vez1_dolu_1, vez1_dolu_zvuk_1, vez1_nahoru_2, vez1_vlevo_2, vez1_dolu_2, vez1_dolu_zvuk_2, vez1_nahoru_3, vez1_vlevo_3, vez1_dolu_3, vez1_dolu_zvuk_3, vez2_nahoru_1, vez2_vlevo_1, vez2_dolu_1, vez2_dolu_zvuk_1, vez2_nahoru_2, vez2_vlevo_2, vez2_dolu_2, vez2_dolu_zvuk_2 = false;

        private void btnPlayAnim_Click(object sender, EventArgs e)
        {
            if(animace.Enabled == false)
            {
                animace.Enabled = true;
            }
        }

        public Form1()
        {
            InitializeComponent();

            // nastavení dynamických souřadnic X a Y pro červený blok
            vez1_red_X1 = 50;
            vez1_red_Y1 = 78;

            // nastavení dynamických souřadnic X a Y pro oranžový blok
            vez1_orange_X1 = 40;
            vez1_orange_Y1 = 98;

            // nastavení dynamických souřadnic X a Y pro zelený blok
            vez1_green_X1 = 30;
            vez1_green_Y1 = 118;
        }

        private void animace_Tick(object sender, EventArgs e)
        {
            // pohyb červeného bloku nahoru ze základní pozice Y; pouze pokud ještě nebyl pohyb červeného bloku nahoru proveden
            if (vez1_red_Y1 > 48 && vez1_nahoru_1 == false)
            {
                vez1_red_Y1 -= 2;
                Refresh();
            }

            // pohyb červeného bloku doleva po dosažení Y = 48 do doby než je dosaženo X = 188; pouze pokud ještě nebyl pohyb červeného bloku  vlevo prováděn
            if(vez1_red_Y1 == 48 && vez1_red_X1 <= 188 && vez1_vlevo_1 == false)
            {
                vez1_red_X1 += 2;
                vez1_nahoru_1 = true;
                Refresh();
            }

            // pohyb červeného bloku dolů po dosažení X = 190 do doby než je dosaženo Y = 116; pouze pokud ještě nebyl pohyb červeného bloku dolů prováděn
            if(vez1_red_X1 == 190 && vez1_red_Y1 <= 116 && vez1_dolu_1 == false)
            {
                vez1_red_Y1 += 2;
                vez1_vlevo_1 = true;
                Refresh();
            }

            // pohyb oranžového bloku nahoru ze základní pozice po dokončení pohybu červeného bloku na X = 190 a Y = 118; pouze pokud ještě nebyl pohyb oranžového bloku nahoru prováděn
            if(vez1_red_Y1 == 118 && vez1_orange_Y1 > 48 && vez1_nahoru_2 == false)
            {
                vez1_orange_Y1 -= 2;
                vez1_dolu_1 = true;
                Refresh();
            }

            // pohyb oranžového bloku doleva po dosažení Y = 48 do doby než je dosaženo X = 178; pouze pokud ještě nebyl pohyb oranžového bloku vlevo prováděn
            if(vez1_orange_Y1 == 48 && vez1_orange_X1 <= 178 && vez1_vlevo_2 == false)
            {
                vez1_orange_X1 += 2;
                vez1_nahoru_2 = true;
                Refresh();
            }

            // pohyb oranžového bloku dolů po dosažení X = 180 do doby než je dosaženo Y = 96; pouze pokud ještě nebyl pohyb oranžového bloku dolů prováděn
            if (vez1_orange_X1 == 180 && vez1_orange_Y1 <= 96 && vez1_dolu_2 == false)
            {
                vez1_orange_Y1 += 2;
                vez1_vlevo_2 = true;
                Refresh();
            }

            // pohyb zeleného bloku nahoru ze základní pozice po dokončení pohybu oranžového bloku na X = 180 a Y = 98; pouze pokud ještě nebyl pohyb zeleného bloku nahoru prováděn
            if (vez1_orange_Y1 == 98 && vez1_orange_X1 == 180 && vez1_green_Y1 > 48 && vez1_nahoru_3 == false)
            {
                vez1_green_Y1 -= 2;
                vez1_dolu_2 = true;
                Refresh();
            }

            // pohyb zeleného bloku doleva po dokončení Y = 48; pouze pokud ještě nebyl pohyb zeleného bloku vlevo prováděn
            if (vez1_green_Y1 == 48 && vez1_green_X1 <= 308 && vez1_vlevo_3 == false)
            {
                vez1_green_X1 += 2;
                vez1_nahoru_3 = true;
                Refresh();
            }

            // pohyb zeleného bloku dolů po dokončení X = 310; pouze pokud ještě nebyl pohyb zeleného bloku dolů prováděn
            if (vez1_green_X1 == 310 && vez1_green_Y1 <= 116 && vez1_dolu_3 == false)
            {
                vez1_green_Y1 += 2;
                vez1_vlevo_3 = true;
                Refresh();
            }

            // pohyb oranžového bloku nahorů z věže B na věž C po dokončení pohybu zeleného bloku na Y = 118; pouze pokud ještě nebyl pohyb oranžového bloku nahoru z věže B prováděn
            if(vez1_green_X1 == 310 && vez1_green_Y1 == 118 && vez1_orange_Y1 > 48 && vez2_nahoru_1 == false)
            {
                vez1_orange_Y1 -= 2;
                vez1_dolu_3 = true;
                Refresh();
            }

            // pohyb oranžového bloku vlevo od věže B k věži C po dokončení pohybu oranžového bloku nahoru na Y = 48; pouze pokud ještě nebyl pohyb oranžového bloku doleva od věže B prováděn
            if (vez1_orange_Y1 == 48 && vez1_orange_X1 <= 318 && vez1_dolu_2 == true && vez2_vlevo_1 == false)
            {
                vez1_orange_X1 += 2;
                vez2_nahoru_1 = true;
                Refresh();
            }

            // pohyb oranžového bloku dolů na věž C po dokončení pohybu oranžového bloku vlevo na X = 320; pouze pokud ještě nebyl pohyb oranžového bloku dolů na věž C prováděn
            if (vez1_orange_X1 == 320 && vez1_orange_Y1 <= 96 && vez1_nahoru_2 == true && vez2_dolu_1 == false)
            {
                vez1_orange_Y1 += 2;
                vez2_vlevo_1 = true;
                Refresh();
            }

            if(vez1_orange_X1 == 320 && vez1_orange_Y1 == 98 && vez1_red_Y1 > 48 && vez2_nahoru_2 == false)
            {
                vez1_red_Y1 -= 2;
                vez2_dolu_1 = true;
                Refresh();
            }

            if (vez1_red_Y1 == 48 && vez1_red_X1 <= 328 && vez1_dolu_1 == true && vez2_vlevo_2 == false)
            {
                vez1_red_X1 += 2;
                vez2_nahoru_2 = true;
                Refresh();
            }

            if (vez1_red_X1 == 330 && vez1_red_Y1 <= 76 && vez2_dolu_2 == false)
            {
                vez1_red_Y1 += 2;
                vez2_vlevo_2 = true;
                Refresh();
            }

            // výpis souřadnic bloků ve tvaru [X; Y]
            lblSouradniceCervena.Text = $"Červený blok: [{vez1_red_X1};{vez1_red_Y1}]";
            lblSouradniceOranzova.Text = $"Oranžový blok: [{vez1_orange_X1};{vez1_orange_Y1}]";
            lblSouradniceZelena.Text = $"Zelený blok: [{vez1_green_X1};{vez1_green_Y1}]";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics platno = e.Graphics;
            Pen peroCara = new Pen(Color.Black, 4);

            // vykreslení věže A
            platno.DrawLine(peroCara, 20, 140, 120, 140);
            platno.DrawLine(peroCara, 70, 70, 70, 140);

            // vykreslení věže B
            platno.DrawLine(peroCara, 160, 140, 260, 140);
            platno.DrawLine(peroCara, 210, 70, 210, 140);
            // platno.FillRectangle(Brushes.Green, 170, 118, 80, 20);
            // platno.FillRectangle(Brushes.Orange, 180, 98, 60, 20);
            // platno.FillRectangle(Brushes.Red, 190, 118, 40, 20);

            // vykreslení věže C
            platno.DrawLine(peroCara, 300, 140, 400, 140);
            platno.DrawLine(peroCara, 350, 70, 350, 140);
            // platno.FillRectangle(Brushes.Green, 310, 118, 80, 20);
            // platno.FillRectangle(Brushes.Orange, 320, 98, 60, 20);
            // platno.FillRectangle(Brushes.Red, 330, 78, 40, 20);

            // vykreslení bloků
            platno.FillRectangle(Brushes.Green, vez1_green_X1, vez1_green_Y1, 80, 20);
            platno.FillRectangle(Brushes.Orange, vez1_orange_X1, vez1_orange_Y1, 60, 20);
            platno.FillRectangle(Brushes.Red, vez1_red_X1, vez1_red_Y1, 40, 20);

            if(vez1_red_X1 == 190 && vez1_red_Y1 == 118 && vez1_dolu_zvuk_1 == false)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.block);
                player.Play();
                vez1_dolu_zvuk_1 = true;
            }

            if (vez1_orange_X1 == 180 && vez1_orange_Y1 == 98 && vez1_dolu_zvuk_2 == false)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.block);
                player.Play();
                vez1_dolu_zvuk_2 = true;
            }

            if (vez1_green_X1 == 310 && vez1_green_Y1 == 118 && vez1_dolu_zvuk_3 == false)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.block);
                player.Play();
                vez1_dolu_zvuk_3 = true;
            }

            if (vez1_orange_X1 == 320 && vez1_orange_Y1 == 98 && vez2_dolu_zvuk_1 == false)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.block);
                player.Play();
                vez2_dolu_zvuk_1 = true;
            }

            if (vez1_red_X1 == 330 && vez1_red_Y1 == 78 && vez2_dolu_zvuk_2 == false)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.block);
                player.Play();
                vez2_dolu_zvuk_2 = true;
            }
        }
    }
}
