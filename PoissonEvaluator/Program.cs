using System;
using PoissonEvaluator;

namespace PoissonEvaaluator
{
	class Program
	{
		static void Main(string[] args)
		{
			var poisson = new PoissonDistribution(9);
			//Console.WriteLine("CDF 1 : " + poisson.Cdf(1) + ", CDF0: " + poisson.Cdf0(1));
			//Console.WriteLine("CDF 5 : " + poisson.Cdf(5) + ", CDF0: " + poisson.Cdf0(5));
			//Console.WriteLine("CDF 7 : " + poisson.Cdf(7) + ", CDF0: " + poisson.Cdf0(7));
			//Console.WriteLine("CDF 9 : " + poisson.Cdf(9) + ", CDF0: " + poisson.Cdf0(9));
			//Console.WriteLine("CDF 10 : " + poisson.Cdf(10) + ", CDF0: " + poisson.Cdf0(10));
			//Console.WriteLine("CDF 12 : " + poisson.Cdf(12) + ", CDF0: " + poisson.Cdf0(12));
			//Console.WriteLine("CDF 14 : " + poisson.Cdf(14) + ", CDF0: " + poisson.Cdf0(14));
			//Console.WriteLine("CDF 15 : " + poisson.Cdf(15) + ", CDF0 :" + poisson.Cdf0(15));
			//Console.WriteLine("CDF 27 : " + poisson.Cdf(27) + ", CDF0 :" + poisson.Cdf0(27));
			//Console.WriteLine("CDF 20 : " + poisson.Cdf(20) + ", CDF0 :" + poisson.Cdf0(20));
			//Console.WriteLine("----PoissonDistribution(1800)---");
			//poisson = new PoissonDistribution(1800);
			//Console.WriteLine("CDF 100 : " + poisson.Cdf(100) + ", CDF1: " + poisson.Cdf1(100));
			//Console.WriteLine("CDF 500 : " + poisson.Cdf(500) + ", CDF1: " + poisson.Cdf1(500));
			//Console.WriteLine("CDF 700 : " + poisson.Cdf(700) + ", CDF1: " + poisson.Cdf1(700));
			//Console.WriteLine("CDF 900 : " + poisson.Cdf(900) + ", CDF1: " + poisson.Cdf1(900));
			//Console.WriteLine("CDF 1000 : " + poisson.Cdf(1000) + ", CDF1: " + poisson.Cdf1(1000));
			//Console.WriteLine("CDF 1200 : " + poisson.Cdf(1200) + ", CDF1: " + poisson.Cdf1(1200));
			//Console.WriteLine("CDF 1400 : " + poisson.Cdf(1400) + ", CDF1: " + poisson.Cdf1(1400));
			//Console.WriteLine("CDF 1500 : " + poisson.Cdf(1500) + ", CDF1 :" + poisson.Cdf1(1500));
			//Console.WriteLine("CDF 1700 : " + poisson.Cdf(1700) + ", CDF1 :" + poisson.Cdf1(1700));
			//Console.WriteLine("CDF 1900 : " + poisson.Cdf(1900) + ", CDF1 :" + poisson.Cdf1(1900));
			//Console.WriteLine("CDF 2100 : " + poisson.Cdf(2100) + ", CDF1 :" + poisson.Cdf1(2100));
			//Console.WriteLine("CDF 2300 : " + poisson.Cdf(2300) + ", CDF1 :" + poisson.Cdf1(2300));
			//Console.WriteLine("CDF 2500 : " + poisson.Cdf(2500) + ", CDF1 :" + poisson.Cdf1(2500));
			Console.WriteLine("CDF 2700 : " + poisson.Cdf(2700) + ", CDF1 :" + poisson.Cdf1(2700));

			for (int i = 3; i < 300; i++)
			{
				var d = poisson.Factorial(i) - poisson.Factorial1(i);
				Console.WriteLine("i: " + i + ", Factorial: " + poisson.Factorial(i) + ", Factorial1: " + poisson.Factorial1(i) + ", diff: " + d);
			}

			//for (int i = 3; i < 160; i++)
			//{
			//	Console.WriteLine("i: " + i + ", PMF: " + poisson.Pmf(i));
			//}
			Console.ReadKey();
		}
	}
}
