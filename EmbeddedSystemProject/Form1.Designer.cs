namespace EmbeddedSystemProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelTempTxt = new System.Windows.Forms.Label();
            this.labelHumidTxt = new System.Windows.Forms.Label();
            this.labelTempValue = new System.Windows.Forms.Label();
            this.labelHumidValue = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.aGaugeTemp = new System.Windows.Forms.AGauge();
            this.aGaugeHumid = new System.Windows.Forms.AGauge();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTempTxt
            // 
            this.labelTempTxt.AutoSize = true;
            this.labelTempTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempTxt.Location = new System.Drawing.Point(159, 321);
            this.labelTempTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTempTxt.Name = "labelTempTxt";
            this.labelTempTxt.Size = new System.Drawing.Size(115, 20);
            this.labelTempTxt.TabIndex = 4;
            this.labelTempTxt.Text = "Temperature";
            // 
            // labelHumidTxt
            // 
            this.labelHumidTxt.AutoSize = true;
            this.labelHumidTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidTxt.Location = new System.Drawing.Point(558, 316);
            this.labelHumidTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHumidTxt.Name = "labelHumidTxt";
            this.labelHumidTxt.Size = new System.Drawing.Size(83, 20);
            this.labelHumidTxt.TabIndex = 5;
            this.labelHumidTxt.Text = "Humidity";
            this.labelHumidTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTempValue
            // 
            this.labelTempValue.AutoSize = true;
            this.labelTempValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempValue.Location = new System.Drawing.Point(8, 301);
            this.labelTempValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTempValue.Name = "labelTempValue";
            this.labelTempValue.Size = new System.Drawing.Size(37, 25);
            this.labelTempValue.TabIndex = 6;
            this.labelTempValue.Text = "°C";
            // 
            // labelHumidValue
            // 
            this.labelHumidValue.AutoSize = true;
            this.labelHumidValue.BackColor = System.Drawing.Color.Transparent;
            this.labelHumidValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidValue.Location = new System.Drawing.Point(440, 316);
            this.labelHumidValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHumidValue.Name = "labelHumidValue";
            this.labelHumidValue.Size = new System.Drawing.Size(31, 25);
            this.labelHumidValue.TabIndex = 7;
            this.labelHumidValue.Text = "%";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(17, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 374);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelTempValue);
            this.tabPage1.Controls.Add(this.labelHumidValue);
            this.tabPage1.Controls.Add(this.labelTempTxt);
            this.tabPage1.Controls.Add(this.labelHumidTxt);
            this.tabPage1.Controls.Add(this.aGaugeTemp);
            this.tabPage1.Controls.Add(this.aGaugeHumid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(757, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // aGaugeTemp
            // 
            this.aGaugeTemp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aGaugeTemp.BackgroundImage")));
            this.aGaugeTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aGaugeTemp.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGaugeTemp.BaseArcRadius = 80;
            this.aGaugeTemp.BaseArcStart = 210;
            this.aGaugeTemp.BaseArcSweep = 270;
            this.aGaugeTemp.BaseArcWidth = 2;
            this.aGaugeTemp.Center = new System.Drawing.Point(115, 210);
            this.aGaugeTemp.Location = new System.Drawing.Point(13, 6);
            this.aGaugeTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aGaugeTemp.MaxValue = 190F;
            this.aGaugeTemp.MinValue = 0F;
            this.aGaugeTemp.Name = "aGaugeTemp";
            this.aGaugeTemp.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.aGaugeTemp.NeedleColor2 = System.Drawing.Color.DarkRed;
            this.aGaugeTemp.NeedleRadius = 80;
            this.aGaugeTemp.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGaugeTemp.NeedleWidth = 5;
            this.aGaugeTemp.ScaleLinesInterColor = System.Drawing.Color.Transparent;
            this.aGaugeTemp.ScaleLinesInterInnerRadius = 73;
            this.aGaugeTemp.ScaleLinesInterOuterRadius = 80;
            this.aGaugeTemp.ScaleLinesInterWidth = 1;
            this.aGaugeTemp.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGaugeTemp.ScaleLinesMajorInnerRadius = 73;
            this.aGaugeTemp.ScaleLinesMajorOuterRadius = 80;
            this.aGaugeTemp.ScaleLinesMajorStepValue = 20F;
            this.aGaugeTemp.ScaleLinesMajorWidth = 2;
            this.aGaugeTemp.ScaleLinesMinorColor = System.Drawing.Color.Transparent;
            this.aGaugeTemp.ScaleLinesMinorInnerRadius = 75;
            this.aGaugeTemp.ScaleLinesMinorOuterRadius = 80;
            this.aGaugeTemp.ScaleLinesMinorTicks = 9;
            this.aGaugeTemp.ScaleLinesMinorWidth = 1;
            this.aGaugeTemp.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGaugeTemp.ScaleNumbersFormat = null;
            this.aGaugeTemp.ScaleNumbersRadius = 93;
            this.aGaugeTemp.ScaleNumbersRotation = 0;
            this.aGaugeTemp.ScaleNumbersStartScaleLine = 0;
            this.aGaugeTemp.ScaleNumbersStepScaleLines = 1;
            this.aGaugeTemp.Size = new System.Drawing.Size(343, 293);
            this.aGaugeTemp.TabIndex = 2;
            this.aGaugeTemp.Text = "aGauge1";
            this.aGaugeTemp.Value = 0F;
            // 
            // aGaugeHumid
            // 
            this.aGaugeHumid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aGaugeHumid.BackgroundImage")));
            this.aGaugeHumid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aGaugeHumid.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGaugeHumid.BaseArcRadius = 80;
            this.aGaugeHumid.BaseArcStart = 210;
            this.aGaugeHumid.BaseArcSweep = 270;
            this.aGaugeHumid.BaseArcWidth = 2;
            this.aGaugeHumid.Center = new System.Drawing.Point(120, 205);
            this.aGaugeHumid.Location = new System.Drawing.Point(379, 6);
            this.aGaugeHumid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aGaugeHumid.MaxValue = 190F;
            this.aGaugeHumid.MinValue = 0F;
            this.aGaugeHumid.Name = "aGaugeHumid";
            this.aGaugeHumid.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Blue;
            this.aGaugeHumid.NeedleColor2 = System.Drawing.Color.MidnightBlue;
            this.aGaugeHumid.NeedleRadius = 80;
            this.aGaugeHumid.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGaugeHumid.NeedleWidth = 5;
            this.aGaugeHumid.ScaleLinesInterColor = System.Drawing.Color.Transparent;
            this.aGaugeHumid.ScaleLinesInterInnerRadius = 73;
            this.aGaugeHumid.ScaleLinesInterOuterRadius = 80;
            this.aGaugeHumid.ScaleLinesInterWidth = 1;
            this.aGaugeHumid.ScaleLinesMajorColor = System.Drawing.Color.MidnightBlue;
            this.aGaugeHumid.ScaleLinesMajorInnerRadius = 70;
            this.aGaugeHumid.ScaleLinesMajorOuterRadius = 80;
            this.aGaugeHumid.ScaleLinesMajorStepValue = 20F;
            this.aGaugeHumid.ScaleLinesMajorWidth = 2;
            this.aGaugeHumid.ScaleLinesMinorColor = System.Drawing.Color.Transparent;
            this.aGaugeHumid.ScaleLinesMinorInnerRadius = 75;
            this.aGaugeHumid.ScaleLinesMinorOuterRadius = 80;
            this.aGaugeHumid.ScaleLinesMinorTicks = 9;
            this.aGaugeHumid.ScaleLinesMinorWidth = 1;
            this.aGaugeHumid.ScaleNumbersColor = System.Drawing.Color.MidnightBlue;
            this.aGaugeHumid.ScaleNumbersFormat = null;
            this.aGaugeHumid.ScaleNumbersRadius = 95;
            this.aGaugeHumid.ScaleNumbersRotation = 0;
            this.aGaugeHumid.ScaleNumbersStartScaleLine = 0;
            this.aGaugeHumid.ScaleNumbersStepScaleLines = 1;
            this.aGaugeHumid.Size = new System.Drawing.Size(343, 293);
            this.aGaugeHumid.TabIndex = 3;
            this.aGaugeHumid.Text = "aGauge2";
            this.aGaugeHumid.Value = 0F;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartHistory);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(757, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartHistory
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHistory.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHistory.Legends.Add(legend1);
            this.chartHistory.Location = new System.Drawing.Point(117, 7);
            this.chartHistory.Margin = new System.Windows.Forms.Padding(4);
            this.chartHistory.Name = "chartHistory";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            this.chartHistory.Series.Add(series1);
            this.chartHistory.Size = new System.Drawing.Size(583, 306);
            this.chartHistory.TabIndex = 0;
            this.chartHistory.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 470);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Weather station";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.AGauge aGaugeTemp;
        private System.Windows.Forms.AGauge aGaugeHumid;
        private System.Windows.Forms.Label labelTempTxt;
        private System.Windows.Forms.Label labelHumidTxt;
        private System.Windows.Forms.Label labelTempValue;
        private System.Windows.Forms.Label labelHumidValue;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistory;
    }
}

