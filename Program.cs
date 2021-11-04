using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Wifi.AdressManagement.Verwaltung
{
	class Program
	{
		static void Main(string[] args)
		{
			//StreamWriter swData = new StreamWriter("c:\\temp\\test.txt", true);
			//swData.WriteLine("Hallo Wifi!!!!");
			//swData.Close();

			StreamReader srData = new StreamReader("c:\\temp\\test.txt");
			string zeile = srData.ReadLine();
			srData.Close();

			StreamReader srMails = new StreamReader("K:\\SWE\\mail.txt");
			while (!srMails.EndOfStream)
			{
				zeile = srMails.ReadLine();
				Console.WriteLine(zeile);
			}
			srMails.Close();

			Console.WriteLine(zeile);
			Console.WriteLine("Press any key...");
			Console.ReadKey();
		}
	}

}
