namespace ContactsAppUI
{
    partial class AboutForm
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
            this.ContactsAppLabel = new System.Windows.Forms.Label();
            this.VarsionLabel = new System.Windows.Forms.Label();
            this.AuthorAboutLabel = new System.Windows.Forms.Label();
            this.EmailAboutLabel = new System.Windows.Forms.Label();
            this.GithubLabel = new System.Windows.Forms.Label();
            this.EmailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AuthorAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ContactsAppLabel
            // 
            this.ContactsAppLabel.AutoSize = true;
            this.ContactsAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.ContactsAppLabel.Location = new System.Drawing.Point(35, 39);
            this.ContactsAppLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactsAppLabel.Name = "ContactsAppLabel";
            this.ContactsAppLabel.Size = new System.Drawing.Size(182, 31);
            this.ContactsAppLabel.TabIndex = 0;
            this.ContactsAppLabel.Text = "ContactsApp";
            // 
            // VarsionLabel
            // 
            this.VarsionLabel.AutoSize = true;
            this.VarsionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.VarsionLabel.Location = new System.Drawing.Point(37, 82);
            this.VarsionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VarsionLabel.Name = "VarsionLabel";
            this.VarsionLabel.Size = new System.Drawing.Size(55, 18);
            this.VarsionLabel.TabIndex = 1;
            this.VarsionLabel.Text = "v. 0.0.1";
            // 
            // AuthorAboutLabel
            // 
            this.AuthorAboutLabel.AutoSize = true;
            this.AuthorAboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.AuthorAboutLabel.Location = new System.Drawing.Point(37, 158);
            this.AuthorAboutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorAboutLabel.Name = "AuthorAboutLabel";
            this.AuthorAboutLabel.Size = new System.Drawing.Size(142, 18);
            this.AuthorAboutLabel.TabIndex = 2;
            this.AuthorAboutLabel.Text = "Author: Igor Serdyuk";
            // 
            // EmailAboutLabel
            // 
            this.EmailAboutLabel.AutoSize = true;
            this.EmailAboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.EmailAboutLabel.Location = new System.Drawing.Point(37, 223);
            this.EmailAboutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailAboutLabel.Name = "EmailAboutLabel";
            this.EmailAboutLabel.Size = new System.Drawing.Size(138, 18);
            this.EmailAboutLabel.TabIndex = 3;
            this.EmailAboutLabel.Text = "e-mail for feedback:";
            // 
            // GithubLabel
            // 
            this.GithubLabel.AutoSize = true;
            this.GithubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.GithubLabel.Location = new System.Drawing.Point(37, 262);
            this.GithubLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GithubLabel.Name = "GithubLabel";
            this.GithubLabel.Size = new System.Drawing.Size(62, 18);
            this.GithubLabel.TabIndex = 5;
            this.GithubLabel.Text = "Git Hub:";
            // 
            // EmailLinkLabel
            // 
            this.EmailLinkLabel.AutoSize = true;
            this.EmailLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.EmailLinkLabel.Location = new System.Drawing.Point(191, 223);
            this.EmailLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLinkLabel.Name = "EmailLinkLabel";
            this.EmailLinkLabel.Size = new System.Drawing.Size(178, 18);
            this.EmailLinkLabel.TabIndex = 7;
            this.EmailLinkLabel.TabStop = true;
            this.EmailLinkLabel.Text = "igorserd2909@gmail.com";
            // 
            // GitHubLinkLabel
            // 
            this.GitHubLinkLabel.AutoSize = true;
            this.GitHubLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.GitHubLinkLabel.Location = new System.Drawing.Point(107, 262);
            this.GitHubLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.Size = new System.Drawing.Size(293, 18);
            this.GitHubLinkLabel.TabIndex = 8;
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.Text = "https://github.com/Pomidoriya/ContactsApp";
            this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
            // 
            // AuthorAbout
            // 
            this.AuthorAbout.AutoSize = true;
            this.AuthorAbout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AuthorAbout.Location = new System.Drawing.Point(16, 391);
            this.AuthorAbout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorAbout.Name = "AuthorAbout";
            this.AuthorAbout.Size = new System.Drawing.Size(138, 17);
            this.AuthorAbout.TabIndex = 9;
            this.AuthorAbout.Text = "2022 Igor Serdyuk ©";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 409);
            this.Controls.Add(this.AuthorAbout);
            this.Controls.Add(this.GitHubLinkLabel);
            this.Controls.Add(this.EmailLinkLabel);
            this.Controls.Add(this.GithubLabel);
            this.Controls.Add(this.EmailAboutLabel);
            this.Controls.Add(this.AuthorAboutLabel);
            this.Controls.Add(this.VarsionLabel);
            this.Controls.Add(this.ContactsAppLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(543, 456);
            this.MinimumSize = new System.Drawing.Size(543, 456);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ContactsAppLabel;
        private System.Windows.Forms.Label VarsionLabel;
        private System.Windows.Forms.Label AuthorAboutLabel;
        private System.Windows.Forms.Label EmailAboutLabel;
        private System.Windows.Forms.Label GithubLabel;
        private System.Windows.Forms.LinkLabel EmailLinkLabel;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel;
        private System.Windows.Forms.Label AuthorAbout;
    }
}