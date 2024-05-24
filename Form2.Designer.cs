namespace Library
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
            this.allBooksListBox = new System.Windows.Forms.ListBox();
            this.viewAllButton = new System.Windows.Forms.Button();
            this.allBooksLabel = new System.Windows.Forms.Label();
            this.addNewBookButton = new System.Windows.Forms.Button();
            this.showInPilesButton = new System.Windows.Forms.Button();
            this.booksToStoreLabel = new System.Windows.Forms.Label();
            this.filteredListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // allBooksListBox
            // 
            this.allBooksListBox.FormattingEnabled = true;
            this.allBooksListBox.HorizontalScrollbar = true;
            this.allBooksListBox.Location = new System.Drawing.Point(38, 96);
            this.allBooksListBox.Name = "allBooksListBox";
            this.allBooksListBox.Size = new System.Drawing.Size(336, 277);
            this.allBooksListBox.TabIndex = 0;
            // 
            // viewAllButton
            // 
            this.viewAllButton.BackColor = System.Drawing.Color.SteelBlue;
            this.viewAllButton.Location = new System.Drawing.Point(203, 23);
            this.viewAllButton.Name = "viewAllButton";
            this.viewAllButton.Size = new System.Drawing.Size(116, 33);
            this.viewAllButton.TabIndex = 1;
            this.viewAllButton.Text = "VIEW BOOKS";
            this.viewAllButton.UseVisualStyleBackColor = false;
            this.viewAllButton.Click += new System.EventHandler(this.viewAllButton_Click);
            // 
            // allBooksLabel
            // 
            this.allBooksLabel.AutoSize = true;
            this.allBooksLabel.Location = new System.Drawing.Point(35, 80);
            this.allBooksLabel.Name = "allBooksLabel";
            this.allBooksLabel.Size = new System.Drawing.Size(66, 13);
            this.allBooksLabel.TabIndex = 5;
            this.allBooksLabel.Text = "ALL BOOKS";
            // 
            // addNewBookButton
            // 
            this.addNewBookButton.BackColor = System.Drawing.Color.SteelBlue;
            this.addNewBookButton.Location = new System.Drawing.Point(508, 23);
            this.addNewBookButton.Name = "addNewBookButton";
            this.addNewBookButton.Size = new System.Drawing.Size(116, 33);
            this.addNewBookButton.TabIndex = 12;
            this.addNewBookButton.Text = "ADD A NEW BOOK";
            this.addNewBookButton.UseVisualStyleBackColor = false;
            this.addNewBookButton.Click += new System.EventHandler(this.addNewBookButton_Click);
            // 
            // showInPilesButton
            // 
            this.showInPilesButton.BackColor = System.Drawing.Color.SteelBlue;
            this.showInPilesButton.Location = new System.Drawing.Point(353, 23);
            this.showInPilesButton.Name = "showInPilesButton";
            this.showInPilesButton.Size = new System.Drawing.Size(116, 33);
            this.showInPilesButton.TabIndex = 22;
            this.showInPilesButton.Text = "SHOW IN PILES";
            this.showInPilesButton.UseVisualStyleBackColor = false;
            this.showInPilesButton.Click += new System.EventHandler(this.showInPilesButton_Click);
            // 
            // booksToStoreLabel
            // 
            this.booksToStoreLabel.AutoSize = true;
            this.booksToStoreLabel.Location = new System.Drawing.Point(415, 80);
            this.booksToStoreLabel.Name = "booksToStoreLabel";
            this.booksToStoreLabel.Size = new System.Drawing.Size(102, 13);
            this.booksToStoreLabel.TabIndex = 24;
            this.booksToStoreLabel.Text = "BOOKS TO STORE";
            // 
            // filteredListBox
            // 
            this.filteredListBox.FormattingEnabled = true;
            this.filteredListBox.HorizontalScrollbar = true;
            this.filteredListBox.Location = new System.Drawing.Point(418, 96);
            this.filteredListBox.Name = "filteredListBox";
            this.filteredListBox.Size = new System.Drawing.Size(336, 277);
            this.filteredListBox.TabIndex = 23;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.booksToStoreLabel);
            this.Controls.Add(this.filteredListBox);
            this.Controls.Add(this.showInPilesButton);
            this.Controls.Add(this.addNewBookButton);
            this.Controls.Add(this.allBooksLabel);
            this.Controls.Add(this.viewAllButton);
            this.Controls.Add(this.allBooksListBox);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox allBooksListBox;
        private System.Windows.Forms.Button viewAllButton;
        private System.Windows.Forms.Label allBooksLabel;
        private System.Windows.Forms.Button addNewBookButton;
        private System.Windows.Forms.Button showInPilesButton;
        private System.Windows.Forms.Label booksToStoreLabel;
        private System.Windows.Forms.ListBox filteredListBox;
    }
}