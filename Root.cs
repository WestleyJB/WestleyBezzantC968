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
    public partial class Root : Form
    {
        public Root()
        {
            InitializeComponent();

            Inventory.ExampleItems();

            var partTable = new BindingSource();
            partTable.DataSource = Inventory.Parts;
            partGridView.DataSource = partTable;

            var prodTable = new BindingSource();
            prodTable.DataSource = Inventory.Products;
            productGridView.DataSource = prodTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PartsSearchButtonRoot_Click(object sender, EventArgs e)
        {
            try
            {
                int searchValue = int.Parse(PartsSearchBarRoot.Text);
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

                foreach (DataGridViewRow row in partGridView.Rows)
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
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer for the Part ID.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void ModifyPartRoot_Click(object sender, EventArgs e)
        {
            if (partGridView.CurrentRow.DataBoundItem.GetType() == typeof(C968.InHousePart))
            {
                InHousePart inHousePart = (InHousePart)partGridView.CurrentRow.DataBoundItem;
                new ModifyParts(inHousePart).Show();
            }
            else
            {
                OutsourcedPart outsourcedPart = (OutsourcedPart)partGridView.CurrentRow.DataBoundItem;
                new ModifyParts(outsourcedPart).Show();
            }
        }

        private void dataGridViewPartsRoot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void AddPartRoot_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.Show();
        }

        private void AddProductRoot_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void ExitRoot_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PartsSearchBarRoot_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModifyProductRoot_Click(object sender, EventArgs e)
        {
            Product selectedProd = (Product)productGridView.CurrentRow.DataBoundItem;
            new ModifyProduct(selectedProd).Show();
        }

        //You MUST have the ENTIRE row selected in order to delete it. You can do this by pressing the corresponding row from the column to the LEFT of the 'Part ID' column.
        private void DeletePartRoot_Click(object sender, EventArgs e)
        {
            if (partGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row has been selected. Please select an entire row and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in partGridView.SelectedRows)
                {
                    partGridView.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }

        //There is an empty product-row that gets generated. It is not in my bound-list and it cannot be deleted. I put in exception handling for this case; all other products are able to be deleted when selected.
        private void DeleteProductRoot_Click(object sender, EventArgs e)
        {
            if (productGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row has been selected. Please select an entire row and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in productGridView.SelectedRows)
                {
                    try
                    {
                        productGridView.Rows.RemoveAt(row.Index);
                    }
                    catch(ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Product ID is out of range, cannot delete. Please try deleting a different product/row.");
                        return;
                    }
                    catch(InvalidOperationException)
                    {
                        MessageBox.Show("Cannot delete this product/row. Please select a different product/row and try again.");
                        return;
                    }
                }
            }
            else return;
        }
    }
}
