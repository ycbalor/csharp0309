using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	// 내가 만든 버블 소트
	delegate bool ObjectDeligate(object obj1, object obj2);

	class ObjectSort
	{
		// obj는 정렬 대상, 정렬의 타겟
		// deli는 뒤집을지 말지를 결정하는 메소드를 참조하는 델리게이트
		public static void BubbleSort(object[] obj, ObjectDeligate deligate)
		{
			object temp;

			for (int i = 0; i < obj.Length; i++)
			{
				// 사용자가 작성한 정렬의 기준이 되는 메소드를 호출하여 뒤집을지를 결정
				// 비교 대상 둘중 i는 뒤에 있는 것, j는 앞에 있는 것
				for (int j = 0; j < i; j++)
				{
					temp = obj[i];
					obj[i] = obj[j];
					obj[j] = temp;
				}
			}
		}
	}

	// 개 회사에서 만든 것
	class Dog
	{
		string _Name;
		public Dog(string name)
		{
			this._Name = name;
		}

		public static bool MySort(object d1, object d2)
		{
			// 이름 순 오름차순 정렬을 위해 앞에 있는 d1.name이 크면 뒤집으라고 true를 리턴
			return ((((Dog)d1)._Name.CompareTo(((Dog)d2)._Name) > 0) ? true : false);
		}

		public override string ToString()
		{
			return "Dog:" + _Name;
		}
	}

	// 사람 회사에서 만든 것
	class Emp
	{
		string _Name;
		int _Sal;
		public Emp(string name, int sal)
		{
			this._Name = name;
			this._Sal = sal;
		}

		public static bool MySort(object d1, object d2)
		{
			// 급여순 오름차순 정렬을 위해 앞에 있는 d1.sal이 크면 뒤집으라고 true를 리턴
			return ((((Emp)d1)._Sal > ((Emp)d2)._Sal) ? true : false);
		}

		public override string ToString()
		{
			return "Emp:" + _Name + ", " + _Sal;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Dog[] dog = new Dog[4];
			dog[0] = new Dog("멍멍이");
			dog[1] = new Dog("푸들이");
			dog[2] = new Dog("진도이");
			dog[3] = new Dog("삽살이");

			ObjectDeligate sort = new ObjectDeligate(Dog.MySort);
			ObjectSort.BubbleSort(dog, sort);

			Console.WriteLine("Dog 정렬 후");
			foreach (Dog s in dog)
			{
				Console.WriteLine(s);
			}

			Emp[] emp = new Emp[4];
			emp[0] = new Emp("홍길이", 900);
			emp[1] = new Emp("곰길이", 100);
			emp[2] = new Emp("길길이", 1100);
			emp[3] = new Emp("북북이", 9900);

			sort = new ObjectDeligate(Emp.MySort);
			ObjectSort.BubbleSort(emp, sort);

			Console.WriteLine("Emp 정렬 후");
			foreach (Emp s in emp)
			{
				Console.WriteLine(s);
			}
		}
	}
}
