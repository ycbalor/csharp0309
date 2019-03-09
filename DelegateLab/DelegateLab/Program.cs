
// 1번
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLab
{

	
	class Program
{
	delegate void OnjDelegate(int a, int b);

	static void Main(string[] args)
	{
		string str = Console.ReadLine();
		str.Trim();

		string[] numbers = str.Split(',');

		OnjDelegate Callback = Plus;
		Callback += Minus;
		Callback += Multiple;
		Callback += Division;

		Callback(Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1]));
	}

	static void Plus(int a, int b)
	{
		Console.WriteLine(a + b);
	}

	static void Minus(int a, int b)
	{
		Console.WriteLine(a - b);
	}

	static void Multiple(int a, int b)
	{
		Console.WriteLine(a * b);
	}

	static void Division(int a, int b)
	{
		Console.WriteLine(a / b);
	}
}
}

// 2번
using System;

public delegate void Callback();
class Program
{
	static void Main(string[] args)
	{
		MyClass my = new MyClass();

		//Direct call

		my.MyMethod1();
		my.MyMethod2();

		Console.WriteLine("------------");

		// Call via a delegate
		// MyClass의 GetCallback(Callback callBack) 메소드를 호출하여
		// MyMethod1, MyMethod2가 호출 되도록 코드를 완성하세요

		my.GetCallback(my.MyMethod1);
		my.GetCallback(my.MyMethod2);

	}
}
public class MyClass
{
	public MyClass() { }
	public void GetCallback(Callback callBack)
	{
		callBack();
	}

	public void MyMethod1()
	{
		Console.WriteLine("My Method 1");
	}

	public void MyMethod2()
	{
		Console.WriteLine("My Method 2");
	}
}


// 3번
using System;
using System.IO;

namespace DelegateAppl
{
	class PrintString
	{
		static FileStream fs;
		static StreamWriter sw;
		// 델리게이트 선언

		delegate void printString(string s);

		// 콘솔화면에 출력
		public static void WriteToScreen(string str)
		{
			Console.WriteLine("The String is: {0}", str);
		}

		//파일에 출력
		public static void WriteToFile(string s)
		{
			fs = new FileStream("d:\\message.txt",
			FileMode.Append, FileAccess.Write);
			sw = new StreamWriter(fs);
			sw.WriteLine(s);
			sw.Flush();
			sw.Close();
			fs.Close();
		}

		// 델리게이트를 인자로 받아 실행
		// 결국 델리게이트가 참조하는 메소드 실행된다.
		static void sendString(printString ps)
		{
			ps("Test");
		}

		static void Main(string[] args)
		{
			printString ps1 = new printString(WriteToScreen);
			printString ps2 = new printString(WriteToFile);

			sendString(ps1);

			sendString(ps2);

			Console.ReadKey();
		}
	}
}


// 4번
using System;
using System.Windows.Forms;

delegate void DisplayMessage(string message);

public class TestCustomDelegate
{
	public static void Main()
	{
		DisplayMessage messageTarget;

		if (Environment.GetCommandLineArgs().Length > 1)
			messageTarget = ShowWindowsMessage;
		else
			messageTarget = Console.WriteLine;
		messageTarget("Hello, World!");
	}

	private static void ShowWindowsMessage(string message)
	{
		MessageBox.Show(message);
	}
}

