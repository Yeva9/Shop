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
    public partial class CreateSupplierDialog : Form
    {
        public CreateSupplierDialog()
        {
            InitializeComponent();
        }

     private void CreateSupplierDialog_Load(object sender, EventArgs e)
        {
            //enumi arzheqnery compoboxi mej gcenq
             string[] c = Enum.GetNames(typeof(City));
              CitycomboBox.Items.AddRange(c);
              CitycomboBox.SelectedIndex = 0;        
    
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text == "")
            {
                MessageBox.Show("Enter Supplier name", "Error");
                NametextBox.Focus();
            }
            if (AddresstextBox.Text == "")
            {
                MessageBox.Show("Enter Address", "Error");
                AddresstextBox.Focus();
            }
            //validatingi masin grenq, vor enpes chstacvi textery datark linen...
            //mez petq er ok-i zhamanak nor supplier sarqeinq u avelacneinq mer cucakin
            //parse anenq sarqenq enumi tipi(enumi funkcianery nayel),,,obj  enq stanum
            //anuny textboxic vercnenq, c-enumy stananq 

            City c = (City)Enum.Parse(typeof(City),
                CitycomboBox.Text);  
            Supplier s = new Supplier(NametextBox.Text,c,
                AddresstextBox.Text);
             
            try
            {
                Shop.Shop.AddSupplier(s);//exc qcogh er
            }
            catch (SystemException ex)
            {
                //henc exc qcec => messbox kanchenq
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                //exc trner te che sa petq e arver dra hamar` finallyy mej
                NametextBox.Clear();
                CitycomboBox.SelectedIndex = 0;
                AddresstextBox.Clear();
                NametextBox.Focus();
            }
        }
    }
}
