using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968
{
    public partial class ModifyProduct : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        Root RootWindow = (Root)Application.OpenForms["Root"];
        public ModifyProduct(Product prod)
        {
            InitializeComponent();

            //product fields populated with selected product
            modProductIDTextBox.Text = prod.ProductID.ToString();
            modProductNameTextBox.Text = prod.Name;
            modProductInventoryTextBox.Text = prod.Inventory.ToString();
            modProductPriceTextBox.Text = prod.Price.Substring(1).ToString();
            modProductMaxTextBox.Text = prod.Max.ToString();
            modProductMinTextBox.Text = prod.Min.ToString();

            //populates top table with all products
            var topTable = new BindingSource();
            topTable.DataSource = Inventory.Parts;
            modCandidatePartsGrid.DataSource = topTable;

            //populates bottom table with linked parts
            foreach (Part part in prod.AssociatedParts)
            {
                addedParts.Add(part);
            }
            var botTable = new BindingSource();
            botTable.DataSource = addedParts;
            modAssociatedPartsGrid.DataSource = botTable;
        }

        private void modProductNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void modCandidatePartsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cancelAddProductbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
