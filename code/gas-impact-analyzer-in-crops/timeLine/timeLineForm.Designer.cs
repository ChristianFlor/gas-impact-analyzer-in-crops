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
            this.gasesComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.initialDate = new System.Windows.Forms.NumericUpDown();
            this.finalDate = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.initialDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDate)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(13, 13);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1271, 390);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a gas you want to know its concentration history";
            // 
            // gasesComboBox
            // 
            this.gasesComboBox.FormattingEnabled = true;
            this.gasesComboBox.Items.AddRange(new object[] {
            "CO",
            "O3",
            "NO2",
            "SO2",
            "PM10",
            "PM2.5"});
            this.gasesComboBox.Location = new System.Drawing.Point(566, 446);
            this.gasesComboBox.Name = "gasesComboBox";
            this.gasesComboBox.Size = new System.Drawing.Size(121, 21);
            this.gasesComboBox.TabIndex = 2;
            this.gasesComboBox.Text = "CO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select the time interval where you want to see the gas concentration history";
            // 
            // initialDate
            // 
            this.initialDate.Location = new System.Drawing.Point(543, 499);
            this.initialDate.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.initialDate.Minimum = new decimal(new int[] {
            2011,
            0,
            0,
            0});
            this.initialDate.Name = "initialDate";
            this.initialDate.Size = new System.Drawing.Size(49, 20);
            this.initialDate.TabIndex = 4;
            this.initialDate.Value = new decimal(new int[] {
            2011,
            0,
            0,
            0});
            // 
            // finalDate
            // 
            this.finalDate.Location = new System.Drawing.Point(661, 499);
            this.finalDate.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.finalDate.Minimum = new decimal(new int[] {
            2011,
            0,
            0,
            0});
            this.finalDate.Name = "finalDate";
            this.finalDate.Size = new System.Drawing.Size(48, 20);
            this.finalDate.TabIndex = 5;
            this.finalDate.Value = new decimal(new int[] {
            2011,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Visualize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimeLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.finalDate);
            this.Controls.Add(this.initialDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gasesComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "TimeLineForm";
            this.Text = "Gas concentration timeline";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.initialDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox gasesComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown initialDate;
        private System.Windows.Forms.NumericUpDown finalDate;
        private System.Windows.Forms.Button button1;
    }
}

