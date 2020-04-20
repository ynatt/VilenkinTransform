using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VilenkinTransform {
	class Complex {
		private readonly double Re;
		private readonly double Im;
		private const String FORMAT_POSITIVE = "({0} + i{1})";
		private const String FORMAT_NEGATIVE = "({0} - i{1})";
		private readonly bool IsImPositive;

		public Complex(double Re, double Im) {
			this.Re = RoundZero(Re);
			this.Im = RoundZero(Im);
			IsImPositive = Im >= 0;
		}

		private double RoundZero(double x) {
			if (Math.Abs(x) < 0.00000000000001) {
				return 0;
			} else {
				return x;
			}
		}

		public double GetRe() {
			return Re;
		}

		public double GetIm() {
			return Im;
		}

		public override string ToString() {
			if (IsImPositive) {
				return String.Format("({0} + i{1})", Re, Im);
			} else {
				return String.Format("({0} - i{1})", Re, Math.Abs(Im));
			}
		}

		public Complex Multipy(Complex z) {
			return new Complex(this.Re * z.Re - this.Im * z.Im, this.Re * z.Im + this.Im * z.Re);
		}

		public static Complex operator *(Complex a, Complex b) {
			return new Complex(a.Re * b.Re - a.Im * b.Im, a.Re * b.Im + a.Im * b.Re);
		}

		public static Complex operator +(Complex a, Complex b) {
			return new Complex(a.Re + b.Re, a.Im + b.Im);
		}

		public Complex Conjugate() {
			return new Complex(this.Re, -this.Im);
		}

		public int CompareTo(Complex other) {
			return this.Module() >= other.Module() ? 1 : -1;
		}

		public double Module() {
			return Math.Sqrt(this.Re * this.Re + this.Im * this.Im);
		}
	}
}
