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
    public partial class CreateProductDialog : Form
    {
        public CreateProductDialog()
        {
            InitializeComponent();
        }

        private void CreateProductDialog_Load(object sender, EventArgs e)
        {
            
                SuppliercomboBox.Items.AddRange(Shop.Shop.Suppliers.ToArray());
            if (SuppliercomboBox.Items.Count != 0)
                SuppliercomboBox.SelectedIndex = 0;
          
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Enter Product Name", "Error");
                nameTextBox.Focus();
            }
            if (marktextbox.Text == "")
            {
                MessageBox.Show("Enter Mark", "Error");
                marktextbox.Focus();
            }

            Product prod = new Product(nameTextBox.Text, Int32.Parse(pricetextbox.Text),
                (Supplier)SuppliercomboBox.SelectedItem,
                marktextbox.Text);
            try
            {

                Shop.Shop.AddProduct(prod);
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                nameTextBox.Clear();
                pricetextbox.Clear();
                if (SuppliercomboBox.Items.Count != 0)
                    SuppliercomboBox.SelectedIndex = 0;
                marktextbox.Clear();
                nameTextBox.Focus();
            }
        }

        private void pricetextbox_Validating(object sender, CancelEventArgs e)
        {
            //valid-y menak chisht arzheqnern e grats toghum textboxum
            //or. name-y u mark-y petq a datark chlini(ok seghmeluc)
            //isk price qani der tiv chenq grel => togh durs chga
            //dra hamar 0-n grats unenanq ???????????????????????????????????????????

            int x;//sra mej tryparse-i ardyunqn enq unenalu ?????????????????????????
            if (!Int32.TryParse(pricetextbox.Text, out x))
            {
                //bool e veradardznum stacel e parse arats te che=>
                //ete false e=>vat depqn e => chenq toghi araj gna
                MessageBox.Show("Enter Number!", "Error");
                pricetextbox.SelectAll();//eghatsy jnjenq
                pricetextbox.Focus();
            }
        }

        private void SuppliercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
