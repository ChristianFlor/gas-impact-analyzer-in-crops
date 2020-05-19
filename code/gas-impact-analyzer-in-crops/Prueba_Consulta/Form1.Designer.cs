namespace Prueba_Consulta
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.repositoryUrl = new MaterialSkin.Controls.MaterialTextBox();
            this.datasetId = new MaterialSkin.Controls.MaterialTextBox();
            this.texBoxValor = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(262, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Query in data base";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(985, 307);
            this.dataGridView1.TabIndex = 9;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(794, 54);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(210, 169);
            this.checkedListBox1.TabIndex = 11;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            this.textBox1.Location = new System.Drawing.Point(497, 175);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(186, 61);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "url repo:   \r\nhttps://www.datos.gov.co\r\nid dataset:   \r\nysq6-ri4e\r\n\r\n";
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(497, 91);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(58, 36);
            this.materialButton1.TabIndex = 20;
            this.materialButton1.Text = "Read";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(299, 166);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(78, 36);
            this.materialButton2.TabIndex = 21;
            this.materialButton2.Text = "Search";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            this.repositoryUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repositoryUrl.Depth = 0;
            this.repositoryUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.repositoryUrl.Hint = "URL repository";
            this.repositoryUrl.Location = new System.Drawing.Point(44, 77);
            this.repositoryUrl.MaxLength = 50;
            this.repositoryUrl.MouseState = MaterialSkin.MouseState.OUT;
            this.repositoryUrl.Multiline = false;
            this.repositoryUrl.Name = "repositoryUrl";
            this.repositoryUrl.Size = new System.Drawing.Size(206, 50);
            this.repositoryUrl.TabIndex = 22;
            this.repositoryUrl.Text = "";
            this.datasetId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datasetId.Depth = 0;
            this.datasetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datasetId.Hint = "ID dataset";
            this.datasetId.Location = new System.Drawing.Point(299, 77);
            this.datasetId.MaxLength = 50;
            this.datasetId.MouseState = MaterialSkin.MouseState.OUT;
            this.datasetId.Multiline = false;
            this.datasetId.Name = "datasetId";
            this.datasetId.Size = new System.Drawing.Size(139, 50);
            this.datasetId.TabIndex = 23;
            this.datasetId.Text = "";
            this.texBoxValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texBoxValor.Depth = 0;
            this.texBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.texBoxValor.Hint = "Value to consult";
            this.texBoxValor.Location = new System.Drawing.Point(44, 152);
            this.texBoxValor.MaxLength = 50;
            this.texBoxValor.MouseState = MaterialSkin.MouseState.OUT;
            this.texBoxValor.Multiline = false;
            this.texBoxValor.Name = "texBoxValor";
            this.texBoxValor.Size = new System.Drawing.Size(152, 50);
            this.texBoxValor.TabIndex = 24;
            this.texBoxValor.Text = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 618);
            this.Controls.Add(this.texBoxValor);
            this.Controls.Add(this.datasetId);
            this.Controls.Add(this.repositoryUrl);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialTextBox datasetId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox repositoryUrl;
        private MaterialSkin.Controls.MaterialTextBox texBoxValor;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}

