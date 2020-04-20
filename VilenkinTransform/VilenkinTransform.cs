using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VilenkinTransform {
	class VilenkinTransform {

		private List<Complex> coeffs;

		private Dictionary<int, VilenkinFunction> vilenkinFunctions;

		public VilenkinTransform(ExpansionBase expansionBase, List<Complex> coeffs) {
			this.coeffs = coeffs;
			vilenkinFunctions = new Dictionary<int, VilenkinFunction>();
			for (int i = 0; i < coeffs.Count; i++) {
				vilenkinFunctions.Add(i, new VilenkinFunction(expansionBase, new ParyN(expansionBase, i)));
			}
		}

		public Complex Value(ParyX x) {
			Complex value = new Complex(0, 0);
			for (int i = 0; i < coeffs.Count; i++) {
				value += coeffs.ElementAt(i) * vilenkinFunctions[i].Value(x);
			}
			return value;
		}
	}
}
