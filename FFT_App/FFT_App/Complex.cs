using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFT_App {
	class Complex : IComparable<Complex> {
		public readonly double Re;
		public readonly double Im;

		public Complex(double Re, double Im) {
			this.Re = Re;
			this.Im = Im;
		}

		public int CompareTo(Complex other) {
			return this.Module() >= other.Module() ? 1 : -1;
		}

		public double Module() {
			return Math.Sqrt(this.Re * this.Re + this.Im * this.Im);
		}
	}
}
