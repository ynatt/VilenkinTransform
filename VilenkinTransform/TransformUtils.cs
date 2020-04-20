using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VilenkinTransform {
	class TransformUtils {

		public static List<Complex> ZeroByPercent(List<Complex> coeffs, double percent) {
			List<KeyValuePair<int, Complex>> temp = new List<KeyValuePair<int, Complex>>(coeffs.Count);
			for (int i = 0; i < coeffs.Count; i++) {
				temp.Add(new KeyValuePair<int, Complex>(i, coeffs[i]));
			}
			Complex[] result = new Complex[coeffs.Count];
			int countToZero = (int)(percent / 100 * coeffs.Count);
			Complex zero = new Complex(0, 0);
			temp.Sort(delegate (KeyValuePair<int, Complex> p1, KeyValuePair<int, Complex> p2) { return p1.Value.CompareTo(p2.Value); });
			KeyValuePair<int, Complex> tempComplex;
			for (int i = 0; i < countToZero; i++) {
				tempComplex = temp.ElementAt(i);
				temp.RemoveAt(i);
				temp.Insert(i, new KeyValuePair<int, Complex>(tempComplex.Key, zero));
			}
			foreach (KeyValuePair<int, Complex> pair in temp) {
				result[pair.Key] = pair.Value;
			}
			return result.ToList();
		}
	}
}
