using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingExam
{
	class AddClass
	{
		// 연산자 오버로딩
		public static AddClass operator +(AddClass op1, AddClass op2)
		{
			AddClass a = new AddClass();
			a.val = op1.val + op2.val;
			return a;
		}
		public int val { get; set; } // 속성
	}

	class Program
	{
		static void Main(string[] args)
		{
			// 인스턴스는 객체참조변수라고도 한다.
			AddClass a1 = new AddClass(); a1.val = 1;
			AddClass a2 = new AddClass(); a2.val = 2;
			AddClass a3 = a1 + a2;

			// 결과
			Console.WriteLine(a3.val);
		}
	}
}
