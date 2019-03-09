using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{

	//// 1번
	//delegate double OnjDouble(double x);

	//class OnjMath
	//{
	//	internal static double MultipleByTwo(double value)
	//	{
	//		return value * 2;
	//	}

	//	internal static double Square(double value)
	//	{
	//		return value * value;
	//	}
	//}

	//class Program
	//{
	//	static void Main(string[] args)
	//	{
	//		OnjDouble[] op =
	//		{
	//			new OnjDouble(OnjMath.MultipleByTwo), new OnjDouble(OnjMath.Square)
	//		};

	//		for (int i = 0; i < op.Length; i++)
	//		{
	//			Console.WriteLine("op[{0}] 호출:", i);
	//			CallDelegate(op[i], 3.0);
	//		}
	//	}

	//	// 메소드 인자가 델리게이트로 들어오면 할일이 동적으로 바뀌게 된다..
	//	static void CallDelegate(OnjDouble func, double value)
	//	{
	//		double ret = func(value);
	//		Console.WriteLine("입력된 값은 {0}이고 결과는 {1}이다.", value, ret);
	//	}
	//}


	//// 2번
	//class Program
	//{
	//	public delegate int MyDelegate(int i, int j);

	//	public static void Main()
	//	{
	//		// TakesADelegate 메소드를 부르면서 인자로 델리게이트를 생성하고 인자로는 참조할 메소드 명을 넣어준다.
	//		TakeADelegate(new MyDelegate(Add));
	//		TakeADelegate(new MyDelegate(Minus));
	//		TakeADelegate(new MyDelegate(Gop));
	//		TakeADelegate(new MyDelegate(Nanugi));
	//	}

	//	public static void TakeADelegate(MyDelegate SomFunction)
	//	{
	//		Console.WriteLine(SomFunction(1, 2));
	//	}

	//	public static int Add(int i, int j)
	//	{
	//		return i + j;
	//	}

	//	public static int Minus(int i, int j)
	//	{
	//		return i - j;
	//	}

	//	public static int Gop(int i, int j)
	//	{
	//		return i * j;
	//	}

	//	public static int Nanugi(int i, int j)
	//	{
	//		return i / j;
	//	}
	//}


	//// 3번
	//class Program
	//{
	//	delegate void Deli(string s);

	//	static void Main()
	//	{
	//		Deli d0 = (v) => Console.WriteLine(v);
	//		d0.Invoke("OJC");

	//		Deli d1 = new Deli(d);
	//		d1.Invoke("OJC");

	//		Deli d2 = d;
	//		d2.Invoke("OJC");
	//	}

	//	static void d(string s)
	//	{
	//		Console.WriteLine(s);
	//	}
	//}


	// 4번
	delegate void OnjDelegate(int a, int b);
	class Program
	{
		static void Main()
		{
			Program main = new Program();

			// 델리게이트 체인
			// 여러 메소드를 추가해주는듯
			OnjDelegate Callback = (OnjDelegate)Delegate.Combine(
																	new OnjDelegate(Plus),
																	new OnjDelegate(Minus),
																	new OnjDelegate(Mutiple),
																	new OnjDelegate(Divisin)
																);

			// 델리게이트 체인 이렇게도 됨 1
			//OnjDelegate Callback = new OnjDelegate(Plus);
			//Callback += new OnjDelegate(Minus);
			//Callback += new OnjDelegate(Mutiple);
			//Callback += new OnjDelegate(Divisin);

			// 델리게잍트 체인 이렇게도 됨 2
			//OnjDelegate CallBack1 = new OnjDelegate(Plus);
			//OnjDelegate CallBack2 = new OnjDelegate(Minus);
			//OnjDelegate CallBack3 = new OnjDelegate(Mutiple);
			//OnjDelegate CallBack4 = new OnjDelegate(Divisin);
			//OnjDelegate Callback = CallBack1 + CallBack2 + CallBack3 + CallBack4;

			Callback(4, 3);

		}

		static void Plus(int a, int b)
		{
			Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
		}

		static void Minus(int a, int b)
		{
			Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
		}

		static void Mutiple(int a, int b)
		{
			Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
		}

		static void Divisin(int a, int b)
		{
			Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
		}
	}
}