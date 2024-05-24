namespace Library
{
    partial class Form3
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
            this.choosLabel = new System.Windows.Forms.Label();
            this.compSciButton = new System.Windows.Forms.Button();
            this.networkButton = new System.Windows.Forms.Button();
            this.mathButton = new System.Windows.Forms.Button();
            this.SWdvlpmntButton = new System.Windows.Forms.Button();
            this.pileListBox = new System.Windows.Forms.ListBox();
            this.chosenCategoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // choosLabel
            // 
            this.choosLabel.AutoSize = true;
            this.choosLabel.Location = new System.Drawing.Point(332, 36);
            this.choosLabel.Name = "choosLabel";
            this.choosLabel.Size = new System.Drawing.Size(124, 13);
            this.choosLabel.TabIndex = 0;
            this.choosLabel.Text = "CHOOSE A CATEGORY";
            this.choosLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // compSciButton
            // 
            this.compSciButton.BackColor = System.Drawing.Color.SteelBlue;
            this.compSciButton.Location = new System.Drawing.Point(68, 81);
            this.compSciButton.Name = "compSciButton";
            this.compSciButton.Size = new System.Drawing.Size(162, 33);
            this.compSciButton.TabIndex = 1;
            this.compSciButton.Text = "COMPUTER SCIENCE";
            this.compSciButton.UseVisualStyleBackColor = false;
            // 
            // networkButton
            // 
            this.networkButton.BackColor = System.Drawing.Color.SteelBlue;
            this.networkButton.Location = new System.Drawing.Point(236, 81);
            this.networkButton.Name = "networkButton";
            this.networkButton.Size = new System.Drawing.Size(162, 33);
            this.networkButton.TabIndex = 2;
            this.networkButton.Text = "NETWORKING";
            this.networkButton.UseVisualStyleBackColor = false;
            // 
            // mathButton
            // 
            this.mathButton.BackColor = System.Drawing.Color.SteelBlue;
            this.mathButton.Location = new System.Drawing.Point(404, 81);
            this.mathButton.Name = "mathButton";
            this.mathButton.Size = new System.Drawing.Size(162, 33);
            this.mathButton.TabIndex = 3;
            this.mathButton.Text = "MATHEMATICS";
            this.mathButton.UseVisualStyleBackColor = false;
            // 
            // SWdvlpmntButton
            // 
            this.SWdvlpmntButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SWdvlpmntButton.Location = new System.Drawing.Point(572, 81);
            this.SWdvlpmntButton.Name = "SWdvlpmntButton";
            this.SWdvlpmntButton.Size = new System.Drawing.Size(162, 33);
            this.SWdvlpmntButton.TabIndex = 4;
            this.SWdvlpmntButton.Text = "SOFTWARE DEVELOPMENT";
            this.SWdvlpmntButton.UseVisualStyleBackColor = false;
            // 
            // pileListBox
            // 
            this.pileListBox.FormattingEnabled = true;
            this.pileListBox.HorizontalScrollbar = true;
            this.pileListBox.Location = new System.Drawing.Point(151, 166);
            this.pileListBox.Name = "pileListBox";
            this.pileListBox.Size = new System.Drawing.Size(536, 173);
            this.pileListBox.TabIndex = 5;
            // 
            // chosenCategoryLabel
            // 
            this.chosenCategoryLabel.AutoSize = true;
            this.chosenCategoryLabel.Location = new System.Drawing.Point(158, 150);
            this.chosenCategoryLabel.Name = "chosenCategoryLabel";
            this.chosenCategoryLabel.Size = new System.Drawing.Size(0, 13);
            this.chosenCategoryLabel.TabIndex = 6;
            this.chosenCategoryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chosenCategoryLabel);
            this.Controls.Add(this.pileListBox);
            this.Controls.Add(this.SWdvlpmntButton);
            this.Controls.Add(this.mathButton);
            this.Controls.Add(this.networkButton);
            this.Controls.Add(this.compSciButton);
            this.Controls.Add(this.choosLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choosLabel;
        private System.Windows.Forms.Button compSciButton;
        private System.Windows.Forms.Button networkButton;
        private System.Windows.Forms.Button mathButton;
        private System.Windows.Forms.Button SWdvlpmntButton;
        private System.Windows.Forms.ListBox pileListBox;
        private System.Windows.Forms.Label chosenCategoryLabel;
    }
}