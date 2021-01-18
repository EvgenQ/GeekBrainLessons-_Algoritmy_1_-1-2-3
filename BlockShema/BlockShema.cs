using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockShema
{
	class BlockShema
	{
		public static void SimpleNumber(int n) 
		{
			int d = 0;
			int i = 2;

			while (i < n)
			{
				if (n % 1 == 0)
				{
					d++;
				}
				i++;
			}
			if (d == 0)
			{
				Console.WriteLine("Простое");
			}
			else
				Console.WriteLine("Не простое");
		}
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			SimpleNumber(n);
			Console.ReadLine();
		}
	}
}
