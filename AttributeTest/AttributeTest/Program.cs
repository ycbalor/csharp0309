
using AttributeTest;
using System;
using System.Diagnostics;

[AddtionalInfo("jclee", "2018-01-01", Download = "http://ojc.asia")]
class Test
{
	static void Main()
	{
		Type type = typeof(Test);

		foreach (Attribute attr in type.GetCustomAttributes(true))
		{
			AddtionalInfoAttribute info = attr as AddtionalInfoAttribute;

			if (info != null)
			{
				Console.WriteLine("Name = {0}, Update = {1}, DownLoad = {2}", info.Name, info.Update, info.Download);
			}
		}
	}
}