namespace Virus_Studio
{
    partial class News
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_1 = new System.Windows.Forms.Label();
            this.txt_2 = new System.Windows.Forms.Label();
            this.p_1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txt_1
            // 
            this.txt_1.AutoSize = true;
            this.txt_1.Font = new System.Drawing.Font("Roboto Th", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_1.ForeColor = System.Drawing.Color.White;
            this.txt_1.Location = new System.Drawing.Point(22, 14);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(86, 33);
            this.txt_1.TabIndex = 0;
            this.txt_1.Text = "News:";
            // 
            // txt_2
            // 
            this.txt_2.AutoSize = true;
            this.txt_2.Font = new System.Drawing.Font("Roboto Bk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_2.ForeColor = System.Drawing.Color.White;
            this.txt_2.Location = new System.Drawing.Point(247, 75);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(132, 24);
            this.txt_2.TabIndex = 1;
            this.txt_2.Text = "Release 1.0.0";
            // 
            // p_1
            // 
            this.p_1.Location = new System.Drawing.Point(174, 112);
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(278, 161);
            this.p_1.TabIndex = 2;
            // 
            // News
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.p_1);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Name = "News";
            this.Size = new System.Drawing.Size(627, 414);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_1;
        private System.Windows.Forms.Label txt_2;
        private System.Windows.Forms.Panel p_1;
    }
}
