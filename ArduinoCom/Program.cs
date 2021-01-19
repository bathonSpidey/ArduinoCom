using System;
using System.IO.Ports;

namespace ArduinoCom
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Connecting to com 10");
			port = new SerialPort("COM10", 9600);//"/dev/ttyUSB0", 115200);
			port.Open();
			Console.WriteLine("Connected...");
			port.DiscardInBuffer();
			port.DiscardOutBuffer();
			var bytes = new byte[] { 1 };
			var secondBytes=new byte[] { 2 };
			port.Write(bytes,0,1);
			Console.WriteLine("Led Blink up!");
			port.Write(secondBytes,0,1);
			Console.WriteLine("Led Blink Down");
			port.Write(bytes,0,1);
			Console.WriteLine("Led Blink up!");
			port.Close();
		}
		private static SerialPort port;
	}
}
