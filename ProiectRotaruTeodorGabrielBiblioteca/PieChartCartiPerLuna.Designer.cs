
namespace ProiectRotaruTeodorGabrielBiblioteca
{
    partial class PieChartCartiPerLuna
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.btn_afiseazaPieChart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 0;
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(210, 3);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(609, 367);
            this.pieChart1.TabIndex = 2;
            this.pieChart1.Text = "pieChart1";
            // 
            // btn_afiseazaPieChart
            // 
            this.btn_afiseazaPieChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_afiseazaPieChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_afiseazaPieChart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_afiseazaPieChart.Location = new System.Drawing.Point(22, 71);
            this.btn_afiseazaPieChart.Name = "btn_afiseazaPieChart";
            this.btn_afiseazaPieChart.Size = new System.Drawing.Size(158, 23);
            this.btn_afiseazaPieChart.TabIndex = 3;
            this.btn_afiseazaPieChart.Text = "Afiseaza";
            this.btn_afiseazaPieChart.UseVisualStyleBackColor = false;
            this.btn_afiseazaPieChart.Click += new System.EventHandler(this.btn_afiseazaPieChart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Introduceti anul";
            // 
            // PieChartCartiPerLuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(931, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_afiseazaPieChart);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.textBox1);
            this.Name = "PieChartCartiPerLuna";
            this.Text = "PieChartCartiPerLuna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Button btn_afiseazaPieChart;
        private System.Windows.Forms.Label label1;
    }
}