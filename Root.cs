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

            partGridView.RowHeadersVisible = false;
            partGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            productGridView.RowHeadersVisible = false;
            productGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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

                partGridView.ClearSelection();

                foreach (DataGridViewRow row in partGridView.Rows)
                {
                    Part part = (Part)row.DataBoundItem;
                    if (part.PartID == match.PartID)
                    {
                        row.Selected = true;
                        partGridView.CurrentCell = row.Cells[0];
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

        private void DeleteProductRoot_Click(object sender, EventArgs e)
        {
            if (productGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row has been selected. Please select an entire row and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow row in productGridView.SelectedRows.Cast<DataGridViewRow>().ToList())
            {
                Product selectedProduct = (Product)row.DataBoundItem;

                //Verifying whether a product has associated parts or not. I put it here because it needs to happen before the dialog box appears asking you to confirm that you want to delete a product.
                if (selectedProduct.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("This product has associated parts. You cannot delete a product with associated parts. Please remove the associated parts first and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //The rest of the exception handling happens here, after the Yes/No message box appears.
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

        private void ProductsSearchButtonRoot_Click(object sender, EventArgs e)
        {
            try
            {
                int searchValue = int.Parse(ProductsSearchBarRoot.Text);
                if (searchValue < 1)
                {
                    MessageBox.Show("Please enter a value greater than 0", "Invalid Number", MessageBoxButtons.OK);
                    return;
                }

                Product match = Inventory.LookupProduct(searchValue);

                if (match == null)
                {
                    MessageBox.Show("No product found with ID: " + searchValue, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                productGridView.ClearSelection();

                foreach (DataGridViewRow row in productGridView.Rows)
                {
                    Product product = (Product)row.DataBoundItem;
                    if (product.ProductID == match.ProductID)
                    {
                        row.Selected = true;
                        productGridView.CurrentCell = row.Cells[0];
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
                MessageBox.Show("Please enter a valid integer for the Product ID.");
            }
        }
    }
}
