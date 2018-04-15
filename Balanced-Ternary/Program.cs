using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Ternary
{
	class Program
	{
		static void Main(string[] args)
		{
			var program = new Program();
			Console.WriteLine("Podaj liczbę całkowitą:");
			//zapętla na wiele liczb
			while (true)
			{
				int n;
				if (int.TryParse(Console.ReadLine(), out n))
				{
					string b = program.dek_to_bater(n);
					Console.WriteLine(b);
				}
				else return;
			}
		}

		//zamienia dziesiętnego inta do zbalansowanego trójkowego

		public string dek_to_bater(int n)
		{
			string b = "";

			if (n == 0) b = "o";
			else
				while (n != 0)
				{
					if (n % 3 == 0)
					{
						b = "o" + b;
						n = n / 3;
					}
					else if (n % 3 == 1 || n % 3 == -2)
					{
						b = "+" + b;
						n = (n - 1) / 3;
					}
					else
					{
						b = "-" + b;
						n = (n + 1) / 3;
					}
				}
			return b;
		}
	}
}
