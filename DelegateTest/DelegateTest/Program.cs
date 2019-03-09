using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
	class Program
	{
		// 델리게이트는 총 3단계
		private delegate int onjSum(int i, int j); // 1단계 선언
		// 위의 델리게이트는 int를 반환하고 int 파라미터 2개를 받는 메소드가 호출될꺼라는 것을 짐작할 수 있음

		static void Main(string[] args)
		{
			// 2단계 생성, 메소드 이름을 인자로 넣는다. 
			// 메소드 인자의 생긴것과 델리게이트는 생긴것이 동일해야함

			onjSum myMethod = new onjSum(Program.Sum);
			//onjSum myMethod = new onjSum(Sum); // 같은 static이면 메소드 이름만 인자로 넣어주어도 된다.
			//onjSum myMethod = Sum; // 메소드 이름만 넣어줘도 된다.

			Console.WriteLine("두수 합 : {0}", myMethod(10, 30)); // 3단계 실행
		}

		static int Sum(int i, int j)
		{
			return i + j;
		}
	}
}