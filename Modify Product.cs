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

        private void searchPartListButton_Click(object sender, EventArgs e)
        {
            try
            {
                int searchValue = int.Parse(modPartSearchTextBox.Text);
                if (searchValue < 1)
                {
                    MessageBox.Show("Please enter a value greater than 0", "Invalid Number", MessageBoxButtons.OK);
                    return;
                }

                Part match = Inventory.LookupPart(searchValue);

                if (match == null)
                {
                    MessageBox.Show("No part found with ID: " + searchValue, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                modCandidatePartsGrid.ClearSelection();

                foreach (DataGridViewRow row in modCandidatePartsGrid.Rows)
                {
                    Part part = (Part)row.DataBoundItem;
                    if (part.PartID == match.PartID)
                    {
                        row.Selected = true;
                        modCandidatePartsGrid.CurrentCell = row.Cells[0];
                        break;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer for the Part ID.");
            }
        }

        private void addPartToItemButton_Click(object sender, EventArgs e)
        {
            Part partToAdd = (Part)modCandidatePartsGrid.CurrentRow.DataBoundItem;
            addedParts.Add(partToAdd);
        }

        private void deleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            Part part = (Part)modAssociatedPartsGrid.CurrentRow.DataBoundItem;
            int id = int.Parse(modProductIDTextBox.Text);

            Product product = Inventory.LookupProduct(id);
            product.RemoveAssociatedPart(part.PartID);

            foreach (DataGridViewRow row in modAssociatedPartsGrid.SelectedRows)
            {
                modAssociatedPartsGrid.Rows.RemoveAt(row.Index);
            }
        }

        private void cancelAddProductbutton_Click(object sender, EventArgs e)
        {
            Close();
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
