namespace ShopGUI
{
    partial class CreateSupplierDialog
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.CitycomboBox = new System.Windows.Forms.ComboBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.okbutton = new System.Windows.Forms.Button();
            this.canclebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(46, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(49, 39);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(121, 20);
            this.NametextBox.TabIndex = 1;
            this.NametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(49, 77);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City";
            // 
            // CitycomboBox
            // 
            this.CitycomboBox.FormattingEnabled = true;
            this.CitycomboBox.Location = new System.Drawing.Point(52, 93);
            this.CitycomboBox.Name = "CitycomboBox";
            this.CitycomboBox.Size = new System.Drawing.Size(118, 21);
            this.CitycomboBox.TabIndex = 3;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(49, 136);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(52, 153);
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(118, 20);
            this.AddresstextBox.TabIndex = 5;
            this.AddresstextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // okbutton
            // 
            this.okbutton.Location = new System.Drawing.Point(39, 228);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(45, 23);
            this.okbutton.TabIndex = 6;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // canclebutton
            // 
            this.canclebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.canclebutton.Location = new System.Drawing.Point(106, 228);
            this.canclebutton.Name = "canclebutton";
            this.canclebutton.Size = new System.Drawing.Size(75, 23);
            this.canclebutton.TabIndex = 7;
            this.canclebutton.Text = "Cancle";
            this.canclebutton.UseVisualStyleBackColor = true;
            // 
            // CreateSupplierDialog
            // 
            this.AcceptButton = this.okbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.canclebutton;
            this.ClientSize = new System.Drawing.Size(215, 265);
            this.Controls.Add(this.canclebutton);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.AddresstextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.CitycomboBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateSupplierDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Supplier";
            this.Load += new System.EventHandler(this.CreateSupplierDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.ComboBox CitycomboBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.Button canclebutton;
    }
}