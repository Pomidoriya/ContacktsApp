namespace ContactsAppUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BirthdayPanel = new System.Windows.Forms.Panel();
            this.TodayBdayPictureBox = new System.Windows.Forms.PictureBox();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.BdayLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.VkLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.DateBirthDay = new System.Windows.Forms.DateTimePicker();
            this.IdVkTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.BirthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TodayBdayPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveButton.Image")));
            this.RemoveButton.Location = new System.Drawing.Point(96, 495);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(37, 28);
            this.RemoveButton.TabIndex = 0;
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.Remove_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.Color.Transparent;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(16, 495);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(37, 28);
            this.AddButton.TabIndex = 6;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.Add_Click);
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.IntegralHeight = false;
            this.ContactsListBox.ItemHeight = 16;
            this.ContactsListBox.Location = new System.Drawing.Point(16, 66);
            this.ContactsListBox.Margin = new System.Windows.Forms.Padding(1);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(288, 420);
            this.ContactsListBox.TabIndex = 7;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            this.ContactsListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ContactsListBox_KeyDown);
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(16, 37);
            this.FindLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(39, 17);
            this.FindLabel.TabIndex = 15;
            this.FindLabel.Text = "Find:";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(64, 33);
            this.FindTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(240, 22);
            this.FindTextBox.TabIndex = 16;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.Location = new System.Drawing.Point(52, 495);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(37, 28);
            this.EditButton.TabIndex = 17;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BirthdayPanel);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 514);
            this.panel1.TabIndex = 19;
            // 
            // BirthdayPanel
            // 
            this.BirthdayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanel.AutoScroll = true;
            this.BirthdayPanel.Controls.Add(this.TodayBdayPictureBox);
            this.BirthdayPanel.Controls.Add(this.BirthDateLabel);
            this.BirthdayPanel.Location = new System.Drawing.Point(311, 348);
            this.BirthdayPanel.Margin = new System.Windows.Forms.Padding(4);
            this.BirthdayPanel.Name = "BirthdayPanel";
            this.BirthdayPanel.Size = new System.Drawing.Size(533, 153);
            this.BirthdayPanel.TabIndex = 22;
            // 
            // TodayBdayPictureBox
            // 
            this.TodayBdayPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TodayBdayPictureBox.Image")));
            this.TodayBdayPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("TodayBdayPictureBox.InitialImage")));
            this.TodayBdayPictureBox.Location = new System.Drawing.Point(4, 36);
            this.TodayBdayPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.TodayBdayPictureBox.Name = "TodayBdayPictureBox";
            this.TodayBdayPictureBox.Size = new System.Drawing.Size(85, 84);
            this.TodayBdayPictureBox.TabIndex = 22;
            this.TodayBdayPictureBox.TabStop = false;
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(93, 69);
            this.BirthDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(78, 17);
            this.BirthDateLabel.TabIndex = 21;
            this.BirthDateLabel.Text = "Bdaylabel1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SurnameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.NameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SurnameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BdayLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PhoneLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.EmailLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.VkLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.EmailTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.PhoneTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DateBirthDay, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.IdVkTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.NameTextBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(311, 7);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.07618F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.31281F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.69449F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.63884F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.63884F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.63884F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 231);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SurnameLabel.Location = new System.Drawing.Point(20, 10);
            this.SurnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(69, 17);
            this.SurnameLabel.TabIndex = 0;
            this.SurnameLabel.Text = "Surname:";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(40, 48);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.Location = new System.Drawing.Point(97, 7);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.ReadOnly = true;
            this.SurnameTextBox.Size = new System.Drawing.Size(432, 22);
            this.SurnameTextBox.TabIndex = 7;
            // 
            // BdayLabel
            // 
            this.BdayLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BdayLabel.AutoSize = true;
            this.BdayLabel.Location = new System.Drawing.Point(23, 86);
            this.BdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BdayLabel.Name = "BdayLabel";
            this.BdayLabel.Size = new System.Drawing.Size(66, 17);
            this.BdayLabel.TabIndex = 2;
            this.BdayLabel.Text = "BirthDay:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(36, 124);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(53, 17);
            this.PhoneLabel.TabIndex = 3;
            this.PhoneLabel.Text = "Phone:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(38, 162);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(51, 17);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "E-mail:";
            // 
            // VkLabel
            // 
            this.VkLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VkLabel.AutoSize = true;
            this.VkLabel.Location = new System.Drawing.Point(33, 202);
            this.VkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VkLabel.Name = "VkLabel";
            this.VkLabel.Size = new System.Drawing.Size(56, 17);
            this.VkLabel.TabIndex = 5;
            this.VkLabel.Text = "vk.com:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(97, 160);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(432, 22);
            this.EmailTextBox.TabIndex = 11;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneTextBox.Location = new System.Drawing.Point(97, 122);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.ReadOnly = true;
            this.PhoneTextBox.Size = new System.Drawing.Size(432, 22);
            this.PhoneTextBox.TabIndex = 10;
            // 
            // DateBirthDay
            // 
            this.DateBirthDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DateBirthDay.Enabled = false;
            this.DateBirthDay.Location = new System.Drawing.Point(97, 84);
            this.DateBirthDay.Margin = new System.Windows.Forms.Padding(4);
            this.DateBirthDay.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.DateBirthDay.Name = "DateBirthDay";
            this.DateBirthDay.Size = new System.Drawing.Size(432, 22);
            this.DateBirthDay.TabIndex = 9;
            // 
            // IdVkTextBox
            // 
            this.IdVkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IdVkTextBox.Location = new System.Drawing.Point(97, 199);
            this.IdVkTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdVkTextBox.Name = "IdVkTextBox";
            this.IdVkTextBox.ReadOnly = true;
            this.IdVkTextBox.Size = new System.Drawing.Size(432, 22);
            this.IdVkTextBox.TabIndex = 12;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(97, 45);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(432, 22);
            this.NameTextBox.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            this.addContactToolStripMenuItem.Click += new System.EventHandler(this.addContactToolStripMenuItem_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.editContactToolStripMenuItem.Text = "Edit Contact";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.editContactToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.removeToolStripMenuItem.Text = "Remove Contact";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 542);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.FindTextBox);
            this.Controls.Add(this.FindLabel);
            this.Controls.Add(this.ContactsListBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1119, 662);
            this.MinimumSize = new System.Drawing.Size(913, 559);
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactsForm_FormClosing);
            this.Load += new System.EventHandler(this.ContactsForm_Load);
            this.panel1.ResumeLayout(false);
            this.BirthdayPanel.ResumeLayout(false);
            this.BirthdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TodayBdayPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BdayLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label VkLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox IdVkTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.DateTimePicker DateBirthDay;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.Panel BirthdayPanel;
        private System.Windows.Forms.PictureBox TodayBdayPictureBox;
    }
}