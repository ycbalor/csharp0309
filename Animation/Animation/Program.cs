using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animation
{
	

	public class Animation
	{
		private int total;
		private string[] title; // 뭔가 수상
		private string distributor;
		private string date;
		private int price;

		public Animation(int total, string distributor, string date, int price)
		{
			this.total = total;
			this.title = new string[total];
			this.distributor = distributor;
			this.date = date;
			this.price = price;
		}

		// 이부분에서 인덱서를 정의한다. 이전 프로그램의 setTitle, getTitle이 인덱서로 대체된다 
		// 즉 this라는 Property가 인덱서인 것이다.
		public string this[int index]
		{
			get
			{
				return title[index];
			}
			set
			{
				title[index] = value;
			}
		}

		public string getDistributor()
		{
			return distributor;
		}

		public int getPrice()
		{
			return price;
		}

		public int getTotal()
		{
			return total;
		}


	}

	class Program
	{
		static void Main(string[] args)
		{
			Animation ani = new Animation(5, "한국애니메이션", "10-27-2004", 35000);

			Console.WriteLine("배급사:{0}", ani.getDistributor());
			Console.WriteLine("가격:{0}", ani.getPrice());
			Console.WriteLine("--------------------------------");

			for (int i = 0; i < ani.getTotal(); i++)
			{
				Console.WriteLine("Volume{0} : {1}", i, ani[i]);
			}

		}
	}
}
