using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFT_App {
	class ComplexBuilder {
		public static Complex[] buildRandom(double a, double b, int n) {
			Complex[] result = new Complex[n];
			Random random = new Random();
			for (int i = 0; i < n; i++) {
				result[i] = new Complex(a + random.NextDouble() * Math.Abs(b - a),
									a + random.NextDouble() * Math.Abs(b - a));
			}
			return result;
		}
	}
}
