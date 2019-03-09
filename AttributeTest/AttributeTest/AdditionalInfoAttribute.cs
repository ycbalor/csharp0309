using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeTest
{
	// 어트리뷰트를 쓸때 사용하는 방법을 정의한다.
	// 어떤 사람이 사용하려면 Class 위에서 쓰라는 것이다.

	[AttributeUsage(AttributeTargets.Class)]
	public class AddtionalInfoAttribute : Attribute
	{
		string name;
		string update;

		// 생성자에 있는 두개의 인자는 위치지정 파라미터이다.
		// 즉 위치 지정 파라미터는 클래스에 어트리뷰트를 붙일 때, 반드시 넘겨줘여한다.
		// 항상 생성자에서 값을 넘겨 주게 되어있으므로 name, update인 경우 Property에서 set이 없다.
		public AddtionalInfoAttribute(string name, string update)
		{
			this.name = name;
			this.update = update;
		}

		public string Name
		{
			get { return name; }
		}

		public string Update
		{
			get { return update; }
		}

		public string Download
		{
			get;
			set;
		}
	}

	
}
