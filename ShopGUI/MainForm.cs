using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop;

namespace ShopGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void createSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateSupplierDialog createSupplierDialog = new CreateSupplierDialog();
            createSupplierDialog.ShowDialog();
           // UpdateProductsTable();

        }

        private void createProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateProductDialog createProductDialog = new CreateProductDialog();
            createProductDialog.ShowDialog();
            UpdateProductsTable();
        }

        private void enterProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterSellProductDialog enterProductDialog = new EnterSellProductDialog();
            enterProductDialog.ShowDialog();
            UpdateProductsTable();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // ProductDataGridView.Rows[5].Cells["NameColumn"].Value/* aysqany mihat cell e aranc Value*/
            //ProductDataGridView.Rows.Add("a", 1, "aaa", 5, "q"); //toghov kavelacni
            /*
            int i = ProductDataGridView.Rows.Add();//nuyny anenq bayc indexy vercnenq
            ProductDataGridView.Rows[i].Cells[0].Value = "a";
            ProductDataGridView.Rows[i].Cells[1].Value = "a";
            ProductDataGridView.Rows[i].Cells[2].Value = "a";
            ProductDataGridView.Rows[i].Cells[3].Value = "a";
            ProductDataGridView.Rows[i].Cells[4].Value = "B";
            */

            //shopic vercnenq productnery u lcnenq aystegh

            UpdateProductsTable();
        }

        private void UpdateProductsTable()
        {
            ProductDataGridView.Rows.Clear();
            foreach (Product p in Shop.Shop.Products.Keys)//franq apranqneri vrayov
            {
                int i = ProductDataGridView.Rows.Add();//nuyny anenq bayc indexy vercnenq
                ProductDataGridView.Rows[i].Cells[0].Value = p.Name;
                ProductDataGridView.Rows[i].Cells[1].Value = p.Price;
                ProductDataGridView.Rows[i].Cells[2].Value = Shop.Shop.Products[p];//tiv e veradardznum
                //????????????????????????????vonc tiv?
                ProductDataGridView.Rows[i].Cells[3].Value = p.Supplier.ToString();//vortev enum er
                ProductDataGridView.Rows[i].Cells[4].Value = p.Mark;
            }

            //kkanchenq prod. sarqelu dialogic heto....
        }



        /* private void sellProductToolStripMenuItem_Click(object sender, EventArgs e)
         {
             SellProductDialog sellProductDialog = new SellProductDialog();
             sellProductDialog.ShowDialog();
         }*/
    }
}
