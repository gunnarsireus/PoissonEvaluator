using System;
using PoissonEvaluator;

namespace PoissonEvaaluator
{
	class Program
	{
		static void Main(string[] args)
		{
			var poisson = new PoissonDistribution(9);
			//Console.WriteLine("CDF 1 : " + poisson.CDF(1) + ", CDF0: " + poisson.CDF0(1));
			//Console.WriteLine("CDF 5 : " + poisson.CDF(5) + ", CDF0: " + poisson.CDF0(5));
			//Console.WriteLine("CDF 7 : " + poisson.CDF(7) + ", CDF0: " + poisson.CDF0(7));
			//Console.WriteLine("CDF 9 : " + poisson.CDF(9) + ", CDF0: " + poisson.CDF0(9));
			//Console.WriteLine("CDF 10 : " + poisson.CDF(10) + ", CDF0: " + poisson.CDF0(10));
			//Console.WriteLine("CDF 12 : " + poisson.CDF(12) + ", CDF0: " + poisson.CDF0(12));
			//Console.WriteLine("CDF 14 : " + poisson.CDF(14) + ", CDF0: " + poisson.CDF0(14));
			//Console.WriteLine("CDF 15 : " + poisson.CDF(15) + ", CDF0 :" + poisson.CDF0(15));
			//Console.WriteLine("CDF 27 : " + poisson.CDF(27) + ", CDF0 :" + poisson.CDF0(27));
			//Console.WriteLine("CDF 20 : " + poisson.CDF(20) + ", CDF0 :" + poisson.CDF0(20));
			//Console.WriteLine("----PoissonDistribution(90)---");
			//poisson = new PoissonDistribution(90);
			//Console.WriteLine("CDF 10 : " + poisson.CDF(10) + ", CDF0: " + poisson.CDF0(10));
			//Console.WriteLine("CDF 50 : " + poisson.CDF(50) + ", CDF0: " + poisson.CDF0(50));
			//Console.WriteLine("CDF 70 : " + poisson.CDF(70) + ", CDF0: " + poisson.CDF0(70));
			//Console.WriteLine("CDF 90 : " + poisson.CDF(90) + ", CDF0: " + poisson.CDF0(90));
			//Console.WriteLine("CDF 100 : " + poisson.CDF(100) + ", CDF0: " + poisson.CDF0(100));
			//Console.WriteLine("CDF 120 : " + poisson.CDF(120) + ", CDF0: " + poisson.CDF0(120));
			//Console.WriteLine("CDF 140 : " + poisson.CDF(140) + ", CDF0: " + poisson.CDF0(140));
			//Console.WriteLine("CDF 150 : " + poisson.CDF(150) + ", CDF0 :" + poisson.CDF0(150));
			//Console.WriteLine("CDF 170 : " + poisson.CDF(170) + ", CDF0 :" + poisson.CDF0(170));
			//Console.WriteLine("CDF 190 : " + poisson.CDF(190) + ", CDF0 :" + poisson.CDF0(190));
			//Console.WriteLine("CDF 210 : " + poisson.CDF(210) + ", CDF0 :" + poisson.CDF0(210));
			//Console.WriteLine("CDF 230 : " + poisson.CDF(230) + ", CDF0 :" + poisson.CDF0(230));
			//Console.WriteLine("CDF 250 : " + poisson.CDF(250) + ", CDF0 :" + poisson.CDF0(250));
			Console.WriteLine("CDF 270 : " + poisson.CDF(270) + ", CDF0 :" + poisson.CDF0(270));

			//for (int i = 3; i < 160; i++)
			//{
			//	Console.WriteLine("i: " + i + ", Factorial: " + poisson.Factorial(i) + ", Factorial1: " + poisson.Factorial1(i) + ", diff: " + (poisson.Factorial(i) - poisson.Factorial1(i)));
			//}

			for (int i = 3; i < 160; i++)
			{
				Console.WriteLine("i: " + i + ", PMF: " + poisson.PMF(i));
			}
			Console.ReadKey();
		}
	}
}
