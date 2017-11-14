using System;
using PoissonEvaluator;

namespace PoissonEvaaluator
{
	class Program
	{
		static void Main(string[] args)
		{
			var poisson = new PoissonDistribution(9);
			Console.WriteLine("CDF 1 : " + poisson.CDF(1) + ", CDF0: " + poisson.CDF0(1));
			Console.WriteLine("CDF 5 : " + poisson.CDF(5) + ", CDF0: " + poisson.CDF0(5));
			Console.WriteLine("CDF 7 : " + poisson.CDF(7) + ", CDF0: " + poisson.CDF0(7));
			Console.WriteLine("CDF 9 : " + poisson.CDF(9) + ", CDF0: " + poisson.CDF0(9));
			Console.WriteLine("CDF 10 : " + poisson.CDF(10) + ", CDF0: " + poisson.CDF0(10));
			Console.WriteLine("CDF 12 : " + poisson.CDF(12) + ", CDF0: " + poisson.CDF0(12));
			Console.WriteLine("CDF 14 : " + poisson.CDF(14) + ", CDF0: " + poisson.CDF0(14));
			Console.WriteLine("CDF 15 : " + poisson.CDF(15) + ", CDF0 :" + poisson.CDF0(15));
			Console.WriteLine("CDF 27 : " + poisson.CDF(27) + ", CDF0 :" + poisson.CDF0(27));
			Console.WriteLine("CDF 20 : " + poisson.CDF(20) + ", CDF0 :" + poisson.CDF0(20));
			Console.WriteLine("----PoissonDistribution(1800)---");
			poisson = new PoissonDistribution(1800);
			Console.WriteLine("CDF 100 : " + poisson.CDF(100) + ", CDF1: " + poisson.CDF1(100));
			Console.WriteLine("CDF 500 : " + poisson.CDF(500) + ", CDF1: " + poisson.CDF1(500));
			Console.WriteLine("CDF 700 : " + poisson.CDF(700) + ", CDF1: " + poisson.CDF1(700));
			Console.WriteLine("CDF 900 : " + poisson.CDF(900) + ", CDF1: " + poisson.CDF1(900));
			Console.WriteLine("CDF 1000 : " + poisson.CDF(1000) + ", CDF1: " + poisson.CDF1(1000));
			Console.WriteLine("CDF 1200 : " + poisson.CDF(1200) + ", CDF1: " + poisson.CDF1(1200));
			Console.WriteLine("CDF 1400 : " + poisson.CDF(1400) + ", CDF1: " + poisson.CDF1(1400));
			Console.WriteLine("CDF 1500 : " + poisson.CDF(1500) + ", CDF1 :" + poisson.CDF1(1500));
			Console.WriteLine("CDF 1700 : " + poisson.CDF(1700) + ", CDF1 :" + poisson.CDF1(1700));
			Console.WriteLine("CDF 1900 : " + poisson.CDF(1900) + ", CDF1 :" + poisson.CDF1(1900));
			Console.WriteLine("CDF 2100 : " + poisson.CDF(2100) + ", CDF1 :" + poisson.CDF1(2100));
			Console.WriteLine("CDF 2300 : " + poisson.CDF(2300) + ", CDF1 :" + poisson.CDF1(2300));
			Console.WriteLine("CDF 2500 : " + poisson.CDF(2500) + ", CDF1 :" + poisson.CDF1(2500));
			Console.WriteLine("CDF 2700 : " + poisson.CDF(2700) + ", CDF1 :" + poisson.CDF1(2700));

			//for (int i = 100; i < 300; i++)
			//{
			//	var d = poisson.Factorial(i) - poisson.Factorial1(i);
			//	Console.WriteLine("i: " + i + ", Factorial: " + poisson.Factorial(i) + ", Factorial1: " + poisson.Factorial1(i) + ", diff: " + d);
			//}

			//for (int i = 3; i < 160; i++)
			//{
			//	Console.WriteLine("i: " + i + ", PMF: " + poisson.PMF(i));
			//}
			Console.ReadKey();
		}
	}
}
