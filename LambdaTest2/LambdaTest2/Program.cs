using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaTest2
{
	// 메소드 기반 쿼리식
	//class Program
	//{
	//	static void Main(string[] args)
	//	{

	//		int[] scores = { 30, 54, 64, 54, 99, 11 };
	//		string[] arr = { "test", "sdfd" };

	//		// int oddScoreSum = scores.Where(MyWhere).Sum();
	//		// int oddScoreSum = scores.Where(new Func<int, bool>( n => n % 2 == 1)).Sum();
	//		// int oddScoreSum = scores.Where(new Func<int, bool>(MyWhere)).Sum();
	//		int oddScoreSum = scores.Where(n => n % 2 == 1).Sum();			
	//		Console.WriteLine("{0} 홀수의 합", oddScoreSum);

	//		int Count = scores.Where(n => n > 50).Count();
	//		Console.WriteLine("{0} 50보다 큰 개수", Count);
	//	}
	//}

	class Program
	{
		delegate int Sum(int[] arg);

		static void Main(string[] args)
		{
			Sum sumdeli = arg =>
			{
				int mySum = 0;
				foreach (int i in arg)
					mySum += i;
				return mySum;
			};

			int sum = sumdeli(new int[] { 1, 2, 3, 4, 5 });
			Console.WriteLine("1 + 2 + 3 + 4 + 5 = {0}", sum);
		}
	}
}
