namespace ShopGUI
{
    partial class CreateProductDialog
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
            this.marktextbox = new System.Windows.Forms.TextBox();
            this.marklabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.SuppliercomboBox = new System.Windows.Forms.ComboBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // marktextbox
            // 
            this.marktextbox.Location = new System.Drawing.Point(37, 201);
            this.marktextbox.Name = "marktextbox";
            this.marktextbox.Size = new System.Drawing.Size(156, 20);
            this.marktextbox.TabIndex = 17;
            this.marktextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // marklabel
            // 
            this.marklabel.AutoSize = true;
            this.marklabel.Location = new System.Drawing.Point(37, 185);
            this.marklabel.Name = "marklabel";
            this.marklabel.Size = new System.Drawing.Size(31, 13);
            this.marklabel.TabIndex = 16;
            this.marklabel.Text = "Mark";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(118, 246);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(37, 246);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 18;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // pricetextbox
            // 
            this.pricetextbox.Location = new System.Drawing.Point(37, 91);
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(156, 20);
            this.pricetextbox.TabIndex = 13;
            this.pricetextbox.Text = "0";
            this.pricetextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pricetextbox.Validating += new System.ComponentModel.CancelEventHandler(this.pricetextbox_Validating);
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(37, 128);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(45, 13);
            this.supplierLabel.TabIndex = 14;
            this.supplierLabel.Text = "Supplier";
            // 
            // SuppliercomboBox
            // 
            this.SuppliercomboBox.FormattingEnabled = true;
            this.SuppliercomboBox.Location = new System.Drawing.Point(37, 144);
            this.SuppliercomboBox.Name = "SuppliercomboBox";
            this.SuppliercomboBox.Size = new System.Drawing.Size(156, 21);
            this.SuppliercomboBox.TabIndex = 15;
            this.SuppliercomboBox.SelectedIndexChanged += new System.EventHandler(this.SuppliercomboBox_SelectedIndexChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(37, 75);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 12;
            this.PriceLabel.Text = "Price";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(37, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(156, 20);
            this.nameTextBox.TabIndex = 11;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(37, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name";
            // 
            // CreateProductDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(227, 289);
            this.Controls.Add(this.marktextbox);
            this.Controls.Add(this.marklabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.pricetextbox);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this.SuppliercomboBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateProductDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Product";
            this.Load += new System.EventHandler(this.CreateProductDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox marktextbox;
        private System.Windows.Forms.Label marklabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox pricetextbox;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.ComboBox SuppliercomboBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
    }
}