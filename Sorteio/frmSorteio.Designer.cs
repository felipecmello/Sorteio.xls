namespace Sorteio
{
    partial class frmSorteio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSorteio));
            this.txNome = new System.Windows.Forms.TextBox();
            this.btSortear = new System.Windows.Forms.Button();
            this.lbSorteios = new System.Windows.Forms.Label();
            this.txEvento = new System.Windows.Forms.Label();
            this.txAnteriores = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txNome
            // 
            this.txNome.Font = new System.Drawing.Font("Segoe UI", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(15, 14);
            this.txNome.Name = "txNome";
            this.txNome.ReadOnly = true;
            this.txNome.Size = new System.Drawing.Size(1312, 131);
            this.txNome.TabIndex = 0;
            this.txNome.TabStop = false;
            this.txNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSortear
            // 
            this.btSortear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSortear.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSortear.Location = new System.Drawing.Point(15, 151);
            this.btSortear.Name = "btSortear";
            this.btSortear.Size = new System.Drawing.Size(217, 82);
            this.btSortear.TabIndex = 6;
            this.btSortear.Text = "SORTEAR";
            this.btSortear.UseVisualStyleBackColor = true;
            this.btSortear.Click += new System.EventHandler(this.btSortear_Click);
            // 
            // lbSorteios
            // 
            this.lbSorteios.AutoSize = true;
            this.lbSorteios.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSorteios.Location = new System.Drawing.Point(902, 167);
            this.lbSorteios.Name = "lbSorteios";
            this.lbSorteios.Size = new System.Drawing.Size(377, 50);
            this.lbSorteios.TabIndex = 5;
            this.lbSorteios.Text = "Sorteios Realizados: 0";
            // 
            // txEvento
            // 
            this.txEvento.AutoSize = true;
            this.txEvento.BackColor = System.Drawing.Color.Transparent;
            this.txEvento.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEvento.Location = new System.Drawing.Point(184, 101);
            this.txEvento.Name = "txEvento";
            this.txEvento.Size = new System.Drawing.Size(165, 50);
            this.txEvento.TabIndex = 4;
            this.txEvento.Text = "EVENTO";
            // 
            // txAnteriores
            // 
            this.txAnteriores.BackColor = System.Drawing.Color.White;
            this.txAnteriores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txAnteriores.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txAnteriores.Location = new System.Drawing.Point(12, 425);
            this.txAnteriores.Name = "txAnteriores";
            this.txAnteriores.Size = new System.Drawing.Size(1342, 331);
            this.txAnteriores.TabIndex = 0;
            this.txAnteriores.TabStop = false;
            this.txAnteriores.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(593, 86);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sorteio de Brindes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbSorteios);
            this.panel1.Controls.Add(this.btSortear);
            this.panel1.Controls.Add(this.txNome);
            this.panel1.Location = new System.Drawing.Point(12, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 247);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(887, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(467, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // frmSorteio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sorteio.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txAnteriores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSorteio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorteio";
            this.Load += new System.EventHandler(this.frmSorteio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txAnteriores;
        private System.Windows.Forms.Label lbSorteios;
        private System.Windows.Forms.Label txEvento;
        private System.Windows.Forms.Button btSortear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}