//Subject: ITN114 Wireless Internet and Pervasive Computing
//Language: C#
//IDE: Visual Studio 2019
//Azalea Mae Manimog

using System;

namespace Methods2
{
    class Program
    {
		static string Encrypt(char letter)
		{
			int letterASCII = (int)letter;

			int firstDigit = 0, lastDigit = letterASCII % 10;

			int codeASCII = letterASCII;

			while (codeASCII > 0)
			{
				firstDigit = codeASCII % 10;
				codeASCII = codeASCII / 10;
			}
			
			return (char)(letterASCII + lastDigit) + "" + firstDigit + lastDigit + (char)(letterASCII - firstDigit);
		}

		static void Main(string[] args)
		{
			String output = "";

			int n;
			char letter;

			n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				letter = Convert.ToChar(Console.ReadLine());
				output += Encrypt(letter);
			}
			Console.WriteLine("\n" + output);
		}
	}
}
