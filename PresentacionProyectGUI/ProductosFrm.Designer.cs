namespace PulsacionesGUI
{
    partial class ProductosFrm
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
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUnitValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSave = new FontAwesome.Sharp.IconButton();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.BtnRemove = new FontAwesome.Sharp.IconButton();
            this.BtnModify = new FontAwesome.Sharp.IconButton();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSearch = new FontAwesome.Sharp.IconButton();
            this.BtnShowList = new FontAwesome.Sharp.IconButton();
            this.TxtIVA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbUnitMeasure = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DgvTableProducts = new System.Windows.Forms.DataGridView();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTableProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label4.Location = new System.Drawing.Point(397, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Cantidad";
            // 
            // TxtUnitValue
            // 
            this.TxtUnitValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUnitValue.Location = new System.Drawing.Point(189, 175);
            this.TxtUnitValue.Name = "TxtUnitValue";
            this.TxtUnitValue.Size = new System.Drawing.Size(96, 20);
            this.TxtUnitValue.TabIndex = 5;
            this.TxtUnitValue.ModifiedChanged += new System.EventHandler(this.TxtBoxes_ModifiedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label3.Location = new System.Drawing.Point(186, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Valor Unit.";
            // 
            // TxtName
            // 
            this.TxtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtName.Location = new System.Drawing.Point(189, 104);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(168, 20);
            this.TxtName.TabIndex = 2;
            this.TxtName.ModifiedChanged += new System.EventHandler(this.TxtBoxes_ModifiedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label2.Location = new System.Drawing.Point(186, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nombre";
            // 
            // TxtID
            // 
            this.TxtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtID.Location = new System.Drawing.Point(60, 104);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(70, 20);
            this.TxtID.TabIndex = 1;
            this.TxtID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtID_MouseClick);
            this.TxtID.ModifiedChanged += new System.EventHandler(this.TxtBoxes_ModifiedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(57, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "ID";
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
            this.BtnSave.Location = new System.Drawing.Point(566, 159);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Rotation = 0D;
            this.BtnSave.Size = new System.Drawing.Size(70, 55);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtQuantity.Location = new System.Drawing.Point(400, 104);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(70, 20);
            this.TxtQuantity.TabIndex = 3;
            this.TxtQuantity.ModifiedChanged += new System.EventHandler(this.TxtBoxes_ModifiedChanged);
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
            this.BtnRemove.Location = new System.Drawing.Point(659, 160);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Rotation = 0D;
            this.BtnRemove.Size = new System.Drawing.Size(70, 55);
            this.BtnRemove.TabIndex = 8;
            this.BtnRemove.Text = "Eliminar";
            this.BtnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Visible = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
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
            this.BtnModify.Location = new System.Drawing.Point(749, 160);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Rotation = 0D;
            this.BtnModify.Size = new System.Drawing.Size(70, 55);
            this.BtnModify.TabIndex = 9;
            this.BtnModify.Text = "Editar";
            this.BtnModify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModify.UseVisualStyleBackColor = false;
            this.BtnModify.Visible = false;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.Location = new System.Drawing.Point(566, 104);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(89, 20);
            this.TxtSearch.TabIndex = 73;
            this.TxtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtSearch_MouseClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label5.Location = new System.Drawing.Point(568, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "ID:";
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
            this.BtnSearch.Location = new System.Drawing.Point(683, 96);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Rotation = 0D;
            this.BtnSearch.Size = new System.Drawing.Size(89, 34);
            this.BtnSearch.TabIndex = 87;
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
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
            this.BtnShowList.Location = new System.Drawing.Point(60, 255);
            this.BtnShowList.Name = "BtnShowList";
            this.BtnShowList.Rotation = 0D;
            this.BtnShowList.Size = new System.Drawing.Size(149, 42);
            this.BtnShowList.TabIndex = 10;
            this.BtnShowList.Text = "Ver / Ocultar Lista";
            this.BtnShowList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnShowList.UseVisualStyleBackColor = false;
            this.BtnShowList.Click += new System.EventHandler(this.BtnShowList_Click);
            // 
            // TxtIVA
            // 
            this.TxtIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtIVA.Location = new System.Drawing.Point(400, 175);
            this.TxtIVA.Name = "TxtIVA";
            this.TxtIVA.Size = new System.Drawing.Size(70, 20);
            this.TxtIVA.TabIndex = 6;
            this.TxtIVA.ModifiedChanged += new System.EventHandler(this.TxtBoxes_ModifiedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label6.Location = new System.Drawing.Point(397, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 90;
            this.label6.Text = "IVA";
            // 
            // CmbUnitMeasure
            // 
            this.CmbUnitMeasure.FormattingEnabled = true;
            this.CmbUnitMeasure.Items.AddRange(new object[] {
            "Kg",
            "L"});
            this.CmbUnitMeasure.Location = new System.Drawing.Point(60, 174);
            this.CmbUnitMeasure.Name = "CmbUnitMeasure";
            this.CmbUnitMeasure.Size = new System.Drawing.Size(96, 21);
            this.CmbUnitMeasure.TabIndex = 4;
            this.CmbUnitMeasure.SelectedIndexChanged += new System.EventHandler(this.CmbUnitMeasure_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.label7.Location = new System.Drawing.Point(57, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 93;
            this.label7.Text = "Unidad Medida";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(26, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 24);
            this.label13.TabIndex = 94;
            this.label13.Text = "Registrae Productos";
            // 
            // DgvTableProducts
            // 
            this.DgvTableProducts.BackgroundColor = System.Drawing.Color.White;
            this.DgvTableProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTableProducts.Location = new System.Drawing.Point(60, 303);
            this.DgvTableProducts.Name = "DgvTableProducts";
            this.DgvTableProducts.ReadOnly = true;
            this.DgvTableProducts.Size = new System.Drawing.Size(501, 150);
            this.DgvTableProducts.TabIndex = 95;
            this.DgvTableProducts.TabStop = false;
            this.DgvTableProducts.Visible = false;
            this.DgvTableProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTableProducts_CellContentClick);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 514;
            this.lineShape1.X2 = 513;
            this.lineShape1.Y1 = 61;
            this.lineShape1.Y2 = 214;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(860, 512);
            this.shapeContainer1.TabIndex = 97;
            this.shapeContainer1.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(555, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 24);
            this.label8.TabIndex = 98;
            this.label8.Text = "Buscar Productos";
            // 
            // ProductosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 512);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DgvTableProducts);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbUnitMeasure);
            this.Controls.Add(this.TxtIVA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnShowList);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUnitValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductosFrm";
            this.Text = "RegistrarPersonaFrm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTableProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUnitValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnSave;
        private System.Windows.Forms.TextBox TxtQuantity;
        private FontAwesome.Sharp.IconButton BtnRemove;
        private FontAwesome.Sharp.IconButton BtnModify;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton BtnSearch;
        private FontAwesome.Sharp.IconButton BtnShowList;
        private System.Windows.Forms.TextBox TxtIVA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbUnitMeasure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView DgvTableProducts;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label8;
    }
}