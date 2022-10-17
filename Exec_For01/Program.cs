using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 倒星形三角形
			int rows = 5;
			for (int i = rows; i > 0; i--)
			{
				string row = new string('*', i);
				Console.WriteLine(row);
			}
		}
	}
}
