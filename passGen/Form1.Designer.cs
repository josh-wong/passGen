namespace passGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Generate_pw = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Generate_pw_s = new System.Windows.Forms.Button();
            this.Copy_s = new System.Windows.Forms.Button();
            this.RandomNumber = new System.Windows.Forms.MaskedTextBox();
            this.RandomNumber_s = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenNewWindow_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Documentation_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReleaseNotes_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportIssue_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Generate_pw
            // 
            this.Generate_pw.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Generate_pw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Generate_pw.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.Generate_pw.FlatAppearance.BorderSize = 0;
            this.Generate_pw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generate_pw.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_pw.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Generate_pw.Location = new System.Drawing.Point(337, 123);
            this.Generate_pw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Generate_pw.Name = "Generate_pw";
            this.Generate_pw.Size = new System.Drawing.Size(252, 84);
            this.Generate_pw.TabIndex = 0;
            this.Generate_pw.Text = "Create a password without symbols";
            this.Generate_pw.UseVisualStyleBackColor = false;
            this.Generate_pw.Click += new System.EventHandler(this.Generate_pw_Click);
            // 
            // Copy
            // 
            this.Copy.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Copy.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.Copy.FlatAppearance.BorderSize = 0;
            this.Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Copy.Location = new System.Drawing.Point(337, 298);
            this.Copy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(252, 45);
            this.Copy.TabIndex = 5;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = false;
            this.Copy.Visible = false;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Generate_pw_s
            // 
            this.Generate_pw_s.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Generate_pw_s.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Generate_pw_s.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.Generate_pw_s.FlatAppearance.BorderSize = 0;
            this.Generate_pw_s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generate_pw_s.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_pw_s.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Generate_pw_s.Location = new System.Drawing.Point(40, 123);
            this.Generate_pw_s.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Generate_pw_s.Name = "Generate_pw_s";
            this.Generate_pw_s.Size = new System.Drawing.Size(252, 84);
            this.Generate_pw_s.TabIndex = 6;
            this.Generate_pw_s.Text = "Create a password \r\nwith symbols";
            this.Generate_pw_s.UseVisualStyleBackColor = false;
            this.Generate_pw_s.Click += new System.EventHandler(this.Generate_pw_s_Click);
            // 
            // Copy_s
            // 
            this.Copy_s.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Copy_s.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Copy_s.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.Copy_s.FlatAppearance.BorderSize = 0;
            this.Copy_s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy_s.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy_s.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Copy_s.Location = new System.Drawing.Point(40, 298);
            this.Copy_s.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Copy_s.Name = "Copy_s";
            this.Copy_s.Size = new System.Drawing.Size(252, 45);
            this.Copy_s.TabIndex = 8;
            this.Copy_s.Text = "Copy";
            this.Copy_s.UseVisualStyleBackColor = false;
            this.Copy_s.Visible = false;
            this.Copy_s.Click += new System.EventHandler(this.Copy_s_Click);
            // 
            // RandomNumber
            // 
            this.RandomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RandomNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomNumber.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomNumber.Location = new System.Drawing.Point(337, 234);
            this.RandomNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RandomNumber.Name = "RandomNumber";
            this.RandomNumber.PasswordChar = '*';
            this.RandomNumber.ReadOnly = true;
            this.RandomNumber.Size = new System.Drawing.Size(252, 45);
            this.RandomNumber.TabIndex = 9;
            this.RandomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RandomNumber.Visible = false;
            this.RandomNumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RandomNumber_MouseDown);
            this.RandomNumber.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RandomNumber_MouseUp);
            // 
            // RandomNumber_s
            // 
            this.RandomNumber_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RandomNumber_s.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomNumber_s.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomNumber_s.Location = new System.Drawing.Point(40, 234);
            this.RandomNumber_s.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RandomNumber_s.Name = "RandomNumber_s";
            this.RandomNumber_s.PasswordChar = '*';
            this.RandomNumber_s.ReadOnly = true;
            this.RandomNumber_s.Size = new System.Drawing.Size(252, 45);
            this.RandomNumber_s.TabIndex = 10;
            this.RandomNumber_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RandomNumber_s.Visible = false;
            this.RandomNumber_s.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RandomNumber_s_MouseDown);
            this.RandomNumber_s.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RandomNumber_s_MouseUp);
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem,
            this.Help_ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(737, 51);
            this.menuStrip.TabIndex = 12;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_ItemClicked);
            // 
            // File_ToolStripMenuItem
            // 
            this.File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenNewWindow_ToolStripMenuItem,
            this.Clear_ToolStripMenuItem,
            this.Exit_ToolStripMenuItem});
            this.File_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
            this.File_ToolStripMenuItem.Size = new System.Drawing.Size(68, 47);
            this.File_ToolStripMenuItem.Text = "File";
            // 
            // OpenNewWindow_ToolStripMenuItem
            // 
            this.OpenNewWindow_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenNewWindow_ToolStripMenuItem.Image = global::passGen.Properties.Resources.app_window_add;
            this.OpenNewWindow_ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.OpenNewWindow_ToolStripMenuItem.Name = "OpenNewWindow_ToolStripMenuItem";
            this.OpenNewWindow_ToolStripMenuItem.Size = new System.Drawing.Size(327, 40);
            this.OpenNewWindow_ToolStripMenuItem.Text = "Open new window";
            this.OpenNewWindow_ToolStripMenuItem.Click += new System.EventHandler(this.OpenNewWindow_ToolStripMenuItem_Click);
            // 
            // Clear_ToolStripMenuItem
            // 
            this.Clear_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_ToolStripMenuItem.Image = global::passGen.Properties.Resources.bin_1;
            this.Clear_ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.Clear_ToolStripMenuItem.Name = "Clear_ToolStripMenuItem";
            this.Clear_ToolStripMenuItem.Size = new System.Drawing.Size(327, 40);
            this.Clear_ToolStripMenuItem.Text = "Clear";
            this.Clear_ToolStripMenuItem.Click += new System.EventHandler(this.Clear_ToolStripMenuItem_Click);
            // 
            // Exit_ToolStripMenuItem
            // 
            this.Exit_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_ToolStripMenuItem.Image = global::passGen.Properties.Resources.close;
            this.Exit_ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem";
            this.Exit_ToolStripMenuItem.Size = new System.Drawing.Size(327, 40);
            this.Exit_ToolStripMenuItem.Text = "Exit";
            this.Exit_ToolStripMenuItem.Click += new System.EventHandler(this.Exit_ToolStripMenuItem_Click);
            // 
            // Help_ToolStripMenuItem
            // 
            this.Help_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Documentation_ToolStripMenuItem,
            this.ReleaseNotes_ToolStripMenuItem,
            this.ReportIssue_ToolStripMenuItem,
            this.About_ToolStripMenuItem});
            this.Help_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help_ToolStripMenuItem.Name = "Help_ToolStripMenuItem";
            this.Help_ToolStripMenuItem.Size = new System.Drawing.Size(82, 47);
            this.Help_ToolStripMenuItem.Text = "Help";
            // 
            // Documentation_ToolStripMenuItem
            // 
            this.Documentation_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Documentation_ToolStripMenuItem.Image = global::passGen.Properties.Resources.notes_diary;
            this.Documentation_ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.Documentation_ToolStripMenuItem.Name = "Documentation_ToolStripMenuItem";
            this.Documentation_ToolStripMenuItem.Size = new System.Drawing.Size(298, 40);
            this.Documentation_ToolStripMenuItem.Text = "Documentation";
            this.Documentation_ToolStripMenuItem.Click += new System.EventHandler(this.Documentation_ToolStripMenuItem_Click);
            // 
            // ReleaseNotes_ToolStripMenuItem
            // 
            this.ReleaseNotes_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseNotes_ToolStripMenuItem.Image = global::passGen.Properties.Resources.notes_checklist_flip;
            this.ReleaseNotes_ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.ReleaseNotes_ToolStripMenuItem.Name = "ReleaseNotes_ToolStripMenuItem";
            this.ReleaseNotes_ToolStripMenuItem.Size = new System.Drawing.Size(298, 40);
            this.ReleaseNotes_ToolStripMenuItem.Text = "Release notes";
            this.ReleaseNotes_ToolStripMenuItem.Click += new System.EventHandler(this.ReleaseNotes_ToolStripMenuItem_Click);
            // 
            // ReportIssue_ToolStripMenuItem
            // 
            this.ReportIssue_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportIssue_ToolStripMenuItem.Image = global::passGen.Properties.Resources.conversation_question_warning;
            this.ReportIssue_ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.ReportIssue_ToolStripMenuItem.Name = "ReportIssue_ToolStripMenuItem";
            this.ReportIssue_ToolStripMenuItem.Size = new System.Drawing.Size(298, 40);
            this.ReportIssue_ToolStripMenuItem.Text = "Report issue";
            this.ReportIssue_ToolStripMenuItem.Click += new System.EventHandler(this.ReportIssue_ToolStripMenuItem_Click);
            // 
            // About_ToolStripMenuItem
            // 
            this.About_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_ToolStripMenuItem.Image = global::passGen.Properties.Resources.information_circle;
            this.About_ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.About_ToolStripMenuItem.Name = "About_ToolStripMenuItem";
            this.About_ToolStripMenuItem.Size = new System.Drawing.Size(298, 40);
            this.About_ToolStripMenuItem.Text = "About passGen";
            this.About_ToolStripMenuItem.Click += new System.EventHandler(this.About_ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.label1.Location = new System.Drawing.Point(34, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Create a 16-character password.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(632, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Copy_s);
            this.Controls.Add(this.Generate_pw_s);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Generate_pw);
            this.Controls.Add(this.RandomNumber);
            this.Controls.Add(this.RandomNumber_s);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "passGen";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate_pw;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Generate_pw_s;
        private System.Windows.Forms.Button Copy_s;
        private System.Windows.Forms.MaskedTextBox RandomNumber;
        private System.Windows.Forms.MaskedTextBox RandomNumber_s;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Clear_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Help_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenNewWindow_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Documentation_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReleaseNotes_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportIssue_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About_ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

