using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace SudeTeslimeDaka_YonlendirilmisCalisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false; // Thread çakışmaları önemsenmeyecek ve somut hatalar ortadan kalkacaktır.
        }

        SoundPlayer playerAccess = new SoundPlayer();
        SoundPlayer playerKey = new SoundPlayer();
        private void btn_Bagla_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = "COM3";
            serialPort1.Open(); //portu açtık
            timer1.Start();
            gln_Veri.Text = "Lütfen Kartınızı gösterin.";
            gln_Veri.ForeColor = Color.Black;
        }
        String veri;
        int counter = 0;
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //gelen verileri okuyabiliriz.

            veri = serialPort1.ReadLine(); //veri isimdeki stringe verilerimiz aktarılacak
            playerAccess.SoundLocation = @"C:\Users\Lenovo\source\repos\SudeTeslimeDaka_YonlendirilmisCalisma\SudeTeslimeDaka_YonlendirilmisCalisma\Resources\accessSound.wav";
            playerKey.SoundLocation = @"C:\Users\Lenovo\source\repos\SudeTeslimeDaka_YonlendirilmisCalisma\SudeTeslimeDaka_YonlendirilmisCalisma\Resources\wrongpassword.wav";

            if (veri.ToString() == "1417502b78")
            {
                gln_Veri.Text = veri.ToString() + " Giriş Başarılı";
                gln_Veri.ForeColor = Color.Green;
                status_pictureBox.Image = Properties.Resources.card_png;
                playerAccess.Play();
            }
            else
            {
                gln_Veri.Text = veri.ToString() + " Başarısız";
                gln_Veri.ForeColor = Color.Red;
                status_pictureBox.Image = Properties.Resources.key_png;
                playerKey.Play();
            }
            counter = 0;
        }

        private void btn_Kes_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            serialPort1.Close();
            gln_Veri.Text = "Bağlantı Yok!";
            gln_Veri.ForeColor = Color.Black;
            status_pictureBox.Image = Properties.Resources.door_png;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > 2)
            {
                counter = 0;
                gln_Veri.Text = "Lütfen Kartınızı gösterin.";
                gln_Veri.ForeColor = Color.Black;
            }
        }
    }
}
