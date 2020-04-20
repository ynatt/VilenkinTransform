﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VilenkinTransform {
	class VilenkinFunction {
		private ParyN n;

		private ExpansionBase ExpBase;

		private List<RademacherFunction> Rj;

		public VilenkinFunction(ExpansionBase expBase, ParyN n) {
			Rj = new List<RademacherFunction>();
			List<int> notZeroIndexes = n.GetNotZeroCoeffs();
			foreach (int j in notZeroIndexes) {
				Rj.Add(new RademacherFunction(expBase, j));
			}
			ExpBase = expBase;
			this.n = n;
		}

		public Complex Value(ParyX x) {
			Complex value = new Complex(1, 0);
			for (int j = 0; j < Rj.Count; j++) {
				value *=(Rj[j].Value(x, n.Ak(Rj[j].GetK())));
			}
			return value;
		}
	}
}
