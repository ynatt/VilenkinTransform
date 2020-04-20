using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FFT_App {
	public partial class FFT_App : Form {
		public FFT_App() {
			InitializeComponent();
		}

		String SeriesName = "Random Complex";
		String transform = "Transform";
		String ChartAreaName = "Fixed Grid";

		private ChartArea fixedGrid;

		private void Form1_Load(object sender, EventArgs e) {
			AddSeries(SeriesName);
			AddSeries(transform);
			ConfigGrid(ChartAreaName);
			chart.Series[SeriesName].ChartArea = ChartAreaName;
			chart.Series[transform].ChartArea = ChartAreaName;
		}

		private void AddSeries(string seriesName) {
			chart.Series.Add(seriesName).ChartType = SeriesChartType.Point;
			chart.Series[seriesName].IsVisibleInLegend = false;
		}

		private void ConfigGrid(string gridName) {
			fixedGrid = chart.ChartAreas.Add(gridName);
			fixedGrid.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
			fixedGrid.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
			fixedGrid.AxisY.Interval = 1;
			fixedGrid.AxisX.Interval = 1;
			fixedGrid.AxisX.Maximum = ReadB();
			fixedGrid.AxisX.Minimum = ReadA();
		}

		private int ReadDim() {
			int result;
			if (int.TryParse(dim_box.Text, out result)) {
				return result;
			} else {
				throw new FormatException("Wrong dim");
			}
		}

		private double ReadA() {
			return double.Parse(textBox_a.Text);
		}

		private double ReadB() {
			return double.Parse(textBox_b.Text);
		}

		private double ReadPercent() {
			return double.Parse(textBox_percent.Text);
		}

		private int ReadPow() {
			return int.Parse(textBox_xPow.Text);
		}

		private void button_count_Click(object sender, EventArgs e) {
			chart.Series[SeriesName].Points.Clear();
			chart.Series[transform].Points.Clear();
			Complex[] function;
			if (checkBox_useReal.Checked) {
				function = countRealFunction(); 
			} else {
				function = ComplexBuilder.buildRandom(ReadA(), ReadB(), ReadDim());
			}
			Complex[] transformRandom = TransformUtils.InverseTransform(function);
			double[] top3;
			Complex[] compressed = CompressUtils.ZeroByPercent(transformRandom, ReadPercent(), out top3);
			Complex[] compressedFunction = TransformUtils.ForvardTransform(compressed);
			setTop3(top3);
			Complex point;
			if (checkBox_useReal.Checked) {
				chart.Series[transform].ChartType = SeriesChartType.Line;
				double h = (ReadB() - ReadA()) / ReadDim();
				double x = ReadA();
				for (int i = 0; i < function.Length; i++) {
					point = function[i];
					chart.Series[SeriesName].Points.AddXY(x, point.Re);
					chart.Series[transform].Points.AddXY(x, compressedFunction[i].Re);
					x += h;
				}
			} else {
				for (int i = 0; i < function.Length; i++) {
					point = function[i];
					chart.Series[SeriesName].Points.AddXY(point.Re, point.Im);
					chart.Series[transform].Points.AddXY(compressedFunction[i].Re, compressedFunction[i].Im);
				}
			}
		}

		private void setTop3(double[] top3) {
			label_top1.Text = string.Format("{0:F3}",top3[0]);
			label_top2.Text = string.Format("{0:F3}",top3[1]);
			label_top3.Text = string.Format("{0:F3}",top3[2]);
		}

		private Complex[] countRealFunction() {
			if (checkBox_sin.Checked) {
				return FunctionBuilder.BuildRealSin(ReadA(), ReadB(), ReadDim());
			}
			if (checkBox_xPow.Checked) {
				return FunctionBuilder.BuildRealPow(ReadA(), ReadB(), ReadDim(), ReadPow());
			}
			return null;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e) {
			if (((CheckBox)sender).Checked) {
				checkBox_sin.Visible = true;
				checkBox_sin.Checked = true;
				checkBox_xPow.Visible = true;
				textBox_xPow.Visible = true;
				label_xPow.Visible = true;
			} else {
				checkBox_sin.Visible = false;
				checkBox_xPow.Visible = false;
				textBox_xPow.Visible = false;
				label_xPow.Visible = false;
			}
		}

		private void textBox_a_TextChanged(object sender, EventArgs e) {
			fixedGrid.AxisX.Minimum = ReadA();
		}

		private void textBox_b_TextChanged(object sender, EventArgs e) {
			fixedGrid.AxisX.Maximum = ReadB();
		}
	}
}
