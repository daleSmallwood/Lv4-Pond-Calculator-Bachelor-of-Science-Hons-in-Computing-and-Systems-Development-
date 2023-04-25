namespace Pondcalc_dale_smallwood_130089872_lv4_2020
{
    partial class Form2
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
            this.CreateNewUser = new System.Windows.Forms.TextBox();
            this.NewUserPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewUser = new System.Windows.Forms.RadioButton();
            this.Remove = new System.Windows.Forms.RadioButton();
            this.Continue = new System.Windows.Forms.Button();
            this.AdminProgress = new System.Windows.Forms.ProgressBar();
            this.None = new System.Windows.Forms.RadioButton();
            this.RemoveUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ExistingUsers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Staff = new System.Windows.Forms.RadioButton();
            this.Admin = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Confirmation = new System.Windows.Forms.TextBox();
            this.SubmitNewUser = new System.Windows.Forms.Button();
            this.GroupBoxNewUser = new System.Windows.Forms.GroupBox();
            this.GroupBoxRemoveUser = new System.Windows.Forms.GroupBox();
            this.PhraseSubmit = new System.Windows.Forms.Button();
            this.AdminMenuTimer = new System.Windows.Forms.Timer(this.components);
            this.GroupBoxNewUser.SuspendLayout();
            this.GroupBoxRemoveUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateNewUser
            // 
            this.CreateNewUser.Location = new System.Drawing.Point(185, 26);
            this.CreateNewUser.Name = "CreateNewUser";
            this.CreateNewUser.Size = new System.Drawing.Size(138, 22);
            this.CreateNewUser.TabIndex = 0;
            this.CreateNewUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewUserPassword
            // 
            this.NewUserPassword.Location = new System.Drawing.Point(185, 66);
            this.NewUserPassword.Name = "NewUserPassword";
            this.NewUserPassword.Size = new System.Drawing.Size(138, 22);
            this.NewUserPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "New User Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "New User Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "What would you like to do?\r\n";
            // 
            // NewUser
            // 
            this.NewUser.AutoSize = true;
            this.NewUser.Location = new System.Drawing.Point(12, 43);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(119, 21);
            this.NewUser.TabIndex = 5;
            this.NewUser.TabStop = true;
            this.NewUser.Text = "Add New User";
            this.NewUser.UseVisualStyleBackColor = true;
            this.NewUser.CheckedChanged += new System.EventHandler(this.NewUser_CheckedChanged);
            // 
            // Remove
            // 
            this.Remove.AutoSize = true;
            this.Remove.Location = new System.Drawing.Point(12, 70);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(167, 21);
            this.Remove.TabIndex = 6;
            this.Remove.TabStop = true;
            this.Remove.Text = "Remove Existing User";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.CheckedChanged += new System.EventHandler(this.Remove_CheckedChanged);
            // 
            // Continue
            // 
            this.Continue.Enabled = false;
            this.Continue.Location = new System.Drawing.Point(565, 268);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(86, 47);
            this.Continue.TabIndex = 7;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // AdminProgress
            // 
            this.AdminProgress.BackColor = System.Drawing.Color.Lime;
            this.AdminProgress.ForeColor = System.Drawing.Color.Lime;
            this.AdminProgress.Location = new System.Drawing.Point(12, 268);
            this.AdminProgress.Name = "AdminProgress";
            this.AdminProgress.Size = new System.Drawing.Size(540, 47);
            this.AdminProgress.TabIndex = 8;
            this.AdminProgress.Click += new System.EventHandler(this.AdminProgress_Click);
            // 
            // None
            // 
            this.None.AutoSize = true;
            this.None.Location = new System.Drawing.Point(12, 97);
            this.None.Name = "None";
            this.None.Size = new System.Drawing.Size(63, 21);
            this.None.TabIndex = 9;
            this.None.TabStop = true;
            this.None.Text = "None";
            this.None.UseVisualStyleBackColor = true;
            this.None.CheckedChanged += new System.EventHandler(this.None_CheckedChanged);
            // 
            // RemoveUser
            // 
            this.RemoveUser.Enabled = false;
            this.RemoveUser.Location = new System.Drawing.Point(12, 46);
            this.RemoveUser.Name = "RemoveUser";
            this.RemoveUser.Size = new System.Drawing.Size(118, 47);
            this.RemoveUser.TabIndex = 10;
            this.RemoveUser.Text = "Remove User";
            this.RemoveUser.UseVisualStyleBackColor = true;
            this.RemoveUser.Click += new System.EventHandler(this.RemoveUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "List of Existing Users";
            // 
            // ExistingUsers
            // 
            this.ExistingUsers.Enabled = false;
            this.ExistingUsers.FormattingEnabled = true;
            this.ExistingUsers.Items.AddRange(new object[] {
            "Dale",
            "Jeff",
            "Frank"});
            this.ExistingUsers.Location = new System.Drawing.Point(158, 22);
            this.ExistingUsers.Name = "ExistingUsers";
            this.ExistingUsers.Size = new System.Drawing.Size(121, 24);
            this.ExistingUsers.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Staff or Admin";
            // 
            // Staff
            // 
            this.Staff.AutoSize = true;
            this.Staff.Location = new System.Drawing.Point(175, 111);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(58, 21);
            this.Staff.TabIndex = 15;
            this.Staff.TabStop = true;
            this.Staff.Text = "Staff";
            this.Staff.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Location = new System.Drawing.Point(255, 113);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(68, 21);
            this.Admin.TabIndex = 16;
            this.Admin.TabStop = true;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Confirmation Phrase";
            // 
            // Confirmation
            // 
            this.Confirmation.Location = new System.Drawing.Point(151, 120);
            this.Confirmation.Name = "Confirmation";
            this.Confirmation.Size = new System.Drawing.Size(121, 22);
            this.Confirmation.TabIndex = 18;
            this.Confirmation.TextChanged += new System.EventHandler(this.Confirmation_TextChanged);
            // 
            // SubmitNewUser
            // 
            this.SubmitNewUser.Enabled = false;
            this.SubmitNewUser.Location = new System.Drawing.Point(28, 157);
            this.SubmitNewUser.Name = "SubmitNewUser";
            this.SubmitNewUser.Size = new System.Drawing.Size(295, 47);
            this.SubmitNewUser.TabIndex = 19;
            this.SubmitNewUser.Text = "Add New User";
            this.SubmitNewUser.UseVisualStyleBackColor = true;
            this.SubmitNewUser.Click += new System.EventHandler(this.SubmitNewUser_Click);
            // 
            // GroupBoxNewUser
            // 
            this.GroupBoxNewUser.Controls.Add(this.SubmitNewUser);
            this.GroupBoxNewUser.Controls.Add(this.label5);
            this.GroupBoxNewUser.Controls.Add(this.Staff);
            this.GroupBoxNewUser.Controls.Add(this.Admin);
            this.GroupBoxNewUser.Controls.Add(this.NewUserPassword);
            this.GroupBoxNewUser.Controls.Add(this.CreateNewUser);
            this.GroupBoxNewUser.Controls.Add(this.label2);
            this.GroupBoxNewUser.Controls.Add(this.label1);
            this.GroupBoxNewUser.Enabled = false;
            this.GroupBoxNewUser.Location = new System.Drawing.Point(319, 12);
            this.GroupBoxNewUser.Name = "GroupBoxNewUser";
            this.GroupBoxNewUser.Size = new System.Drawing.Size(332, 220);
            this.GroupBoxNewUser.TabIndex = 20;
            this.GroupBoxNewUser.TabStop = false;
            this.GroupBoxNewUser.Enter += new System.EventHandler(this.GroupBoxNewUser_Enter);
            // 
            // GroupBoxRemoveUser
            // 
            this.GroupBoxRemoveUser.Controls.Add(this.label4);
            this.GroupBoxRemoveUser.Controls.Add(this.ExistingUsers);
            this.GroupBoxRemoveUser.Controls.Add(this.RemoveUser);
            this.GroupBoxRemoveUser.Enabled = false;
            this.GroupBoxRemoveUser.Location = new System.Drawing.Point(15, 163);
            this.GroupBoxRemoveUser.Name = "GroupBoxRemoveUser";
            this.GroupBoxRemoveUser.Size = new System.Drawing.Size(298, 99);
            this.GroupBoxRemoveUser.TabIndex = 21;
            this.GroupBoxRemoveUser.TabStop = false;
            this.GroupBoxRemoveUser.Enter += new System.EventHandler(this.GroupBoxRemoveUser_Enter);
            // 
            // PhraseSubmit
            // 
            this.PhraseSubmit.Location = new System.Drawing.Point(15, 143);
            this.PhraseSubmit.Name = "PhraseSubmit";
            this.PhraseSubmit.Size = new System.Drawing.Size(124, 23);
            this.PhraseSubmit.TabIndex = 22;
            this.PhraseSubmit.Text = "Submit Phrase";
            this.PhraseSubmit.UseVisualStyleBackColor = true;
            this.PhraseSubmit.Click += new System.EventHandler(this.PhraseSubmit_Click);
            // 
            // AdminMenuTimer
            // 
            this.AdminMenuTimer.Interval = 40;
            this.AdminMenuTimer.Tick += new System.EventHandler(this.AdminMenuTimer_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 335);
            this.Controls.Add(this.PhraseSubmit);
            this.Controls.Add(this.GroupBoxRemoveUser);
            this.Controls.Add(this.Confirmation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GroupBoxNewUser);
            this.Controls.Add(this.None);
            this.Controls.Add(this.AdminProgress);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.NewUser);
            this.Controls.Add(this.label3);
            this.Name = "Form2";
            this.Text = "Admin menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.GroupBoxNewUser.ResumeLayout(false);
            this.GroupBoxNewUser.PerformLayout();
            this.GroupBoxRemoveUser.ResumeLayout(false);
            this.GroupBoxRemoveUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CreateNewUser;
        private System.Windows.Forms.TextBox NewUserPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton NewUser;
        private System.Windows.Forms.RadioButton Remove;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.ProgressBar AdminProgress;
        private System.Windows.Forms.RadioButton None;
        private System.Windows.Forms.Button RemoveUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ExistingUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Staff;
        private System.Windows.Forms.RadioButton Admin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Confirmation;
        private System.Windows.Forms.Button SubmitNewUser;
        private System.Windows.Forms.GroupBox GroupBoxNewUser;
        private System.Windows.Forms.GroupBox GroupBoxRemoveUser;
        private System.Windows.Forms.Button PhraseSubmit;
        private System.Windows.Forms.Timer AdminMenuTimer;
    }
}