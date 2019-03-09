using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaTest
{
	class Program
	{
		delegate int Calc(int i, int j);

		static void Main(string[] args)
		{
			Calc c = new Calc(MySum);
			Console.WriteLine("1 + 2 = {0}", c(1, 2));

			Calc c1 = delegate (int i, int j)
			{
				return i + j;
			};
			Console.WriteLine("1 + 4 = {0}", c1(1, 2));

			Calc c2 = (int i, int j) => i + j;
			Console.WriteLine("7 + 4 = {0}", c2(7, 4));

			// 형식 유추로 매개 변수의 형식을 제거할 수 있다.
			Calc c3 = (i, j) => i + j;
			Console.WriteLine("10 + 8 = {0}", c3(10, 8));
		}

		static int MySum(int i, int j)
		{
			return i + j;
		}
	}
}
