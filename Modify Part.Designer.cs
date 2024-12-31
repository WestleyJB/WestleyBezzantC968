namespace C968
{
    partial class ModifyParts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.PartsIHRadio = new System.Windows.Forms.RadioButton();
            this.PartsORadio = new System.Windows.Forms.RadioButton();
            this.PartsID = new System.Windows.Forms.Label();
            this.PartsName = new System.Windows.Forms.Label();
            this.PartsInventory = new System.Windows.Forms.Label();
            this.PartsPriceCost = new System.Windows.Forms.Label();
            this.PartsMax = new System.Windows.Forms.Label();
            this.PartsMachineORCompanyID = new System.Windows.Forms.Label();
            this.PartsMin = new System.Windows.Forms.Label();
            this.PartNameText = new System.Windows.Forms.TextBox();
            this.PartMinText = new System.Windows.Forms.TextBox();
            this.PartMachineORCompanyIDText = new System.Windows.Forms.TextBox();
            this.PartMaxText = new System.Windows.Forms.TextBox();
            this.PartPriceCostText = new System.Windows.Forms.TextBox();
            this.PartInventoryText = new System.Windows.Forms.TextBox();
            this.PartsSave = new System.Windows.Forms.Button();
            this.PartsCancel = new System.Windows.Forms.Button();
            this.modPartIDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modify Part";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PartsIHRadio
            // 
            this.PartsIHRadio.AutoSize = true;
            this.PartsIHRadio.Location = new System.Drawing.Point(229, 27);
            this.PartsIHRadio.Name = "PartsIHRadio";
            this.PartsIHRadio.Size = new System.Drawing.Size(68, 17);
            this.PartsIHRadio.TabIndex = 2;
            this.PartsIHRadio.TabStop = true;
            this.PartsIHRadio.Text = "In-House";
            this.PartsIHRadio.UseVisualStyleBackColor = true;
            this.PartsIHRadio.CheckedChanged += new System.EventHandler(this.PartsIHRadio_CheckedChanged);
            // 
            // PartsORadio
            // 
            this.PartsORadio.AutoSize = true;
            this.PartsORadio.Location = new System.Drawing.Point(389, 28);
            this.PartsORadio.Name = "PartsORadio";
            this.PartsORadio.Size = new System.Drawing.Size(80, 17);
            this.PartsORadio.TabIndex = 3;
            this.PartsORadio.TabStop = true;
            this.PartsORadio.Text = "Outsourced";
            this.PartsORadio.UseVisualStyleBackColor = true;
            this.PartsORadio.CheckedChanged += new System.EventHandler(this.PartsORadio_CheckedChanged);
            // 
            // PartsID
            // 
            this.PartsID.AutoSize = true;
            this.PartsID.Location = new System.Drawing.Point(204, 122);
            this.PartsID.Name = "PartsID";
            this.PartsID.Size = new System.Drawing.Size(18, 13);
            this.PartsID.TabIndex = 4;
            this.PartsID.Text = "ID";
            this.PartsID.Click += new System.EventHandler(this.label1_Click);
            // 
            // PartsName
            // 
            this.PartsName.AutoSize = true;
            this.PartsName.Location = new System.Drawing.Point(187, 161);
            this.PartsName.Name = "PartsName";
            this.PartsName.Size = new System.Drawing.Size(35, 13);
            this.PartsName.TabIndex = 5;
            this.PartsName.Text = "Name";
            // 
            // PartsInventory
            // 
            this.PartsInventory.AutoSize = true;
            this.PartsInventory.Location = new System.Drawing.Point(171, 199);
            this.PartsInventory.Name = "PartsInventory";
            this.PartsInventory.Size = new System.Drawing.Size(51, 13);
            this.PartsInventory.TabIndex = 6;
            this.PartsInventory.Text = "Inventory";
            // 
            // PartsPriceCost
            // 
            this.PartsPriceCost.AutoSize = true;
            this.PartsPriceCost.Location = new System.Drawing.Point(159, 241);
            this.PartsPriceCost.Name = "PartsPriceCost";
            this.PartsPriceCost.Size = new System.Drawing.Size(63, 13);
            this.PartsPriceCost.TabIndex = 7;
            this.PartsPriceCost.Text = "Price / Cost";
            // 
            // PartsMax
            // 
            this.PartsMax.AutoSize = true;
            this.PartsMax.Location = new System.Drawing.Point(195, 288);
            this.PartsMax.Name = "PartsMax";
            this.PartsMax.Size = new System.Drawing.Size(27, 13);
            this.PartsMax.TabIndex = 8;
            this.PartsMax.Text = "Max";
            this.PartsMax.Click += new System.EventHandler(this.label6_Click);
            // 
            // PartsMachineORCompanyID
            // 
            this.PartsMachineORCompanyID.AutoSize = true;
            this.PartsMachineORCompanyID.Location = new System.Drawing.Point(160, 325);
            this.PartsMachineORCompanyID.Name = "PartsMachineORCompanyID";
            this.PartsMachineORCompanyID.Size = new System.Drawing.Size(62, 13);
            this.PartsMachineORCompanyID.TabIndex = 9;
            this.PartsMachineORCompanyID.Text = "Machine ID";
            // 
            // PartsMin
            // 
            this.PartsMin.AutoSize = true;
            this.PartsMin.Location = new System.Drawing.Point(386, 288);
            this.PartsMin.Name = "PartsMin";
            this.PartsMin.Size = new System.Drawing.Size(24, 13);
            this.PartsMin.TabIndex = 10;
            this.PartsMin.Text = "Min";
            // 
            // PartNameText
            // 
            this.PartNameText.Location = new System.Drawing.Point(249, 158);
            this.PartNameText.Name = "PartNameText";
            this.PartNameText.Size = new System.Drawing.Size(100, 20);
            this.PartNameText.TabIndex = 12;
            // 
            // PartMinText
            // 
            this.PartMinText.Location = new System.Drawing.Point(431, 285);
            this.PartMinText.Name = "PartMinText";
            this.PartMinText.Size = new System.Drawing.Size(100, 20);
            this.PartMinText.TabIndex = 13;
            // 
            // PartMachineORCompanyIDText
            // 
            this.PartMachineORCompanyIDText.Location = new System.Drawing.Point(249, 322);
            this.PartMachineORCompanyIDText.Name = "PartMachineORCompanyIDText";
            this.PartMachineORCompanyIDText.Size = new System.Drawing.Size(100, 20);
            this.PartMachineORCompanyIDText.TabIndex = 14;
            // 
            // PartMaxText
            // 
            this.PartMaxText.Location = new System.Drawing.Point(249, 285);
            this.PartMaxText.Name = "PartMaxText";
            this.PartMaxText.Size = new System.Drawing.Size(100, 20);
            this.PartMaxText.TabIndex = 15;
            // 
            // PartPriceCostText
            // 
            this.PartPriceCostText.Location = new System.Drawing.Point(249, 238);
            this.PartPriceCostText.Name = "PartPriceCostText";
            this.PartPriceCostText.Size = new System.Drawing.Size(100, 20);
            this.PartPriceCostText.TabIndex = 16;
            // 
            // PartInventoryText
            // 
            this.PartInventoryText.Location = new System.Drawing.Point(249, 196);
            this.PartInventoryText.Name = "PartInventoryText";
            this.PartInventoryText.Size = new System.Drawing.Size(100, 20);
            this.PartInventoryText.TabIndex = 17;
            // 
            // PartsSave
            // 
            this.PartsSave.Location = new System.Drawing.Point(389, 395);
            this.PartsSave.Name = "PartsSave";
            this.PartsSave.Size = new System.Drawing.Size(75, 23);
            this.PartsSave.TabIndex = 18;
            this.PartsSave.Text = "Save";
            this.PartsSave.UseVisualStyleBackColor = true;
            this.PartsSave.Click += new System.EventHandler(this.PartsSave_Click);
            // 
            // PartsCancel
            // 
            this.PartsCancel.Location = new System.Drawing.Point(485, 395);
            this.PartsCancel.Name = "PartsCancel";
            this.PartsCancel.Size = new System.Drawing.Size(75, 23);
            this.PartsCancel.TabIndex = 19;
            this.PartsCancel.Text = "Cancel";
            this.PartsCancel.UseVisualStyleBackColor = true;
            this.PartsCancel.Click += new System.EventHandler(this.PartsCancel_Click);
            // 
            // modPartIDTextBox
            // 
            this.modPartIDTextBox.Location = new System.Drawing.Point(249, 119);
            this.modPartIDTextBox.Name = "modPartIDTextBox";
            this.modPartIDTextBox.ReadOnly = true;
            this.modPartIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.modPartIDTextBox.TabIndex = 31;
            // 
            // ModifyParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.modPartIDTextBox);
            this.Controls.Add(this.PartsCancel);
            this.Controls.Add(this.PartsSave);
            this.Controls.Add(this.PartInventoryText);
            this.Controls.Add(this.PartPriceCostText);
            this.Controls.Add(this.PartMaxText);
            this.Controls.Add(this.PartMachineORCompanyIDText);
            this.Controls.Add(this.PartMinText);
            this.Controls.Add(this.PartNameText);
            this.Controls.Add(this.PartsMin);
            this.Controls.Add(this.PartsMachineORCompanyID);
            this.Controls.Add(this.PartsMax);
            this.Controls.Add(this.PartsPriceCost);
            this.Controls.Add(this.PartsInventory);
            this.Controls.Add(this.PartsName);
            this.Controls.Add(this.PartsID);
            this.Controls.Add(this.PartsORadio);
            this.Controls.Add(this.PartsIHRadio);
            this.Controls.Add(this.label2);
            this.Name = "ModifyParts";
            this.Text = "Modify Parts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton PartsIHRadio;
        private System.Windows.Forms.RadioButton PartsORadio;
        private System.Windows.Forms.Label PartsID;
        private System.Windows.Forms.Label PartsName;
        private System.Windows.Forms.Label PartsInventory;
        private System.Windows.Forms.Label PartsPriceCost;
        private System.Windows.Forms.Label PartsMax;
        private System.Windows.Forms.Label PartsMachineORCompanyID;
        private System.Windows.Forms.Label PartsMin;
        private System.Windows.Forms.TextBox PartNameText;
        private System.Windows.Forms.TextBox PartMinText;
        private System.Windows.Forms.TextBox PartMachineORCompanyIDText;
        private System.Windows.Forms.TextBox PartMaxText;
        private System.Windows.Forms.TextBox PartPriceCostText;
        private System.Windows.Forms.TextBox PartInventoryText;
        private System.Windows.Forms.Button PartsSave;
        private System.Windows.Forms.Button PartsCancel;
        private System.Windows.Forms.TextBox modPartIDTextBox;
    }
}

