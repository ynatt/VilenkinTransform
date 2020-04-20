using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFT_App {
	class CompressUtils {
		public static Complex[] ZeroByPercent(Complex[] vector, double percent, out double[] top3) {
			List<KeyValuePair<int, Complex>> temp = new List<KeyValuePair<int, Complex>>(vector.Length);
			for (int i = 0; i < vector.Length; i++) {
				temp.Add(new KeyValuePair<int, Complex>(i, vector[i]));
			}
			Complex[] result = new Complex[vector.Length];
			int countToZero = (int) (percent / 100 * vector.Length);
			Complex zero = new Complex(0, 0);
			temp.Sort(delegate (KeyValuePair<int, Complex> p1, KeyValuePair<int, Complex> p2) { return p1.Value.CompareTo(p2.Value); });
			KeyValuePair<int, Complex> tempComplex;
			top3 = new double[3];
			for (int i = temp.Count - 1, j = 0; i >= temp.Count - 3 && j < 3; i--, j++) {
				top3[j] = temp.ElementAt(i).Value.Module();
			}
			for (int i = 0; i < countToZero; i++) {
				tempComplex = temp.ElementAt(i);
				temp.RemoveAt(i);
				temp.Insert(i, new KeyValuePair<int, Complex>(tempComplex.Key, zero));
			}
			foreach (KeyValuePair<int, Complex> pair in temp) {
				result[pair.Key] = pair.Value;
			}
			return result;
		}
	}
}
