using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VilenkinTransform {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private List<int> p = new List<int>() { 4, 4, 4, 4, 4, 4};

		private String SeriesName = "Graph";
		private String TransformSeriesName = "Transform";
		private String gridName = "Graph grid";

		private void MainForm_Load(object sender, EventArgs e) {
			ExpansionBase expansionBase = new ExpansionBase(p);

			int K = 1;

			ParyX[] xs = ConstIntervalsUtils.Intervals(expansionBase, K);
			int P = p.ElementAt(K);
			Complex[] function = ConstIntervalsUtils.BuildConstFunc(xs);
			Complex[,] B;
			Complex[,] conjugatedRademacherMatrix;
			Complex[,] rademacherMatrix;
			Complex[,] FkValues = new Complex[expansionBase.Mk(K), P];
			Complex N = new Complex(1d / p.ElementAt(K), 0);
			ParyX[] subXs;
			Complex[] X;
			Complex[,] XMatrix;
			for (int i = 0; i < expansionBase.Mk(K); i++) {
				subXs = ArrayUtils.SubArray(xs, i * P, P);
				rademacherMatrix = MatrixUtils.BuildRadamacher(expansionBase, subXs, K);
				conjugatedRademacherMatrix = MatrixUtils.Conjugate(rademacherMatrix);
				MatrixUtils.Multiply(conjugatedRademacherMatrix, N);
				B = MatrixUtils.ToMatrix(ArrayUtils.SubArray(function, i * P, P));
				XMatrix = MatrixUtils.Multiply(conjugatedRademacherMatrix, B);
				X = ArrayUtils.ToArray(XMatrix);
				MatrixUtils.InsertVectorToMatrix(FkValues, X, i);
			}
			ParyX[] vilenkinXs = ConstIntervalsUtils.Intervals(expansionBase, K - 1);
			Complex[,] vilenkinMatrix = MatrixUtils.BuildVilenkin(expansionBase, vilenkinXs);
			Complex[,] conjugatedWMatrix = MatrixUtils.Conjugate(vilenkinMatrix);
			Complex WN = new Complex(1d / expansionBase.Mk(K), 0);
			MatrixUtils.Multiply(conjugatedWMatrix, WN);
			List<Complex> coeffs = new List<Complex>();
			Complex[,] C; 
			for (int i = 0; i < P; i++) {
				B = MatrixUtils.ColumnAsMatrix(FkValues, i);
				C = MatrixUtils.Multiply(conjugatedWMatrix, B);
				ArrayUtils.AddAll(ArrayUtils.ToArray(C), coeffs);
			}
			VilenkinTransform transform = new VilenkinTransform(expansionBase, coeffs);
			List<Complex> zeroCoeffs = TransformUtils.ZeroByPercent(coeffs, 50);//процент обнуления коэффициентов
			VilenkinTransform transformWithZeros = new VilenkinTransform(expansionBase, zeroCoeffs);
			AddSeries(SeriesName, SeriesChartType.Line, Color.Empty);
			AddSeries(TransformSeriesName, SeriesChartType.Point, Color.Red);
			ConfigGraph();
			chart.Series[SeriesName].ChartArea = gridName;
			chart.Series[TransformSeriesName].ChartArea = gridName;
			for (int i = 0; i < xs.Length; i++) {
				chart.Series[SeriesName].Points.AddXY(xs[i].GetX(), transform.Value(xs[i]).GetRe());
				chart.Series[TransformSeriesName].Points.AddXY(xs[i].GetX(), transformWithZeros.Value(xs[i]).GetRe());
			}
		}

		private void ConfigGraph() {
			ChartArea fixedGrid = chart.ChartAreas.Add(gridName);
			fixedGrid.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
			fixedGrid.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
			fixedGrid.AxisY.Interval = 0.25;
			fixedGrid.AxisX.Interval = 0.25;
			fixedGrid.AxisX.Maximum = 1;
			fixedGrid.AxisX.Minimum = 0;
			fixedGrid.AxisY.Maximum = 2;
			fixedGrid.AxisY.Minimum = -2;
		}

		private void AddSeries(string seriesName, SeriesChartType chartType, Color color) {
			chart.Series.Add(seriesName).ChartType = chartType;
			chart.Series[seriesName].IsVisibleInLegend = false;
			chart.Series[seriesName].MarkerSize= 3;
			if (color != Color.Empty) {
				chart.Series[seriesName].Color = color;
			}
		}
	}
}
