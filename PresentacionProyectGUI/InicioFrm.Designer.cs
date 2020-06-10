namespace PulsacionesGUI
{
    partial class InicioFrm
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPrincipal = new FontAwesome.Sharp.IconPictureBox();
            this.fechaLbl = new System.Windows.Forms.Label();
            this.horaLbl = new System.Windows.Forms.Label();
            this.HoraYFechaTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(53)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Tractor;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(53)))));
            this.iconPictureBox1.IconSize = 140;
            this.iconPictureBox1.Location = new System.Drawing.Point(102, 99);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(295, 140);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 9;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Agroinsumos de San Sebastian";
            // 
            // iconPrincipal
            // 
            this.iconPrincipal.BackColor = System.Drawing.Color.White;
            this.iconPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(53)))));
            this.iconPrincipal.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.iconPrincipal.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(53)))));
            this.iconPrincipal.IconSize = 140;
            this.iconPrincipal.Location = new System.Drawing.Point(515, 99);
            this.iconPrincipal.Name = "iconPrincipal";
            this.iconPrincipal.Size = new System.Drawing.Size(197, 140);
            this.iconPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPrincipal.TabIndex = 7;
            this.iconPrincipal.TabStop = false;
            // 
            // fechaLbl
            // 
            this.fechaLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaLbl.AutoSize = true;
            this.fechaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaLbl.ForeColor = System.Drawing.Color.DarkGray;
            this.fechaLbl.Location = new System.Drawing.Point(465, 467);
            this.fechaLbl.Name = "fechaLbl";
            this.fechaLbl.Size = new System.Drawing.Size(86, 31);
            this.fechaLbl.TabIndex = 6;
            this.fechaLbl.Text = "label1";
            // 
            // horaLbl
            // 
            this.horaLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.horaLbl.AutoSize = true;
            this.horaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaLbl.Location = new System.Drawing.Point(421, 375);
            this.horaLbl.Name = "horaLbl";
            this.horaLbl.Size = new System.Drawing.Size(209, 76);
            this.horaLbl.TabIndex = 5;
            this.horaLbl.Text = "label1";
            // 
            // HoraYFechaTimer
            // 
            this.HoraYFechaTimer.Enabled = true;
            this.HoraYFechaTimer.Tick += new System.EventHandler(this.HoraYFechaTimer_Tick);
            // 
            // InicioFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 512);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPrincipal);
            this.Controls.Add(this.fechaLbl);
            this.Controls.Add(this.horaLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioFrm";
            this.Text = "InicioFrm";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPrincipal;
        private System.Windows.Forms.Label fechaLbl;
        private System.Windows.Forms.Label horaLbl;
        private System.Windows.Forms.Timer HoraYFechaTimer;
    }
}