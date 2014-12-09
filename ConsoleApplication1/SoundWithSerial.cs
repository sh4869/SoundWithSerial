using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ConsoleApplication1
{
    public partial class SoundWithSerial : Form
    {
        public SoundWithSerial()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void StartButton_Click(object sender, EventArgs e)
        {

            System.Media.SoundPlayer music = new System.Media.SoundPlayer(@"C:\Users\nobuK\Music\Program\playsound.wav");
            music.PlaySync();
            SerialPort sepo = new SerialPort();
            sepo.BaudRate = Convert.ToInt32(this.BoudRateBox.Text);
            sepo.PortName = this.SerialPortCom.Text;
            try
            {
                sepo.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: ポートが開きませんでした");
                return;
            }
            sepo.ReadTimeout = Convert.ToInt32(this.ReadTimeBox.Text);
            stoped = false;
            while (true)
            {
                try
                {
                    sepo.ReadByte();
                    music.Play();
                    Console.Write("Beep");
                }
                catch (Exception)
                {
                }
                System.Windows.Forms.Application.DoEvents();
                if (stoped)
                {
                    sepo.Close();
                    sepo.Dispose();  
                    break;
                }
            }

        }
        private bool stoped;
        private void StopButton_Click(object sender, EventArgs e)
        {
            stoped = true;
        }

        private void SoundWithSerial_Load(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}
