namespace BarGraphic
{
    partial class BarGraph
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
            this.showButton = new System.Windows.Forms.Button();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(12, 12);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(782, 347);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // citiesComboBox
            // 
            this.citiesComboBox.FormattingEnabled = true;
            this.citiesComboBox.Items.AddRange(new object[] {
            "BUENAVENTURA",
            "GUADALAJARA DE BUGA",
            "CALI",
            "CANDELARIA",
            "JAMUNDÍ",
            "PALMIRA",
            "YUMBO"});
            this.citiesComboBox.Location = new System.Drawing.Point(101, 393);
            this.citiesComboBox.Name = "citiesComboBox";
            this.citiesComboBox.Size = new System.Drawing.Size(121, 21);
            this.citiesComboBox.TabIndex = 1;
            this.citiesComboBox.Text = "City";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(434, 393);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.yearComboBox.Location = new System.Drawing.Point(270, 393);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(121, 21);
            this.yearComboBox.TabIndex = 2;
            this.yearComboBox.Text = "Year";
            // 
            // BarGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.citiesComboBox);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "BarGraph";
            this.Text = "BarGraphic";
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.ComboBox citiesComboBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ComboBox yearComboBox;
    }
}

