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

        private void addPartToItemButton_Click(object sender, EventArgs e)
        {
            Part partToAdd = (Part)modCandidatePartsGrid.CurrentRow.DataBoundItem;
            addedParts.Add(partToAdd);
        }

        private void saveNewProductButton_Click(object sender, EventArgs e)
        {
            int inventory;
            int min;
            int max;
            decimal price;

            try
            {
                min = int.Parse(modProductMinTextBox.Text);
                max = int.Parse(modProductMaxTextBox.Text);
                inventory = int.Parse(modProductInventoryTextBox.Text);
                price = decimal.Parse(modProductPriceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: 'Inventory', 'Price', 'Max', and 'Min' text fields must be numeric values. Please try again.");
                return;
            }
            int id = int.Parse(modProductIDTextBox.Text);
            string name = modProductNameTextBox.Text;
            inventory = int.Parse(modProductInventoryTextBox.Text);
            price = decimal.Parse(modProductPriceTextBox.Text);
            min = int.Parse(modProductMinTextBox.Text);
            max = int.Parse(modProductMaxTextBox.Text);

            //This statement prevents users from entering a higher minimum inventory value than their maximum inventory value.
            if (min > max)
            {
                MessageBox.Show("Error: 'Min' value cannot be greater than 'max' value. Please try again.");
                return;
            }

            if (inventory > max || inventory < min)
            {
                MessageBox.Show("Error: 'Inventory' value must be between 'Max' and 'Min' values. Please try again.");
                return;
            }
            //This statement allows a user to create a new product and add it to their inventory.
            Product product = new Product(id, name, inventory, price, max, min);
            foreach (Part part in addedParts)
            {
                product.AddAssociatedPart(part);
            }
            Inventory.UpdateProduct(id, product);
            Close();
        }
    }
}
