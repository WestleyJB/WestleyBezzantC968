using C968;
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
    public partial class AddProduct : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        public AddProduct()
        {
            InitializeComponent();
            int nextProductID = Inventory.Products.Count + 1;
            addProductIDTextBox.Text = nextProductID.ToString();

            //The top table contains a list of all parts, as also found on the home screen
            var topTable = new BindingSource();
            topTable.DataSource = Inventory.Parts;
            addCandidatePartsGrid.DataSource = topTable;

            //The bottom table contains a list of the parts that belong to a specific product, which was selected from the home screen
            var botTable = new BindingSource();
            botTable.DataSource = addedParts;
            addAssociatedPartsGrid.DataSource = botTable;
        }

        private void cancelAddProductbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete this part?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in addAssociatedPartsGrid.SelectedRows)
                {
                    addAssociatedPartsGrid.Rows.RemoveAt(row.Index);
                }
            }
            else return;

        }

        private void SearchPartListButton_Click(object sender, EventArgs e)
        {
            int partID = int.Parse(addPartSearchTextBox.Text);
            Part match = Inventory.LookupPart(partID);
            foreach (DataGridViewRow row in addCandidatePartsGrid.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.PartID == match.PartID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void addPartToItemButton_Click(object sender, EventArgs e)
        {
            Part partToAdd = (Part)addCandidatePartsGrid.CurrentRow.DataBoundItem;
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
                min = int.Parse(addProductMinTextBox.Text);
                max = int.Parse(addProductMaxTextBox.Text);
                inventory = int.Parse(addProductInventoryTextBox.Text);
                price = decimal.Parse(addProductPriceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: 'Inventory', 'Price', 'Max', and 'Min' text fields must be numeric values. Please try again.");
                return;
            }

            string name = addProductNameTextBox.Text;
            inventory = int.Parse(addProductInventoryTextBox.Text);
            price = decimal.Parse(addProductPriceTextBox.Text);
            min = int.Parse(addProductMinTextBox.Text);
            max = int.Parse(addProductMaxTextBox.Text);

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
            Product product = new Product(Inventory.Products.Count + 1, name, inventory, price, max, min);
            Inventory.AddProduct(product);

            foreach (Part part in addedParts)
            {
                product.AddAssociatedPart(part);
            }
            Close();
        }

        //The visual [Design] file would throw errors if this was deleted, so it doesn't do anything but is here.

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addAssociatedPartsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
