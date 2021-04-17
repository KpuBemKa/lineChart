
namespace lineChart
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartBox = new System.Windows.Forms.GroupBox();
            this.ControlsBox = new System.Windows.Forms.GroupBox();
            this.NewDiagramButton = new System.Windows.Forms.Button();
            this.DeleteDataButton = new System.Windows.Forms.Button();
            this.InsertDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.ChartBox.SuspendLayout();
            this.ControlsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 19);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(682, 253);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // ChartBox
            // 
            this.ChartBox.Controls.Add(this.chart1);
            this.ChartBox.Location = new System.Drawing.Point(12, 12);
            this.ChartBox.Name = "ChartBox";
            this.ChartBox.Size = new System.Drawing.Size(694, 272);
            this.ChartBox.TabIndex = 1;
            this.ChartBox.TabStop = false;
            this.ChartBox.Text = "Chart";
            // 
            // ControlsBox
            // 
            this.ControlsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlsBox.Controls.Add(this.NewDiagramButton);
            this.ControlsBox.Controls.Add(this.DeleteDataButton);
            this.ControlsBox.Controls.Add(this.InsertDataButton);
            this.ControlsBox.Location = new System.Drawing.Point(509, 290);
            this.ControlsBox.Name = "ControlsBox";
            this.ControlsBox.Size = new System.Drawing.Size(200, 111);
            this.ControlsBox.TabIndex = 2;
            this.ControlsBox.TabStop = false;
            this.ControlsBox.Text = "Controls";
            // 
            // NewDiagramButton
            // 
            this.NewDiagramButton.Location = new System.Drawing.Point(6, 77);
            this.NewDiagramButton.Name = "NewDiagramButton";
            this.NewDiagramButton.Size = new System.Drawing.Size(188, 23);
            this.NewDiagramButton.TabIndex = 2;
            this.NewDiagramButton.Text = "Crearea unei diagrame noi";
            this.NewDiagramButton.UseVisualStyleBackColor = true;
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.Location = new System.Drawing.Point(6, 48);
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Size = new System.Drawing.Size(188, 23);
            this.DeleteDataButton.TabIndex = 1;
            this.DeleteDataButton.Text = "Ștergerea datelor";
            this.DeleteDataButton.UseVisualStyleBackColor = true;
            this.DeleteDataButton.Click += new System.EventHandler(this.DeleteDataButton_Click);
            // 
            // InsertDataButton
            // 
            this.InsertDataButton.Location = new System.Drawing.Point(6, 19);
            this.InsertDataButton.Name = "InsertDataButton";
            this.InsertDataButton.Size = new System.Drawing.Size(188, 23);
            this.InsertDataButton.TabIndex = 0;
            this.InsertDataButton.Text = "Introducerea datelor noi";
            this.InsertDataButton.UseVisualStyleBackColor = true;
            this.InsertDataButton.Click += new System.EventHandler(this.InsertDataButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 426);
            this.Controls.Add(this.ControlsBox);
            this.Controls.Add(this.ChartBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "Line Charts";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ChartBox.ResumeLayout(false);
            this.ControlsBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox ChartBox;
        private System.Windows.Forms.GroupBox ControlsBox;
        private System.Windows.Forms.Button DeleteDataButton;
        private System.Windows.Forms.Button InsertDataButton;
        private System.Windows.Forms.Button NewDiagramButton;
    }
}

