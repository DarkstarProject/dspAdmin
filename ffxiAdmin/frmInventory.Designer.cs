namespace dspAdmin
{
    partial class frmInventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbAllItems = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeletefromChar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddtoChar = new System.Windows.Forms.Button();
            this.dgvCharInventory = new System.Windows.Forms.DataGridView();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.radInventory = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radSatchel = new System.Windows.Forms.RadioButton();
            this.radSafe = new System.Windows.Forms.RadioButton();
            this.radHouse = new System.Windows.Forms.RadioButton();
            this.txtItemQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvInventoryCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvInventoryItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventoryItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLocation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvInventoryItemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharInventory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory:";
            // 
            // lbAllItems
            // 
            this.lbAllItems.FormattingEnabled = true;
            this.lbAllItems.Location = new System.Drawing.Point(663, 95);
            this.lbAllItems.Name = "lbAllItems";
            this.lbAllItems.ScrollAlwaysVisible = true;
            this.lbAllItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbAllItems.Size = new System.Drawing.Size(163, 277);
            this.lbAllItems.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "All Available Items:";
            // 
            // btnDeletefromChar
            // 
            this.btnDeletefromChar.Enabled = false;
            this.btnDeletefromChar.Location = new System.Drawing.Point(99, 401);
            this.btnDeletefromChar.Name = "btnDeletefromChar";
            this.btnDeletefromChar.Size = new System.Drawing.Size(108, 23);
            this.btnDeletefromChar.TabIndex = 4;
            this.btnDeletefromChar.Text = "Delete Selected";
            this.btnDeletefromChar.UseVisualStyleBackColor = true;
            this.btnDeletefromChar.Click += new System.EventHandler(this.btnDeletefromChar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(438, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAddtoChar
            // 
            this.btnAddtoChar.Enabled = false;
            this.btnAddtoChar.Location = new System.Drawing.Point(843, 313);
            this.btnAddtoChar.Name = "btnAddtoChar";
            this.btnAddtoChar.Size = new System.Drawing.Size(75, 23);
            this.btnAddtoChar.TabIndex = 6;
            this.btnAddtoChar.Text = "Add";
            this.btnAddtoChar.UseVisualStyleBackColor = true;
            this.btnAddtoChar.Click += new System.EventHandler(this.btnAddtoChar_Click);
            // 
            // dgvCharInventory
            // 
            this.dgvCharInventory.AllowUserToAddRows = false;
            this.dgvCharInventory.AllowUserToDeleteRows = false;
            this.dgvCharInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCharInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvInventoryCheckbox,
            this.dgvInventoryItemID,
            this.dgvInventoryItemName,
            this.clmLocation,
            this.dgvInventoryItemAmount});
            this.dgvCharInventory.Location = new System.Drawing.Point(43, 95);
            this.dgvCharInventory.Name = "dgvCharInventory";
            this.dgvCharInventory.Size = new System.Drawing.Size(614, 277);
            this.dgvCharInventory.TabIndex = 7;
            this.dgvCharInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvCharInventory.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCharInventory_CellEndEdit);
            // 
            // cmbItemType
            // 
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Items.AddRange(new object[] {
            "Armor",
            "Basic",
            "Furnishings",
            "Usable",
            "Weapons"});
            this.cmbItemType.Location = new System.Drawing.Point(663, 68);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(121, 21);
            this.cmbItemType.TabIndex = 8;
            this.cmbItemType.Text = "Select Item Type";
            this.cmbItemType.SelectedIndexChanged += new System.EventHandler(this.cmbItemType_SelectedIndexChanged);
            // 
            // radInventory
            // 
            this.radInventory.AutoSize = true;
            this.radInventory.Checked = true;
            this.radInventory.Location = new System.Drawing.Point(6, 19);
            this.radInventory.Name = "radInventory";
            this.radInventory.Size = new System.Drawing.Size(69, 17);
            this.radInventory.TabIndex = 9;
            this.radInventory.TabStop = true;
            this.radInventory.Text = "Inventory";
            this.radInventory.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSatchel);
            this.groupBox1.Controls.Add(this.radSafe);
            this.groupBox1.Controls.Add(this.radHouse);
            this.groupBox1.Controls.Add(this.radInventory);
            this.groupBox1.Location = new System.Drawing.Point(840, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 116);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add To:";
            // 
            // radSatchel
            // 
            this.radSatchel.AutoSize = true;
            this.radSatchel.Location = new System.Drawing.Point(6, 88);
            this.radSatchel.Name = "radSatchel";
            this.radSatchel.Size = new System.Drawing.Size(61, 17);
            this.radSatchel.TabIndex = 12;
            this.radSatchel.Text = "Satchel";
            this.radSatchel.UseVisualStyleBackColor = true;
            // 
            // radSafe
            // 
            this.radSafe.AutoSize = true;
            this.radSafe.Location = new System.Drawing.Point(6, 65);
            this.radSafe.Name = "radSafe";
            this.radSafe.Size = new System.Drawing.Size(47, 17);
            this.radSafe.TabIndex = 11;
            this.radSafe.Text = "Safe";
            this.radSafe.UseVisualStyleBackColor = true;
            // 
            // radHouse
            // 
            this.radHouse.AutoSize = true;
            this.radHouse.Location = new System.Drawing.Point(6, 42);
            this.radHouse.Name = "radHouse";
            this.radHouse.Size = new System.Drawing.Size(56, 17);
            this.radHouse.TabIndex = 10;
            this.radHouse.Text = "House";
            this.radHouse.UseVisualStyleBackColor = true;
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Location = new System.Drawing.Point(843, 251);
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.Size = new System.Drawing.Size(75, 20);
            this.txtItemQuantity.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(843, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quantity:";
            // 
            // dgvInventoryCheckbox
            // 
            this.dgvInventoryCheckbox.HeaderText = "Select";
            this.dgvInventoryCheckbox.Name = "dgvInventoryCheckbox";
            this.dgvInventoryCheckbox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvInventoryCheckbox.Width = 50;
            // 
            // dgvInventoryItemID
            // 
            this.dgvInventoryItemID.HeaderText = "Item ID";
            this.dgvInventoryItemID.Name = "dgvInventoryItemID";
            this.dgvInventoryItemID.ReadOnly = true;
            this.dgvInventoryItemID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryItemID.Width = 75;
            // 
            // dgvInventoryItemName
            // 
            this.dgvInventoryItemName.HeaderText = "Item Name";
            this.dgvInventoryItemName.Name = "dgvInventoryItemName";
            this.dgvInventoryItemName.ReadOnly = true;
            this.dgvInventoryItemName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryItemName.Width = 300;
            // 
            // clmLocation
            // 
            this.clmLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmLocation.HeaderText = "Location";
            this.clmLocation.Name = "clmLocation";
            this.clmLocation.Width = 54;
            // 
            // dgvInventoryItemAmount
            // 
            this.dgvInventoryItemAmount.FillWeight = 75F;
            this.dgvInventoryItemAmount.HeaderText = "Amount";
            this.dgvInventoryItemAmount.Name = "dgvInventoryItemAmount";
            this.dgvInventoryItemAmount.Width = 75;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtItemQuantity);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbItemType);
            this.Controls.Add(this.dgvCharInventory);
            this.Controls.Add(this.btnAddtoChar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDeletefromChar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAllItems);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmInventory";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "frmInventory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharInventory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAllItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeletefromChar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddtoChar;
        private System.Windows.Forms.DataGridView dgvCharInventory;
        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.RadioButton radInventory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radSatchel;
        private System.Windows.Forms.RadioButton radSafe;
        private System.Windows.Forms.RadioButton radHouse;
        private System.Windows.Forms.TextBox txtItemQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvInventoryCheckbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventoryItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventoryItemName;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventoryItemAmount;
    }
}