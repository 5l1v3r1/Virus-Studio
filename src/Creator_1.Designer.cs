namespace Virus_Studio
{
    partial class Creator_1
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.txt_1 = new System.Windows.Forms.Label();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(29, 22);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(110, 23);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "Show a Alert";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(215, 22);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(110, 23);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "Open a website";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(400, 22);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(110, 23);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "Shutdown PC";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(29, 83);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(110, 23);
            this.btn_4.TabIndex = 3;
            this.btn_4.Text = "Custom Script";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(215, 83);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(110, 23);
            this.btn_5.TabIndex = 4;
            this.btn_5.Text = "Show virus name";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(400, 83);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(110, 23);
            this.btn_6.TabIndex = 5;
            this.btn_6.Text = "Spam a Message";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // txt_1
            // 
            this.txt_1.AutoSize = true;
            this.txt_1.Font = new System.Drawing.Font("Roboto Th", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_1.ForeColor = System.Drawing.Color.White;
            this.txt_1.Location = new System.Drawing.Point(148, 310);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(253, 33);
            this.txt_1.TabIndex = 6;
            this.txt_1.Text = "More coming soon...";
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(191, 368);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(158, 38);
            this.btn_7.TabIndex = 7;
            this.btn_7.Text = "Save Virus";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(29, 146);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(110, 23);
            this.btn_8.TabIndex = 8;
            this.btn_8.Text = "Set virus name";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // Creator_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Name = "Creator_1";
            this.Size = new System.Drawing.Size(535, 426);
            this.Load += new System.EventHandler(this.Creator_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Label txt_1;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
    }
}
