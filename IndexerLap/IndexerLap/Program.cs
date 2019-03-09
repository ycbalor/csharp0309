//// 1번
//using System;
//class DataStore<T>
//{
//	private T[] s = new T[10];

//	public T this[int index]
//	{
//		get
//		{
//			if (index < 0 || index >= s.Length)
//				throw new IndexOutOfRangeException("Cannot store more than 10 objects");
//			return s[index];
//		}
//		set
//		{
//			if (index < 0 || index >= s.Length)
//				throw new IndexOutOfRangeException("Cannot store more than 10 objects");
//			s[index] = value;
//		}
//	}
//}

//class Program
//{
//	static void Main(string[] args)
//	{
//		DataStore<string> ds1 = new DataStore<string>();
//		ds1[0] = "One";
//		ds1[1] = "Two";
//		ds1[2] = "Three";
//		for (int i = 0; i < 3; i++)
//			Console.WriteLine(ds1[i]);

//		DataStore<int> ds2 = new DataStore<int>();
//		ds2[0] = 1;
//		ds2[1] = 2;
//		ds2[2] = 3;
//		for (int i = 0; i < 3; i++)
//			Console.WriteLine(ds2[i]);
//		ds2[11] = 11;
//	}
//} 

//// 2번
//using System;
//class DataStore
//{
//	private string[] strArr = new string[10]; // internal data storage

//	public DataStore() { }

//	public string this[int index]
//	{
//		get
//		{
//			if (index < 0 || index >= strArr.Length)
//				throw new IndexOutOfRangeException("Cannot store more than 10 objects");
//			return strArr[index];
//		}
//		set
//		{
//			if (index < 0 || index >= strArr.Length)
//				throw new IndexOutOfRangeException("Cannot store more than 10 objects");
//			strArr[index] = value;

//		}
//	}

//	// 인덱서도 String으로 넣어서 가능하다.
//	public string this[string name]
//	{
//		get
//		{
//			foreach (string s in strArr)
//			{
//				if (s.ToLower() == name.ToLower())
//					return s;
//			}
//			return null;
//		}
//	}
//}


//class Program
//{
//	static void Main(string[] args)
//	{
//		DataStore strStore = new DataStore();

//		strStore[0] = "One";
//		strStore[1] = "Two";
//		strStore[2] = "Three";
//		strStore[3] = "Four";

//		Console.WriteLine(strStore["one"]);
//		Console.WriteLine(strStore["two"]);
//		Console.WriteLine(strStore["Three"]);
//		Console.WriteLine(strStore["FOUR"]);
//	}
//}



// 3번
using System;
class OvrIndexer
{
	private string[] myData;
	private int arrSize;

	public OvrIndexer(int size)
	{
		arrSize = size;
		myData = new string[arrSize];

		for (int i = 0; i < size; i++)
		{
			//myData setting
			myData[i] = "empty";
		}
	}

	public string this[int pos]
	{
		get
		{
			return myData[pos];
		}
		set
		{
			myData[pos] = value;
		}
	}

	public string this[string data]
    {
		get
        {
			int count = 0;

            for (int i = 0; i<arrSize; i++)
            {
                if (myData[i] == data)
                {
                    count++;
                }
            }
            return count.ToString();
        }
        set
        {
            for (int i = 0; i<arrSize; i++)
            {
                if (myData[i] == data)
                {
					myData[i] = value;
                }
            }
        }
    }



    static void Main(string[] args)
	{
		int size = 10;
		OvrIndexer myInd = new OvrIndexer(size);

		myInd[9] = "Some Value";
		myInd[3] = "Another Value";
		myInd[5] = "Any Value";
		myInd["empty"] = "no value";

		Console.WriteLine("\nIndexer Output\n");

		for (int i = 0; i < size; i++)
		{
			Console.WriteLine("myInd[{0}]: {1}", i, myInd[i]);
		}

		Console.WriteLine("\nNumber of \"no value\" entries: {0}", myInd["no value"]);

	}
}