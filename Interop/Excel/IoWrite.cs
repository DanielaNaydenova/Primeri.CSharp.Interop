﻿using System;
using InteropExcel = Microsoft.Office.Interop.Excel;

namespace Excel
{
	public class IoWrite
	{
		private DataStruct _data;
		private InteropExcel.Application excel;

		public IoWrite (DataStruct data)
		{
		}

		public bool exportTable ()
		{
			try {
				//Междинни проверки


				return true;
			}catch{
			}

			return false;
		}

		public void addRow (DataRow _row)
		{
			try {

			}catch{
			}
		}

		public void runFile ()
		{
			try {
				System.Diagnostics.Process.Start (getPath ());
			}catch{
			}
		}

		private string getPath ()
		{
			return System.IO.Path.Combine (AppDomain.CurrentDomain.BaseDirectory, "table1.xlsx");
		}
	}
}

