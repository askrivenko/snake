﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Snake
{
	class Program
	{
		static void Main(string[] args)
		{

			Draw(2, 1, '*');

			Console.ReadKey();
		}

		static void Draw(int x, int y, char sym)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}
	}
}
