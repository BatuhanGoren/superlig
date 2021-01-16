using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Süperlig
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        int fbpuan = 0;
        int gspuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;



        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label21.Text = a.ToString();
            label22.Text = b.ToString();
            label23.Text = c.ToString();
            label24.Text = d.ToString();
            button4.Enabled = false;


            if (Convert.ToInt32(label22.Text) > Convert.ToInt32(label24.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label22.Text) < Convert.ToInt32(label24.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label22.Text) == Convert.ToInt32(label24.Text))
            {
                fbpuan = fbpuan + 3;
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();

            }
            if (Convert.ToInt32(label21.Text) > Convert.ToInt32(label23.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label21.Text) < Convert.ToInt32(label23.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label21.Text) == Convert.ToInt32(label23.Text))
            {
                gspuan = gspuan + 3;
                tspuan = tspuan + 3;
                labelgspuan.Text = gspuan.ToString();
                labeltspuan.Text = tspuan.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label7.Text = a.ToString();
            label8.Text = b.ToString();
            label9.Text = c.ToString();
            label10.Text = d.ToString();
            button1.Enabled = false;

            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label8.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label7.Text) < Convert.ToInt32(label8.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label7.Text) == Convert.ToInt32(label8.Text))
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label9.Text) > Convert.ToInt32(label10.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();

            }
            if (Convert.ToInt32(label9.Text) < Convert.ToInt32(label10.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label9.Text) == Convert.ToInt32(label10.Text))
            {
                tspuan = tspuan + 1;
                bjkpuan = bjkpuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }
        }







        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label11.Text = a.ToString();
            label12.Text = b.ToString();
            label13.Text = c.ToString();
            label14.Text = d.ToString();
            button2.Enabled = false;

            if (Convert.ToInt32(label12.Text) > Convert.ToInt32(label14.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label12.Text) < Convert.ToInt32(label14.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label12.Text) == Convert.ToInt32(label14.Text))
            {
                tspuan = tspuan + 1;
                fbpuan = fbpuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label13.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) < Convert.ToInt32(label13.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) == Convert.ToInt32(label13.Text))
            {
                gspuan = gspuan + 1;
                bjkpuan = bjkpuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }
        }


        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelfbpuan.Text))
            {
                label39.Text = "ŞAMPİYON GALATASARAY !!!! ";
                label39.BackColor = Color.Red;
                label39.ForeColor = Color.Yellow;
                pictureBox1.Visible = Enabled;
                pictureBox1.ImageLocation = "C:\\Users\\batuh\\OneDrive\\Masaüstü\\c#wmp\\gs.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                axWindowsMediaPlayer1.URL = "C:\\Users\\batuh\\OneDrive\\Masaüstü\\c#wmp\\gs.mp3";
                MessageBox.Show("Oyunumuzu oynadığınız için teşekkür ederiz :)");
                button3.Enabled = false;


            }
            if (Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelgspuan.Text))
            {
                label39.Text = "ŞAMPİYON FENERBAHÇE !!!";
                label39.BackColor = Color.Blue;
                label39.ForeColor = Color.Yellow;
                pictureBox1.Visible = Enabled;
                pictureBox1.ImageLocation = "C:\\Users\\batuh\\OneDrive\\Masaüstü\\c#wmp\\fb.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                axWindowsMediaPlayer1.URL = "C:\\Users\\batuh\\OneDrive\\Masaüstü\\c#wmp\\fb.mp3";
                MessageBox.Show("Oyunumuzu oynadığınız için teşekkür ederiz :)");
                button3.Enabled = false;
            }
            if (Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelgspuan.Text))
            {
                label39.Text = "ŞAMPİYON TRABZONSPOR !!!";
                label39.BackColor = Color.DarkRed;
                label39.ForeColor = Color.Blue;
                pictureBox1.Visible = Enabled;
                pictureBox1.ImageLocation = "C:\\Users\\batuh\\OneDrive\\Masaüstü\\c#wmp\\ts.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                axWindowsMediaPlayer1.URL = "C:\\Users\\batuh\\OneDrive\\Masaüstü\\c#wmp\\ts.mp3";
                MessageBox.Show("Oyunumuzu oynadığınız için teşekkür ederiz :)");
                button3.Enabled = false;
            }
            if (Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelgspuan.Text))
            {
                label39.Text = "ŞAMPİYON BEŞİKTAŞ !!! ";
                label39.BackColor = Color.Black;
                label39.ForeColor = Color.White;
                pictureBox1.Visible = Enabled;
                pictureBox1.ImageLocation = "C:\\Users\\batuh\\OneDrive\\Masaüstü\\c#wmp\\bjk.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                axWindowsMediaPlayer1.URL = "C:\\Users\\batuh\\OneDrive\\Masaüstü\\c#wmp\\bjk.mp3";
                MessageBox.Show("Oyunumuzu oynadığınız için teşekkür ederiz :)");
                button3.Enabled = false;


            }


        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
            
            
