namespace StackedAreaGraphic
{
    partial class StackedArea
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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.citiesComboBox = new System.Windows.Forms.ComboBox();
            this.cropCombobox = new System.Windows.Forms.ComboBox();
            this.difference = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(2, 12);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(795, 346);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // citiesComboBox
            // 
            this.citiesComboBox.FormattingEnabled = true;
            this.citiesComboBox.Items.AddRange(new object[] {
            "Cali",
            "Palmira",
            "Candelaria",
            "Buga",
            "Buenaventura"});
            this.citiesComboBox.Location = new System.Drawing.Point(158, 383);
            this.citiesComboBox.Name = "citiesComboBox";
            this.citiesComboBox.Size = new System.Drawing.Size(121, 21);
            this.citiesComboBox.TabIndex = 1;
            this.citiesComboBox.Text = "City";
            // 
            // cropCombobox
            // 
            this.cropCombobox.FormattingEnabled = true;
            this.cropCombobox.Location = new System.Drawing.Point(339, 383);
            this.cropCombobox.Name = "cropCombobox";
            this.cropCombobox.Size = new System.Drawing.Size(121, 21);
            this.cropCombobox.TabIndex = 2;
            this.cropCombobox.Text = "Crop";
            // 
            // difference
            // 
            this.difference.Location = new System.Drawing.Point(527, 383);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(105, 23);
            this.difference.TabIndex = 3;
            this.difference.Text = "Show difference";
            this.difference.UseVisualStyleBackColor = true;
            this.difference.Click += new System.EventHandler(this.difference_Click);
            // 
            // StackedArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.cropCombobox);
            this.Controls.Add(this.citiesComboBox);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "StackedArea";
            this.Text = "Stacked Area";
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.ComboBox citiesComboBox;
        private System.Windows.Forms.ComboBox cropCombobox;
        private System.Windows.Forms.Button difference;
    }
}

