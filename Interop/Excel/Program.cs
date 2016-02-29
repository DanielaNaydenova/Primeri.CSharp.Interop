using System;

namespace Excel
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DataStruct data = new DataStruct ();
			IoWrite write = new IoWrite (data);

			//Набиране на данни в основната таблица
			data.addRow ("Даниела", "Найденова", "23");
			data.addRow ("Вуйчо", "Ваньо", "49");

			//Проверка на таблицата
			data.printTable ();

			write.exportTable ();
			write.runFile ();
		}
	}
}
