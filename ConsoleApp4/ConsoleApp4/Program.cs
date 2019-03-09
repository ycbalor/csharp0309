//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//	class EventPublisherArgs : System.EventArgs
//	{
//		public string _MyEventData;

//		public EventPublisherArgs(string myEventData)
//		{
//			_MyEventData = myEventData;
//		}
//	}

//	class EventPublisher
//	{
//		public delegate void MyEventHandler(object sender, EventPublisherArgs e);
//		public event MyEventHandler MyEvent;

//		public void Do()
//		{
//			if (MyEvent != null)
//			{
//				EventPublisherArgs args = new EventPublisherArgs("데이터");
//				MyEvent(this, args);
//			}
//		}
//	}

//	class Program
//	{
//		static void Main(string[] args)
//		{
//			EventPublisher p = new EventPublisher();
//			p.MyEvent += new EventPublisher.MyEventHandler(doAction);
//			p.Do();
//		}

//		static void doAction(object sender, EventPublisherArgs e)
//		{
//			Console.WriteLine("MyEvent 라는 이벤트 발생...");
//			Console.WriteLine("이벤트 매개변수 : " + e._MyEventData);
//		}
//	}
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	class EventPublisherArgs : System.EventArgs
	{
		public string _MyEventData;

		public EventPublisherArgs(string myEventData)
		{
			_MyEventData = myEventData;
		}
	}

	class EventPublisher
	{
		// public delegate void MyEventHandler(object sender, EventPublisherArgs e);
		public event EventHandler MyEvent;

		public void Do()
		{
			if (MyEvent != null)
			{
				EventPublisherArgs args = new EventPublisherArgs("데이터");
				MyEvent(this, args);
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			EventPublisher p = new EventPublisher();
			p.MyEvent += new EventHandler(doAction);
			p.Do();
		}

		static void doAction(object sender, EventArgs e)
		{
			Console.WriteLine("MyEvent 라는 이벤트 발생...");
			Console.WriteLine("이벤트 매개변수 : " + ((EventPublisherArgs)e)._MyEventData);
		}
	}
}

