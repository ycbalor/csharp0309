using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingExam2
{
	class Adder1
	{
		public static Adder3 operator +(Adder1 a1, Adder2 a2)
		{
			Adder3 a3 = new Adder3();
			a3.Val = a1.Val + a2.Val;
			return a3;
		}
		public int Val { get; set; }
	}

	class Adder2
	{
		public int Val { get; set; }
	}

	class Adder3
	{
		public int Val { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{
			Adder1 a1 = new Adder1();
			Adder2 a2 = new Adder2();
			// a1이나 a2 둘중에 하나에 해주면 될듯
			Adder3 a3 = a1 + a2;

			Console.WriteLine(a3.Val);
		}
	}
}
