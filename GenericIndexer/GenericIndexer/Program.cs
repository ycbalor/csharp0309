using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIndexer
{
	class Ojc<T>
	{
		// 배열의 타입이 매번 변한다.
		private T[] ojcArr = new T[10];

		// 제네릭을 통한 인덱서
		public T this[int i]
		{
			get
			{
				return ojcArr[i];
			}
			set
			{
				ojcArr[i] = value;
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Ojc<string> ojc1 = new Ojc<string>();
			ojc1[0] = "Hello OJC"; // 인스턴스를 배열처럼 쓰는것처럼 보이지만 실제로는 인덱스를 통해 속성 값을 넣어주는것이다.
			Console.WriteLine(ojc1[0]);

			Ojc<int> ojc2 = new Ojc<int>();
			ojc2[0] = 999;
			Console.WriteLine(ojc2[0]);
		}
	}
}
