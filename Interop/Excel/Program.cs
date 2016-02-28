using System;

namespace Excel
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DataStruct data = new DataStruct ();
			IoWrite write = new IoWrite (data);
			Console.WriteLine ("Hello World!");
		}
	}
}
