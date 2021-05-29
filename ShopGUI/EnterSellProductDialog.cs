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
    public partial class EnterSellProductDialog : Form
    {
        public EnterSellProductDialog()
        {
            InitializeComponent();
        }

        private void EnterProductDialog_Load(object sender, EventArgs e)
        {
            //mutq aneluc petq e apranqy grancvats lini u  petq e asenq te qani hat enq tvyal apranqic mutq anum
            // combobox u qanak unenanq,,,, unenanq mi dialog mutq-vacharqi hamar ete -tiv e => vachrum enq,+`mutq
            //henc comboyum apranqy yntrenq => taky beri lcni infon u da pokhel chlini =>disable arats lini
            ProductComboBox.Items.AddRange(Shop.Shop.Products.Keys.ToArray());
            if(ProductComboBox.Items.Count != 0)
            {
                ProductComboBox.SelectedIndex = 0;
            }
        }

        private void CountTextBox_Validating(object sender, CancelEventArgs e)
        {
            int x;
            if (!Int32.TryParse(CountTextBox.Text, out x))
            {
                MessageBox.Show("Enter Number!", "Error");
                CountTextBox.SelectAll();
                CountTextBox.Focus();
            }
           /* else
            {
                if (Int32.Parse(CountTextBox.Text) == 0)///??????????????????????????????????/
                {
                    MessageBox.Show("Invalid Number!", "Warning");
                    CountTextBox.SelectAll();
                    CountTextBox.Focus();
                }
            }*/
        }

        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // PriceTextBox.Text = ProductComboBox.SelectedItem.Price;skhal
 


            Product p = (Product)ProductComboBox.SelectedItem;
            PriceTextBox.Text = p.Price.ToString();
            SupplierTextBox.Text = p.Supplier.ToString();
            MarkTextBox.Text = p.Mark.ToString();//kam p.Mark

            
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            /*Product p = new Product(ProductComboBox.Text, Int32.Parse(PriceTextBox.Text),
                SupplierTextBox.Text, MarkTextBox.Text);///??????*/
            
        }
    }
    }

