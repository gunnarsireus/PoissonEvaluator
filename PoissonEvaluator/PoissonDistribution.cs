using System;
using System.Collections.Generic;
using System.Text;

namespace PoissonEvaluator
{
	public class PoissonDistribution
	{
		double lambda;

		public PoissonDistribution(double lambda = 1.0)
		{
			this.lambda = lambda;
		}

		public double PMF(int k)
		{
			//(l^k / k! ) * e^-l
			//l = lamda
			double kFactorial = Factorial(k);
			double numerator = Math.Pow(Math.E, -lambda) * Math.Pow(lambda, k);

			double p = numerator / kFactorial;
			return p;
		}

		public double CDF(long k)
		{
			var e = Math.Pow(Math.E, -lambda);
			long i = 0;
			var sum = 0.0;
			var infinityIsFound = false;
			while (i <= k)
			{
				double n;
				if (infinityIsFound)
				{
					var a = Math.Log(i * (1 + 4 * i * (1 + 2 * i))) / 6;
					var b = Math.Log(Math.PI) / 2;
					var lnN = i * Math.Log(lambda) - (i * Math.Log(i) - i + a + b);
					var lnx = i * Math.Log(lambda) - i * Math.Log(i) + i - Math.Log(Math.Sqrt((2 * i + 1.0 / 3) * Math.PI));
					n = Math.Pow(Math.E, lnN - lambda);
				}
				else
				{
					if (i > 170 || double.IsInfinity(Math.Pow(lambda, i)))
					{
						infinityIsFound = true;
						var a = Math.Log(i * (1 + 4 * i * (1 + 2 * i))) / 6;
						var b = Math.Log(Math.PI) / 2;
						var lnN = i * Math.Log(lambda) - (i * Math.Log(i) - i + a + b);
						var lnx = i * Math.Log(lambda) - i * Math.Log(i) + i - Math.Log(Math.Sqrt((2 * i + 1.0 / 3) * Math.PI));
						n = Math.Pow(Math.E, lnN - lambda);
					}
					else
					{
						n = e * Math.Pow(lambda, i) / Factorial(i);
					}
				}

				sum += n;
				i++;
			}
			return (sum > 1) ? 1.0 : sum;
		}

		public double CDF0(long k)
		{
			var e = Math.Pow(Math.E, -lambda);
			long i = 0;
			var sum = 0.0;
			while (i <= k)
			{
				sum += e * Math.Pow(lambda, i) / Factorial(i);
				i++;
			}
			return sum;
		}

		public double Factorial(long k)
		{
			long count = k;
			double factorial = 1;
			while (count >= 1)
			{
				factorial = factorial * count;
				count--;
			}

			return factorial;
		}

		public double Factorial12(double k)
		{
			//var factorial = Math.Pow(Math.E, k * Math.Log(k)) * Math.Pow(Math.E, -k -1);
			var factorial = Math.Sqrt((2 * k + 1.0 / 3) * Math.PI) * Math.Pow(k, k) * Math.Pow(Math.E, -k);
			return factorial;
		}
		//https://en.wikipedia.org/wiki/Factorial
		//https://sv.wikipedia.org/wiki/Stirlings_formel
		public double Factorial1(long k)
		{
			//Srinivasa Ramanujan (Ramanujan 1988)
			return Math.Round(Math.Pow(Math.E, k * Math.Log(k) - k + Math.Log(k * (1 + 4 * k * (1 + 2 * k))) / 6 + Math.Log(Math.PI) / 2));

		}

	}
}
