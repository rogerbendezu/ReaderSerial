using System;
using System.IO.Ports;

namespace ReaderSerial
{
    class Program
    {
        static SerialPort SpPuertos = new SerialPort();

        static void Main(string[] args)
        {
            SpPuertos.BaudRate = 19200;
            SpPuertos.DataBits = 8;
            SpPuertos.Parity = Parity.None;
            SpPuertos.StopBits = StopBits.One;
            SpPuertos.Handshake = Handshake.None;
            SpPuertos.PortName = "COM18";

            SpPuertos.Open();
            while (SpPuertos.ReadExisting() != null)
            {
                var Data_in = SpPuertos.ReadExisting();
                if (!string.IsNullOrEmpty(Data_in))
                {
                    Console.WriteLine(Data_in);
                }
                
            }
            SpPuertos.Close();
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                //run loop until Enter is press
            }
        }

    }
}
