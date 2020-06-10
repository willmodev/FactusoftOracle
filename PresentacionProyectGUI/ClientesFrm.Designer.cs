namespace PulsacionesGUI
{
    partial class ClientesFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFistName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSocondName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSecondLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTelephone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAddressHome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNeighborhood = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.CmbSex = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DtpDateOfBorn = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.DgvTableClients = new System.Windows.Forms.DataGridView();
            this.BtnShowList = new FontAwesome.Sharp.IconButton();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnModify = new FontAwesome.Sharp.IconButton();
            this.BtnRemove = new FontAwesome.Sharp.IconButton();
            this.BtnSave = new FontAwesome.Sharp.IconButton();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnSearch = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTableClients)).BeginInit();
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
            this.label13.Location = new System.Drawing.Point(48, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 24);
            this.label13.TabIndex = 83;
            this.label13.Text = "Registrar Clientes";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label2.Location = new System.Drawing.Point(237, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Primer Nombre: ";
            // 
            // TxtFistName
            // 
            this.TxtFistName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFistName.Location = new System.Drawing.Point(240, 90);
            this.TxtFistName.Name = "TxtFistName";
            this.TxtFistName.Size = new System.Drawing.Size(144, 20);
            this.TxtFistName.TabIndex = 2;
            this.TxtFistName.ModifiedChanged += new System.EventHandler(this.TextBoxes_ModifiedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(421, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Segundo Nombre: ";
            // 
            // TxtSocondName
            // 
            this.TxtSocondName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSocondName.Location = new System.Drawing.Point(424, 90);
            this.TxtSocondName.Name = "TxtSocondName";
            this.TxtSocondName.Size = new System.Drawing.Size(144, 20);
            this.TxtSocondName.TabIndex = 3;
            this.TxtSocondName.ModifiedChanged += new System.EventHandler(this.TextBoxes_ModifiedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label3.Location = new System.Drawing.Point(60, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Primer Apellido: ";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLastName.Location = new System.Drawing.Point(63, 141);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(144, 20);
            this.TxtLastName.TabIndex = 4;
            this.TxtLastName.ModifiedChanged += new System.EventHandler(this.TextBoxes_ModifiedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label4.Location = new System.Drawing.Point(237, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Segundo Apellido: ";
            // 
            // TxtSecondLastName
            // 
            this.TxtSecondLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSecondLastName.Location = new System.Drawing.Point(240, 141);
            this.TxtSecondLastName.Name = "TxtSecondLastName";
            this.TxtSecondLastName.Size = new System.Drawing.Size(144, 20);
            this.TxtSecondLastName.TabIndex = 5;
            this.TxtSecondLastName.ModifiedChanged += new System.EventHandler(this.TextBoxes_ModifiedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label5.Location = new System.Drawing.Point(611, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Cedula:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.Location = new System.Drawing.Point(614, 95);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(144, 20);
            this.TxtSearch.TabIndex = 66;
            this.TxtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtSearch_MouseClick);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label6.Location = new System.Drawing.Point(60, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Telefono: ";
            // 
            // TxtTelephone
            // 
            this.TxtTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTelephone.Location = new System.Drawing.Point(63, 239);
            this.TxtTelephone.Name = "TxtTelephone";
            this.TxtTelephone.Size = new System.Drawing.Size(144, 20);
            this.TxtTelephone.TabIndex = 10;
            this.TxtTelephone.ModifiedChanged += new System.EventHandler(this.TextBoxes_ModifiedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label7.Location = new System.Drawing.Point(237, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Correo: ";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmail.Location = new System.Drawing.Point(240, 239);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(144, 20);
            this.TxtEmail.TabIndex = 11;
            this.TxtEmail.ModifiedChanged += new System.EventHandler(this.TextBoxes_ModifiedChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label8.Location = new System.Drawing.Point(60, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "Direccion:";
            // 
            // TxtAddressHome
            // 
            this.TxtAddressHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAddressHome.Location = new System.Drawing.Point(63, 189);
            this.TxtAddressHome.Name = "TxtAddressHome";
            this.TxtAddressHome.Size = new System.Drawing.Size(144, 20);
            this.TxtAddressHome.TabIndex = 7;
            this.TxtAddressHome.ModifiedChanged += new System.EventHandler(this.TextBoxes_ModifiedChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label9.Location = new System.Drawing.Point(237, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "Barrio:";
            // 
            // TxtNeighborhood
            // 
            this.TxtNeighborhood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNeighborhood.Location = new System.Drawing.Point(240, 189);
            this.TxtNeighborhood.Name = "TxtNeighborhood";
            this.TxtNeighborhood.Size = new System.Drawing.Size(153, 20);
            this.TxtNeighborhood.TabIndex = 8;
            this.TxtNeighborhood.ModifiedChanged += new System.EventHandler(this.TextBoxes_ModifiedChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label10.Location = new System.Drawing.Point(421, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "Ciudad:";
            // 
            // TxtCity
            // 
            this.TxtCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCity.Location = new System.Drawing.Point(424, 189);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(144, 20);
            this.TxtCity.TabIndex = 9;
            this.TxtCity.ModifiedChanged += new System.EventHandler(this.TextBoxes_ModifiedChanged);
            // 
            // CmbSex
            // 
            this.CmbSex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbSex.FormattingEnabled = true;
            this.CmbSex.ItemHeight = 13;
            this.CmbSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CmbSex.Location = new System.Drawing.Point(424, 141);
            this.CmbSex.Name = "CmbSex";
            this.CmbSex.Size = new System.Drawing.Size(66, 21);
            this.CmbSex.TabIndex = 78;
            this.CmbSex.SelectedIndexChanged += new System.EventHandler(this.CmbSex_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label11.Location = new System.Drawing.Point(421, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "Sexo:";
            // 
            // DtpDateOfBorn
            // 
            this.DtpDateOfBorn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpDateOfBorn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateOfBorn.Location = new System.Drawing.Point(424, 239);
            this.DtpDateOfBorn.Name = "DtpDateOfBorn";
            this.DtpDateOfBorn.Size = new System.Drawing.Size(144, 20);
            this.DtpDateOfBorn.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label12.Location = new System.Drawing.Point(421, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 13);
            this.label12.TabIndex = 81;
            this.label12.Text = "Fecha De Nacimiento:";
            // 
            // DgvTableClients
            // 
            this.DgvTableClients.BackgroundColor = System.Drawing.Color.White;
            this.DgvTableClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTableClients.Location = new System.Drawing.Point(63, 333);
            this.DgvTableClients.Name = "DgvTableClients";
            this.DgvTableClients.ReadOnly = true;
            this.DgvTableClients.Size = new System.Drawing.Size(734, 150);
            this.DgvTableClients.TabIndex = 97;
            this.DgvTableClients.TabStop = false;
            this.DgvTableClients.Visible = false;
            this.DgvTableClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTableClients_CellContentClick);
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
            this.BtnShowList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.BtnShowList.IconChar = FontAwesome.Sharp.IconChar.List;
            this.BtnShowList.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.BtnShowList.IconSize = 30;
            this.BtnShowList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnShowList.Location = new System.Drawing.Point(63, 285);
            this.BtnShowList.Name = "BtnShowList";
            this.BtnShowList.Rotation = 0D;
            this.BtnShowList.Size = new System.Drawing.Size(159, 42);
            this.BtnShowList.TabIndex = 14;
            this.BtnShowList.Text = "Ver / Ocultar Lista";
            this.BtnShowList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnShowList.UseVisualStyleBackColor = false;
            this.BtnShowList.Click += new System.EventHandler(this.BtnShowList_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(860, 512);
            this.shapeContainer1.TabIndex = 98;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 590;
            this.lineShape1.X2 = 590;
            this.lineShape1.Y1 = 90;
            this.lineShape1.Y2 = 260;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(627, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 24);
            this.label14.TabIndex = 99;
            this.label14.Text = "Buscar Cliente";
            // 
            // BtnModify
            // 
            this.BtnModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModify.BackColor = System.Drawing.Color.White;
            this.BtnModify.FlatAppearance.BorderSize = 0;
            this.BtnModify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnModify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModify.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.BtnModify.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtnModify.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.BtnModify.IconSize = 30;
            this.BtnModify.Location = new System.Drawing.Point(778, 206);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Rotation = 0D;
            this.BtnModify.Size = new System.Drawing.Size(70, 55);
            this.BtnModify.TabIndex = 102;
            this.BtnModify.Text = "Editar";
            this.BtnModify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModify.UseVisualStyleBackColor = false;
            this.BtnModify.Visible = false;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click_1);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRemove.BackColor = System.Drawing.Color.White;
            this.BtnRemove.FlatAppearance.BorderSize = 0;
            this.BtnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.BtnRemove.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnRemove.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.BtnRemove.IconSize = 30;
            this.BtnRemove.Location = new System.Drawing.Point(688, 206);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Rotation = 0D;
            this.BtnRemove.Size = new System.Drawing.Size(70, 55);
            this.BtnRemove.TabIndex = 101;
            this.BtnRemove.Text = "Eliminar";
            this.BtnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Visible = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click_1);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSave.BackColor = System.Drawing.Color.White;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.BtnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.BtnSave.IconSize = 30;
            this.BtnSave.Location = new System.Drawing.Point(595, 205);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Rotation = 0D;
            this.BtnSave.Size = new System.Drawing.Size(70, 55);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtCedula
            // 
            this.TxtCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCedula.Location = new System.Drawing.Point(63, 90);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(144, 20);
            this.TxtCedula.TabIndex = 1;
            this.TxtCedula.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtCedula_MouseClick);
            this.TxtCedula.ModifiedChanged += new System.EventHandler(this.TextBoxes_ModifiedChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label15.Location = new System.Drawing.Point(60, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 104;
            this.label15.Text = "Cedula:";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.BackColor = System.Drawing.Color.White;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.BtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.BtnSearch.IconSize = 30;
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearch.Location = new System.Drawing.Point(614, 125);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Rotation = 0D;
            this.BtnSearch.Size = new System.Drawing.Size(89, 36);
            this.BtnSearch.TabIndex = 105;
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click_1);
            // 
            // ClientesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 512);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.DgvTableClients);
            this.Controls.Add(this.BtnShowList);
            this.Controls.Add(this.CmbSex);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtTelephone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DtpDateOfBorn);
            this.Controls.Add(this.TxtAddressHome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtSecondLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNeighborhood);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSocondName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtFistName);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientesFrm";
            this.Text = "ClientesFrm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTableClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFistName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSocondName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSecondLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTelephone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAddressHome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtNeighborhood;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.ComboBox CmbSex;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DtpDateOfBorn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DgvTableClients;
        private FontAwesome.Sharp.IconButton BtnShowList;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconButton BtnModify;
        private FontAwesome.Sharp.IconButton BtnRemove;
        private FontAwesome.Sharp.IconButton BtnSave;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label15;
        private FontAwesome.Sharp.IconButton BtnSearch;
    }
}