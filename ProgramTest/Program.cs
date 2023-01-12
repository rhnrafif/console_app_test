
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApplication3
{
	class Program
	{
		static void Main(string[] args)
		{
			bool showMenu = true;
			while (showMenu)
			{
				Console.WriteLine("Pilih Menu Dibawah ini : ");
				Console.WriteLine("1. Segita Siku");
				Console.WriteLine("2. Deret Fibonacci");
				Console.WriteLine("3. Perulangan");
				Console.WriteLine("4. Exit");
				Console.Write("Tuliskan pilihan : ");
				switch (Console.ReadLine())
				{
					case "1":
						SegitaSiku();
						showMenu = true;
						break;
					case "2":
						Fibonacci();
						showMenu = true;
						break;
					case "3":
						Test();
						showMenu = true;
						break;
					case "4":
						showMenu = false;
						break;
					default:
						showMenu = true;
						break;
					
				}		
			}
		}

		static void Fibonacci()
		{
			int x = 1, y = 1 , z = 1 ;

			Console.Write("Masukan jumlah bilangan fibonacci yang ingin ditampilkan : ");
			int jumlah = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			for (int i = 0; i < jumlah; i++)
			{
				Console.Write(z + " ");
				z = x + y;
				x = y;
				y = z;
			}
			Console.WriteLine();
			Console.WriteLine();

		}

		static void Test()
		{
			for (int i = 1; i <= 3; i++)
			{
				for (int j = 1; j <= 5; j++)
				{
					Console.WriteLine(j);
					if (j == 5)
					{
						Console.WriteLine();
						for (int k = 1; k <= 1; k++)
						{
							for (int l = 5; l >= 1; l--)
							{
								Console.WriteLine(l);
								if (l == 1)
								{
									Console.WriteLine();
								}
							}
						}
					}
				}
			}
		}
		static void SegitaSiku()
		{
			Console.Write("Tuliskan tinggi segitiga : ");
			int input = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			for (int i = 1; i <= input; i++)
			{
				for (int j = input-1; j >= i; j--)
				{
					Console.Write("");
				}
				for (int k = 1; k <= i; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine("");
			}
			Console.WriteLine();

		}
	}
}




