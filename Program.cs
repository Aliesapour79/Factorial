using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace func 
{
	class Program
	{
		static void Main(string[] args)
		{
			var func = new Class1();
			int b;
			int read;
			Console.Write("INSERT NUMBER = ");
			read=int.Parse(Console.ReadLine());
			b=read;
			read = func.fact(b);
			Console.WriteLine("Factorial = {0}",read);
			
			Console.ReadKey();
		}
		
	}
}
