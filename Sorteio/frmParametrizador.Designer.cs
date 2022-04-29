namespace Sorteio
{
    partial class frmParametrizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParametrizador));
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.btGerarArquivo = new System.Windows.Forms.Button();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.ckBotao = new System.Windows.Forms.CheckBox();
            this.btSorteio = new System.Windows.Forms.Button();
            this.grSorteio = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txFile = new System.Windows.Forms.TextBox();
            this.grProgress = new System.Windows.Forms.GroupBox();
            this.grProcesso = new System.Windows.Forms.GroupBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.welcomeWizardPage1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            this.grSorteio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grProgress.SuspendLayout();
            this.grProcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.completionWizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.completionWizardPage1});
            this.wizardControl1.Size = new System.Drawing.Size(684, 561);
            this.wizardControl1.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_CancelClick);
            this.wizardControl1.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Controls.Add(this.btGerarArquivo);
            this.welcomeWizardPage1.IntroductionText = resources.GetString("welcomeWizardPage1.IntroductionText");
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(467, 428);
            this.welcomeWizardPage1.Text = "Sorteio de Brindes";
            // 
            // btGerarArquivo
            // 
            this.btGerarArquivo.Image = ((System.Drawing.Image)(resources.GetObject("btGerarArquivo.Image")));
            this.btGerarArquivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarArquivo.Location = new System.Drawing.Point(3, 72);
            this.btGerarArquivo.Name = "btGerarArquivo";
            this.btGerarArquivo.Size = new System.Drawing.Size(461, 40);
            this.btGerarArquivo.TabIndex = 2;
            this.btGerarArquivo.Text = "Gerar Arquivo Base de Dados";
            this.btGerarArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGerarArquivo.UseVisualStyleBackColor = true;
            this.btGerarArquivo.Click += new System.EventHandler(this.btGerarArquivo_Click);
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.ckBotao);
            this.wizardPage1.Controls.Add(this.btSorteio);
            this.wizardPage1.Controls.Add(this.grSorteio);
            this.wizardPage1.Controls.Add(this.pictureBox2);
            this.wizardPage1.Controls.Add(this.groupBox3);
            this.wizardPage1.Controls.Add(this.grProgress);
            this.wizardPage1.DescriptionText = "Selecione o arquivo Excel com a Base de Dados do Sorteio";
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(652, 416);
            this.wizardPage1.Text = "Base de Dados";
            // 
            // ckBotao
            // 
            this.ckBotao.AutoSize = true;
            this.ckBotao.Checked = true;
            this.ckBotao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBotao.Location = new System.Drawing.Point(7, 376);
            this.ckBotao.Name = "ckBotao";
            this.ckBotao.Size = new System.Drawing.Size(272, 30);
            this.ckBotao.TabIndex = 31;
            this.ckBotao.Text = "Botão SORTEAR:\r\nExibir botão para sortear. (Além de clicar na imagem)";
            this.ckBotao.UseVisualStyleBackColor = true;
            // 
            // btSorteio
            // 
            this.btSorteio.Enabled = false;
            this.btSorteio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSorteio.Location = new System.Drawing.Point(285, 367);
            this.btSorteio.Name = "btSorteio";
            this.btSorteio.Size = new System.Drawing.Size(361, 46);
            this.btSorteio.TabIndex = 30;
            this.btSorteio.Text = "Abrir a Interface do Sorteio";
            this.btSorteio.UseVisualStyleBackColor = true;
            this.btSorteio.Click += new System.EventHandler(this.btSorteio_Click);
            // 
            // grSorteio
            // 
            this.grSorteio.Controls.Add(this.dgv);
            this.grSorteio.Location = new System.Drawing.Point(3, 73);
            this.grSorteio.Name = "grSorteio";
            this.grSorteio.Size = new System.Drawing.Size(646, 291);
            this.grSorteio.TabIndex = 29;
            this.grSorteio.TabStop = false;
            this.grSorteio.Text = "Total de Linhas: 0";
            this.grSorteio.Visible = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 16);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(640, 272);
            this.dgv.TabIndex = 0;
            this.dgv.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_RowsRemoved);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txFile);
            this.groupBox3.Location = new System.Drawing.Point(70, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 65);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selecione o Arquivo do Excel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Local do Arquivo:";
            // 
            // txFile
            // 
            this.txFile.Enabled = false;
            this.txFile.Location = new System.Drawing.Point(9, 32);
            this.txFile.Name = "txFile";
            this.txFile.ReadOnly = true;
            this.txFile.Size = new System.Drawing.Size(528, 20);
            this.txFile.TabIndex = 19;
            // 
            // grProgress
            // 
            this.grProgress.Controls.Add(this.grProcesso);
            this.grProgress.Controls.Add(this.pictureBox3);
            this.grProgress.Location = new System.Drawing.Point(3, 73);
            this.grProgress.Name = "grProgress";
            this.grProgress.Size = new System.Drawing.Size(646, 291);
            this.grProgress.TabIndex = 1;
            this.grProgress.TabStop = false;
            this.grProgress.Visible = false;
            // 
            // grProcesso
            // 
            this.grProcesso.Controls.Add(this.progress);
            this.grProcesso.Location = new System.Drawing.Point(215, 107);
            this.grProcesso.Name = "grProcesso";
            this.grProcesso.Size = new System.Drawing.Size(401, 69);
            this.grProcesso.TabIndex = 8;
            this.grProcesso.TabStop = false;
            this.grProcesso.Text = "Progresso de Execução do Processo";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(6, 19);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(389, 44);
            this.progress.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(40, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(169, 166);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Controls.Add(this.pictureBox1);
            this.completionWizardPage1.FinishText = "";
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(467, 428);
            this.completionWizardPage1.Text = "Sorteio Finalizado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmParametrizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.wizardControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "frmParametrizador";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parâmetros do Sorteio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmParametrizador_FormClosed);
            this.Load += new System.EventHandler(this.frmParametrizador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.welcomeWizardPage1.ResumeLayout(false);
            this.wizardPage1.ResumeLayout(false);
            this.wizardPage1.PerformLayout();
            this.grSorteio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grProgress.ResumeLayout(false);
            this.grProcesso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.completionWizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private System.Windows.Forms.Button btGerarArquivo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txFile;
        private System.Windows.Forms.GroupBox grSorteio;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btSorteio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grProgress;
        private System.Windows.Forms.GroupBox grProcesso;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox ckBotao;
    }
}

