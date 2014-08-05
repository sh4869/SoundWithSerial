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

            SoundWithSerial mainwindow = new SoundWithSerial();
            
            mainwindow.ShowDialog();
            
            
        }
    }
}
