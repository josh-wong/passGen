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
            this.generate_pw = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.generate_pw_s = new System.Windows.Forms.Button();
            this.copy_s = new System.Windows.Forms.Button();
            this.RandomNumber = new System.Windows.Forms.MaskedTextBox();
            this.RandomNumber_s = new System.Windows.Forms.MaskedTextBox();
            this.reset = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generate_pw
            // 
            this.generate_pw.BackColor = System.Drawing.SystemColors.HotTrack;
            this.generate_pw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generate_pw.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.generate_pw.FlatAppearance.BorderSize = 0;
            this.generate_pw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate_pw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.generate_pw.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.generate_pw.Location = new System.Drawing.Point(18, 22);
            this.generate_pw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generate_pw.Name = "generate_pw";
            this.generate_pw.Size = new System.Drawing.Size(116, 128);
            this.generate_pw.TabIndex = 0;
            this.generate_pw.Text = "Password without symbols";
            this.generate_pw.UseVisualStyleBackColor = false;
            this.generate_pw.Click += new System.EventHandler(this.generate_pw_Click);
            // 
            // copy
            // 
            this.copy.BackColor = System.Drawing.SystemColors.HotTrack;
            this.copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copy.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.copy.FlatAppearance.BorderSize = 0;
            this.copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.copy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.copy.Location = new System.Drawing.Point(354, 62);
            this.copy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(80, 39);
            this.copy.TabIndex = 5;
            this.copy.Text = "Copy";
            this.copy.UseVisualStyleBackColor = false;
            this.copy.Visible = false;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // generate_pw_s
            // 
            this.generate_pw_s.BackColor = System.Drawing.SystemColors.HotTrack;
            this.generate_pw_s.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generate_pw_s.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.generate_pw_s.FlatAppearance.BorderSize = 0;
            this.generate_pw_s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate_pw_s.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.generate_pw_s.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.generate_pw_s.Location = new System.Drawing.Point(18, 172);
            this.generate_pw_s.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generate_pw_s.Name = "generate_pw_s";
            this.generate_pw_s.Size = new System.Drawing.Size(116, 128);
            this.generate_pw_s.TabIndex = 6;
            this.generate_pw_s.Text = "Password with symbols";
            this.generate_pw_s.UseVisualStyleBackColor = false;
            this.generate_pw_s.Click += new System.EventHandler(this.generate_pw_s_Click);
            // 
            // copy_s
            // 
            this.copy_s.BackColor = System.Drawing.SystemColors.HotTrack;
            this.copy_s.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copy_s.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.copy_s.FlatAppearance.BorderSize = 0;
            this.copy_s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy_s.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.copy_s.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.copy_s.Location = new System.Drawing.Point(354, 212);
            this.copy_s.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.copy_s.Name = "copy_s";
            this.copy_s.Size = new System.Drawing.Size(80, 39);
            this.copy_s.TabIndex = 8;
            this.copy_s.Text = "Copy";
            this.copy_s.UseVisualStyleBackColor = false;
            this.copy_s.Visible = false;
            this.copy_s.Click += new System.EventHandler(this.copy_s_Click);
            // 
            // RandomNumber
            // 
            this.RandomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RandomNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RandomNumber.Location = new System.Drawing.Point(156, 62);
            this.RandomNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RandomNumber.Name = "RandomNumber";
            this.RandomNumber.PasswordChar = '*';
            this.RandomNumber.ReadOnly = true;
            this.RandomNumber.Size = new System.Drawing.Size(200, 39);
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
            this.RandomNumber_s.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RandomNumber_s.Location = new System.Drawing.Point(156, 212);
            this.RandomNumber_s.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RandomNumber_s.Name = "RandomNumber_s";
            this.RandomNumber_s.PasswordChar = '*';
            this.RandomNumber_s.ReadOnly = true;
            this.RandomNumber_s.Size = new System.Drawing.Size(200, 39);
            this.RandomNumber_s.TabIndex = 10;
            this.RandomNumber_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RandomNumber_s.Visible = false;
            this.RandomNumber_s.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RandomNumber_s_MouseDown);
            this.RandomNumber_s.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RandomNumber_s_MouseUp);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.HotTrack;
            this.reset.FlatAppearance.BorderSize = 0;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reset.Location = new System.Drawing.Point(18, 322);
            this.reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(116, 48);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(318, 322);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(116, 48);
            this.exit.TabIndex = 12;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(452, 394);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.copy_s);
            this.Controls.Add(this.generate_pw_s);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.generate_pw);
            this.Controls.Add(this.RandomNumber);
            this.Controls.Add(this.RandomNumber_s);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "passGen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate_pw;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button generate_pw_s;
        private System.Windows.Forms.Button copy_s;
        private System.Windows.Forms.MaskedTextBox RandomNumber;
        private System.Windows.Forms.MaskedTextBox RandomNumber_s;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button exit;
    }
}

