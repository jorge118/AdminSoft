﻿namespace AdminSoftNext.Vista
{
    partial class FormularioTiposPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioTiposPago));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtidPago = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelCabecera = new System.Windows.Forms.Panel();
            this.BtnRestaurar = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.BtnMaximizar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.txtidPago);
            this.panel1.Controls.Add(this.txtPago);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 315);
            this.panel1.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(113, 268);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(36, 36);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Location = new System.Drawing.Point(71, 268);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(36, 36);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(29, 268);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(36, 36);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(298, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtidPago
            // 
            this.txtidPago.Location = new System.Drawing.Point(119, 27);
            this.txtidPago.Name = "txtidPago";
            this.txtidPago.Size = new System.Drawing.Size(208, 20);
            this.txtidPago.TabIndex = 3;
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(119, 57);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(208, 20);
            this.txtPago.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // PanelCabecera
            // 
            this.PanelCabecera.BackColor = System.Drawing.Color.Goldenrod;
            this.PanelCabecera.Controls.Add(this.label3);
            this.PanelCabecera.Controls.Add(this.BtnRestaurar);
            this.PanelCabecera.Controls.Add(this.BtnMinimizar);
            this.PanelCabecera.Controls.Add(this.BtnMaximizar);
            this.PanelCabecera.Controls.Add(this.BtnCerrar);
            this.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCabecera.Location = new System.Drawing.Point(0, 0);
            this.PanelCabecera.Margin = new System.Windows.Forms.Padding(2);
            this.PanelCabecera.Name = "PanelCabecera";
            this.PanelCabecera.Size = new System.Drawing.Size(411, 29);
            this.PanelCabecera.TabIndex = 1;
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestaurar.FlatAppearance.BorderSize = 0;
            this.BtnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.BtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestaurar.Image")));
            this.BtnRestaurar.Location = new System.Drawing.Point(357, -2);
            this.BtnRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(25, 26);
            this.BtnRestaurar.TabIndex = 3;
            this.BtnRestaurar.UseVisualStyleBackColor = true;
            this.BtnRestaurar.Visible = false;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(329, 2);
            this.BtnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(25, 26);
            this.BtnMinimizar.TabIndex = 2;
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.FlatAppearance.BorderSize = 0;
            this.BtnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.Image")));
            this.BtnMaximizar.Location = new System.Drawing.Point(357, 2);
            this.BtnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(25, 26);
            this.BtnMaximizar.TabIndex = 1;
            this.BtnMaximizar.UseVisualStyleBackColor = true;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(385, 0);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 26);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "TIPOS DE PAGO";
            // 
            // FormularioTiposPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 384);
            this.Controls.Add(this.PanelCabecera);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioTiposPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioTiposPago";
            this.Load += new System.EventHandler(this.FormularioTiposPago_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PanelCabecera.ResumeLayout(false);
            this.PanelCabecera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtidPago;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel PanelCabecera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRestaurar;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Button BtnMaximizar;
        private System.Windows.Forms.Button BtnCerrar;
    }
}