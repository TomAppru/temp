namespace battleTest
{
    partial class battleWindow
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
            this.lblItemToUse = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.clmItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUseItem = new System.Windows.Forms.Button();
            this.cmbItemToUse = new System.Windows.Forms.ComboBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.pbHealth = new System.Windows.Forms.ProgressBar();
            this.lblHPlabel = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.sfdSavePlayer = new System.Windows.Forms.SaveFileDialog();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblLevelText = new System.Windows.Forms.Label();
            this.lblGoldText = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblExperienceText = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.ap1 = new System.Windows.Forms.Panel();
            this.ap2 = new System.Windows.Forms.Panel();
            this.ap3 = new System.Windows.Forms.Panel();
            this.ap4 = new System.Windows.Forms.Panel();
            this.ap5 = new System.Windows.Forms.Panel();
            this.ap6 = new System.Windows.Forms.Panel();
            this.ap7 = new System.Windows.Forms.Panel();
            this.ap8 = new System.Windows.Forms.Panel();
            this.ap9 = new System.Windows.Forms.Panel();
            this.ap10 = new System.Windows.Forms.Panel();
            this.lblActionPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemToUse
            // 
            this.lblItemToUse.AutoSize = true;
            this.lblItemToUse.Location = new System.Drawing.Point(262, 307);
            this.lblItemToUse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemToUse.Name = "lblItemToUse";
            this.lblItemToUse.Size = new System.Drawing.Size(68, 13);
            this.lblItemToUse.TabIndex = 19;
            this.lblItemToUse.Text = "Item To Use:";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(4, 134);
            this.lblInventory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(78, 20);
            this.lblInventory.TabIndex = 14;
            this.lblInventory.Text = "Inventory:";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmItemName,
            this.clmItemCount,
            this.clmItemID});
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Location = new System.Drawing.Point(8, 159);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowTemplate.Height = 28;
            this.dgvInventory.ShowEditingIcon = false;
            this.dgvInventory.Size = new System.Drawing.Size(249, 225);
            this.dgvInventory.TabIndex = 13;
            // 
            // clmItemName
            // 
            this.clmItemName.HeaderText = "Item";
            this.clmItemName.Name = "clmItemName";
            this.clmItemName.ReadOnly = true;
            this.clmItemName.Width = 200;
            // 
            // clmItemCount
            // 
            this.clmItemCount.HeaderText = "";
            this.clmItemCount.Name = "clmItemCount";
            this.clmItemCount.ReadOnly = true;
            this.clmItemCount.Width = 50;
            // 
            // clmItemID
            // 
            this.clmItemID.HeaderText = "";
            this.clmItemID.Name = "clmItemID";
            this.clmItemID.ReadOnly = true;
            this.clmItemID.Visible = false;
            // 
            // btnUseItem
            // 
            this.btnUseItem.Location = new System.Drawing.Point(559, 318);
            this.btnUseItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnUseItem.Name = "btnUseItem";
            this.btnUseItem.Size = new System.Drawing.Size(113, 31);
            this.btnUseItem.TabIndex = 12;
            this.btnUseItem.Text = "Use";
            this.btnUseItem.UseVisualStyleBackColor = true;
            this.btnUseItem.Click += new System.EventHandler(this.btnUseItem_Click);
            // 
            // cmbItemToUse
            // 
            this.cmbItemToUse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemToUse.FormattingEnabled = true;
            this.cmbItemToUse.Location = new System.Drawing.Point(261, 324);
            this.cmbItemToUse.Margin = new System.Windows.Forms.Padding(2);
            this.cmbItemToUse.Name = "cmbItemToUse";
            this.cmbItemToUse.Size = new System.Drawing.Size(295, 21);
            this.cmbItemToUse.TabIndex = 11;
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.SystemColors.Window;
            this.rtbOutput.Location = new System.Drawing.Point(261, 8);
            this.rtbOutput.Margin = new System.Windows.Forms.Padding(2);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(412, 283);
            this.rtbOutput.TabIndex = 10;
            this.rtbOutput.Text = "";
            // 
            // pbHealth
            // 
            this.pbHealth.BackColor = System.Drawing.SystemColors.Desktop;
            this.pbHealth.ForeColor = System.Drawing.Color.ForestGreen;
            this.pbHealth.Location = new System.Drawing.Point(8, 27);
            this.pbHealth.Margin = new System.Windows.Forms.Padding(2);
            this.pbHealth.Name = "pbHealth";
            this.pbHealth.Size = new System.Drawing.Size(249, 17);
            this.pbHealth.Step = 1;
            this.pbHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbHealth.TabIndex = 21;
            // 
            // lblHPlabel
            // 
            this.lblHPlabel.AutoSize = true;
            this.lblHPlabel.Location = new System.Drawing.Point(5, 8);
            this.lblHPlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHPlabel.Name = "lblHPlabel";
            this.lblHPlabel.Size = new System.Drawing.Size(25, 13);
            this.lblHPlabel.TabIndex = 22;
            this.lblHPlabel.Text = "HP:";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(5, 45);
            this.lblHealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(0, 13);
            this.lblHealth.TabIndex = 23;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(185, 86);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(72, 31);
            this.btnLoad.TabIndex = 24;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(185, 123);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 31);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Location = new System.Drawing.Point(559, 354);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(113, 31);
            this.btnEndTurn.TabIndex = 26;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(185, 49);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(72, 31);
            this.btnNewGame.TabIndex = 27;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblLevelText
            // 
            this.lblLevelText.AutoSize = true;
            this.lblLevelText.Location = new System.Drawing.Point(32, 80);
            this.lblLevelText.Name = "lblLevelText";
            this.lblLevelText.Size = new System.Drawing.Size(36, 13);
            this.lblLevelText.TabIndex = 28;
            this.lblLevelText.Text = "Level:";
            // 
            // lblGoldText
            // 
            this.lblGoldText.AutoSize = true;
            this.lblGoldText.Location = new System.Drawing.Point(36, 93);
            this.lblGoldText.Name = "lblGoldText";
            this.lblGoldText.Size = new System.Drawing.Size(32, 13);
            this.lblGoldText.TabIndex = 29;
            this.lblGoldText.Text = "Gold:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(68, 80);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 13);
            this.lblLevel.TabIndex = 30;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(68, 93);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(0, 13);
            this.lblGold.TabIndex = 31;
            // 
            // lblExperienceText
            // 
            this.lblExperienceText.AutoSize = true;
            this.lblExperienceText.Location = new System.Drawing.Point(5, 67);
            this.lblExperienceText.Name = "lblExperienceText";
            this.lblExperienceText.Size = new System.Drawing.Size(63, 13);
            this.lblExperienceText.TabIndex = 32;
            this.lblExperienceText.Text = "Experience:";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(68, 67);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(0, 13);
            this.lblExperience.TabIndex = 33;
            // 
            // ap1
            // 
            this.ap1.BackColor = System.Drawing.Color.Teal;
            this.ap1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ap1.Location = new System.Drawing.Point(261, 364);
            this.ap1.Name = "ap1";
            this.ap1.Size = new System.Drawing.Size(20, 20);
            this.ap1.TabIndex = 34;
            // 
            // ap2
            // 
            this.ap2.BackColor = System.Drawing.Color.Teal;
            this.ap2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ap2.Location = new System.Drawing.Point(287, 364);
            this.ap2.Name = "ap2";
            this.ap2.Size = new System.Drawing.Size(20, 20);
            this.ap2.TabIndex = 35;
            // 
            // ap3
            // 
            this.ap3.BackColor = System.Drawing.Color.Teal;
            this.ap3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ap3.Location = new System.Drawing.Point(313, 364);
            this.ap3.Name = "ap3";
            this.ap3.Size = new System.Drawing.Size(20, 20);
            this.ap3.TabIndex = 35;
            // 
            // ap4
            // 
            this.ap4.BackColor = System.Drawing.Color.Teal;
            this.ap4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ap4.Location = new System.Drawing.Point(339, 364);
            this.ap4.Name = "ap4";
            this.ap4.Size = new System.Drawing.Size(20, 20);
            this.ap4.TabIndex = 35;
            // 
            // ap5
            // 
            this.ap5.BackColor = System.Drawing.Color.Teal;
            this.ap5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ap5.Location = new System.Drawing.Point(365, 364);
            this.ap5.Name = "ap5";
            this.ap5.Size = new System.Drawing.Size(20, 20);
            this.ap5.TabIndex = 35;
            // 
            // ap6
            // 
            this.ap6.BackColor = System.Drawing.Color.Teal;
            this.ap6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ap6.Location = new System.Drawing.Point(391, 364);
            this.ap6.Name = "ap6";
            this.ap6.Size = new System.Drawing.Size(20, 20);
            this.ap6.TabIndex = 35;
            // 
            // ap7
            // 
            this.ap7.BackColor = System.Drawing.Color.Teal;
            this.ap7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ap7.Location = new System.Drawing.Point(417, 364);
            this.ap7.Name = "ap7";
            this.ap7.Size = new System.Drawing.Size(20, 20);
            this.ap7.TabIndex = 35;
            // 
            // ap8
            // 
            this.ap8.BackColor = System.Drawing.Color.Teal;
            this.ap8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ap8.Location = new System.Drawing.Point(443, 364);
            this.ap8.Name = "ap8";
            this.ap8.Size = new System.Drawing.Size(20, 20);
            this.ap8.TabIndex = 35;
            // 
            // ap9
            // 
            this.ap9.BackColor = System.Drawing.Color.Teal;
            this.ap9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ap9.Location = new System.Drawing.Point(469, 364);
            this.ap9.Name = "ap9";
            this.ap9.Size = new System.Drawing.Size(20, 20);
            this.ap9.TabIndex = 35;
            // 
            // ap10
            // 
            this.ap10.BackColor = System.Drawing.Color.Teal;
            this.ap10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ap10.Location = new System.Drawing.Point(495, 364);
            this.ap10.Name = "ap10";
            this.ap10.Size = new System.Drawing.Size(20, 20);
            this.ap10.TabIndex = 35;
            // 
            // lblActionPoints
            // 
            this.lblActionPoints.AutoSize = true;
            this.lblActionPoints.Location = new System.Drawing.Point(262, 348);
            this.lblActionPoints.Name = "lblActionPoints";
            this.lblActionPoints.Size = new System.Drawing.Size(72, 13);
            this.lblActionPoints.TabIndex = 36;
            this.lblActionPoints.Text = "Action Points:";
            // 
            // battleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 392);
            this.Controls.Add(this.lblActionPoints);
            this.Controls.Add(this.ap2);
            this.Controls.Add(this.ap3);
            this.Controls.Add(this.ap4);
            this.Controls.Add(this.ap5);
            this.Controls.Add(this.ap6);
            this.Controls.Add(this.ap7);
            this.Controls.Add(this.ap8);
            this.Controls.Add(this.ap9);
            this.Controls.Add(this.ap10);
            this.Controls.Add(this.ap1);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblExperienceText);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblGoldText);
            this.Controls.Add(this.lblLevelText);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblHPlabel);
            this.Controls.Add(this.pbHealth);
            this.Controls.Add(this.lblItemToUse);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.btnUseItem);
            this.Controls.Add(this.cmbItemToUse);
            this.Controls.Add(this.rtbOutput);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "battleWindow";
            this.Text = "Battle-O-Tron";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemToUse;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnUseItem;
        private System.Windows.Forms.ComboBox cmbItemToUse;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.ProgressBar pbHealth;
        private System.Windows.Forms.Label lblHPlabel;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog sfdSavePlayer;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemID;
        private System.Windows.Forms.Label lblLevelText;
        private System.Windows.Forms.Label lblGoldText;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblExperienceText;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Panel ap1;
        private System.Windows.Forms.Panel ap2;
        private System.Windows.Forms.Panel ap3;
        private System.Windows.Forms.Panel ap4;
        private System.Windows.Forms.Panel ap5;
        private System.Windows.Forms.Panel ap6;
        private System.Windows.Forms.Panel ap7;
        private System.Windows.Forms.Panel ap8;
        private System.Windows.Forms.Panel ap9;
        private System.Windows.Forms.Panel ap10;
        private System.Windows.Forms.Label lblActionPoints;
    }
}

