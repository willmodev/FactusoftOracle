namespace PulsacionesGUI
{
    partial class FacturaFrm
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
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCedulaClient = new System.Windows.Forms.TextBox();
            this.TxtLastNameClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNameClient = new System.Windows.Forms.TextBox();
            this.BtnAddClient = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblInvoiceNumber = new System.Windows.Forms.Label();
            this.BtnEliminarProducto = new FontAwesome.Sharp.IconButton();
            this.LblTotalInvoice = new System.Windows.Forms.Label();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.LblIVA = new System.Windows.Forms.Label();
            this.BtnSearchProduct = new FontAwesome.Sharp.IconButton();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtWarehouseQuantity = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtUnitValue = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtIVA = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.BtnAddInvoiceDetail = new FontAwesome.Sharp.IconButton();
            this.BtnShowList = new FontAwesome.Sharp.IconButton();
            this.BtnEdit = new FontAwesome.Sharp.IconButton();
            this.TxtDiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtUnitMeasure = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.CmbInvoiceType = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.BtnSearchClient = new FontAwesome.Sharp.IconButton();
            this.DgvTableInvoiceDetail = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnCommitInvoice = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTableInvoiceDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(48, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 24);
            this.label13.TabIndex = 84;
            this.label13.Text = "Datos Factura";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label5.Location = new System.Drawing.Point(167, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Identificacion: ";
            // 
            // TxtCedulaClient
            // 
            this.TxtCedulaClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCedulaClient.Location = new System.Drawing.Point(170, 149);
            this.TxtCedulaClient.Name = "TxtCedulaClient";
            this.TxtCedulaClient.Size = new System.Drawing.Size(138, 20);
            this.TxtCedulaClient.TabIndex = 68;
            // 
            // TxtLastNameClient
            // 
            this.TxtLastNameClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtLastNameClient.Location = new System.Drawing.Point(536, 149);
            this.TxtLastNameClient.Name = "TxtLastNameClient";
            this.TxtLastNameClient.Size = new System.Drawing.Size(136, 20);
            this.TxtLastNameClient.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label2.Location = new System.Drawing.Point(533, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(349, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "Nombre:";
            // 
            // TxtNameClient
            // 
            this.TxtNameClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtNameClient.Location = new System.Drawing.Point(352, 149);
            this.TxtNameClient.Name = "TxtNameClient";
            this.TxtNameClient.Size = new System.Drawing.Size(138, 20);
            this.TxtNameClient.TabIndex = 93;
            // 
            // BtnAddClient
            // 
            this.BtnAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddClient.BackColor = System.Drawing.Color.White;
            this.BtnAddClient.FlatAppearance.BorderSize = 0;
            this.BtnAddClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAddClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddClient.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddClient.ForeColor = System.Drawing.Color.Lime;
            this.BtnAddClient.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.BtnAddClient.IconColor = System.Drawing.Color.Lime;
            this.BtnAddClient.IconSize = 30;
            this.BtnAddClient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAddClient.Location = new System.Drawing.Point(731, 133);
            this.BtnAddClient.Name = "BtnAddClient";
            this.BtnAddClient.Rotation = 0D;
            this.BtnAddClient.Size = new System.Drawing.Size(60, 44);
            this.BtnAddClient.TabIndex = 93;
            this.BtnAddClient.Text = "Agregar";
            this.BtnAddClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAddClient.UseVisualStyleBackColor = false;
            this.BtnAddClient.Click += new System.EventHandler(this.BtnAddClient_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(48, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 24);
            this.label4.TabIndex = 95;
            this.label4.Text = "Agregar Productos";
            // 
            // TxtID
            // 
            this.TxtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtID.Location = new System.Drawing.Point(148, 241);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(77, 20);
            this.TxtID.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label6.Location = new System.Drawing.Point(145, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "ID:";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtQuantity.Location = new System.Drawing.Point(496, 242);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(64, 20);
            this.TxtQuantity.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label7.Location = new System.Drawing.Point(492, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 99;
            this.label7.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label8.Location = new System.Drawing.Point(49, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "N° de factura:";
            // 
            // LblInvoiceNumber
            // 
            this.LblInvoiceNumber.AutoSize = true;
            this.LblInvoiceNumber.Location = new System.Drawing.Point(142, 79);
            this.LblInvoiceNumber.Name = "LblInvoiceNumber";
            this.LblInvoiceNumber.Size = new System.Drawing.Size(0, 13);
            this.LblInvoiceNumber.TabIndex = 103;
            // 
            // BtnEliminarProducto
            // 
            this.BtnEliminarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarProducto.BackColor = System.Drawing.Color.White;
            this.BtnEliminarProducto.FlatAppearance.BorderSize = 0;
            this.BtnEliminarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEliminarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarProducto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProducto.ForeColor = System.Drawing.Color.Crimson;
            this.BtnEliminarProducto.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnEliminarProducto.IconColor = System.Drawing.Color.Crimson;
            this.BtnEliminarProducto.IconSize = 20;
            this.BtnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarProducto.Location = new System.Drawing.Point(663, 262);
            this.BtnEliminarProducto.Name = "BtnEliminarProducto";
            this.BtnEliminarProducto.Rotation = 0D;
            this.BtnEliminarProducto.Size = new System.Drawing.Size(79, 24);
            this.BtnEliminarProducto.TabIndex = 104;
            this.BtnEliminarProducto.Text = "Eliminar";
            this.BtnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminarProducto.UseVisualStyleBackColor = false;
            this.BtnEliminarProducto.Click += new System.EventHandler(this.BtnEliminarProducto_Click);
            // 
            // LblTotalInvoice
            // 
            this.LblTotalInvoice.AutoSize = true;
            this.LblTotalInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalInvoice.Location = new System.Drawing.Point(624, 401);
            this.LblTotalInvoice.Name = "LblTotalInvoice";
            this.LblTotalInvoice.Size = new System.Drawing.Size(0, 13);
            this.LblTotalInvoice.TabIndex = 108;
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.AutoSize = true;
            this.LblSubTotal.Location = new System.Drawing.Point(633, 350);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(0, 13);
            this.LblSubTotal.TabIndex = 109;
            // 
            // LblIVA
            // 
            this.LblIVA.AutoSize = true;
            this.LblIVA.Location = new System.Drawing.Point(611, 375);
            this.LblIVA.Name = "LblIVA";
            this.LblIVA.Size = new System.Drawing.Size(0, 13);
            this.LblIVA.TabIndex = 111;
            // 
            // BtnSearchProduct
            // 
            this.BtnSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearchProduct.BackColor = System.Drawing.Color.White;
            this.BtnSearchProduct.FlatAppearance.BorderSize = 0;
            this.BtnSearchProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSearchProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchProduct.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchProduct.ForeColor = System.Drawing.Color.Lime;
            this.BtnSearchProduct.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearchProduct.IconColor = System.Drawing.Color.Lime;
            this.BtnSearchProduct.IconSize = 20;
            this.BtnSearchProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearchProduct.Location = new System.Drawing.Point(60, 240);
            this.BtnSearchProduct.Name = "BtnSearchProduct";
            this.BtnSearchProduct.Rotation = 0D;
            this.BtnSearchProduct.Size = new System.Drawing.Size(76, 23);
            this.BtnSearchProduct.TabIndex = 97;
            this.BtnSearchProduct.Text = "Buscar";
            this.BtnSearchProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSearchProduct.UseVisualStyleBackColor = false;
            this.BtnSearchProduct.Click += new System.EventHandler(this.BtnSearchProduct_Click);
            // 
            // TxtName
            // 
            this.TxtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtName.Location = new System.Drawing.Point(247, 241);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(114, 20);
            this.TxtName.TabIndex = 112;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label10.Location = new System.Drawing.Point(244, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 113;
            this.label10.Text = "Nombre:";
            // 
            // TxtWarehouseQuantity
            // 
            this.TxtWarehouseQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtWarehouseQuantity.Location = new System.Drawing.Point(390, 287);
            this.TxtWarehouseQuantity.Name = "TxtWarehouseQuantity";
            this.TxtWarehouseQuantity.Size = new System.Drawing.Size(81, 20);
            this.TxtWarehouseQuantity.TabIndex = 114;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label16.Location = new System.Drawing.Point(387, 271);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 115;
            this.label16.Text = "Cant. Bodega:";
            // 
            // TxtUnitValue
            // 
            this.TxtUnitValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUnitValue.Location = new System.Drawing.Point(148, 284);
            this.TxtUnitValue.Name = "TxtUnitValue";
            this.TxtUnitValue.Size = new System.Drawing.Size(64, 20);
            this.TxtUnitValue.TabIndex = 117;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label17.Location = new System.Drawing.Point(145, 268);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 116;
            this.label17.Text = "Valor Unit:";
            // 
            // TxtIVA
            // 
            this.TxtIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtIVA.Location = new System.Drawing.Point(247, 284);
            this.TxtIVA.Name = "TxtIVA";
            this.TxtIVA.Size = new System.Drawing.Size(81, 20);
            this.TxtIVA.TabIndex = 119;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label18.Location = new System.Drawing.Point(244, 268);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 118;
            this.label18.Text = "IVA:";
            // 
            // BtnAddInvoiceDetail
            // 
            this.BtnAddInvoiceDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddInvoiceDetail.BackColor = System.Drawing.Color.White;
            this.BtnAddInvoiceDetail.FlatAppearance.BorderSize = 0;
            this.BtnAddInvoiceDetail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAddInvoiceDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnAddInvoiceDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddInvoiceDetail.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAddInvoiceDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddInvoiceDetail.ForeColor = System.Drawing.Color.Lime;
            this.BtnAddInvoiceDetail.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.BtnAddInvoiceDetail.IconColor = System.Drawing.Color.Lime;
            this.BtnAddInvoiceDetail.IconSize = 20;
            this.BtnAddInvoiceDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddInvoiceDetail.Location = new System.Drawing.Point(663, 226);
            this.BtnAddInvoiceDetail.Name = "BtnAddInvoiceDetail";
            this.BtnAddInvoiceDetail.Rotation = 0D;
            this.BtnAddInvoiceDetail.Size = new System.Drawing.Size(81, 26);
            this.BtnAddInvoiceDetail.TabIndex = 122;
            this.BtnAddInvoiceDetail.Text = "Agregar";
            this.BtnAddInvoiceDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddInvoiceDetail.UseVisualStyleBackColor = false;
            this.BtnAddInvoiceDetail.Click += new System.EventHandler(this.BtnAddInvoiceDetail_Click);
            // 
            // BtnShowList
            // 
            this.BtnShowList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnShowList.BackColor = System.Drawing.Color.White;
            this.BtnShowList.FlatAppearance.BorderSize = 0;
            this.BtnShowList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnShowList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnShowList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowList.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnShowList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowList.ForeColor = System.Drawing.Color.Lime;
            this.BtnShowList.IconChar = FontAwesome.Sharp.IconChar.List;
            this.BtnShowList.IconColor = System.Drawing.Color.Lime;
            this.BtnShowList.IconSize = 20;
            this.BtnShowList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnShowList.Location = new System.Drawing.Point(60, 284);
            this.BtnShowList.Name = "BtnShowList";
            this.BtnShowList.Rotation = 0D;
            this.BtnShowList.Size = new System.Drawing.Size(82, 23);
            this.BtnShowList.TabIndex = 123;
            this.BtnShowList.Text = "Ver Lista";
            this.BtnShowList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnShowList.UseVisualStyleBackColor = false;
            this.BtnShowList.Click += new System.EventHandler(this.BtnVerlista_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.BackColor = System.Drawing.Color.White;
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtnEdit.IconColor = System.Drawing.Color.RoyalBlue;
            this.BtnEdit.IconSize = 20;
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.Location = new System.Drawing.Point(663, 296);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Rotation = 0D;
            this.BtnEdit.Size = new System.Drawing.Size(79, 24);
            this.BtnEdit.TabIndex = 124;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // TxtDiscount
            // 
            this.TxtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDiscount.Location = new System.Drawing.Point(496, 287);
            this.TxtDiscount.Name = "TxtDiscount";
            this.TxtDiscount.Size = new System.Drawing.Size(64, 20);
            this.TxtDiscount.TabIndex = 127;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label9.Location = new System.Drawing.Point(493, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 126;
            this.label9.Text = "Descuento:";
            // 
            // TxtUnitMeasure
            // 
            this.TxtUnitMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUnitMeasure.Location = new System.Drawing.Point(390, 241);
            this.TxtUnitMeasure.Name = "TxtUnitMeasure";
            this.TxtUnitMeasure.Size = new System.Drawing.Size(64, 20);
            this.TxtUnitMeasure.TabIndex = 129;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label21.Location = new System.Drawing.Point(387, 225);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 13);
            this.label21.TabIndex = 128;
            this.label21.Text = "Unidad:";
            // 
            // CmbInvoiceType
            // 
            this.CmbInvoiceType.FormattingEnabled = true;
            this.CmbInvoiceType.Items.AddRange(new object[] {
            "Compra",
            "Venta"});
            this.CmbInvoiceType.Location = new System.Drawing.Point(390, 76);
            this.CmbInvoiceType.Name = "CmbInvoiceType";
            this.CmbInvoiceType.Size = new System.Drawing.Size(121, 21);
            this.CmbInvoiceType.TabIndex = 130;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label22.Location = new System.Drawing.Point(284, 79);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 13);
            this.label22.TabIndex = 131;
            this.label22.Text = "Tipo de factura:";
            // 
            // BtnSearchClient
            // 
            this.BtnSearchClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearchClient.BackColor = System.Drawing.Color.White;
            this.BtnSearchClient.FlatAppearance.BorderSize = 0;
            this.BtnSearchClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSearchClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnSearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchClient.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchClient.ForeColor = System.Drawing.Color.Lime;
            this.BtnSearchClient.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearchClient.IconColor = System.Drawing.Color.Lime;
            this.BtnSearchClient.IconSize = 20;
            this.BtnSearchClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearchClient.Location = new System.Drawing.Point(60, 146);
            this.BtnSearchClient.Name = "BtnSearchClient";
            this.BtnSearchClient.Rotation = 0D;
            this.BtnSearchClient.Size = new System.Drawing.Size(76, 23);
            this.BtnSearchClient.TabIndex = 132;
            this.BtnSearchClient.Text = "Buscar";
            this.BtnSearchClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSearchClient.UseVisualStyleBackColor = false;
            this.BtnSearchClient.Click += new System.EventHandler(this.BtnSearchClient_Click);
            // 
            // DgvTableInvoiceDetail
            // 
            this.DgvTableInvoiceDetail.BackgroundColor = System.Drawing.Color.White;
            this.DgvTableInvoiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTableInvoiceDetail.Location = new System.Drawing.Point(52, 336);
            this.DgvTableInvoiceDetail.Name = "DgvTableInvoiceDetail";
            this.DgvTableInvoiceDetail.ReadOnly = true;
            this.DgvTableInvoiceDetail.Size = new System.Drawing.Size(501, 150);
            this.DgvTableInvoiceDetail.TabIndex = 133;
            this.DgvTableInvoiceDetail.TabStop = false;
            this.DgvTableInvoiceDetail.Visible = false;
            this.DgvTableInvoiceDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTableInvoiceDetail_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 134;
            this.label3.Text = "Subtotal:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(582, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 135;
            this.label11.Text = "IVA:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(582, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 136;
            this.label12.Text = "Total:";
            // 
            // BtnCommitInvoice
            // 
            this.BtnCommitInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCommitInvoice.BackColor = System.Drawing.Color.White;
            this.BtnCommitInvoice.FlatAppearance.BorderSize = 0;
            this.BtnCommitInvoice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCommitInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnCommitInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCommitInvoice.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCommitInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCommitInvoice.ForeColor = System.Drawing.Color.Lime;
            this.BtnCommitInvoice.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            this.BtnCommitInvoice.IconColor = System.Drawing.Color.Lime;
            this.BtnCommitInvoice.IconSize = 30;
            this.BtnCommitInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCommitInvoice.Location = new System.Drawing.Point(663, 444);
            this.BtnCommitInvoice.Name = "BtnCommitInvoice";
            this.BtnCommitInvoice.Rotation = 0D;
            this.BtnCommitInvoice.Size = new System.Drawing.Size(145, 42);
            this.BtnCommitInvoice.TabIndex = 137;
            this.BtnCommitInvoice.Text = "Confirmar  Factura";
            this.BtnCommitInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCommitInvoice.UseVisualStyleBackColor = false;
            this.BtnCommitInvoice.Click += new System.EventHandler(this.BtnCommitInvoice_Click);
            // 
            // FacturaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 512);
            this.Controls.Add(this.BtnCommitInvoice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvTableInvoiceDetail);
            this.Controls.Add(this.BtnSearchClient);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.CmbInvoiceType);
            this.Controls.Add(this.TxtUnitMeasure);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.TxtDiscount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnShowList);
            this.Controls.Add(this.BtnAddInvoiceDetail);
            this.Controls.Add(this.TxtIVA);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TxtUnitValue);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TxtWarehouseQuantity);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblIVA);
            this.Controls.Add(this.LblSubTotal);
            this.Controls.Add(this.LblTotalInvoice);
            this.Controls.Add(this.BtnEliminarProducto);
            this.Controls.Add(this.LblInvoiceNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.TxtCedulaClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtLastNameClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNameClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnSearchProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAddClient);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturaFrm";
            this.Text = "FacturaFrm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTableInvoiceDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCedulaClient;
        private System.Windows.Forms.TextBox TxtLastNameClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnAddClient;
        private System.Windows.Forms.TextBox TxtNameClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblInvoiceNumber;
        private FontAwesome.Sharp.IconButton BtnEliminarProducto;
        private System.Windows.Forms.Label LblTotalInvoice;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.Label LblIVA;
        private FontAwesome.Sharp.IconButton BtnSearchProduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private FontAwesome.Sharp.IconButton BtnAddInvoiceDetail;
        private FontAwesome.Sharp.IconButton BtnShowList;
        private FontAwesome.Sharp.IconButton BtnEdit;
        public System.Windows.Forms.TextBox TxtID;
        public System.Windows.Forms.TextBox TxtQuantity;
        public System.Windows.Forms.TextBox TxtName;
        public System.Windows.Forms.TextBox TxtWarehouseQuantity;
        public System.Windows.Forms.TextBox TxtUnitValue;
        public System.Windows.Forms.TextBox TxtIVA;
        public System.Windows.Forms.TextBox TxtDiscount;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TxtUnitMeasure;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox CmbInvoiceType;
        private System.Windows.Forms.Label label22;
        private FontAwesome.Sharp.IconButton BtnSearchClient;
        private System.Windows.Forms.DataGridView DgvTableInvoiceDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton BtnCommitInvoice;
    }
}