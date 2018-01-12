using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
	class Program
	{
		static void Main(string[] args)
		{
			var s = System.Configuration.ConfigurationManager.AppSettings["test"];
			Console.WriteLine(s);
			Console.ReadLine();
		}

		static void test5_1()
		{
			var s = "";
		}

	}
}
