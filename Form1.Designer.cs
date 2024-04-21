
namespace Ritprogram1
{
    partial class Form1
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
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Spara = new System.Windows.Forms.Button();
            this.btn_Linje = new System.Windows.Forms.Button();
            this.btn_Cirkel = new System.Windows.Forms.Button();
            this.btn_Rensa = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Färg = new System.Windows.Forms.Button();
            this.btn_Rektangel = new System.Windows.Forms.Button();
            this.btn_Penna = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(260, -4);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(707, 607);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 607);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btn_Spara);
            this.panel2.Controls.Add(this.btn_Linje);
            this.panel2.Controls.Add(this.btn_Cirkel);
            this.panel2.Controls.Add(this.btn_Rensa);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.Färg);
            this.panel2.Controls.Add(this.btn_Rektangel);
            this.panel2.Controls.Add(this.btn_Penna);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(20, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 601);
            this.panel2.TabIndex = 8;
            // 
            // btn_Spara
            // 
            this.btn_Spara.BackColor = System.Drawing.Color.White;
            this.btn_Spara.Location = new System.Drawing.Point(20, 549);
            this.btn_Spara.Name = "btn_Spara";
            this.btn_Spara.Size = new System.Drawing.Size(90, 40);
            this.btn_Spara.TabIndex = 5;
            this.btn_Spara.Text = "Spara";
            this.btn_Spara.UseVisualStyleBackColor = false;
            this.btn_Spara.Click += new System.EventHandler(this.btn_Spara_Click);
            // 
            // btn_Linje
            // 
            this.btn_Linje.BackColor = System.Drawing.Color.White;
            this.btn_Linje.Location = new System.Drawing.Point(116, 268);
            this.btn_Linje.Name = "btn_Linje";
            this.btn_Linje.Size = new System.Drawing.Size(90, 65);
            this.btn_Linje.TabIndex = 6;
            this.btn_Linje.Text = "Linje";
            this.btn_Linje.UseVisualStyleBackColor = false;
            this.btn_Linje.Click += new System.EventHandler(this.btn_Linje_Click);
            // 
            // btn_Cirkel
            // 
            this.btn_Cirkel.BackColor = System.Drawing.Color.White;
            this.btn_Cirkel.Location = new System.Drawing.Point(20, 339);
            this.btn_Cirkel.Name = "btn_Cirkel";
            this.btn_Cirkel.Size = new System.Drawing.Size(90, 65);
            this.btn_Cirkel.TabIndex = 7;
            this.btn_Cirkel.Text = "Cirkel";
            this.btn_Cirkel.UseVisualStyleBackColor = false;
            this.btn_Cirkel.Click += new System.EventHandler(this.btn_Cirkel_Click);
            // 
            // btn_Rensa
            // 
            this.btn_Rensa.BackColor = System.Drawing.Color.White;
            this.btn_Rensa.Location = new System.Drawing.Point(119, 99);
            this.btn_Rensa.Name = "btn_Rensa";
            this.btn_Rensa.Size = new System.Drawing.Size(75, 64);
            this.btn_Rensa.TabIndex = 1;
            this.btn_Rensa.Text = "Rensa";
            this.btn_Rensa.UseVisualStyleBackColor = false;
            this.btn_Rensa.Click += new System.EventHandler(this.btn_Rensa_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar1.Location = new System.Drawing.Point(38, 181);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(156, 69);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Färg
            // 
            this.Färg.BackColor = System.Drawing.Color.White;
            this.Färg.Location = new System.Drawing.Point(116, 339);
            this.Färg.Name = "Färg";
            this.Färg.Size = new System.Drawing.Size(90, 65);
            this.Färg.TabIndex = 3;
            this.Färg.Text = "Färg";
            this.Färg.UseVisualStyleBackColor = false;
            this.Färg.Click += new System.EventHandler(this.Färg_Click);
            // 
            // btn_Rektangel
            // 
            this.btn_Rektangel.BackColor = System.Drawing.Color.White;
            this.btn_Rektangel.Location = new System.Drawing.Point(22, 268);
            this.btn_Rektangel.Name = "btn_Rektangel";
            this.btn_Rektangel.Size = new System.Drawing.Size(90, 65);
            this.btn_Rektangel.TabIndex = 2;
            this.btn_Rektangel.Text = "Rektangel";
            this.btn_Rektangel.UseVisualStyleBackColor = false;
            this.btn_Rektangel.Click += new System.EventHandler(this.btn_Rektangel_Click);
            // 
            // btn_Penna
            // 
            this.btn_Penna.BackColor = System.Drawing.Color.White;
            this.btn_Penna.Location = new System.Drawing.Point(38, 99);
            this.btn_Penna.Name = "btn_Penna";
            this.btn_Penna.Size = new System.Drawing.Size(75, 64);
            this.btn_Penna.TabIndex = 0;
            this.btn_Penna.Text = "Penna";
            this.btn_Penna.UseVisualStyleBackColor = false;
            this.btn_Penna.Click += new System.EventHandler(this.btn_Penna_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(4, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 362);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verktyg";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ritprogram1.Properties.Resources.Måla;
            this.pictureBox1.Location = new System.Drawing.Point(805, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Färg;
        private System.Windows.Forms.Button btn_Rektangel;
        private System.Windows.Forms.Button btn_Rensa;
        private System.Windows.Forms.Button btn_Penna;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btn_Spara;
        private System.Windows.Forms.Button btn_Linje;
        private System.Windows.Forms.Button btn_Cirkel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

