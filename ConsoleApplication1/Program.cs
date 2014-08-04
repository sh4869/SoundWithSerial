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
            SerialPort sepo;
            sepo.BaudRate = 9600;
            sepo.PortName = "";
            sepo.Open();

            System.Media.SystemSounds.Beep.Play();

        }
    }
}
