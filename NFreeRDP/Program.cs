using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NFreeRDP
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindow());
		}
		int a = 4;
		int b = 5;
		int sum = a + b;
		Console.WriteLine("The sum of two numbers is: + sum");S
	}
	
}
