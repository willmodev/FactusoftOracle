namespace PulsacionesGUI
{
    partial class ListaProductosFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProductosFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CerrarBtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSelect = new FontAwesome.Sharp.IconButton();
            this.DgvProductsList = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductsList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.CerrarBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 36);
            this.panel1.TabIndex = 102;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CerrarBtn.Image")));
            this.CerrarBtn.Location = new System.Drawing.Point(578, 9);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(15, 15);
            this.CerrarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarBtn.TabIndex = 103;
            this.CerrarBtn.TabStop = false;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.BtnSelect);
            this.panel2.Controls.Add(this.DgvProductsList);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(12, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 355);
            this.panel2.TabIndex = 103;
            // 
            // BtnSelect
            // 
            this.BtnSelect.BackColor = System.Drawing.Color.White;
            this.BtnSelect.FlatAppearance.BorderSize = 0;
            this.BtnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelect.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect.ForeColor = System.Drawing.Color.Lime;
            this.BtnSelect.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnSelect.IconColor = System.Drawing.Color.Lime;
            this.BtnSelect.IconSize = 30;
            this.BtnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSelect.Location = new System.Drawing.Point(443, 291);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Rotation = 0D;
            this.BtnSelect.Size = new System.Drawing.Size(114, 30);
            this.BtnSelect.TabIndex = 104;
            this.BtnSelect.Text = "Seleccionar";
            this.BtnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSelect.UseVisualStyleBackColor = false;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // DgvProductsList
            // 
            this.DgvProductsList.BackgroundColor = System.Drawing.Color.White;
            this.DgvProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductsList.Location = new System.Drawing.Point(34, 79);
            this.DgvProductsList.Name = "DgvProductsList";
            this.DgvProductsList.Size = new System.Drawing.Size(523, 183);
            this.DgvProductsList.TabIndex = 103;
            this.DgvProductsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductsList_CellContentClick);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(30, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 24);
            this.label13.TabIndex = 102;
            this.label13.Text = "Lista de productos";
            // 
            // ListaProductosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(604, 409);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaProductosFrm";
            this.Text = "ListaProductosFrm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CerrarBtn;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnSelect;
        private System.Windows.Forms.DataGridView DgvProductsList;
        private System.Windows.Forms.Label label13;
    }
}