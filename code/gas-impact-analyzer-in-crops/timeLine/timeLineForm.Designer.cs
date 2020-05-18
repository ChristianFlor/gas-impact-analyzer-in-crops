namespace timeLine
{
    partial class TimeLineForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.municipalityComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yearSelector = new System.Windows.Forms.NumericUpDown();
            this.monthSelector = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.gasComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(12, 12);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(946, 356);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a gas you want to know its concentration history";
            // 
            // municipalityComboBox
            // 
            this.municipalityComboBox.FormattingEnabled = true;
            this.municipalityComboBox.Items.AddRange(new object[] {
            "GUADALAJARA DE BUGA",
            "JAMUNDÍ",
            "YUMBO",
            "CANDELARIA",
            "PALMIRA",
            "BUENAVENTURA",
            "CALI"});
            this.municipalityComboBox.Location = new System.Drawing.Point(122, 397);
            this.municipalityComboBox.Name = "municipalityComboBox";
            this.municipalityComboBox.Size = new System.Drawing.Size(121, 21);
            this.municipalityComboBox.TabIndex = 2;
            this.municipalityComboBox.Text = "CALI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select the time interval where you want to see the gas concentration history";
            // 
            // yearSelector
            // 
            this.yearSelector.Location = new System.Drawing.Point(494, 398);
            this.yearSelector.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.yearSelector.Minimum = new decimal(new int[] {
            2011,
            0,
            0,
            0});
            this.yearSelector.Name = "yearSelector";
            this.yearSelector.Size = new System.Drawing.Size(49, 20);
            this.yearSelector.TabIndex = 4;
            this.yearSelector.Value = new decimal(new int[] {
            2011,
            0,
            0,
            0});
            // 
            // monthSelector
            // 
            this.monthSelector.Location = new System.Drawing.Point(603, 398);
            this.monthSelector.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthSelector.Name = "monthSelector";
            this.monthSelector.Size = new System.Drawing.Size(48, 20);
            this.monthSelector.TabIndex = 5;
            this.monthSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Visualize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gasComboBox
            // 
            this.gasComboBox.FormattingEnabled = true;
            this.gasComboBox.Items.AddRange(new object[] {
            "CO",
            "O3",
            "NO2",
            "SO2",
            "PM10",
            "PM2.5"});
            this.gasComboBox.Location = new System.Drawing.Point(311, 397);
            this.gasComboBox.Name = "gasComboBox";
            this.gasComboBox.Size = new System.Drawing.Size(121, 21);
            this.gasComboBox.TabIndex = 7;
            this.gasComboBox.Text = "CO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Municipality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Month";
            // 
            // TimeLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(962, 425);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gasComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthSelector);
            this.Controls.Add(this.yearSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.municipalityComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "TimeLineForm";
            this.Text = "Gas concentration timeline";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yearSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox municipalityComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown yearSelector;
        private System.Windows.Forms.NumericUpDown monthSelector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox gasComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

