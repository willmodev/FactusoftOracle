namespace PulsacionesGUI
{
    partial class PrincipalFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalFrm));
            this.BarraTituloPnl = new System.Windows.Forms.Panel();
            this.MaximizarBtn = new System.Windows.Forms.PictureBox();
            this.RestaurarBtn = new System.Windows.Forms.PictureBox();
            this.MinimizarBtn = new System.Windows.Forms.PictureBox();
            this.CerrarBtn = new System.Windows.Forms.PictureBox();
            this.MenuVerticalPnl = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gestionFacturaBtn = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.inicioBtn = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.facturarBtn = new FontAwesome.Sharp.IconButton();
            this.clientesBtn = new FontAwesome.Sharp.IconButton();
            this.productosBtn = new FontAwesome.Sharp.IconButton();
            this.PanelContenedorPnl = new System.Windows.Forms.Panel();
            this.HoraFechaTimer = new System.Windows.Forms.Timer(this.components);
            this.BarraTituloPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).BeginInit();
            this.MenuVerticalPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTituloPnl
            // 
            this.BarraTituloPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.BarraTituloPnl.Controls.Add(this.MaximizarBtn);
            this.BarraTituloPnl.Controls.Add(this.RestaurarBtn);
            this.BarraTituloPnl.Controls.Add(this.MinimizarBtn);
            this.BarraTituloPnl.Controls.Add(this.CerrarBtn);
            this.BarraTituloPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloPnl.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloPnl.Name = "BarraTituloPnl";
            this.BarraTituloPnl.Size = new System.Drawing.Size(1080, 38);
            this.BarraTituloPnl.TabIndex = 0;
            this.BarraTituloPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTituloPnl_MouseDown);
            // 
            // MaximizarBtn
            // 
            this.MaximizarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizarBtn.Image = ((System.Drawing.Image)(resources.GetObject("MaximizarBtn.Image")));
            this.MaximizarBtn.Location = new System.Drawing.Point(1022, 12);
            this.MaximizarBtn.Name = "MaximizarBtn";
            this.MaximizarBtn.Size = new System.Drawing.Size(15, 15);
            this.MaximizarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaximizarBtn.TabIndex = 1;
            this.MaximizarBtn.TabStop = false;
            this.MaximizarBtn.Visible = false;
            this.MaximizarBtn.Click += new System.EventHandler(this.MaximizarBtn_Click_1);
            // 
            // RestaurarBtn
            // 
            this.RestaurarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestaurarBtn.Image = ((System.Drawing.Image)(resources.GetObject("RestaurarBtn.Image")));
            this.RestaurarBtn.Location = new System.Drawing.Point(1022, 12);
            this.RestaurarBtn.Name = "RestaurarBtn";
            this.RestaurarBtn.Size = new System.Drawing.Size(15, 15);
            this.RestaurarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RestaurarBtn.TabIndex = 3;
            this.RestaurarBtn.TabStop = false;
            this.RestaurarBtn.Visible = false;
            this.RestaurarBtn.Click += new System.EventHandler(this.RestaurarBtn_Click_1);
            // 
            // MinimizarBtn
            // 
            this.MinimizarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizarBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarBtn.Image")));
            this.MinimizarBtn.Location = new System.Drawing.Point(1022, 12);
            this.MinimizarBtn.Name = "MinimizarBtn";
            this.MinimizarBtn.Size = new System.Drawing.Size(15, 15);
            this.MinimizarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizarBtn.TabIndex = 2;
            this.MinimizarBtn.TabStop = false;
            this.MinimizarBtn.Click += new System.EventHandler(this.MinimizarBtn_Click_1);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CerrarBtn.Image")));
            this.CerrarBtn.Location = new System.Drawing.Point(1050, 12);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(15, 15);
            this.CerrarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarBtn.TabIndex = 0;
            this.CerrarBtn.TabStop = false;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click_1);
            // 
            // MenuVerticalPnl
            // 
            this.MenuVerticalPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(6)))));
            this.MenuVerticalPnl.Controls.Add(this.panel5);
            this.MenuVerticalPnl.Controls.Add(this.gestionFacturaBtn);
            this.MenuVerticalPnl.Controls.Add(this.panel4);
            this.MenuVerticalPnl.Controls.Add(this.inicioBtn);
            this.MenuVerticalPnl.Controls.Add(this.panel3);
            this.MenuVerticalPnl.Controls.Add(this.panel2);
            this.MenuVerticalPnl.Controls.Add(this.panel1);
            this.MenuVerticalPnl.Controls.Add(this.facturarBtn);
            this.MenuVerticalPnl.Controls.Add(this.clientesBtn);
            this.MenuVerticalPnl.Controls.Add(this.productosBtn);
            this.MenuVerticalPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVerticalPnl.Location = new System.Drawing.Point(0, 38);
            this.MenuVerticalPnl.Name = "MenuVerticalPnl";
            this.MenuVerticalPnl.Size = new System.Drawing.Size(220, 512);
            this.MenuVerticalPnl.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.panel5.Location = new System.Drawing.Point(0, 355);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 60);
            this.panel5.TabIndex = 5;
            // 
            // gestionFacturaBtn
            // 
            this.gestionFacturaBtn.FlatAppearance.BorderSize = 0;
            this.gestionFacturaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.gestionFacturaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gestionFacturaBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.gestionFacturaBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionFacturaBtn.ForeColor = System.Drawing.Color.White;
            this.gestionFacturaBtn.IconChar = FontAwesome.Sharp.IconChar.Tractor;
            this.gestionFacturaBtn.IconColor = System.Drawing.Color.White;
            this.gestionFacturaBtn.IconSize = 32;
            this.gestionFacturaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gestionFacturaBtn.Location = new System.Drawing.Point(0, 355);
            this.gestionFacturaBtn.Name = "gestionFacturaBtn";
            this.gestionFacturaBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.gestionFacturaBtn.Rotation = 0D;
            this.gestionFacturaBtn.Size = new System.Drawing.Size(220, 60);
            this.gestionFacturaBtn.TabIndex = 6;
            this.gestionFacturaBtn.TabStop = false;
            this.gestionFacturaBtn.Text = "Gestion Facturas";
            this.gestionFacturaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gestionFacturaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gestionFacturaBtn.UseVisualStyleBackColor = true;
            this.gestionFacturaBtn.Click += new System.EventHandler(this.GestionFacturaBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 60);
            this.panel4.TabIndex = 3;
            // 
            // inicioBtn
            // 
            this.inicioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inicioBtn.FlatAppearance.BorderSize = 0;
            this.inicioBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.inicioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inicioBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.inicioBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioBtn.ForeColor = System.Drawing.Color.White;
            this.inicioBtn.IconChar = FontAwesome.Sharp.IconChar.Artstation;
            this.inicioBtn.IconColor = System.Drawing.Color.White;
            this.inicioBtn.IconSize = 32;
            this.inicioBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inicioBtn.Location = new System.Drawing.Point(0, 30);
            this.inicioBtn.Name = "inicioBtn";
            this.inicioBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.inicioBtn.Rotation = 0D;
            this.inicioBtn.Size = new System.Drawing.Size(220, 60);
            this.inicioBtn.TabIndex = 4;
            this.inicioBtn.TabStop = false;
            this.inicioBtn.Text = "Inicio";
            this.inicioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inicioBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inicioBtn.UseVisualStyleBackColor = true;
            this.inicioBtn.Click += new System.EventHandler(this.InicioBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.panel3.Location = new System.Drawing.Point(0, 273);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 60);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.panel2.Location = new System.Drawing.Point(0, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 60);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.panel1.Location = new System.Drawing.Point(0, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 60);
            this.panel1.TabIndex = 0;
            // 
            // facturarBtn
            // 
            this.facturarBtn.FlatAppearance.BorderSize = 0;
            this.facturarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.facturarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facturarBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.facturarBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturarBtn.ForeColor = System.Drawing.Color.White;
            this.facturarBtn.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.facturarBtn.IconColor = System.Drawing.Color.White;
            this.facturarBtn.IconSize = 32;
            this.facturarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.facturarBtn.Location = new System.Drawing.Point(0, 273);
            this.facturarBtn.Name = "facturarBtn";
            this.facturarBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.facturarBtn.Rotation = 0D;
            this.facturarBtn.Size = new System.Drawing.Size(220, 60);
            this.facturarBtn.TabIndex = 2;
            this.facturarBtn.TabStop = false;
            this.facturarBtn.Text = "Facturar";
            this.facturarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.facturarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.facturarBtn.UseVisualStyleBackColor = true;
            this.facturarBtn.Click += new System.EventHandler(this.FacturarBtn_Click);
            // 
            // clientesBtn
            // 
            this.clientesBtn.FlatAppearance.BorderSize = 0;
            this.clientesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.clientesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientesBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.clientesBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesBtn.ForeColor = System.Drawing.Color.White;
            this.clientesBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.clientesBtn.IconColor = System.Drawing.Color.White;
            this.clientesBtn.IconSize = 32;
            this.clientesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientesBtn.Location = new System.Drawing.Point(0, 193);
            this.clientesBtn.Name = "clientesBtn";
            this.clientesBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.clientesBtn.Rotation = 0D;
            this.clientesBtn.Size = new System.Drawing.Size(220, 60);
            this.clientesBtn.TabIndex = 1;
            this.clientesBtn.TabStop = false;
            this.clientesBtn.Text = "Clientes";
            this.clientesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clientesBtn.UseVisualStyleBackColor = true;
            this.clientesBtn.Click += new System.EventHandler(this.ClientesBtn_Click);
            // 
            // productosBtn
            // 
            this.productosBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productosBtn.FlatAppearance.BorderSize = 0;
            this.productosBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.productosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productosBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.productosBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosBtn.ForeColor = System.Drawing.Color.White;
            this.productosBtn.IconChar = FontAwesome.Sharp.IconChar.Tv;
            this.productosBtn.IconColor = System.Drawing.Color.White;
            this.productosBtn.IconSize = 32;
            this.productosBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productosBtn.Location = new System.Drawing.Point(0, 113);
            this.productosBtn.Name = "productosBtn";
            this.productosBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.productosBtn.Rotation = 0D;
            this.productosBtn.Size = new System.Drawing.Size(220, 60);
            this.productosBtn.TabIndex = 0;
            this.productosBtn.TabStop = false;
            this.productosBtn.Text = "Productos";
            this.productosBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productosBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productosBtn.UseVisualStyleBackColor = true;
            this.productosBtn.Click += new System.EventHandler(this.productosBtn_Click);
            // 
            // PanelContenedorPnl
            // 
            this.PanelContenedorPnl.BackColor = System.Drawing.Color.White;
            this.PanelContenedorPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorPnl.Location = new System.Drawing.Point(220, 38);
            this.PanelContenedorPnl.Name = "PanelContenedorPnl";
            this.PanelContenedorPnl.Size = new System.Drawing.Size(860, 512);
            this.PanelContenedorPnl.TabIndex = 2;
            // 
            // HoraFechaTimer
            // 
            this.HoraFechaTimer.Enabled = true;
            // 
            // PrincipalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 550);
            this.Controls.Add(this.PanelContenedorPnl);
            this.Controls.Add(this.MenuVerticalPnl);
            this.Controls.Add(this.BarraTituloPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalFrm";
            this.Text = "Form1";
            this.BarraTituloPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaximizarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).EndInit();
            this.MenuVerticalPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTituloPnl;
        private System.Windows.Forms.Panel MenuVerticalPnl;
        private System.Windows.Forms.Panel PanelContenedorPnl;
        private System.Windows.Forms.PictureBox RestaurarBtn;
        private System.Windows.Forms.PictureBox MinimizarBtn;
        private System.Windows.Forms.PictureBox MaximizarBtn;
        private System.Windows.Forms.PictureBox CerrarBtn;
        private FontAwesome.Sharp.IconButton facturarBtn;
        private FontAwesome.Sharp.IconButton clientesBtn;
        private FontAwesome.Sharp.IconButton productosBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton inicioBtn;
        private System.Windows.Forms.Timer HoraFechaTimer;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton gestionFacturaBtn;
    }
}

