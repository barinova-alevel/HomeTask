using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arcanoid
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
			new Engine(Console.WindowWidth-1,Console.WindowHeight-1).Run();
			//new Engine(10, 10).Run();
		}
	}
}
