namespace dspAdmin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCharacters = new System.Windows.Forms.DataGridView();
            this.clmStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAcctID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCharName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolJobsExp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCharLook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCharSkills = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExportChar = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCharListRefreshValue = new System.Windows.Forms.TextBox();
            this.chkRefresh = new System.Windows.Forms.CheckBox();
            this.chkAutoConnect = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtDBPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDBUname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCharacter = new System.Windows.Forms.TabPage();
            this.tabMonsters = new System.Windows.Forms.TabPage();
            this.grpMonsterDrop = new System.Windows.Forms.GroupBox();
            this.btnAddDrop = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstMonsters = new System.Windows.Forms.ListBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabChat = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtShowMessages = new System.Windows.Forms.TextBox();
            this.btnChatRefresh = new System.Windows.Forms.Button();
            this.cbChatRefresh = new System.Windows.Forms.CheckBox();
            this.dgChat = new System.Windows.Forms.DataGridView();
            this.chatType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chatFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chatTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chatMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chatTimestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlstrConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlstrTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlstrNumbers = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrRefreshCharList = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tmrRefreshChat = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharacters)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCharacter.SuspendLayout();
            this.tabMonsters.SuspendLayout();
            this.grpMonsterDrop.SuspendLayout();
            this.tabChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChat)).BeginInit();
            this.tabConfig.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCharacters
            // 
            this.dgvCharacters.AllowUserToAddRows = false;
            this.dgvCharacters.AllowUserToDeleteRows = false;
            this.dgvCharacters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCharacters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStatus,
            this.clmID,
            this.clmAcctID,
            this.clmCharName,
            this.clmZone,
            this.clmIP,
            this.clmLastOn});
            this.dgvCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCharacters.Location = new System.Drawing.Point(3, 3);
            this.dgvCharacters.Name = "dgvCharacters";
            this.dgvCharacters.RowHeadersVisible = false;
            this.dgvCharacters.Size = new System.Drawing.Size(985, 478);
            this.dgvCharacters.TabIndex = 0;
            this.dgvCharacters.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCharacters_CellMouseEnter);
            this.dgvCharacters.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvCharacters_MouseDown);
            this.dgvCharacters.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvCharacters_MouseMove);
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Status";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            this.clmStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmStatus.Width = 50;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "Char ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmAcctID
            // 
            this.clmAcctID.HeaderText = "Acct Name";
            this.clmAcctID.Name = "clmAcctID";
            this.clmAcctID.ReadOnly = true;
            // 
            // clmCharName
            // 
            this.clmCharName.HeaderText = "Character";
            this.clmCharName.Name = "clmCharName";
            // 
            // clmZone
            // 
            this.clmZone.HeaderText = "Zone";
            this.clmZone.Name = "clmZone";
            this.clmZone.Width = 150;
            // 
            // clmIP
            // 
            this.clmIP.HeaderText = "IP";
            this.clmIP.Name = "clmIP";
            this.clmIP.ReadOnly = true;
            // 
            // clmLastOn
            // 
            this.clmLastOn.HeaderText = "Last On";
            this.clmLastOn.Name = "clmLastOn";
            this.clmLastOn.Width = 130;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolJobsExp,
            this.toolInventory,
            this.toolCharLook,
            this.toolCharSkills,
            this.toolExportChar});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 114);
            // 
            // toolJobsExp
            // 
            this.toolJobsExp.Name = "toolJobsExp";
            this.toolJobsExp.Size = new System.Drawing.Size(135, 22);
            this.toolJobsExp.Text = "Jobs && EXP";
            this.toolJobsExp.Click += new System.EventHandler(this.toolJobsExp_Click);
            // 
            // toolInventory
            // 
            this.toolInventory.Name = "toolInventory";
            this.toolInventory.Size = new System.Drawing.Size(135, 22);
            this.toolInventory.Text = "Inventory";
            this.toolInventory.Click += new System.EventHandler(this.toolInventory_Click);
            // 
            // toolCharLook
            // 
            this.toolCharLook.Name = "toolCharLook";
            this.toolCharLook.Size = new System.Drawing.Size(135, 22);
            this.toolCharLook.Text = "Char Look";
            // 
            // toolCharSkills
            // 
            this.toolCharSkills.Name = "toolCharSkills";
            this.toolCharSkills.Size = new System.Drawing.Size(135, 22);
            this.toolCharSkills.Text = "Char Skills";
            // 
            // toolExportChar
            // 
            this.toolExportChar.Name = "toolExportChar";
            this.toolExportChar.Size = new System.Drawing.Size(135, 22);
            this.toolExportChar.Text = "Char Export";
            this.toolExportChar.Click += new System.EventHandler(this.toolExportChar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCharListRefreshValue);
            this.groupBox2.Controls.Add(this.chkRefresh);
            this.groupBox2.Controls.Add(this.chkAutoConnect);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.txtDBPassword);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDBUname);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtServerName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Connection:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "seconds.";
            // 
            // txtCharListRefreshValue
            // 
            this.txtCharListRefreshValue.Location = new System.Drawing.Point(216, 140);
            this.txtCharListRefreshValue.Name = "txtCharListRefreshValue";
            this.txtCharListRefreshValue.Size = new System.Drawing.Size(42, 20);
            this.txtCharListRefreshValue.TabIndex = 11;
            this.txtCharListRefreshValue.Text = "30";
            this.txtCharListRefreshValue.TextChanged += new System.EventHandler(this.txtCharListRefreshValue_TextChanged);
            // 
            // chkRefresh
            // 
            this.chkRefresh.AutoSize = true;
            this.chkRefresh.Location = new System.Drawing.Point(109, 142);
            this.chkRefresh.Name = "chkRefresh";
            this.chkRefresh.Size = new System.Drawing.Size(107, 17);
            this.chkRefresh.TabIndex = 10;
            this.chkRefresh.Text = "Refresh list every";
            this.chkRefresh.UseVisualStyleBackColor = true;
            this.chkRefresh.CheckedChanged += new System.EventHandler(this.chkRefresh_CheckedChanged);
            // 
            // chkAutoConnect
            // 
            this.chkAutoConnect.AutoSize = true;
            this.chkAutoConnect.Location = new System.Drawing.Point(109, 103);
            this.chkAutoConnect.Name = "chkAutoConnect";
            this.chkAutoConnect.Size = new System.Drawing.Size(227, 17);
            this.chkAutoConnect.TabIndex = 9;
            this.chkAutoConnect.Text = "Connect automagically on program startup.";
            this.chkAutoConnect.UseVisualStyleBackColor = true;
            this.chkAutoConnect.CheckedChanged += new System.EventHandler(this.chkAutoConnect_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(544, 25);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtDBPassword
            // 
            this.txtDBPassword.Location = new System.Drawing.Point(398, 62);
            this.txtDBPassword.Name = "txtDBPassword";
            this.txtDBPassword.PasswordChar = '*';
            this.txtDBPassword.Size = new System.Drawing.Size(128, 20);
            this.txtDBPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // txtDBUname
            // 
            this.txtDBUname.Location = new System.Drawing.Point(109, 62);
            this.txtDBUname.Name = "txtDBUname";
            this.txtDBUname.Size = new System.Drawing.Size(100, 20);
            this.txtDBUname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login:";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(398, 27);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(128, 20);
            this.txtDB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DB:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(109, 27);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(207, 20);
            this.txtServerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name/IP:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCharacter);
            this.tabControl1.Controls.Add(this.tabMonsters);
            this.tabControl1.Controls.Add(this.tabChat);
            this.tabControl1.Controls.Add(this.tabConfig);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(999, 510);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabCharacter
            // 
            this.tabCharacter.Controls.Add(this.dgvCharacters);
            this.tabCharacter.Location = new System.Drawing.Point(4, 22);
            this.tabCharacter.Name = "tabCharacter";
            this.tabCharacter.Padding = new System.Windows.Forms.Padding(3);
            this.tabCharacter.Size = new System.Drawing.Size(991, 484);
            this.tabCharacter.TabIndex = 0;
            this.tabCharacter.Text = "Characters";
            this.tabCharacter.UseVisualStyleBackColor = true;
            // 
            // tabMonsters
            // 
            this.tabMonsters.Controls.Add(this.grpMonsterDrop);
            this.tabMonsters.Controls.Add(this.lstMonsters);
            this.tabMonsters.Controls.Add(this.txtFilter);
            this.tabMonsters.Controls.Add(this.label5);
            this.tabMonsters.Location = new System.Drawing.Point(4, 22);
            this.tabMonsters.Name = "tabMonsters";
            this.tabMonsters.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonsters.Size = new System.Drawing.Size(991, 484);
            this.tabMonsters.TabIndex = 1;
            this.tabMonsters.Text = "Monsters";
            this.tabMonsters.UseVisualStyleBackColor = true;
            // 
            // grpMonsterDrop
            // 
            this.grpMonsterDrop.Controls.Add(this.btnAddDrop);
            this.grpMonsterDrop.Controls.Add(this.comboBox1);
            this.grpMonsterDrop.Controls.Add(this.label6);
            this.grpMonsterDrop.Location = new System.Drawing.Point(299, 21);
            this.grpMonsterDrop.Name = "grpMonsterDrop";
            this.grpMonsterDrop.Size = new System.Drawing.Size(319, 307);
            this.grpMonsterDrop.TabIndex = 5;
            this.grpMonsterDrop.TabStop = false;
            // 
            // btnAddDrop
            // 
            this.btnAddDrop.Location = new System.Drawing.Point(202, 17);
            this.btnAddDrop.Name = "btnAddDrop";
            this.btnAddDrop.Size = new System.Drawing.Size(75, 23);
            this.btnAddDrop.TabIndex = 5;
            this.btnAddDrop.Text = "Add";
            this.btnAddDrop.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Drops:";
            // 
            // lstMonsters
            // 
            this.lstMonsters.FormattingEnabled = true;
            this.lstMonsters.Location = new System.Drawing.Point(18, 55);
            this.lstMonsters.Name = "lstMonsters";
            this.lstMonsters.Size = new System.Drawing.Size(190, 173);
            this.lstMonsters.TabIndex = 2;
            this.lstMonsters.DoubleClick += new System.EventHandler(this.lstMonsters_DoubleClick);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(55, 19);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Find:";
            // 
            // tabChat
            // 
            this.tabChat.Controls.Add(this.label9);
            this.tabChat.Controls.Add(this.label8);
            this.tabChat.Controls.Add(this.txtShowMessages);
            this.tabChat.Controls.Add(this.btnChatRefresh);
            this.tabChat.Controls.Add(this.cbChatRefresh);
            this.tabChat.Controls.Add(this.dgChat);
            this.tabChat.Location = new System.Drawing.Point(4, 22);
            this.tabChat.Name = "tabChat";
            this.tabChat.Padding = new System.Windows.Forms.Padding(3);
            this.tabChat.Size = new System.Drawing.Size(991, 484);
            this.tabChat.TabIndex = 3;
            this.tabChat.Text = "Chatlog";
            this.tabChat.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(566, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "messages";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Show last:";
            // 
            // txtShowMessages
            // 
            this.txtShowMessages.Location = new System.Drawing.Point(519, 408);
            this.txtShowMessages.Name = "txtShowMessages";
            this.txtShowMessages.Size = new System.Drawing.Size(41, 20);
            this.txtShowMessages.TabIndex = 3;
            this.txtShowMessages.Text = "50";
            this.txtShowMessages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtShowMessages.TextChanged += new System.EventHandler(this.txtShowMessages_TextChanged);
            // 
            // btnChatRefresh
            // 
            this.btnChatRefresh.Location = new System.Drawing.Point(285, 406);
            this.btnChatRefresh.Name = "btnChatRefresh";
            this.btnChatRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnChatRefresh.TabIndex = 2;
            this.btnChatRefresh.Text = "Refresh";
            this.btnChatRefresh.UseVisualStyleBackColor = true;
            this.btnChatRefresh.Click += new System.EventHandler(this.btnChatRefresh_Click);
            // 
            // cbChatRefresh
            // 
            this.cbChatRefresh.AutoSize = true;
            this.cbChatRefresh.Location = new System.Drawing.Point(83, 410);
            this.cbChatRefresh.Name = "cbChatRefresh";
            this.cbChatRefresh.Size = new System.Drawing.Size(88, 17);
            this.cbChatRefresh.TabIndex = 1;
            this.cbChatRefresh.Text = "Auto Refresh";
            this.cbChatRefresh.UseVisualStyleBackColor = true;
            this.cbChatRefresh.CheckedChanged += new System.EventHandler(this.cbChatRefresh_CheckedChanged);
            // 
            // dgChat
            // 
            this.dgChat.AllowUserToAddRows = false;
            this.dgChat.AllowUserToDeleteRows = false;
            this.dgChat.AllowUserToResizeRows = false;
            this.dgChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chatType,
            this.chatFrom,
            this.chatTo,
            this.chatMessage,
            this.chatTimestamp});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgChat.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgChat.Location = new System.Drawing.Point(0, 3);
            this.dgChat.Name = "dgChat";
            this.dgChat.Size = new System.Drawing.Size(983, 388);
            this.dgChat.TabIndex = 0;
            // 
            // chatType
            // 
            this.chatType.HeaderText = "Type";
            this.chatType.Name = "chatType";
            this.chatType.ReadOnly = true;
            // 
            // chatFrom
            // 
            this.chatFrom.HeaderText = "From";
            this.chatFrom.Name = "chatFrom";
            this.chatFrom.ReadOnly = true;
            // 
            // chatTo
            // 
            this.chatTo.HeaderText = "To";
            this.chatTo.Name = "chatTo";
            this.chatTo.ReadOnly = true;
            // 
            // chatMessage
            // 
            this.chatMessage.HeaderText = "Message";
            this.chatMessage.Name = "chatMessage";
            this.chatMessage.ReadOnly = true;
            this.chatMessage.Width = 450;
            // 
            // chatTimestamp
            // 
            this.chatTimestamp.HeaderText = "Timestamp";
            this.chatTimestamp.Name = "chatTimestamp";
            this.chatTimestamp.ReadOnly = true;
            this.chatTimestamp.Width = 150;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.groupBox2);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(991, 484);
            this.tabConfig.TabIndex = 2;
            this.tabConfig.Text = "Config";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrConnected,
            this.tlstrTimer,
            this.tlstrNumbers});
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(999, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlstrConnected
            // 
            this.tlstrConnected.Name = "tlstrConnected";
            this.tlstrConnected.Size = new System.Drawing.Size(71, 17);
            this.tlstrConnected.Text = "Connected!!";
            this.tlstrConnected.Visible = false;
            // 
            // tlstrTimer
            // 
            this.tlstrTimer.Name = "tlstrTimer";
            this.tlstrTimer.Size = new System.Drawing.Size(83, 17);
            this.tlstrTimer.Text = "Timer Enabled";
            this.tlstrTimer.Visible = false;
            // 
            // tlstrNumbers
            // 
            this.tlstrNumbers.Name = "tlstrNumbers";
            this.tlstrNumbers.Size = new System.Drawing.Size(0, 17);
            // 
            // tmrRefreshCharList
            // 
            this.tmrRefreshCharList.Interval = 30000;
            this.tmrRefreshCharList.Tick += new System.EventHandler(this.tmrRefreshCharList_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // tmrRefreshChat
            // 
            this.tmrRefreshChat.Interval = 5000;
            this.tmrRefreshChat.Tick += new System.EventHandler(this.tmrRefreshChat_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 510);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharacters)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCharacter.ResumeLayout(false);
            this.tabMonsters.ResumeLayout(false);
            this.tabMonsters.PerformLayout();
            this.grpMonsterDrop.ResumeLayout(false);
            this.grpMonsterDrop.PerformLayout();
            this.tabChat.ResumeLayout(false);
            this.tabChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChat)).EndInit();
            this.tabConfig.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCharacters;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolJobsExp;
        private System.Windows.Forms.ToolStripMenuItem toolCharLook;
        private System.Windows.Forms.ToolStripMenuItem toolCharSkills;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtDBPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDBUname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCharacter;
        private System.Windows.Forms.TabPage tabMonsters;
        private System.Windows.Forms.ListBox lstMonsters;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem toolInventory;
        private System.Windows.Forms.GroupBox grpMonsterDrop;
        private System.Windows.Forms.Button btnAddDrop;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tlstrConnected;
        private System.Windows.Forms.CheckBox chkAutoConnect;
        private System.Windows.Forms.Timer tmrRefreshCharList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCharListRefreshValue;
        private System.Windows.Forms.CheckBox chkRefresh;
        private System.Windows.Forms.ToolStripStatusLabel tlstrTimer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripStatusLabel tlstrNumbers;
        private System.Windows.Forms.TabPage tabChat;
        private System.Windows.Forms.Button btnChatRefresh;
        private System.Windows.Forms.CheckBox cbChatRefresh;
        private System.Windows.Forms.DataGridView dgChat;
        private System.Windows.Forms.Timer tmrRefreshChat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtShowMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn chatType;
        private System.Windows.Forms.DataGridViewTextBoxColumn chatFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn chatTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn chatMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn chatTimestamp;
        private System.Windows.Forms.DataGridViewImageColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAcctID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCharName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmZone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastOn;
        private System.Windows.Forms.ToolStripMenuItem toolExportChar;
    }
}

