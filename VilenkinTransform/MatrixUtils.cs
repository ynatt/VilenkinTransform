using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VilenkinTransform {
	class MatrixUtils {

		public static Complex[,] BuildRadamacher(ExpansionBase expBase, ParyX[] intervals, int k) {
			int N = intervals.Length;
			Complex[,] matrix = new Complex[N, N];
			RademacherFunction r = new RademacherFunction(expBase, k);
			for (int i = 0; i < N; i++) {
				for (int j = 0; j < N; j++) {
					matrix[i, j] = r.Value(intervals[i], j);
				}
			}
			return matrix;
		}

		public static void ShowMatrix<T>(T[,] matrix){
			int N = matrix.GetLength(0);
			int M = matrix.GetLength(1);
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < N; i++) {
				for (int j = 0; j < M; j++) {
					sb.Append("[").Append(matrix[i,j]).Append("] ");
				}
				sb.AppendLine();
			}
			Console.Write(sb.ToString());
		}

		public static Complex[,] BuildVilenkin(ExpansionBase expBase, ParyX[] intervals) {
			int N = intervals.Length;
			Complex[,] matrix = new Complex[N, N];
			VilenkinFunction[] ws = new VilenkinFunction[N];
			for (int i = 0; i < N; i++) {
				ws[i] = new VilenkinFunction(expBase, new ParyN(expBase, i));
			}
			for (int i = 0; i < N; i++) {
				for (int j = 0; j < N; j++) {
					matrix[i, j] = ws[j].Value(intervals[i]);
				}
			}
			return matrix;
		}

		public static Complex[,] Multiply(Complex[,] a, Complex[,] b) {
			int aN = a.GetLength(0);
			int aM = a.GetLength(1);
			int bN = b.GetLength(0);
			int bM = b.GetLength(1);
			if (aM != bN) {
				throw new System.ArgumentException(String.Format("Не совпадают размерности матриц A.m = {0} B.n = {1}",aM, bN));
			}
			Complex[,] result = new Complex[aN, bM];
			for (int i = 0; i < aN; i++) {
				for (int j = 0; j < bM; j++) {
					result[i, j] = new Complex(0, 0);
					for (int k = 0; k < aM; k++) {
						result[i, j] += a[i, k] * b[k, j];
					}
				}
			}
			return result;
		}

		public static void Multiply(Complex[,] a, Complex n) {
			int aN = a.GetLength(0);
			int aM = a.GetLength(1);
			for (int i = 0; i < aN; i++) {
				for (int j = 0; j < aM; j++) {
					a[i, j] *= n; 
				}
			}
		}

		public static Complex[,] Conjugate(Complex[,] a) {
			int aN = a.GetLength(0);
			int aM = a.GetLength(1);
			Complex[,] result = new Complex[aN, aM];
			for (int i = 0; i < aN; i++) {
				for (int j = 0; j < aM; j++) {
					result[i, j] = a[i, j].Conjugate();
				}
			}
			return result;
		}


		public static Complex[,] ToMatrix(Complex[] vector) {
			Complex[,] matrix = new Complex[vector.Length, 1];
			for (int i = 0; i < vector.Length; i++) {
				matrix[i, 0] = vector[i];
			}
			return matrix;
		}

		public static void InsertVectorToMatrix(Complex[,] matrix, Complex[] vector, int column) {
			int n = matrix.GetLength(0);
			int m = matrix.GetLength(1);
			int l = vector.Length;
			if (column > n - 1 || column < 0 || l > m) {
				throw new System.ArgumentException("Неудается вставить вектор в матрицу так так не совпадают размерности");
			}
			for (int i = 0; i < l; i++) {
				matrix[column, i] = vector[i];
			}
		}

		public static Complex[,] ColumnAsMatrix(Complex[,] matrix, int column) {
			Complex[,] result = new Complex[matrix.GetLength(0), 1];
			for (int i = 0; i < matrix.GetLength(0); i++) {
				result[i, 0] = matrix[i, column];
			}
			return result;
		}
	}
}
