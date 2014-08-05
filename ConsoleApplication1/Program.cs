using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            SerialPort sepo=new SerialPort();
            sepo.BaudRate = 9600;
            sepo.PortName = "COM3";
            sepo.Open();
            sepo.ReadTimeout = 200;
            while (true)
            {
                try
                {
                    sepo.ReadByte();
                    System.Media.SystemSounds.Asterisk.Play();
                    Console.Write("Beep");
                    while (!Console.KeyAvailable)
                    {
                        
                    }
                    break;
                }
                catch (Exception)
                {
                }
            }

        }
    }
}
