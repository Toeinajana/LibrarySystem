namespace AITLibrarY
{
    partial class TabReturn
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dateTimeReturnDate = new System.Windows.Forms.DateTimePicker();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.dataGridViewReturn = new System.Windows.Forms.DataGridView();
            this.textBID = new System.Windows.Forms.TextBox();
            this.textBorrowID = new System.Windows.Forms.Label();
            this.buttonBooks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefresh.Location = new System.Drawing.Point(457, 50);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(71, 38);
            this.buttonRefresh.TabIndex = 25;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // dateTimeReturnDate
            // 
            this.dateTimeReturnDate.Location = new System.Drawing.Point(226, 89);
            this.dateTimeReturnDate.Name = "dateTimeReturnDate";
            this.dateTimeReturnDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimeReturnDate.TabIndex = 24;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBack.Location = new System.Drawing.Point(29, 47);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(77, 39);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(127, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Return date :";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReturn.Location = new System.Drawing.Point(457, 94);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(71, 39);
            this.buttonReturn.TabIndex = 21;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // dataGridViewReturn
            // 
            this.dataGridViewReturn.BackgroundColor = System.Drawing.Color.DarkOrchid;
            this.dataGridViewReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturn.Location = new System.Drawing.Point(9, 137);
            this.dataGridViewReturn.Name = "dataGridViewReturn";
            this.dataGridViewReturn.Size = new System.Drawing.Size(541, 299);
            this.dataGridViewReturn.TabIndex = 26;
            this.dataGridViewReturn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReturn_CellContentClick);
            // 
            // textBID
            // 
            this.textBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBID.Location = new System.Drawing.Point(226, 41);
            this.textBID.Name = "textBID";
            this.textBID.Size = new System.Drawing.Size(141, 23);
            this.textBID.TabIndex = 28;
            // 
            // textBorrowID
            // 
            this.textBorrowID.AutoSize = true;
            this.textBorrowID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBorrowID.Location = new System.Drawing.Point(136, 47);
            this.textBorrowID.Name = "textBorrowID";
            this.textBorrowID.Size = new System.Drawing.Size(77, 17);
            this.textBorrowID.TabIndex = 27;
            this.textBorrowID.Text = "Borrow ID :";
            // 
            // buttonBooks
            // 
            this.buttonBooks.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBooks.Location = new System.Drawing.Point(457, 6);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(71, 38);
            this.buttonBooks.TabIndex = 29;
            this.buttonBooks.Text = "Books";
            this.buttonBooks.UseVisualStyleBackColor = false;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // TabReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(559, 444);
            this.ControlBox = false;
            this.Controls.Add(this.buttonBooks);
            this.Controls.Add(this.textBID);
            this.Controls.Add(this.textBorrowID);
            this.Controls.Add(this.dataGridViewReturn);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dateTimeReturnDate);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonReturn);
            this.Name = "TabReturn";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.TabReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DateTimePicker dateTimeReturnDate;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.DataGridView dataGridViewReturn;
        private System.Windows.Forms.TextBox textBID;
        private System.Windows.Forms.Label textBorrowID;
        private System.Windows.Forms.Button buttonBooks;
    }
}