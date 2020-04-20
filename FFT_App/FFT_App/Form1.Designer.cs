namespace FFT_App {
	partial class FFT_App {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			this.controlsBox = new System.Windows.Forms.GroupBox();
			this.label_xPow = new System.Windows.Forms.Label();
			this.textBox_xPow = new System.Windows.Forms.TextBox();
			this.checkBox_xPow = new System.Windows.Forms.CheckBox();
			this.checkBox_sin = new System.Windows.Forms.CheckBox();
			this.checkBox_useReal = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_percent = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.labelA = new System.Windows.Forms.Label();
			this.textBox_b = new System.Windows.Forms.TextBox();
			this.textBox_a = new System.Windows.Forms.TextBox();
			this.button_count = new System.Windows.Forms.Button();
			this.label_dim = new System.Windows.Forms.Label();
			this.dim_box = new System.Windows.Forms.TextBox();
			this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label = new System.Windows.Forms.Label();
			this.label_top1 = new System.Windows.Forms.Label();
			this.label_top2 = new System.Windows.Forms.Label();
			this.label_top3 = new System.Windows.Forms.Label();
			this.controlsBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			this.SuspendLayout();
			// 
			// controlsBox
			// 
			this.controlsBox.Controls.Add(this.label_top3);
			this.controlsBox.Controls.Add(this.label_top2);
			this.controlsBox.Controls.Add(this.label_top1);
			this.controlsBox.Controls.Add(this.label);
			this.controlsBox.Controls.Add(this.label_xPow);
			this.controlsBox.Controls.Add(this.textBox_xPow);
			this.controlsBox.Controls.Add(this.checkBox_xPow);
			this.controlsBox.Controls.Add(this.checkBox_sin);
			this.controlsBox.Controls.Add(this.checkBox_useReal);
			this.controlsBox.Controls.Add(this.label1);
			this.controlsBox.Controls.Add(this.textBox_percent);
			this.controlsBox.Controls.Add(this.label2);
			this.controlsBox.Controls.Add(this.labelA);
			this.controlsBox.Controls.Add(this.textBox_b);
			this.controlsBox.Controls.Add(this.textBox_a);
			this.controlsBox.Controls.Add(this.button_count);
			this.controlsBox.Controls.Add(this.label_dim);
			this.controlsBox.Controls.Add(this.dim_box);
			this.controlsBox.Location = new System.Drawing.Point(12, 12);
			this.controlsBox.Name = "controlsBox";
			this.controlsBox.Size = new System.Drawing.Size(475, 117);
			this.controlsBox.TabIndex = 0;
			this.controlsBox.TabStop = false;
			this.controlsBox.Text = "Controls";
			// 
			// label_xPow
			// 
			this.label_xPow.AutoSize = true;
			this.label_xPow.Location = new System.Drawing.Point(294, 73);
			this.label_xPow.Name = "label_xPow";
			this.label_xPow.Size = new System.Drawing.Size(13, 13);
			this.label_xPow.TabIndex = 13;
			this.label_xPow.Text = "n";
			// 
			// textBox_xPow
			// 
			this.textBox_xPow.Location = new System.Drawing.Point(258, 70);
			this.textBox_xPow.Name = "textBox_xPow";
			this.textBox_xPow.Size = new System.Drawing.Size(30, 20);
			this.textBox_xPow.TabIndex = 12;
			this.textBox_xPow.Text = "3";
			// 
			// checkBox_xPow
			// 
			this.checkBox_xPow.AutoSize = true;
			this.checkBox_xPow.Location = new System.Drawing.Point(209, 73);
			this.checkBox_xPow.Name = "checkBox_xPow";
			this.checkBox_xPow.Size = new System.Drawing.Size(43, 17);
			this.checkBox_xPow.TabIndex = 11;
			this.checkBox_xPow.Text = "x^n";
			this.checkBox_xPow.UseVisualStyleBackColor = true;
			// 
			// checkBox_sin
			// 
			this.checkBox_sin.AutoSize = true;
			this.checkBox_sin.Location = new System.Drawing.Point(134, 73);
			this.checkBox_sin.Name = "checkBox_sin";
			this.checkBox_sin.Size = new System.Drawing.Size(52, 17);
			this.checkBox_sin.TabIndex = 10;
			this.checkBox_sin.Text = "Sin(x)";
			this.checkBox_sin.UseVisualStyleBackColor = true;
			// 
			// checkBox_useReal
			// 
			this.checkBox_useReal.AutoSize = true;
			this.checkBox_useReal.Location = new System.Drawing.Point(134, 47);
			this.checkBox_useReal.Name = "checkBox_useReal";
			this.checkBox_useReal.Size = new System.Drawing.Size(106, 17);
			this.checkBox_useReal.TabIndex = 9;
			this.checkBox_useReal.Text = "Use real function";
			this.checkBox_useReal.UseVisualStyleBackColor = true;
			this.checkBox_useReal.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(206, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Zero percent ";
			// 
			// textBox_percent
			// 
			this.textBox_percent.Location = new System.Drawing.Point(134, 18);
			this.textBox_percent.Name = "textBox_percent";
			this.textBox_percent.Size = new System.Drawing.Size(66, 20);
			this.textBox_percent.TabIndex = 7;
			this.textBox_percent.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "b";
			// 
			// labelA
			// 
			this.labelA.AutoSize = true;
			this.labelA.Location = new System.Drawing.Point(42, 47);
			this.labelA.Name = "labelA";
			this.labelA.Size = new System.Drawing.Size(13, 13);
			this.labelA.TabIndex = 5;
			this.labelA.Text = "a";
			// 
			// textBox_b
			// 
			this.textBox_b.Location = new System.Drawing.Point(6, 70);
			this.textBox_b.Name = "textBox_b";
			this.textBox_b.Size = new System.Drawing.Size(30, 20);
			this.textBox_b.TabIndex = 4;
			this.textBox_b.Text = "1";
			this.textBox_b.TextChanged += new System.EventHandler(this.textBox_b_TextChanged);
			// 
			// textBox_a
			// 
			this.textBox_a.Location = new System.Drawing.Point(6, 44);
			this.textBox_a.Name = "textBox_a";
			this.textBox_a.Size = new System.Drawing.Size(30, 20);
			this.textBox_a.TabIndex = 3;
			this.textBox_a.Text = "-1";
			this.textBox_a.TextChanged += new System.EventHandler(this.textBox_a_TextChanged);
			// 
			// button_count
			// 
			this.button_count.Location = new System.Drawing.Point(372, 86);
			this.button_count.Name = "button_count";
			this.button_count.Size = new System.Drawing.Size(97, 25);
			this.button_count.TabIndex = 2;
			this.button_count.Text = "Count";
			this.button_count.UseVisualStyleBackColor = true;
			this.button_count.Click += new System.EventHandler(this.button_count_Click);
			// 
			// label_dim
			// 
			this.label_dim.AutoSize = true;
			this.label_dim.Location = new System.Drawing.Point(78, 21);
			this.label_dim.Name = "label_dim";
			this.label_dim.Size = new System.Drawing.Size(15, 13);
			this.label_dim.TabIndex = 1;
			this.label_dim.Text = "N";
			// 
			// dim_box
			// 
			this.dim_box.Location = new System.Drawing.Point(6, 18);
			this.dim_box.Name = "dim_box";
			this.dim_box.Size = new System.Drawing.Size(66, 20);
			this.dim_box.TabIndex = 0;
			this.dim_box.Text = "20";
			// 
			// chart
			// 
			legend1.Name = "Legend1";
			this.chart.Legends.Add(legend1);
			this.chart.Location = new System.Drawing.Point(12, 135);
			this.chart.Name = "chart";
			this.chart.Size = new System.Drawing.Size(475, 359);
			this.chart.SuppressExceptions = true;
			this.chart.TabIndex = 1;
			this.chart.Text = "chart1";
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point(294, 21);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(41, 13);
			this.label.TabIndex = 14;
			this.label.Text = "Top 3 :";
			// 
			// label_top1
			// 
			this.label_top1.AutoSize = true;
			this.label_top1.Location = new System.Drawing.Point(341, 21);
			this.label_top1.Name = "label_top1";
			this.label_top1.Size = new System.Drawing.Size(13, 13);
			this.label_top1.TabIndex = 15;
			this.label_top1.Text = "?";
			// 
			// label_top2
			// 
			this.label_top2.AutoSize = true;
			this.label_top2.Location = new System.Drawing.Point(382, 21);
			this.label_top2.Name = "label_top2";
			this.label_top2.Size = new System.Drawing.Size(13, 13);
			this.label_top2.TabIndex = 16;
			this.label_top2.Text = "?";
			// 
			// label_top3
			// 
			this.label_top3.AutoSize = true;
			this.label_top3.Location = new System.Drawing.Point(423, 21);
			this.label_top3.Name = "label_top3";
			this.label_top3.Size = new System.Drawing.Size(13, 13);
			this.label_top3.TabIndex = 17;
			this.label_top3.Text = "?";
			// 
			// FFT_App
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(499, 506);
			this.Controls.Add(this.chart);
			this.Controls.Add(this.controlsBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FFT_App";
			this.Text = "FFT App";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.controlsBox.ResumeLayout(false);
			this.controlsBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox controlsBox;
		private System.Windows.Forms.Label label_dim;
		private System.Windows.Forms.TextBox dim_box;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart;
		private System.Windows.Forms.Button button_count;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_percent;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelA;
		private System.Windows.Forms.TextBox textBox_b;
		private System.Windows.Forms.TextBox textBox_a;
		private System.Windows.Forms.CheckBox checkBox_useReal;
		private System.Windows.Forms.Label label_xPow;
		private System.Windows.Forms.TextBox textBox_xPow;
		private System.Windows.Forms.CheckBox checkBox_xPow;
		private System.Windows.Forms.CheckBox checkBox_sin;
		private System.Windows.Forms.Label label_top3;
		private System.Windows.Forms.Label label_top2;
		private System.Windows.Forms.Label label_top1;
		private System.Windows.Forms.Label label;
	}
}

