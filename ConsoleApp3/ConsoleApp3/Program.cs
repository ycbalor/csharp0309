using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	// this.button.Click에서 Click의 Type은 Delegate다.
	// 이벤트는 특수한 Delegate라고 생각하면 된다.

	class EventPublisher
	{
		//public delegate void MyEventHandler();
		//public event MyEventHandler MyEvent;
		public event EventHandler MyEvent;

		public void Do()
		{
			// 이벤트 가입자가 있는지 확인
			// if (MyEvent != null) { MyEvent(); }
			// MyEvent?.Invoke();

			MyEvent(null, null);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			EventPublisher eventPublisher = new EventPublisher();

			// C# 1.0 이벤트 가입 방법
			// eventPublisher.MyEvent += new EventPublisher.MyEventHandler(doAction); // MyEventHandler랑 DoAction이랑 메소드 형태 똑같아야함 중요!!

			// C# 2.0이상 이벤트 가입 방법
			// eventPublisher.MyEvent += doAction;

			// C# 3.0이상에서 Delegate를 이용한 무명함수로 이벤트 가입하는 방법
			//eventPublisher.MyEvent += delegate (object sender, EventArgs e)
			//{
			//	Console.WriteLine("이벤트 발생");
			//};

			// C# 3.0이후 람다식을 이용한 무명함수로 이벤트 가입 방법
			eventPublisher.MyEvent += (sender, e) =>
			{
				Console.WriteLine("이벤트 발생");
			};

			eventPublisher.Do();
		}

		//static void doAction(object sender, EventArgs e)
		//{
		//	Console.WriteLine("이벤트 발생");
		//}
	}
}
