namespace ShopGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateMenu = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsLabel = new System.Windows.Forms.Label();
            this.CreateMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateMenu
            // 
            this.CreateMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.tradeToolStripMenuItem});
            this.CreateMenu.Location = new System.Drawing.Point(0, 0);
            this.CreateMenu.Name = "CreateMenu";
            this.CreateMenu.Size = new System.Drawing.Size(802, 24);
            this.CreateMenu.TabIndex = 0;
            this.CreateMenu.Text = "menuStrip1";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSupplierToolStripMenuItem,
            this.createProductToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // createSupplierToolStripMenuItem
            // 
            this.createSupplierToolStripMenuItem.Name = "createSupplierToolStripMenuItem";
            this.createSupplierToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.createSupplierToolStripMenuItem.Text = "Create Supplier...";
            this.createSupplierToolStripMenuItem.Click += new System.EventHandler(this.createSupplierToolStripMenuItem_Click);
            // 
            // createProductToolStripMenuItem
            // 
            this.createProductToolStripMenuItem.Name = "createProductToolStripMenuItem";
            this.createProductToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.createProductToolStripMenuItem.Text = "Create Product...";
            this.createProductToolStripMenuItem.Click += new System.EventHandler(this.createProductToolStripMenuItem_Click);
            // 
            // tradeToolStripMenuItem
            // 
            this.tradeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterProductToolStripMenuItem});
            this.tradeToolStripMenuItem.Name = "tradeToolStripMenuItem";
            this.tradeToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.tradeToolStripMenuItem.Text = "Trade";
            // 
            // enterProductToolStripMenuItem
            // 
            this.enterProductToolStripMenuItem.Name = "enterProductToolStripMenuItem";
            this.enterProductToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.enterProductToolStripMenuItem.Text = "Enter Product";
            this.enterProductToolStripMenuItem.Click += new System.EventHandler(this.enterProductToolStripMenuItem_Click);
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AllowUserToAddRows = false;
            this.ProductDataGridView.AllowUserToDeleteRows = false;
            this.ProductDataGridView.AllowUserToResizeColumns = false;
            this.ProductDataGridView.AllowUserToResizeRows = false;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.PriceColumn,
            this.QuantityColumn,
            this.SupplierColumn,
            this.MarkColumn});
            this.ProductDataGridView.Location = new System.Drawing.Point(15, 44);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.ReadOnly = true;
            this.ProductDataGridView.RowHeadersVisible = false;
            this.ProductDataGridView.Size = new System.Drawing.Size(767, 353);
            this.ProductDataGridView.TabIndex = 1;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 150;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Width = 150;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            this.QuantityColumn.Width = 150;
            // 
            // SupplierColumn
            // 
            this.SupplierColumn.HeaderText = "Supplier";
            this.SupplierColumn.Name = "SupplierColumn";
            this.SupplierColumn.ReadOnly = true;
            this.SupplierColumn.Width = 150;
            // 
            // MarkColumn
            // 
            this.MarkColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MarkColumn.HeaderText = "Mark";
            this.MarkColumn.Name = "MarkColumn";
            this.MarkColumn.ReadOnly = true;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Location = new System.Drawing.Point(12, 28);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(44, 13);
            this.productsLabel.TabIndex = 2;
            this.productsLabel.Text = "Product";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 452);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.ProductDataGridView);
            this.Controls.Add(this.CreateMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.CreateMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.CreateMenu.ResumeLayout(false);
            this.CreateMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip CreateMenu;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterProductToolStripMenuItem;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkColumn;
    }
}

