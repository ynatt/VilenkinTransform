using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFT_App {
	class TransformUtils {
		public static Complex[] ForvardTransform(Complex[] vector) {
			int N = vector.Length;
			double delta = 1 / Math.Sqrt(N);
			Complex[] result = new Complex[N];
			double x = 0;
			double y = 0;
			double cos = 0;
			double sin = 0;
			double c = 2 * Math.PI / N;
			for (int k = 0; k < N; k++) {
				for(int j = 0; j < N; j++) {
					cos = Math.Cos(c * j * k);
					sin = Math.Sin(c * j * k);
					x += vector[j].Re * cos + vector[j].Im * sin;
					y += vector[j].Im * cos - vector[j].Re * sin;
				}
				result[k] = new Complex(delta * x, delta * y);
				x = 0;
				y = 0;
			}
			return result;
		}

		public static Complex[] InverseTransform(Complex[] vector) {
			int N = vector.Length;
			double delta = 1 / Math.Sqrt(N);
			Complex[] result = new Complex[N];
			double x = 0;
			double y = 0;
			double cos = 0;
			double sin = 0;
			double c = 2 * Math.PI / N;
			for (int k = 0; k < N; k++) {
				for (int j = 0; j < N; j++) {
					cos = Math.Cos(c * j * k);
					sin = Math.Sin(c * j * k);
					x += vector[j].Re * cos - vector[j].Im * sin;
					y += vector[j].Im * cos + vector[j].Re * sin;
				}
				result[k] = new Complex(delta * x, delta * y);
				x = 0;
				y = 0;
			}
			return result;
		}
	}
}
