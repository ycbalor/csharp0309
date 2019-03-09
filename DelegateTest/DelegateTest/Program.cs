using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
	class Program
	{
		// 델리게이트를 위해서 C#에서 Func와 Action이 있음
		// Func는 반환값이 있는 것, Action은 반환값이 없는것 
		// 둘다 인자를 15개 ~ 16개 까지 넣을 수 있다.

		static void Main(string[] args)
		{
			// 2단계 생성, 메소드 이름을 인자로 넣는다. 

			Func<int, int, int> myMethod = Sum1;
			Action<int, int> myMethod2 = Sum2;

			Console.WriteLine("두수 합 : {0}", myMethod(10, 30)); // 3단계 실행
			myMethod2(10, 20);

		}

		static int Sum1(int i, int j)
		{
			return i + j;
		}

		static void Sum2(int i, int j)
		{
			Console.WriteLine(i + j);
		}
	}
}