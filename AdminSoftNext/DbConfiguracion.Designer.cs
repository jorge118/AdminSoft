namespace AdminSoftNext
{
    partial class DbConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DbConfiguracion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnLogoLogin = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtSrv = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtDb = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.BtnPruebaConexion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 44);
            this.panel1.TabIndex = 0;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(918, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(47, 38);
            this.BtnCerrar.TabIndex = 12;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.BtnLogoLogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 565);
            this.panel2.TabIndex = 1;
            // 
            // BtnLogoLogin
            // 
            this.BtnLogoLogin.BackColor = System.Drawing.Color.SeaShell;
            this.BtnLogoLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogoLogin.ForeColor = System.Drawing.Color.Red;
            this.BtnLogoLogin.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogoLogin.Image")));
            this.BtnLogoLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLogoLogin.Location = new System.Drawing.Point(0, 3);
            this.BtnLogoLogin.Name = "BtnLogoLogin";
            this.BtnLogoLogin.Size = new System.Drawing.Size(248, 562);
            this.BtnLogoLogin.TabIndex = 1;
            this.BtnLogoLogin.TabStop = false;
            this.BtnLogoLogin.Text = "  NEXTGENESYS";
            this.BtnLogoLogin.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnLogoLogin.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(368, 83);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(486, 37);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "CONEXION A BASE DE DATOS";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAceptar.Enabled = false;
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(578, 540);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(276, 57);
            this.BtnAceptar.TabIndex = 5;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtSrv
            // 
            this.TxtSrv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.TxtSrv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSrv.ForeColor = System.Drawing.Color.White;
            this.TxtSrv.Location = new System.Drawing.Point(375, 169);
            this.TxtSrv.Multiline = true;
            this.TxtSrv.Name = "TxtSrv";
            this.TxtSrv.Size = new System.Drawing.Size(464, 37);
            this.TxtSrv.TabIndex = 1;
            this.TxtSrv.Text = "SERVIDOR";
            this.TxtSrv.Enter += new System.EventHandler(this.TxtSrv_Enter);
            this.TxtSrv.Leave += new System.EventHandler(this.TxtSrv_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Location = new System.Drawing.Point(377, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 3);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaShell;
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Location = new System.Drawing.Point(379, 313);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(482, 3);
            this.panel4.TabIndex = 16;
            // 
            // TxtDb
            // 
            this.TxtDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.TxtDb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDb.ForeColor = System.Drawing.Color.White;
            this.TxtDb.Location = new System.Drawing.Point(377, 258);
            this.TxtDb.Multiline = true;
            this.TxtDb.Name = "TxtDb";
            this.TxtDb.Size = new System.Drawing.Size(464, 37);
            this.TxtDb.TabIndex = 2;
            this.TxtDb.Text = "BASE DE DATOS";
            this.TxtDb.Enter += new System.EventHandler(this.TxtDb_Enter);
            this.TxtDb.Leave += new System.EventHandler(this.TxtDb_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaShell;
            this.panel5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Location = new System.Drawing.Point(379, 397);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(482, 3);
            this.panel5.TabIndex = 18;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(377, 342);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(464, 37);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaShell;
            this.panel6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.Location = new System.Drawing.Point(379, 473);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(482, 3);
            this.panel6.TabIndex = 18;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.Location = new System.Drawing.Point(377, 418);
            this.txtContraseña.Multiline = true;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(464, 37);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.Text = "CONTRASEÑA";
            this.txtContraseña.Enter += new System.EventHandler(this.textBox2_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // BtnPruebaConexion
            // 
            this.BtnPruebaConexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.BtnPruebaConexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPruebaConexion.FlatAppearance.BorderSize = 0;
            this.BtnPruebaConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPruebaConexion.ForeColor = System.Drawing.Color.White;
            this.BtnPruebaConexion.Location = new System.Drawing.Point(377, 540);
            this.BtnPruebaConexion.Name = "BtnPruebaConexion";
            this.BtnPruebaConexion.Size = new System.Drawing.Size(183, 57);
            this.BtnPruebaConexion.TabIndex = 19;
            this.BtnPruebaConexion.Text = "Probar Conexion";
            this.BtnPruebaConexion.UseVisualStyleBackColor = false;
            this.BtnPruebaConexion.Click += new System.EventHandler(this.BtnPruebaConexion_Click);
            // 
            // DbConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(968, 609);
            this.Controls.Add(this.BtnPruebaConexion);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TxtDb);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TxtSrv);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DbConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnLogoLogin;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtSrv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TxtDb;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button BtnPruebaConexion;
    }
}