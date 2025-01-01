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
    public partial class ModifyParts : Form
    {
        Root RootWindow = (Root)Application.OpenForms["Root"];
        
        //Populates text fields
        public ModifyParts(InHousePart inPart)
        {
            InitializeComponent();
            modPartIDTextBox.Text = inPart.PartID.ToString();
            PartNameText.Text = inPart.Name;
            PartInventoryText.Text = inPart.Inventory.ToString();
            PartPriceCostText.Text = inPart.Price.Substring(1).ToString();
            PartMaxText.Text = inPart.Max.ToString();
            PartMinText.Text = inPart.Min.ToString();
            PartMachineORCompanyIDText.Text = inPart.MachineID.ToString();
        }

        public ModifyParts(OutsourcedPart outPart)
        {
            InitializeComponent();
            modPartIDTextBox.Text = outPart.PartID.ToString();
            PartNameText.Text = outPart.Name;
            PartInventoryText.Text = outPart.Inventory.ToString();
            PartPriceCostText.Text = outPart.Price.Substring(1).ToString();
            PartMaxText.Text = outPart.Max.ToString();
            PartMinText.Text = outPart.Min.ToString();
            PartMachineORCompanyIDText.Text = outPart.CompName;

            PartsORadio.Checked = true;
        }

        //Updates part data with changes
        private void PartsSave_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;
            int invInStock;
            decimal price;

            try
            {
                minStock = int.Parse(PartMinText.Text);
                maxStock = int.Parse(PartMaxText.Text);
                invInStock = int.Parse(PartInventoryText.Text);
                price = decimal.Parse(PartPriceCostText.Text);
            }
            catch
            {
                MessageBox.Show("Error: 'Inventory', 'Price/Cost', 'Max' and 'Min' fields must contain numeric values. Please try again.");
                return;
            }

            int id = int.Parse(modPartIDTextBox.Text);
            string name = PartNameText.Text;
            price = decimal.Parse(PartPriceCostText.Text);
            minStock = int.Parse(PartMinText.Text);
            maxStock = int.Parse(PartMaxText.Text);
            invInStock = int.Parse(PartInventoryText.Text);


            //Exception handling
            if (minStock > maxStock)
            {
                MessageBox.Show("Error: 'Max' value must be greater than 'Min' value. Please try again.");
                return;
            }

            if (invInStock > maxStock || invInStock < minStock)
            {
                MessageBox.Show("Error: 'Inventory' value must be between 'Max' value and 'Min' value. Please try again.");
                return;
            }

            if (PartsIHRadio.Checked)
            {
                try
                {
                    int machineID = int.Parse(PartMachineORCompanyIDText.Text);
                }
                catch
                {
                    MessageBox.Show("Error: 'Machine ID' value must only contain numeric values. Please try again.");
                    return;
                }
                InHousePart inPart = new InHousePart(id, name, invInStock, price, maxStock, minStock, int.Parse(PartMachineORCompanyIDText.Text));
                Inventory.UpdatePart(id, inPart);
                PartsIHRadio.Checked = true;
            }
            else
            {
                OutsourcedPart outPart = new OutsourcedPart(id, name, invInStock, price, maxStock, minStock, PartMachineORCompanyIDText.Text);
                Inventory.UpdatePart(id, outPart);
                PartsORadio.Checked = true;
            }
            Close();
        }

        private void PartsCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PartsIHRadio_CheckedChanged(object sender, EventArgs e)
        {
            PartsMachineORCompanyID.Text = "Machine ID";
        }

        private void PartsORadio_CheckedChanged(object sender, EventArgs e)
        {
            PartsMachineORCompanyID.Text = "Company Name";
        }
    }
}
