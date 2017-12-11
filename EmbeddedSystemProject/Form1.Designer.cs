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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea55 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend55 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series109 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series110 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea56 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend56 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series111 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series112 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea57 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend57 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series113 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series114 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelTempTxt = new System.Windows.Forms.Label();
            this.labelHumidTxt = new System.Windows.Forms.Label();
            this.labelTempValue = new System.Windows.Forms.Label();
            this.labelHumidValue = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.aGaugeTemp = new System.Windows.Forms.AGauge();
            this.aGaugeHumid = new System.Windows.Forms.AGauge();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartLiveData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chartHumHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chartTempHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLiveData)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHumHistory)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTempHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTempTxt
            // 
            this.labelTempTxt.AutoSize = true;
            this.labelTempTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempTxt.Location = new System.Drawing.Point(173, 330);
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
            this.labelHumidTxt.Location = new System.Drawing.Point(665, 330);
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
            this.labelTempValue.Location = new System.Drawing.Point(189, 289);
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
            this.labelHumidValue.Location = new System.Drawing.Point(664, 305);
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(17, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(956, 532);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImage = global::EmbeddedSystemProject.Properties.Resources.Background;
            this.tabPage1.Controls.Add(this.aGaugeTemp);
            this.tabPage1.Controls.Add(this.labelTempValue);
            this.tabPage1.Controls.Add(this.labelHumidValue);
            this.tabPage1.Controls.Add(this.labelTempTxt);
            this.tabPage1.Controls.Add(this.labelHumidTxt);
            this.tabPage1.Controls.Add(this.aGaugeHumid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(948, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Real-Time Gauges";
            // 
            // aGaugeTemp
            // 
            this.aGaugeTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aGaugeTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(145)))), ((int)(((byte)(88)))));
            this.aGaugeTemp.BackgroundImage = global::EmbeddedSystemProject.Properties.Resources.Siltsu;
            this.aGaugeTemp.BaseArcColor = System.Drawing.Color.Brown;
            this.aGaugeTemp.BaseArcRadius = 0;
            this.aGaugeTemp.BaseArcStart = 200;
            this.aGaugeTemp.BaseArcSweep = 140;
            this.aGaugeTemp.BaseArcWidth = 0;
            this.aGaugeTemp.Center = new System.Drawing.Point(100, 100);
            this.aGaugeTemp.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGaugeTemp.Location = new System.Drawing.Point(7, 61);
            this.aGaugeTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aGaugeTemp.MaxValue = 100F;
            this.aGaugeTemp.MinValue = -20F;
            this.aGaugeTemp.Name = "aGaugeTemp";
            this.aGaugeTemp.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.aGaugeTemp.NeedleColor2 = System.Drawing.Color.DarkRed;
            this.aGaugeTemp.NeedleRadius = 150;
            this.aGaugeTemp.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGaugeTemp.NeedleWidth = 8;
            this.aGaugeTemp.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGaugeTemp.ScaleLinesInterInnerRadius = 80;
            this.aGaugeTemp.ScaleLinesInterOuterRadius = 80;
            this.aGaugeTemp.ScaleLinesInterWidth = 0;
            this.aGaugeTemp.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGaugeTemp.ScaleLinesMajorInnerRadius = 80;
            this.aGaugeTemp.ScaleLinesMajorOuterRadius = 80;
            this.aGaugeTemp.ScaleLinesMajorStepValue = 20F;
            this.aGaugeTemp.ScaleLinesMajorWidth = 2;
            this.aGaugeTemp.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGaugeTemp.ScaleLinesMinorInnerRadius = 80;
            this.aGaugeTemp.ScaleLinesMinorOuterRadius = 80;
            this.aGaugeTemp.ScaleLinesMinorTicks = 0;
            this.aGaugeTemp.ScaleLinesMinorWidth = 0;
            this.aGaugeTemp.ScaleNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(3)))));
            this.aGaugeTemp.ScaleNumbersFormat = "";
            this.aGaugeTemp.ScaleNumbersRadius = 175;
            this.aGaugeTemp.ScaleNumbersRotation = 1;
            this.aGaugeTemp.ScaleNumbersStartScaleLine = 0;
            this.aGaugeTemp.ScaleNumbersStepScaleLines = 1;
            this.aGaugeTemp.Size = new System.Drawing.Size(500, 400);
            this.aGaugeTemp.TabIndex = 2;
            this.aGaugeTemp.Text = "aGauge1";
            this.aGaugeTemp.Value = 0F;
            this.aGaugeTemp.SizeChanged += new System.EventHandler(this.aGaugeTemp_SizeChanged);
            // 
            // aGaugeHumid
            // 
            this.aGaugeHumid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aGaugeHumid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(145)))), ((int)(((byte)(88)))));
            this.aGaugeHumid.BackgroundImage = global::EmbeddedSystemProject.Properties.Resources.SiltsuRotate;
            this.aGaugeHumid.BaseArcColor = System.Drawing.Color.MidnightBlue;
            this.aGaugeHumid.BaseArcRadius = 0;
            this.aGaugeHumid.BaseArcStart = 200;
            this.aGaugeHumid.BaseArcSweep = 140;
            this.aGaugeHumid.BaseArcWidth = 0;
            this.aGaugeHumid.Center = new System.Drawing.Point(100, 100);
            this.aGaugeHumid.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGaugeHumid.Location = new System.Drawing.Point(513, 61);
            this.aGaugeHumid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aGaugeHumid.MaxValue = 100F;
            this.aGaugeHumid.MinValue = 0F;
            this.aGaugeHumid.Name = "aGaugeHumid";
            this.aGaugeHumid.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Blue;
            this.aGaugeHumid.NeedleColor2 = System.Drawing.Color.MidnightBlue;
            this.aGaugeHumid.NeedleRadius = 150;
            this.aGaugeHumid.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGaugeHumid.NeedleWidth = 8;
            this.aGaugeHumid.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGaugeHumid.ScaleLinesInterInnerRadius = 80;
            this.aGaugeHumid.ScaleLinesInterOuterRadius = 80;
            this.aGaugeHumid.ScaleLinesInterWidth = 0;
            this.aGaugeHumid.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGaugeHumid.ScaleLinesMajorInnerRadius = 80;
            this.aGaugeHumid.ScaleLinesMajorOuterRadius = 80;
            this.aGaugeHumid.ScaleLinesMajorStepValue = 20F;
            this.aGaugeHumid.ScaleLinesMajorWidth = 2;
            this.aGaugeHumid.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGaugeHumid.ScaleLinesMinorInnerRadius = 80;
            this.aGaugeHumid.ScaleLinesMinorOuterRadius = 80;
            this.aGaugeHumid.ScaleLinesMinorTicks = 0;
            this.aGaugeHumid.ScaleLinesMinorWidth = 0;
            this.aGaugeHumid.ScaleNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(3)))));
            this.aGaugeHumid.ScaleNumbersFormat = null;
            this.aGaugeHumid.ScaleNumbersRadius = 175;
            this.aGaugeHumid.ScaleNumbersRotation = 1;
            this.aGaugeHumid.ScaleNumbersStartScaleLine = 0;
            this.aGaugeHumid.ScaleNumbersStepScaleLines = 1;
            this.aGaugeHumid.Size = new System.Drawing.Size(500, 400);
            this.aGaugeHumid.TabIndex = 3;
            this.aGaugeHumid.Text = "aGauge2";
            this.aGaugeHumid.Value = 0F;
            this.aGaugeHumid.SizeChanged += new System.EventHandler(this.aGaugeHumid_SizeChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartLiveData);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(948, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Live Chart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartLiveData
            // 
            chartArea55.AxisY.Title = "Temperature °C, Humidity %";
            chartArea55.Name = "ChartArea1";
            this.chartLiveData.ChartAreas.Add(chartArea55);
            this.chartLiveData.Cursor = System.Windows.Forms.Cursors.Default;
            legend55.Name = "Legend1";
            this.chartLiveData.Legends.Add(legend55);
            this.chartLiveData.Location = new System.Drawing.Point(8, 7);
            this.chartLiveData.Margin = new System.Windows.Forms.Padding(4);
            this.chartLiveData.Name = "chartLiveData";
            series109.ChartArea = "ChartArea1";
            series109.Legend = "Legend1";
            series109.Name = "Humidity";
            series110.ChartArea = "ChartArea1";
            series110.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series110.Legend = "Legend1";
            series110.Name = "Temperature";
            this.chartLiveData.Series.Add(series109);
            this.chartLiveData.Series.Add(series110);
            this.chartLiveData.Size = new System.Drawing.Size(929, 489);
            this.chartLiveData.TabIndex = 0;
            this.chartLiveData.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chartHumHistory);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(948, 503);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Humidity History Chart";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartHumHistory
            // 
            chartArea56.Name = "ChartArea1";
            this.chartHumHistory.ChartAreas.Add(chartArea56);
            legend56.Name = "Legend1";
            this.chartHumHistory.Legends.Add(legend56);
            this.chartHumHistory.Location = new System.Drawing.Point(109, 43);
            this.chartHumHistory.Margin = new System.Windows.Forms.Padding(4);
            this.chartHumHistory.Name = "chartHumHistory";
            series111.ChartArea = "ChartArea1";
            series111.IsXValueIndexed = true;
            series111.Legend = "Legend1";
            series111.Name = "Min Humidity";
            series111.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series112.ChartArea = "ChartArea1";
            series112.IsXValueIndexed = true;
            series112.Legend = "Legend1";
            series112.Name = "Max Humidity";
            series112.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chartHumHistory.Series.Add(series111);
            this.chartHumHistory.Series.Add(series112);
            this.chartHumHistory.Size = new System.Drawing.Size(773, 449);
            this.chartHumHistory.TabIndex = 0;
            this.chartHumHistory.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chartTempHistory);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(948, 503);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Temperature History Chart";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chartTempHistory
            // 
            chartArea57.Name = "ChartArea1";
            this.chartTempHistory.ChartAreas.Add(chartArea57);
            legend57.Name = "Legend1";
            this.chartTempHistory.Legends.Add(legend57);
            this.chartTempHistory.Location = new System.Drawing.Point(85, 31);
            this.chartTempHistory.Margin = new System.Windows.Forms.Padding(4);
            this.chartTempHistory.Name = "chartTempHistory";
            series113.ChartArea = "ChartArea1";
            series113.IsXValueIndexed = true;
            series113.Legend = "Legend1";
            series113.Name = "Min Temperature";
            series113.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series114.ChartArea = "ChartArea1";
            series114.IsXValueIndexed = true;
            series114.Legend = "Legend1";
            series114.Name = "Max Temperature";
            series114.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chartTempHistory.Series.Add(series113);
            this.chartTempHistory.Series.Add(series114);
            this.chartTempHistory.Size = new System.Drawing.Size(807, 437);
            this.chartTempHistory.TabIndex = 0;
            this.chartTempHistory.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 562);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Weather station";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLiveData)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHumHistory)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTempHistory)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLiveData;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHumHistory;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTempHistory;
    }
}

