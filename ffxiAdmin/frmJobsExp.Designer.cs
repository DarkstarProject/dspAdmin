namespace dspAdmin
{
    partial class frmJobsExp
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
            this.cmbJobs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSJ = new System.Windows.Forms.CheckBox();
            this.grpJob = new System.Windows.Forms.GroupBox();
            this.txtCharExp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCharLevel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCharSubmit = new System.Windows.Forms.Button();
            this.lblSaved = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radSEProducer = new System.Windows.Forms.RadioButton();
            this.radGMSenior = new System.Windows.Forms.RadioButton();
            this.radGMLeader = new System.Windows.Forms.RadioButton();
            this.radGM = new System.Windows.Forms.RadioButton();
            this.radGMnone = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.JobListJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobListLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobListUnlocked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpJob.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbJobs
            // 
            this.cmbJobs.FormattingEnabled = true;
            this.cmbJobs.Location = new System.Drawing.Point(459, 239);
            this.cmbJobs.Name = "cmbJobs";
            this.cmbJobs.Size = new System.Drawing.Size(95, 21);
            this.cmbJobs.TabIndex = 0;
            this.cmbJobs.SelectedValueChanged += new System.EventHandler(this.cmbJobs_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Job:";
            // 
            // chkSJ
            // 
            this.chkSJ.AutoSize = true;
            this.chkSJ.Location = new System.Drawing.Point(405, 57);
            this.chkSJ.Name = "chkSJ";
            this.chkSJ.Size = new System.Drawing.Size(108, 17);
            this.chkSJ.TabIndex = 2;
            this.chkSJ.Text = "Subjob Unlocked";
            this.chkSJ.UseVisualStyleBackColor = true;
            this.chkSJ.CheckedChanged += new System.EventHandler(this.chkSJ_CheckedChanged);
            // 
            // grpJob
            // 
            this.grpJob.Controls.Add(this.txtCharExp);
            this.grpJob.Controls.Add(this.label3);
            this.grpJob.Controls.Add(this.txtCharLevel);
            this.grpJob.Controls.Add(this.label2);
            this.grpJob.Location = new System.Drawing.Point(430, 307);
            this.grpJob.Name = "grpJob";
            this.grpJob.Size = new System.Drawing.Size(170, 132);
            this.grpJob.TabIndex = 3;
            this.grpJob.TabStop = false;
            // 
            // txtCharExp
            // 
            this.txtCharExp.Location = new System.Drawing.Point(62, 85);
            this.txtCharExp.Name = "txtCharExp";
            this.txtCharExp.Size = new System.Drawing.Size(60, 20);
            this.txtCharExp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "EXP:";
            // 
            // txtCharLevel
            // 
            this.txtCharLevel.Location = new System.Drawing.Point(64, 28);
            this.txtCharLevel.Name = "txtCharLevel";
            this.txtCharLevel.Size = new System.Drawing.Size(60, 20);
            this.txtCharLevel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Level:";
            // 
            // btnCharSubmit
            // 
            this.btnCharSubmit.Location = new System.Drawing.Point(126, 453);
            this.btnCharSubmit.Name = "btnCharSubmit";
            this.btnCharSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnCharSubmit.TabIndex = 4;
            this.btnCharSubmit.Text = "Save";
            this.btnCharSubmit.UseVisualStyleBackColor = true;
            this.btnCharSubmit.Click += new System.EventHandler(this.btnCharSubmit_Click);
            // 
            // lblSaved
            // 
            this.lblSaved.AutoSize = true;
            this.lblSaved.Location = new System.Drawing.Point(578, 453);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(41, 13);
            this.lblSaved.TabIndex = 5;
            this.lblSaved.Text = "Saved!";
            this.lblSaved.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSEProducer);
            this.groupBox1.Controls.Add(this.radGMSenior);
            this.groupBox1.Controls.Add(this.radGMLeader);
            this.groupBox1.Controls.Add(this.radGM);
            this.groupBox1.Controls.Add(this.radGMnone);
            this.groupBox1.Location = new System.Drawing.Point(626, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 147);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GM Modes";
            // 
            // radSEProducer
            // 
            this.radSEProducer.AutoSize = true;
            this.radSEProducer.Location = new System.Drawing.Point(7, 112);
            this.radSEProducer.Name = "radSEProducer";
            this.radSEProducer.Size = new System.Drawing.Size(85, 17);
            this.radSEProducer.TabIndex = 4;
            this.radSEProducer.Text = "SE Producer";
            this.radSEProducer.UseVisualStyleBackColor = true;
            this.radSEProducer.CheckedChanged += new System.EventHandler(this.radSEProducer_CheckedChanged);
            // 
            // radGMSenior
            // 
            this.radGMSenior.AutoSize = true;
            this.radGMSenior.Location = new System.Drawing.Point(7, 89);
            this.radGMSenior.Name = "radGMSenior";
            this.radGMSenior.Size = new System.Drawing.Size(75, 17);
            this.radGMSenior.TabIndex = 3;
            this.radGMSenior.Text = "GM Senior";
            this.radGMSenior.UseVisualStyleBackColor = true;
            this.radGMSenior.CheckedChanged += new System.EventHandler(this.radGMSenior_CheckedChanged);
            // 
            // radGMLeader
            // 
            this.radGMLeader.AutoSize = true;
            this.radGMLeader.Location = new System.Drawing.Point(7, 66);
            this.radGMLeader.Name = "radGMLeader";
            this.radGMLeader.Size = new System.Drawing.Size(78, 17);
            this.radGMLeader.TabIndex = 2;
            this.radGMLeader.Text = "GM Leader";
            this.radGMLeader.UseVisualStyleBackColor = true;
            this.radGMLeader.CheckedChanged += new System.EventHandler(this.radGMLeader_CheckedChanged);
            // 
            // radGM
            // 
            this.radGM.AutoSize = true;
            this.radGM.Location = new System.Drawing.Point(7, 43);
            this.radGM.Name = "radGM";
            this.radGM.Size = new System.Drawing.Size(88, 17);
            this.radGM.TabIndex = 1;
            this.radGM.Text = "Game Master";
            this.radGM.UseVisualStyleBackColor = true;
            this.radGM.CheckedChanged += new System.EventHandler(this.radGM_CheckedChanged);
            // 
            // radGMnone
            // 
            this.radGMnone.AutoSize = true;
            this.radGMnone.Checked = true;
            this.radGMnone.Location = new System.Drawing.Point(7, 20);
            this.radGMnone.Name = "radGMnone";
            this.radGMnone.Size = new System.Drawing.Size(51, 17);
            this.radGMnone.TabIndex = 0;
            this.radGMnone.TabStop = true;
            this.radGMnone.Text = "None";
            this.radGMnone.UseVisualStyleBackColor = true;
            this.radGMnone.CheckedChanged += new System.EventHandler(this.radGMnone_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 424);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Job List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobListJob,
            this.JobListLevel,
            this.JobListUnlocked});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(350, 405);
            this.dataGridView1.TabIndex = 0;
            // 
            // JobListJob
            // 
            this.JobListJob.HeaderText = "Job";
            this.JobListJob.Name = "JobListJob";
            this.JobListJob.ReadOnly = true;
            // 
            // JobListLevel
            // 
            this.JobListLevel.HeaderText = "Level";
            this.JobListLevel.Name = "JobListLevel";
            // 
            // JobListUnlocked
            // 
            this.JobListUnlocked.HeaderText = "Unlocked";
            this.JobListUnlocked.Name = "JobListUnlocked";
            // 
            // frmJobsExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 504);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkSJ);
            this.Controls.Add(this.lblSaved);
            this.Controls.Add(this.btnCharSubmit);
            this.Controls.Add(this.grpJob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbJobs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmJobsExp";
            this.grpJob.ResumeLayout(false);
            this.grpJob.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbJobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSJ;
        private System.Windows.Forms.GroupBox grpJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCharExp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCharLevel;
        private System.Windows.Forms.Button btnCharSubmit;
        private System.Windows.Forms.Label lblSaved;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radSEProducer;
        private System.Windows.Forms.RadioButton radGMSenior;
        private System.Windows.Forms.RadioButton radGMLeader;
        private System.Windows.Forms.RadioButton radGM;
        private System.Windows.Forms.RadioButton radGMnone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobListJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobListLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobListUnlocked;
    }
}