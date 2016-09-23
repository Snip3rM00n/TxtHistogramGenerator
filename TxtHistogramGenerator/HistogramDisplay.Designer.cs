namespace TxtHistogramGenerator
{
    partial class HistogramDisplay
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.genHisto = new System.Windows.Forms.Button();
            this.saveHisto = new System.Windows.Forms.Button();
            this.histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.histogram)).BeginInit();
            this.SuspendLayout();
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(82, 14);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(464, 20);
            this.folderPath.TabIndex = 0;
            this.folderPath.TextChanged += new System.EventHandler(this.folderPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder Path:";
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(552, 12);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 2;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browseClick);
            // 
            // genHisto
            // 
            this.genHisto.Location = new System.Drawing.Point(633, 12);
            this.genHisto.Name = "genHisto";
            this.genHisto.Size = new System.Drawing.Size(75, 23);
            this.genHisto.TabIndex = 3;
            this.genHisto.Text = "Generate";
            this.genHisto.UseVisualStyleBackColor = true;
            this.genHisto.Click += new System.EventHandler(this.genHisto_Click);
            // 
            // saveHisto
            // 
            this.saveHisto.Location = new System.Drawing.Point(714, 12);
            this.saveHisto.Name = "saveHisto";
            this.saveHisto.Size = new System.Drawing.Size(75, 23);
            this.saveHisto.TabIndex = 4;
            this.saveHisto.Text = "Save";
            this.saveHisto.UseVisualStyleBackColor = true;
            this.saveHisto.Click += new System.EventHandler(this.saveHisto_Click);
            // 
            // histogram
            // 
            this.histogram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histogram.BorderlineColor = System.Drawing.Color.Black;
            this.histogram.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.histogram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.histogram.Legends.Add(legend1);
            this.histogram.Location = new System.Drawing.Point(15, 40);
            this.histogram.Name = "histogram";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.histogram.Series.Add(series1);
            this.histogram.Size = new System.Drawing.Size(774, 344);
            this.histogram.TabIndex = 5;
            this.histogram.Text = "chart1";
            // 
            // HistogramDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 396);
            this.Controls.Add(this.histogram);
            this.Controls.Add(this.saveHisto);
            this.Controls.Add(this.genHisto);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderPath);
            this.Name = "HistogramDisplay";
            this.Text = "Histogram Generator";
            ((System.ComponentModel.ISupportInitialize)(this.histogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button genHisto;
        private System.Windows.Forms.Button saveHisto;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogram;
    }
}

