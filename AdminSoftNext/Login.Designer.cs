namespace AdminSoftNext
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.PnLateral = new System.Windows.Forms.Panel();
            this.BtnLogoLogin = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtUsario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnPanel = new System.Windows.Forms.Button();
            this.BtnDbConexion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PnLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.Location = new System.Drawing.Point(306, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 40);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
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
            this.BtnCerrar.Location = new System.Drawing.Point(810, -3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(47, 47);
            this.BtnCerrar.TabIndex = 11;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // PnLateral
            // 
            this.PnLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.PnLateral.Controls.Add(this.BtnLogoLogin);
            this.PnLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnLateral.Location = new System.Drawing.Point(0, 0);
            this.PnLateral.Name = "PnLateral";
            this.PnLateral.Size = new System.Drawing.Size(306, 618);
            this.PnLateral.TabIndex = 0;
            // 
            // BtnLogoLogin
            // 
            this.BtnLogoLogin.BackColor = System.Drawing.Color.SeaShell;
            this.BtnLogoLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogoLogin.ForeColor = System.Drawing.Color.Red;
            this.BtnLogoLogin.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogoLogin.Image")));
            this.BtnLogoLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLogoLogin.Location = new System.Drawing.Point(3, 3);
            this.BtnLogoLogin.Name = "BtnLogoLogin";
            this.BtnLogoLogin.Size = new System.Drawing.Size(306, 612);
            this.BtnLogoLogin.TabIndex = 0;
            this.BtnLogoLogin.TabStop = false;
            this.BtnLogoLogin.Text = "  NEXTGENESYS";
            this.BtnLogoLogin.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnLogoLogin.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(600, 88);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 51);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "INGRESO";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtUsario
            // 
            this.txtUsario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtUsario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsario.ForeColor = System.Drawing.Color.SeaShell;
            this.txtUsario.Location = new System.Drawing.Point(481, 212);
            this.txtUsario.Multiline = true;
            this.txtUsario.Name = "txtUsario";
            this.txtUsario.Size = new System.Drawing.Size(477, 53);
            this.txtUsario.TabIndex = 1;
            this.txtUsario.Text = "USUARIO";
            this.txtUsario.TextChanged += new System.EventHandler(this.txtUusario_TextChanged);
            this.txtUsario.Enter += new System.EventHandler(this.txtUusario_Enter);
            this.txtUsario.Leave += new System.EventHandler(this.txtUusario_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.ForeColor = System.Drawing.Color.SeaShell;
            this.txtPassword.Location = new System.Drawing.Point(480, 337);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(477, 53);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "CONTRASEÑA";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(480, 507);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(477, 57);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(480, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 3);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Location = new System.Drawing.Point(480, 397);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 3);
            this.panel3.TabIndex = 10;
            // 
            // BtnPanel
            // 
            this.BtnPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.BtnPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPanel.FlatAppearance.BorderSize = 0;
            this.BtnPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPanel.ForeColor = System.Drawing.Color.White;
            this.BtnPanel.Location = new System.Drawing.Point(991, 507);
            this.BtnPanel.Name = "BtnPanel";
            this.BtnPanel.Size = new System.Drawing.Size(157, 57);
            this.BtnPanel.TabIndex = 11;
            this.BtnPanel.Text = "PANEL";
            this.BtnPanel.UseVisualStyleBackColor = false;
            this.BtnPanel.Click += new System.EventHandler(this.BtnPanel_Click);
            // 
            // BtnDbConexion
            // 
            this.BtnDbConexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.BtnDbConexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDbConexion.FlatAppearance.BorderSize = 0;
            this.BtnDbConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDbConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDbConexion.ForeColor = System.Drawing.Color.White;
            this.BtnDbConexion.Location = new System.Drawing.Point(312, 49);
            this.BtnDbConexion.Name = "BtnDbConexion";
            this.BtnDbConexion.Size = new System.Drawing.Size(232, 36);
            this.BtnDbConexion.TabIndex = 12;
            this.BtnDbConexion.Text = "CONEXION DB";
            this.BtnDbConexion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDbConexion.UseVisualStyleBackColor = false;
            this.BtnDbConexion.Click += new System.EventHandler(this.BtnDbConexion_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1158, 618);
            this.Controls.Add(this.BtnDbConexion);
            this.Controls.Add(this.BtnPanel);
            this.Controls.Add(this.txtUsario);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.PnLateral.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnLateral;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnLogoLogin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtUsario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnPanel;
        private System.Windows.Forms.Button BtnDbConexion;
    }
}