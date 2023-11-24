namespace appPlanilla_IA_AMV.ui
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pibSalir = new System.Windows.Forms.PictureBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btniniciar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(17)))), ((int)(((byte)(90)))));
            this.pnlLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogin.BackgroundImage")));
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlLogin.Controls.Add(this.pibSalir);
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(400, 50);
            this.pnlLogin.TabIndex = 0;
            // 
            // pibSalir
            // 
            this.pibSalir.Image = ((System.Drawing.Image)(resources.GetObject("pibSalir.Image")));
            this.pibSalir.Location = new System.Drawing.Point(373, 13);
            this.pibSalir.Name = "pibSalir";
            this.pibSalir.Size = new System.Drawing.Size(24, 24);
            this.pibSalir.TabIndex = 0;
            this.pibSalir.TabStop = false;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblusuario.Location = new System.Drawing.Point(89, 106);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(60, 16);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "Usuario :";
            this.lblusuario.Click += new System.EventHandler(this.lblusuario_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblpassword.Location = new System.Drawing.Point(89, 148);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(73, 16);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Password :";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtusuario.Location = new System.Drawing.Point(207, 103);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 22);
            this.txtusuario.TabIndex = 2;
            this.txtusuario.Enter += new System.EventHandler(this.txt_Enter);
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txtusuario.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtpassword.Location = new System.Drawing.Point(207, 145);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 22);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.Enter += new System.EventHandler(this.txt_Enter);
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txtpassword.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // btniniciar
            // 
            this.btniniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(17)))), ((int)(((byte)(90)))));
            this.btniniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btniniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btniniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btniniciar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btniniciar.Location = new System.Drawing.Point(72, 217);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(100, 30);
            this.btniniciar.TabIndex = 3;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = false;
            this.btniniciar.Enter += new System.EventHandler(this.btn_Enter);
            this.btniniciar.Leave += new System.EventHandler(this.btn_Leave);
            this.btniniciar.MouseEnter += new System.EventHandler(this.btn_Enter);
            this.btniniciar.MouseLeave += new System.EventHandler(this.btn_Leave);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(17)))), ((int)(((byte)(90)))));
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncancelar.Location = new System.Drawing.Point(251, 217);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 30);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Enter += new System.EventHandler(this.btn_Enter);
            this.btncancelar.Leave += new System.EventHandler(this.btn_Leave);
            this.btncancelar.MouseEnter += new System.EventHandler(this.btn_Enter);
            this.btncancelar.MouseLeave += new System.EventHandler(this.btn_Leave);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btniniciar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancelar;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox pibSalir;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Button btncancelar;
    }
}