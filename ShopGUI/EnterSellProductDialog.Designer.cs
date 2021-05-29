namespace ShopGUI
{
    partial class EnterSellProductDialog
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
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SupplierLabel = new System.Windows.Forms.Label();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.MarkTextBox = new System.Windows.Forms.TextBox();
            this.SupplierTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.ProductComboBox = new System.Windows.Forms.ComboBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CalncleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(33, 76);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "Price";
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.Location = new System.Drawing.Point(33, 137);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(45, 13);
            this.SupplierLabel.TabIndex = 4;
            this.SupplierLabel.Text = "Supplier";
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Location = new System.Drawing.Point(33, 200);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(31, 13);
            this.MarkLabel.TabIndex = 6;
            this.MarkLabel.Text = "Mark";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(33, 256);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(35, 13);
            this.CountLabel.TabIndex = 8;
            this.CountLabel.Text = "Count";
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(36, 272);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(149, 20);
            this.CountTextBox.TabIndex = 9;
            this.CountTextBox.Text = "0";
            this.CountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CountTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CountTextBox_Validating);
            // 
            // MarkTextBox
            // 
            this.MarkTextBox.Location = new System.Drawing.Point(36, 216);
            this.MarkTextBox.Name = "MarkTextBox";
            this.MarkTextBox.ReadOnly = true;
            this.MarkTextBox.Size = new System.Drawing.Size(149, 20);
            this.MarkTextBox.TabIndex = 7;
            this.MarkTextBox.TabStop = false;
            this.MarkTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SupplierTextBox
            // 
            this.SupplierTextBox.Location = new System.Drawing.Point(36, 153);
            this.SupplierTextBox.Name = "SupplierTextBox";
            this.SupplierTextBox.ReadOnly = true;
            this.SupplierTextBox.Size = new System.Drawing.Size(149, 20);
            this.SupplierTextBox.TabIndex = 5;
            this.SupplierTextBox.TabStop = false;
            this.SupplierTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PriceTextBox.Location = new System.Drawing.Point(36, 92);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(149, 20);
            this.PriceTextBox.TabIndex = 3;
            this.PriceTextBox.TabStop = false;
            this.PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(33, 22);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(44, 13);
            this.ProductLabel.TabIndex = 0;
            this.ProductLabel.Text = "Product";
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Location = new System.Drawing.Point(36, 38);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(149, 21);
            this.ProductComboBox.TabIndex = 1;
            this.ProductComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductComboBox_SelectedIndexChanged);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(36, 312);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(53, 23);
            this.OkButton.TabIndex = 10;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CalncleButton
            // 
            this.CalncleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CalncleButton.Location = new System.Drawing.Point(110, 312);
            this.CalncleButton.Name = "CalncleButton";
            this.CalncleButton.Size = new System.Drawing.Size(75, 23);
            this.CalncleButton.TabIndex = 11;
            this.CalncleButton.Text = "Cancle";
            this.CalncleButton.UseVisualStyleBackColor = true;
            // 
            // EnterSellProductDialog
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CalncleButton;
            this.ClientSize = new System.Drawing.Size(221, 347);
            this.Controls.Add(this.CalncleButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ProductComboBox);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.SupplierTextBox);
            this.Controls.Add(this.MarkTextBox);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.MarkLabel);
            this.Controls.Add(this.SupplierLabel);
            this.Controls.Add(this.PriceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterSellProductDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter and Sell Product ";
            this.Load += new System.EventHandler(this.EnterProductDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label SupplierLabel;
        private System.Windows.Forms.Label MarkLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.TextBox MarkTextBox;
        private System.Windows.Forms.TextBox SupplierTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CalncleButton;
    }
}