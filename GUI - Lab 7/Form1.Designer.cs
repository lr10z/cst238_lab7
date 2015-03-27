namespace GUI___Lab_7
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
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.showProductsListBox = new System.Windows.Forms.ListBox();
            this.saleCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(12, 12);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 0;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // showProductsListBox
            // 
            this.showProductsListBox.FormattingEnabled = true;
            this.showProductsListBox.Location = new System.Drawing.Point(13, 57);
            this.showProductsListBox.Name = "showProductsListBox";
            this.showProductsListBox.Size = new System.Drawing.Size(120, 134);
            this.showProductsListBox.TabIndex = 1;
            // 
            // saleCheckBox
            // 
            this.saleCheckBox.AutoSize = true;
            this.saleCheckBox.Location = new System.Drawing.Point(162, 140);
            this.saleCheckBox.Name = "saleCheckBox";
            this.saleCheckBox.Size = new System.Drawing.Size(64, 17);
            this.saleCheckBox.TabIndex = 2;
            this.saleCheckBox.Text = "On Sale";
            this.saleCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(162, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(162, 96);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saleCheckBox);
            this.Controls.Add(this.showProductsListBox);
            this.Controls.Add(this.categoryComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ListBox showProductsListBox;
        private System.Windows.Forms.CheckBox saleCheckBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}

