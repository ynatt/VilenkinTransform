using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFT_App {
	class FunctionBuilder {

		public static Complex[] BuildRealSin(double a, double b, int N) {
			double h = (b - a) / N;
			double x = a;
			Complex[] func = new Complex[N];
			for (int i = 0; i < N; i++) {
				func[i] = new Complex(Math.Sin(x), 0);
				x += h;
			}
			return func;
		}

		public static Complex[] BuildRealPow(double a, double b, int N, int pow) {
			double h = (b - a) / N;
			double x = a;
			Complex[] func = new Complex[N];
			for (int i = 0; i < N; i++) {
				func[i] = new Complex(Math.Pow(x, pow), 0);
				x += h;
			}
			return func;
		}

	}
}
