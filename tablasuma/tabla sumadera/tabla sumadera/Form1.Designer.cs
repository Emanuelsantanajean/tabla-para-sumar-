namespace tabla_sumadera
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
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_resultado1 = new System.Windows.Forms.TextBox();
            this.txt_resultado3 = new System.Windows.Forms.TextBox();
            this.txt_resultado2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Columna3});
            this.dataGridView1.Location = new System.Drawing.Point(102, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(356, 261);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.suma);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Columna3
            // 
            this.Columna3.HeaderText = "Column3";
            this.Columna3.Name = "Columna3";
            // 
            // txt_resultado1
            // 
            this.txt_resultado1.Location = new System.Drawing.Point(131, 279);
            this.txt_resultado1.Multiline = true;
            this.txt_resultado1.Name = "txt_resultado1";
            this.txt_resultado1.Size = new System.Drawing.Size(97, 30);
            this.txt_resultado1.TabIndex = 1;
            // 
            // txt_resultado3
            // 
            this.txt_resultado3.Location = new System.Drawing.Point(331, 279);
            this.txt_resultado3.Multiline = true;
            this.txt_resultado3.Name = "txt_resultado3";
            this.txt_resultado3.Size = new System.Drawing.Size(95, 30);
            this.txt_resultado3.TabIndex = 2;
            // 
            // txt_resultado2
            // 
            this.txt_resultado2.Location = new System.Drawing.Point(234, 279);
            this.txt_resultado2.Multiline = true;
            this.txt_resultado2.Name = "txt_resultado2";
            this.txt_resultado2.Size = new System.Drawing.Size(91, 30);
            this.txt_resultado2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tabla_sumadera.Properties.Resources.images__3_;
            this.ClientSize = new System.Drawing.Size(620, 338);
            this.Controls.Add(this.txt_resultado2);
            this.Controls.Add(this.txt_resultado3);
            this.Controls.Add(this.txt_resultado1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_resultado1;
        private System.Windows.Forms.TextBox txt_resultado3;
        private System.Windows.Forms.TextBox txt_resultado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna3;
    }
}

