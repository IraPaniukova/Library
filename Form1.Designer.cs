namespace Library
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
            this.bookDscrptnGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.authorsLabel = new System.Windows.Forms.Label();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.addAuthorButtton = new System.Windows.Forms.Button();
            this.authorsListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.saveBookButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.alertTextBox = new System.Windows.Forms.TextBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.bookDscrptnGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookDscrptnGroupBox
            // 
            this.bookDscrptnGroupBox.Controls.Add(this.deleteButton);
            this.bookDscrptnGroupBox.Controls.Add(this.label1);
            this.bookDscrptnGroupBox.Controls.Add(this.authorsLabel);
            this.bookDscrptnGroupBox.Controls.Add(this.publisherTextBox);
            this.bookDscrptnGroupBox.Controls.Add(this.publisherLabel);
            this.bookDscrptnGroupBox.Controls.Add(this.addAuthorButtton);
            this.bookDscrptnGroupBox.Controls.Add(this.authorsListBox);
            this.bookDscrptnGroupBox.Controls.Add(this.pictureBox1);
            this.bookDscrptnGroupBox.Controls.Add(this.categoryTextBox);
            this.bookDscrptnGroupBox.Controls.Add(this.categoryLabel);
            this.bookDscrptnGroupBox.Controls.Add(this.yearTextBox);
            this.bookDscrptnGroupBox.Controls.Add(this.yearLabel);
            this.bookDscrptnGroupBox.Controls.Add(this.authorTextBox);
            this.bookDscrptnGroupBox.Controls.Add(this.authorLabel);
            this.bookDscrptnGroupBox.Controls.Add(this.bookNameTextBox);
            this.bookDscrptnGroupBox.Controls.Add(this.bookNameLabel);
            this.bookDscrptnGroupBox.Controls.Add(this.isbnTextBox);
            this.bookDscrptnGroupBox.Controls.Add(this.isbnLabel);
            this.bookDscrptnGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bookDscrptnGroupBox.Location = new System.Drawing.Point(50, 33);
            this.bookDscrptnGroupBox.Name = "bookDscrptnGroupBox";
            this.bookDscrptnGroupBox.Size = new System.Drawing.Size(567, 380);
            this.bookDscrptnGroupBox.TabIndex = 0;
            this.bookDscrptnGroupBox.TabStop = false;
            this.bookDscrptnGroupBox.Text = "Book description";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.SteelBlue;
            this.deleteButton.Location = new System.Drawing.Point(7, 137);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Delete them";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(113, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "(add one at a time)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // authorsLabel
            // 
            this.authorsLabel.AutoSize = true;
            this.authorsLabel.Location = new System.Drawing.Point(6, 121);
            this.authorsLabel.Name = "authorsLabel";
            this.authorsLabel.Size = new System.Drawing.Size(76, 13);
            this.authorsLabel.TabIndex = 18;
            this.authorsLabel.Text = "Added authors";
            this.authorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(398, 30);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(152, 20);
            this.publisherTextBox.TabIndex = 17;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(342, 33);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(50, 13);
            this.publisherLabel.TabIndex = 16;
            this.publisherLabel.Text = "Publisher";
            this.publisherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addAuthorButtton
            // 
            this.addAuthorButtton.BackColor = System.Drawing.Color.SteelBlue;
            this.addAuthorButtton.Location = new System.Drawing.Point(147, 309);
            this.addAuthorButtton.Name = "addAuthorButtton";
            this.addAuthorButtton.Size = new System.Drawing.Size(91, 33);
            this.addAuthorButtton.TabIndex = 15;
            this.addAuthorButtton.Text = "ADD AUTHOR";
            this.addAuthorButtton.UseVisualStyleBackColor = false;
            this.addAuthorButtton.Click += new System.EventHandler(this.addAuthorButtton_Click);
            // 
            // authorsListBox
            // 
            this.authorsListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.authorsListBox.FormattingEnabled = true;
            this.authorsListBox.Location = new System.Drawing.Point(86, 117);
            this.authorsListBox.Name = "authorsListBox";
            this.authorsListBox.Size = new System.Drawing.Size(152, 134);
            this.authorsListBox.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 180);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(398, 114);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(152, 20);
            this.categoryTextBox.TabIndex = 11;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(343, 117);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 10;
            this.categoryLabel.Text = "Category";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(398, 71);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(152, 20);
            this.yearTextBox.TabIndex = 9;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(322, 74);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(72, 13);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.Text = "Year released";
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(86, 264);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(152, 20);
            this.authorTextBox.TabIndex = 5;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(42, 267);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 4;
            this.authorLabel.Text = "Author";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(86, 71);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(152, 20);
            this.bookNameTextBox.TabIndex = 3;
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Location = new System.Drawing.Point(16, 74);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(63, 13);
            this.bookNameLabel.TabIndex = 2;
            this.bookNameLabel.Text = "Book Name";
            this.bookNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(86, 30);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(152, 20);
            this.isbnTextBox.TabIndex = 1;
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(48, 33);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(32, 13);
            this.isbnLabel.TabIndex = 0;
            this.isbnLabel.Text = "ISBN";
            this.isbnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // saveBookButton
            // 
            this.saveBookButton.BackColor = System.Drawing.Color.SteelBlue;
            this.saveBookButton.Location = new System.Drawing.Point(671, 206);
            this.saveBookButton.Name = "saveBookButton";
            this.saveBookButton.Size = new System.Drawing.Size(75, 33);
            this.saveBookButton.TabIndex = 1;
            this.saveBookButton.Text = "ADD BOOK";
            this.saveBookButton.UseVisualStyleBackColor = false;
            this.saveBookButton.Click += new System.EventHandler(this.saveBookButton_Click);
            // 
            // alertTextBox
            // 
            this.alertTextBox.BackColor = System.Drawing.Color.SteelBlue;
            this.alertTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alertTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertTextBox.ForeColor = System.Drawing.Color.Pink;
            this.alertTextBox.Location = new System.Drawing.Point(671, 245);
            this.alertTextBox.Multiline = true;
            this.alertTextBox.Name = "alertTextBox";
            this.alertTextBox.Size = new System.Drawing.Size(75, 99);
            this.alertTextBox.TabIndex = 3;
            this.alertTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.SteelBlue;
            this.viewButton.Location = new System.Drawing.Point(661, 380);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(103, 33);
            this.viewButton.TabIndex = 4;
            this.viewButton.Text = "VIEW STORAGE";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.alertTextBox);
            this.Controls.Add(this.saveBookButton);
            this.Controls.Add(this.bookDscrptnGroupBox);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.bookDscrptnGroupBox.ResumeLayout(false);
            this.bookDscrptnGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox bookDscrptnGroupBox;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox authorsListBox;
        private System.Windows.Forms.Button addAuthorButtton;
        private System.Windows.Forms.Button saveBookButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.TextBox alertTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label authorsLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button viewButton;
    }
}

