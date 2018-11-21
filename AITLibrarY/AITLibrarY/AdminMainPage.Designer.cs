namespace AITLibrarY
{
    partial class AdminMainPage
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
            this.buttonGenre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonLanguage = new System.Windows.Forms.Button();
            this.buttonDirector = new System.Windows.Forms.Button();
            this.buttonMedia = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGenre
            // 
            this.buttonGenre.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonGenre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGenre.Location = new System.Drawing.Point(63, 111);
            this.buttonGenre.Name = "buttonGenre";
            this.buttonGenre.Size = new System.Drawing.Size(131, 57);
            this.buttonGenre.TabIndex = 2;
            this.buttonGenre.Text = "Genre";
            this.buttonGenre.UseVisualStyleBackColor = false;
            this.buttonGenre.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(215, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin";
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUser.Location = new System.Drawing.Point(336, 205);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(131, 57);
            this.buttonUser.TabIndex = 4;
            this.buttonUser.Text = "User";
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonLanguage
            // 
            this.buttonLanguage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonLanguage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLanguage.Location = new System.Drawing.Point(63, 205);
            this.buttonLanguage.Name = "buttonLanguage";
            this.buttonLanguage.Size = new System.Drawing.Size(131, 57);
            this.buttonLanguage.TabIndex = 5;
            this.buttonLanguage.Text = "Language";
            this.buttonLanguage.UseVisualStyleBackColor = false;
            this.buttonLanguage.Click += new System.EventHandler(this.buttonLanguage_Click);
            // 
            // buttonDirector
            // 
            this.buttonDirector.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonDirector.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDirector.Location = new System.Drawing.Point(336, 111);
            this.buttonDirector.Name = "buttonDirector";
            this.buttonDirector.Size = new System.Drawing.Size(131, 57);
            this.buttonDirector.TabIndex = 6;
            this.buttonDirector.Text = "Director";
            this.buttonDirector.UseVisualStyleBackColor = false;
            this.buttonDirector.Click += new System.EventHandler(this.buttonDirector_Click);
            // 
            // buttonMedia
            // 
            this.buttonMedia.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonMedia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMedia.Location = new System.Drawing.Point(63, 303);
            this.buttonMedia.Name = "buttonMedia";
            this.buttonMedia.Size = new System.Drawing.Size(131, 57);
            this.buttonMedia.TabIndex = 8;
            this.buttonMedia.Text = "Media";
            this.buttonMedia.UseVisualStyleBackColor = false;
            this.buttonMedia.Click += new System.EventHandler(this.buttonMedia_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogout.Location = new System.Drawing.Point(336, 303);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(131, 57);
            this.buttonLogout.TabIndex = 9;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // AdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(558, 445);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonMedia);
            this.Controls.Add(this.buttonDirector);
            this.Controls.Add(this.buttonLanguage);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGenre);
            this.Name = "AdminMainPage";
            this.Text = "Admin Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonLanguage;
        private System.Windows.Forms.Button buttonDirector;
        private System.Windows.Forms.Button buttonMedia;
        private System.Windows.Forms.Button buttonLogout;
    }
}