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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddPartSave_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;
            int invInStock;
            decimal price;

            try
            {
                minStock = int.Parse(partMinTextBox.Text);
                maxStock = int.Parse(partMaxTextBox.Text);
                invInStock = int.Parse(partInventoryTextBox.Text);
                price = decimal.Parse(partCostTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max, and Min text fields must be numeric values.");
                return;
            }

            string name = partNameTextBox.Text;
            price = decimal.Parse(partCostTextBox.Text);
            minStock = int.Parse(partMinTextBox.Text);
            maxStock = int.Parse(partMaxTextBox.Text);
            invInStock = int.Parse(partInventoryTextBox.Text);


            //exception handling
            if (minStock > maxStock)
            {
                MessageBox.Show("Error: Max must be greater than Min");
                return;
            }

            if (invInStock > maxStock || invInStock < minStock)
            {
                MessageBox.Show("Error: Inventory must be between max and min inventory");
                return;
            }


            if (AddPartsIHRadio.Checked)
            {
                try
                {
                    int machineID = int.Parse(partMachineCompanyTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Error: 'Machine ID' value must only contain numeric values. Please try again.");
                    return;
                }
                InHousePart inPart = new InHousePart((Inventory.Parts.Count + 1), name, invInStock, price, maxStock, minStock, int.Parse(partMachineCompanyTextBox.Text));
                Inventory.AddPart(inPart);

            }
            else
            {
                OutsourcedPart outPart = new OutsourcedPart((Inventory.Parts.Count + 1), name, invInStock, price, maxStock, minStock, partMachineCompanyTextBox.Text);
                Inventory.AddPart(outPart);

            }
            Close();
        }

        private void AddPartsIHRadio_CheckedChanged(object sender, EventArgs e)
        {
            AddPartsMachineORCompanyID.Text = "Machine ID";
        }

        private void AddPartsORadio_CheckedChanged(object sender, EventArgs e)
        {
            AddPartsMachineORCompanyID.Text = "Company Name";
        }

        private void AddPartCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
