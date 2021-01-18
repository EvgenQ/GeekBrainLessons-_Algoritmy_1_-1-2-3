using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_complexity
{
	class Function_complexity
	{
		public static int StrangeSum(int[] inputArray)
		{// O
			int sum = 0;// O(1)
			for (int i = 0; i < inputArray.Length; i++) //O(n^3)
			{
				for (int j = 0; j < inputArray.Length; j++) //O(n^2)
				{
					for (int k = 0; k < inputArray.Length; k++) //O(n)
					{
						int y = 0;// O(1)

						if (j != 0)// O(1)
						{
							y = k / j;// O(1)
						}

						sum += inputArray[i] + i + k + j + y;// O(1)
					}
				}
			}

			return sum;// O(1)
		}
		static void Main(string[] args)
		{
			int[] add = new int[] {1,2,3,4,56,78,54,545,4,8787,452 };
			Console.WriteLine(StrangeSum(add));
			Console.ReadLine();
		}
	}
}
