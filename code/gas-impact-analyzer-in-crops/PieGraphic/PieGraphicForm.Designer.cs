﻿namespace PieGraphic
{
    partial class PieGraphicForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pieHarvested = new LiveCharts.WinForms.PieChart();
            this.citiesComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pieHarvested
            // 
            this.pieHarvested.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pieHarvested.Location = new System.Drawing.Point(157, 41);
            this.pieHarvested.Name = "pieHarvested";
            this.pieHarvested.Size = new System.Drawing.Size(467, 263);
            this.pieHarvested.TabIndex = 1;
            this.pieHarvested.Text = "Harvested";
            // 
            // citiesComboBox
            // 
            this.citiesComboBox.FormattingEnabled = true;
            this.citiesComboBox.Items.AddRange(new object[] {"Cali", "Palmira", "Candelaria", "Buga", "Buenaventura"});
            this.citiesComboBox.Location = new System.Drawing.Point(287, 375);
            this.citiesComboBox.Name = "citiesComboBox";
            this.citiesComboBox.Size = new System.Drawing.Size(121, 21);
            this.citiesComboBox.TabIndex = 2;
            this.citiesComboBox.Text = "Cali";
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {"2011", "2012", "2013", "2014", "2015", "2016", "2017"});
            this.yearComboBox.Location = new System.Drawing.Point(287, 417);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(121, 21);
            this.yearComboBox.TabIndex = 3;
            this.yearComboBox.Text = "2011";
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(492, 394);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 4;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // PieGraphicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.citiesComboBox);
            this.Controls.Add(this.pieHarvested);
            this.Name = "PieGraphicForm";
            this.Text = "Pie Graphic";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox citiesComboBox;
        private LiveCharts.WinForms.PieChart pieHarvested;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.ComboBox yearComboBox;

        #endregion
    }
}

