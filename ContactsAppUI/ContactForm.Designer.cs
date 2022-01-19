namespace ContactsAppUI
{
    partial class ContactForm
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
            this.DateBirthDay = new System.Windows.Forms.DateTimePicker();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.BirthDayLabel = new System.Windows.Forms.Label();
            this.IdVKLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.IdVkTextBox = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // DateBirthDay
            // 
            this.DateBirthDay.Location = new System.Drawing.Point(104, 97);
            this.DateBirthDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateBirthDay.Name = "DateBirthDay";
            this.DateBirthDay.Size = new System.Drawing.Size(411, 22);
            this.DateBirthDay.TabIndex = 25;
            this.DateBirthDay.ValueChanged += new System.EventHandler(this.DateBirthDay_ValueChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(104, 65);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(411, 22);
            this.NameTextBox.TabIndex = 24;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_Leave);
            this.NameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(27, 38);
            this.SurnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(69, 17);
            this.SurnameLabel.TabIndex = 15;
            this.SurnameLabel.Text = "Surname:";
            this.toolTip1.SetToolTip(this.SurnameLabel, "Surname must not be more than 50 charesters");
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(43, 166);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(46, 17);
            this.EmailLabel.TabIndex = 19;
            this.EmailLabel.Text = "Email:";
            this.toolTip1.SetToolTip(this.EmailLabel, "Email: must contain \"@\"");
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(43, 69);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 17);
            this.NameLabel.TabIndex = 16;
            this.NameLabel.Text = "Name:";
            this.toolTip1.SetToolTip(this.NameLabel, "Name must not be more than 15 charesters");
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(104, 129);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(411, 22);
            this.PhoneTextBox.TabIndex = 26;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_Leave);
            this.PhoneTextBox.Leave += new System.EventHandler(this.PhoneTextBox_Leave);
            // 
            // BirthDayLabel
            // 
            this.BirthDayLabel.AutoSize = true;
            this.BirthDayLabel.Location = new System.Drawing.Point(29, 102);
            this.BirthDayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirthDayLabel.Name = "BirthDayLabel";
            this.BirthDayLabel.Size = new System.Drawing.Size(66, 17);
            this.BirthDayLabel.TabIndex = 17;
            this.BirthDayLabel.Text = "BirthDay:";
            this.toolTip1.SetToolTip(this.BirthDayLabel, "BirthDay must be more then 01.01.1900 and values ​​must be up to TODAY");
            // 
            // IdVKLabel
            // 
            this.IdVKLabel.AutoSize = true;
            this.IdVKLabel.Location = new System.Drawing.Point(36, 197);
            this.IdVKLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdVKLabel.Name = "IdVKLabel";
            this.IdVKLabel.Size = new System.Drawing.Size(56, 17);
            this.IdVKLabel.TabIndex = 20;
            this.IdVKLabel.Text = "vk.com:";
            this.toolTip1.SetToolTip(this.IdVKLabel, "id in VK must not be more than 15 characters");
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(39, 134);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(53, 17);
            this.PhoneLabel.TabIndex = 18;
            this.PhoneLabel.Text = "Phone:";
            this.toolTip1.SetToolTip(this.PhoneLabel, "Phone must comply with the format 7(ХХХ)ХХХ ХХ ХХ ");
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(104, 33);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(411, 22);
            this.SurnameTextBox.TabIndex = 23;
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_Leave);
            this.SurnameTextBox.Leave += new System.EventHandler(this.SurnameTextBox_Leave);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(104, 161);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(411, 22);
            this.EmailTextBox.TabIndex = 27;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // IdVkTextBox
            // 
            this.IdVkTextBox.Location = new System.Drawing.Point(104, 193);
            this.IdVkTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdVkTextBox.Name = "IdVkTextBox";
            this.IdVkTextBox.Size = new System.Drawing.Size(411, 22);
            this.IdVkTextBox.TabIndex = 28;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(416, 249);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(308, 249);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 29;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 284);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.DateBirthDay);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.BirthDayLabel);
            this.Controls.Add(this.IdVKLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.IdVkTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(562, 331);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(562, 331);
            this.Name = "ContactForm";
            this.ShowIcon = false;
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateBirthDay;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label BirthDayLabel;
        private System.Windows.Forms.Label IdVKLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox IdVkTextBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}