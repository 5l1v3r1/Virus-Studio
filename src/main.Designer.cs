namespace Virus_Studio
{
    partial class main
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
            this.p_1 = new System.Windows.Forms.Panel();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.txt_1 = new System.Windows.Forms.Label();
            this.user_control_1 = new Virus_Studio.News();
            this.p_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_1
            // 
            this.p_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(48)))));
            this.p_1.Controls.Add(this.btn_4);
            this.p_1.Controls.Add(this.btn_3);
            this.p_1.Controls.Add(this.btn_2);
            this.p_1.Controls.Add(this.btn_1);
            this.p_1.Controls.Add(this.txt_1);
            this.p_1.Location = new System.Drawing.Point(-11, -11);
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(169, 468);
            this.p_1.TabIndex = 0;
            // 
            // btn_4
            // 
            this.btn_4.ForeColor = System.Drawing.Color.White;
            this.btn_4.Location = new System.Drawing.Point(6, 390);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(163, 44);
            this.btn_4.TabIndex = 4;
            this.btn_4.Text = "Exit";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_3
            // 
            this.btn_3.ForeColor = System.Drawing.Color.White;
            this.btn_3.Location = new System.Drawing.Point(6, 198);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(163, 44);
            this.btn_3.TabIndex = 3;
            this.btn_3.Text = "About";
            this.btn_3.UseVisualStyleBackColor = true;
            // 
            // btn_2
            // 
            this.btn_2.ForeColor = System.Drawing.Color.White;
            this.btn_2.Location = new System.Drawing.Point(3, 131);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(166, 44);
            this.btn_2.TabIndex = 2;
            this.btn_2.Text = "Create";
            this.btn_2.UseVisualStyleBackColor = true;
            // 
            // btn_1
            // 
            this.btn_1.ForeColor = System.Drawing.Color.White;
            this.btn_1.Location = new System.Drawing.Point(3, 64);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(166, 44);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "Main Menu";
            this.btn_1.UseVisualStyleBackColor = true;
            // 
            // txt_1
            // 
            this.txt_1.AutoSize = true;
            this.txt_1.Font = new System.Drawing.Font("Roboto Th", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txt_1.ForeColor = System.Drawing.Color.White;
            this.txt_1.Location = new System.Drawing.Point(23, 20);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(126, 27);
            this.txt_1.TabIndex = 0;
            this.txt_1.Text = "Virus Studio";
            // 
            // user_control_1
            // 
            this.user_control_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
            this.user_control_1.Location = new System.Drawing.Point(164, 12);
            this.user_control_1.Name = "user_control_1";
            this.user_control_1.Size = new System.Drawing.Size(535, 426);
            this.user_control_1.TabIndex = 1;
            this.user_control_1.Load += new System.EventHandler(this.user_control_1_Load);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.user_control_1);
            this.Controls.Add(this.p_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "main";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu | Virus Studio";
            this.Load += new System.EventHandler(this.main_Load);
            this.p_1.ResumeLayout(false);
            this.p_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_1;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label txt_1;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private News user_control_1;
    }
}

