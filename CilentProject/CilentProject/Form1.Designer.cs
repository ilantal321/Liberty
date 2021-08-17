namespace CilentProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TBSIP = new System.Windows.Forms.TextBox();
            this.TBSPORT = new System.Windows.Forms.TextBox();
            this.LBServerData = new System.Windows.Forms.ListBox();
            this.LSIP = new System.Windows.Forms.Label();
            this.LSPort = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LAddBookQuantity = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LAddBookName = new System.Windows.Forms.Label();
            this.LAddBookAuthor = new System.Windows.Forms.Label();
            this.TBAddBookQuantity = new System.Windows.Forms.TextBox();
            this.TBAddBookAuthor = new System.Windows.Forms.TextBox();
            this.TBAddBookName = new System.Windows.Forms.TextBox();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.BtnDeleteBook = new System.Windows.Forms.Button();
            this.BtnUpdateBook = new System.Windows.Forms.Button();
            this.BtnShowBooks = new System.Windows.Forms.Button();
            this.LData = new System.Windows.Forms.Label();
            this.BtnFindBookNameBook = new System.Windows.Forms.Button();
            this.BtnFindBookAuthor = new System.Windows.Forms.Button();
            this.RtnRefrash = new System.Windows.Forms.Button();
            this.CBBookName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TBSIP
            // 
            this.TBSIP.Location = new System.Drawing.Point(184, 42);
            this.TBSIP.Margin = new System.Windows.Forms.Padding(4);
            this.TBSIP.Name = "TBSIP";
            this.TBSIP.Size = new System.Drawing.Size(132, 22);
            this.TBSIP.TabIndex = 0;
            // 
            // TBSPORT
            // 
            this.TBSPORT.Location = new System.Drawing.Point(184, 87);
            this.TBSPORT.Margin = new System.Windows.Forms.Padding(4);
            this.TBSPORT.Name = "TBSPORT";
            this.TBSPORT.Size = new System.Drawing.Size(132, 22);
            this.TBSPORT.TabIndex = 1;
            // 
            // LBServerData
            // 
            this.LBServerData.FormattingEnabled = true;
            this.LBServerData.ItemHeight = 16;
            this.LBServerData.Location = new System.Drawing.Point(407, 42);
            this.LBServerData.Margin = new System.Windows.Forms.Padding(4);
            this.LBServerData.Name = "LBServerData";
            this.LBServerData.Size = new System.Drawing.Size(705, 164);
            this.LBServerData.TabIndex = 2;
            // 
            // LSIP
            // 
            this.LSIP.AutoSize = true;
            this.LSIP.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LSIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LSIP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LSIP.Location = new System.Drawing.Point(147, 44);
            this.LSIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LSIP.Name = "LSIP";
            this.LSIP.Size = new System.Drawing.Size(32, 20);
            this.LSIP.TabIndex = 3;
            this.LSIP.Text = "IP:";
            // 
            // LSPort
            // 
            this.LSPort.AutoSize = true;
            this.LSPort.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LSPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LSPort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LSPort.Location = new System.Drawing.Point(129, 87);
            this.LSPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LSPort.Name = "LSPort";
            this.LSPort.Size = new System.Drawing.Size(50, 20);
            this.LSPort.TabIndex = 4;
            this.LSPort.Text = "Port:";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(1009, 550);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(1);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(103, 59);
            this.BtnExit.TabIndex = 106;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(512, 166);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 17);
            this.label16.TabIndex = 104;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(965, 651);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 19);
            this.label11.TabIndex = 98;
            // 
            // LAddBookQuantity
            // 
            this.LAddBookQuantity.AutoSize = true;
            this.LAddBookQuantity.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LAddBookQuantity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LAddBookQuantity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LAddBookQuantity.Location = new System.Drawing.Point(51, 332);
            this.LAddBookQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAddBookQuantity.Name = "LAddBookQuantity";
            this.LAddBookQuantity.Size = new System.Drawing.Size(128, 19);
            this.LAddBookQuantity.TabIndex = 85;
            this.LAddBookQuantity.Text = "Book Quantity:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LAddBookName
            // 
            this.LAddBookName.AutoSize = true;
            this.LAddBookName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LAddBookName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LAddBookName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LAddBookName.Location = new System.Drawing.Point(74, 228);
            this.LAddBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAddBookName.Name = "LAddBookName";
            this.LAddBookName.Size = new System.Drawing.Size(105, 19);
            this.LAddBookName.TabIndex = 84;
            this.LAddBookName.Text = "Book Name:";
            // 
            // LAddBookAuthor
            // 
            this.LAddBookAuthor.AutoSize = true;
            this.LAddBookAuthor.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LAddBookAuthor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LAddBookAuthor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LAddBookAuthor.Location = new System.Drawing.Point(65, 275);
            this.LAddBookAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAddBookAuthor.Name = "LAddBookAuthor";
            this.LAddBookAuthor.Size = new System.Drawing.Size(114, 19);
            this.LAddBookAuthor.TabIndex = 83;
            this.LAddBookAuthor.Text = "Book Author:";
            // 
            // TBAddBookQuantity
            // 
            this.TBAddBookQuantity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TBAddBookQuantity.Location = new System.Drawing.Point(184, 330);
            this.TBAddBookQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.TBAddBookQuantity.Name = "TBAddBookQuantity";
            this.TBAddBookQuantity.Size = new System.Drawing.Size(160, 25);
            this.TBAddBookQuantity.TabIndex = 81;
            // 
            // TBAddBookAuthor
            // 
            this.TBAddBookAuthor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TBAddBookAuthor.Location = new System.Drawing.Point(184, 273);
            this.TBAddBookAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.TBAddBookAuthor.Name = "TBAddBookAuthor";
            this.TBAddBookAuthor.Size = new System.Drawing.Size(304, 25);
            this.TBAddBookAuthor.TabIndex = 80;
            // 
            // TBAddBookName
            // 
            this.TBAddBookName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TBAddBookName.Location = new System.Drawing.Point(184, 226);
            this.TBAddBookName.Margin = new System.Windows.Forms.Padding(4);
            this.TBAddBookName.Name = "TBAddBookName";
            this.TBAddBookName.Size = new System.Drawing.Size(301, 25);
            this.TBAddBookName.TabIndex = 79;
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnAddBook.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BtnAddBook.Location = new System.Drawing.Point(184, 473);
            this.BtnAddBook.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(148, 56);
            this.BtnAddBook.TabIndex = 107;
            this.BtnAddBook.Text = "Add Book";
            this.BtnAddBook.UseVisualStyleBackColor = false;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // BtnDeleteBook
            // 
            this.BtnDeleteBook.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnDeleteBook.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BtnDeleteBook.Location = new System.Drawing.Point(184, 400);
            this.BtnDeleteBook.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDeleteBook.Name = "BtnDeleteBook";
            this.BtnDeleteBook.Size = new System.Drawing.Size(148, 56);
            this.BtnDeleteBook.TabIndex = 108;
            this.BtnDeleteBook.Text = "Delete Book";
            this.BtnDeleteBook.UseVisualStyleBackColor = false;
            this.BtnDeleteBook.Click += new System.EventHandler(this.BtnDeleteBook_Click);
            // 
            // BtnUpdateBook
            // 
            this.BtnUpdateBook.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnUpdateBook.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BtnUpdateBook.Location = new System.Drawing.Point(364, 400);
            this.BtnUpdateBook.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUpdateBook.Name = "BtnUpdateBook";
            this.BtnUpdateBook.Size = new System.Drawing.Size(148, 56);
            this.BtnUpdateBook.TabIndex = 109;
            this.BtnUpdateBook.Text = "Update Quantity";
            this.BtnUpdateBook.UseVisualStyleBackColor = false;
            this.BtnUpdateBook.Click += new System.EventHandler(this.BtnUpdateBook_Click);
            // 
            // BtnShowBooks
            // 
            this.BtnShowBooks.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnShowBooks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BtnShowBooks.Location = new System.Drawing.Point(364, 550);
            this.BtnShowBooks.Margin = new System.Windows.Forms.Padding(4);
            this.BtnShowBooks.Name = "BtnShowBooks";
            this.BtnShowBooks.Size = new System.Drawing.Size(148, 56);
            this.BtnShowBooks.TabIndex = 110;
            this.BtnShowBooks.Text = "Show Books";
            this.BtnShowBooks.UseVisualStyleBackColor = false;
            this.BtnShowBooks.Click += new System.EventHandler(this.BtnShowBooks_Click);
            // 
            // LData
            // 
            this.LData.AutoSize = true;
            this.LData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LData.Location = new System.Drawing.Point(553, 229);
            this.LData.Name = "LData";
            this.LData.Size = new System.Drawing.Size(0, 32);
            this.LData.TabIndex = 111;
            // 
            // BtnFindBookNameBook
            // 
            this.BtnFindBookNameBook.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnFindBookNameBook.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BtnFindBookNameBook.Location = new System.Drawing.Point(184, 550);
            this.BtnFindBookNameBook.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFindBookNameBook.Name = "BtnFindBookNameBook";
            this.BtnFindBookNameBook.Size = new System.Drawing.Size(148, 56);
            this.BtnFindBookNameBook.TabIndex = 112;
            this.BtnFindBookNameBook.Text = "Find Book By Name";
            this.BtnFindBookNameBook.UseVisualStyleBackColor = false;
            this.BtnFindBookNameBook.Click += new System.EventHandler(this.BtnFindBookNameBook_Click);
            // 
            // BtnFindBookAuthor
            // 
            this.BtnFindBookAuthor.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnFindBookAuthor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BtnFindBookAuthor.Location = new System.Drawing.Point(364, 473);
            this.BtnFindBookAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFindBookAuthor.Name = "BtnFindBookAuthor";
            this.BtnFindBookAuthor.Size = new System.Drawing.Size(148, 56);
            this.BtnFindBookAuthor.TabIndex = 113;
            this.BtnFindBookAuthor.Text = "Find Book By Author";
            this.BtnFindBookAuthor.UseVisualStyleBackColor = false;
            this.BtnFindBookAuthor.Click += new System.EventHandler(this.BtnFindBookAuthor_Click);
            // 
            // RtnRefrash
            // 
            this.RtnRefrash.BackColor = System.Drawing.Color.DarkBlue;
            this.RtnRefrash.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RtnRefrash.Location = new System.Drawing.Point(683, 553);
            this.RtnRefrash.Margin = new System.Windows.Forms.Padding(4);
            this.RtnRefrash.Name = "RtnRefrash";
            this.RtnRefrash.Size = new System.Drawing.Size(148, 56);
            this.RtnRefrash.TabIndex = 114;
            this.RtnRefrash.Text = "Refresh";
            this.RtnRefrash.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RtnRefrash.UseVisualStyleBackColor = false;
            this.RtnRefrash.Click += new System.EventHandler(this.RtnRefrash_Click);
            // 
            // CBBookName
            // 
            this.CBBookName.FormattingEnabled = true;
            this.CBBookName.Location = new System.Drawing.Point(579, 492);
            this.CBBookName.Name = "CBBookName";
            this.CBBookName.Size = new System.Drawing.Size(422, 24);
            this.CBBookName.TabIndex = 115;
            this.CBBookName.SelectedIndexChanged += new System.EventHandler(this.CBBookName_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1231, 729);
            this.Controls.Add(this.CBBookName);
            this.Controls.Add(this.RtnRefrash);
            this.Controls.Add(this.BtnFindBookAuthor);
            this.Controls.Add(this.BtnFindBookNameBook);
            this.Controls.Add(this.LData);
            this.Controls.Add(this.BtnShowBooks);
            this.Controls.Add(this.BtnUpdateBook);
            this.Controls.Add(this.BtnDeleteBook);
            this.Controls.Add(this.BtnAddBook);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LAddBookQuantity);
            this.Controls.Add(this.LAddBookName);
            this.Controls.Add(this.LAddBookAuthor);
            this.Controls.Add(this.TBAddBookQuantity);
            this.Controls.Add(this.TBAddBookAuthor);
            this.Controls.Add(this.TBAddBookName);
            this.Controls.Add(this.LSPort);
            this.Controls.Add(this.LSIP);
            this.Controls.Add(this.LBServerData);
            this.Controls.Add(this.TBSPORT);
            this.Controls.Add(this.TBSIP);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBSIP;
        private System.Windows.Forms.TextBox TBSPORT;
        private System.Windows.Forms.ListBox LBServerData;
        private System.Windows.Forms.Label LSIP;
        private System.Windows.Forms.Label LSPort;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LAddBookQuantity;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label LAddBookName;
        private System.Windows.Forms.Label LAddBookAuthor;
        private System.Windows.Forms.TextBox TBAddBookQuantity;
        private System.Windows.Forms.TextBox TBAddBookAuthor;
        private System.Windows.Forms.TextBox TBAddBookName;
        private System.Windows.Forms.Button BtnAddBook;
        private System.Windows.Forms.Button BtnDeleteBook;
        private System.Windows.Forms.Button BtnUpdateBook;
        private System.Windows.Forms.Button BtnShowBooks;
        private System.Windows.Forms.Label LData;
        private System.Windows.Forms.Button BtnFindBookNameBook;
        private System.Windows.Forms.Button BtnFindBookAuthor;
        private System.Windows.Forms.Button RtnRefrash;
        private System.Windows.Forms.ComboBox CBBookName;
    }
}

