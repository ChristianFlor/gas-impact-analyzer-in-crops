namespace PieGraphic
{
    partial class PieGraphic
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pieHarvested = new LiveCharts.WinForms.PieChart();
            this.SuspendLayout();
            // 
            // pieHarvested
            // 
            this.pieHarvested.Location = new System.Drawing.Point(188, 12);
            this.pieHarvested.Name = "pieHarvested";
            this.pieHarvested.Size = new System.Drawing.Size(358, 181);
            this.pieHarvested.TabIndex = 1;
            this.pieHarvested.Text = "Harvested";
            // 
            // PieGraphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pieHarvested);
            this.Name = "PieGraphic";
            this.Text = "Pie Graphic";
            this.ResumeLayout(false);

        }

        #endregion
        private LiveCharts.WinForms.PieChart pieHarvested;
    }
}

