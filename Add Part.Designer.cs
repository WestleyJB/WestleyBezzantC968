namespace C968
{
    partial class AddPart
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddPartsIHRadio = new System.Windows.Forms.RadioButton();
            this.AddPartsORadio = new System.Windows.Forms.RadioButton();
            this.AddPartsID = new System.Windows.Forms.Label();
            this.AddPartsName = new System.Windows.Forms.Label();
            this.AddPartsInventory = new System.Windows.Forms.Label();
            this.AddPartsPriceCost = new System.Windows.Forms.Label();
            this.AddPartsMax = new System.Windows.Forms.Label();
            this.AddPartsMin = new System.Windows.Forms.Label();
            this.AddPartsMachineORCompanyID = new System.Windows.Forms.Label();
            this.partNameTextBox = new System.Windows.Forms.TextBox();
            this.partInventoryTextBox = new System.Windows.Forms.TextBox();
            this.partCostTextBox = new System.Windows.Forms.TextBox();
            this.partMaxTextBox = new System.Windows.Forms.TextBox();
            this.partMinTextBox = new System.Windows.Forms.TextBox();
            this.partMachineCompanyTextBox = new System.Windows.Forms.TextBox();
            this.AddPartSave = new System.Windows.Forms.Button();
            this.AddPartCancel = new System.Windows.Forms.Button();
            this.partIDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddPartsIHRadio
            // 
            this.AddPartsIHRadio.AutoSize = true;
            this.AddPartsIHRadio.Location = new System.Drawing.Point(202, 27);
            this.AddPartsIHRadio.Name = "AddPartsIHRadio";
            this.AddPartsIHRadio.Size = new System.Drawing.Size(68, 17);
            this.AddPartsIHRadio.TabIndex = 1;
            this.AddPartsIHRadio.TabStop = true;
            this.AddPartsIHRadio.Text = "In-House";
            this.AddPartsIHRadio.UseVisualStyleBackColor = true;
            this.AddPartsIHRadio.CheckedChanged += new System.EventHandler(this.AddPartsIHRadio_CheckedChanged);
            // 
            // AddPartsORadio
            // 
            this.AddPartsORadio.AutoSize = true;
            this.AddPartsORadio.Location = new System.Drawing.Point(398, 27);
            this.AddPartsORadio.Name = "AddPartsORadio";
            this.AddPartsORadio.Size = new System.Drawing.Size(80, 17);
            this.AddPartsORadio.TabIndex = 2;
            this.AddPartsORadio.TabStop = true;
            this.AddPartsORadio.Text = "Outsourced";
            this.AddPartsORadio.UseVisualStyleBackColor = true;
            this.AddPartsORadio.CheckedChanged += new System.EventHandler(this.AddPartsORadio_CheckedChanged);
            // 
            // AddPartsID
            // 
            this.AddPartsID.AutoSize = true;
            this.AddPartsID.Location = new System.Drawing.Point(163, 87);
            this.AddPartsID.Name = "AddPartsID";
            this.AddPartsID.Size = new System.Drawing.Size(18, 13);
            this.AddPartsID.TabIndex = 3;
            this.AddPartsID.Text = "ID";
            // 
            // AddPartsName
            // 
            this.AddPartsName.AutoSize = true;
            this.AddPartsName.Location = new System.Drawing.Point(146, 139);
            this.AddPartsName.Name = "AddPartsName";
            this.AddPartsName.Size = new System.Drawing.Size(35, 13);
            this.AddPartsName.TabIndex = 4;
            this.AddPartsName.Text = "Name";
            // 
            // AddPartsInventory
            // 
            this.AddPartsInventory.AutoSize = true;
            this.AddPartsInventory.Location = new System.Drawing.Point(130, 190);
            this.AddPartsInventory.Name = "AddPartsInventory";
            this.AddPartsInventory.Size = new System.Drawing.Size(51, 13);
            this.AddPartsInventory.TabIndex = 5;
            this.AddPartsInventory.Text = "Inventory";
            // 
            // AddPartsPriceCost
            // 
            this.AddPartsPriceCost.AutoSize = true;
            this.AddPartsPriceCost.Location = new System.Drawing.Point(118, 242);
            this.AddPartsPriceCost.Name = "AddPartsPriceCost";
            this.AddPartsPriceCost.Size = new System.Drawing.Size(63, 13);
            this.AddPartsPriceCost.TabIndex = 6;
            this.AddPartsPriceCost.Text = "Price / Cost";
            // 
            // AddPartsMax
            // 
            this.AddPartsMax.AutoSize = true;
            this.AddPartsMax.Location = new System.Drawing.Point(154, 289);
            this.AddPartsMax.Name = "AddPartsMax";
            this.AddPartsMax.Size = new System.Drawing.Size(27, 13);
            this.AddPartsMax.TabIndex = 7;
            this.AddPartsMax.Text = "Max";
            // 
            // AddPartsMin
            // 
            this.AddPartsMin.AutoSize = true;
            this.AddPartsMin.Location = new System.Drawing.Point(357, 289);
            this.AddPartsMin.Name = "AddPartsMin";
            this.AddPartsMin.Size = new System.Drawing.Size(24, 13);
            this.AddPartsMin.TabIndex = 8;
            this.AddPartsMin.Text = "Min";
            // 
            // AddPartsMachineORCompanyID
            // 
            this.AddPartsMachineORCompanyID.AutoSize = true;
            this.AddPartsMachineORCompanyID.Location = new System.Drawing.Point(119, 342);
            this.AddPartsMachineORCompanyID.Name = "AddPartsMachineORCompanyID";
            this.AddPartsMachineORCompanyID.Size = new System.Drawing.Size(62, 13);
            this.AddPartsMachineORCompanyID.TabIndex = 9;
            this.AddPartsMachineORCompanyID.Text = "Machine ID";
            // 
            // partNameTextBox
            // 
            this.partNameTextBox.Location = new System.Drawing.Point(202, 136);
            this.partNameTextBox.Name = "partNameTextBox";
            this.partNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.partNameTextBox.TabIndex = 11;
            // 
            // partInventoryTextBox
            // 
            this.partInventoryTextBox.Location = new System.Drawing.Point(202, 187);
            this.partInventoryTextBox.Name = "partInventoryTextBox";
            this.partInventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.partInventoryTextBox.TabIndex = 12;
            // 
            // partCostTextBox
            // 
            this.partCostTextBox.Location = new System.Drawing.Point(202, 239);
            this.partCostTextBox.Name = "partCostTextBox";
            this.partCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.partCostTextBox.TabIndex = 13;
            // 
            // partMaxTextBox
            // 
            this.partMaxTextBox.Location = new System.Drawing.Point(202, 286);
            this.partMaxTextBox.Name = "partMaxTextBox";
            this.partMaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.partMaxTextBox.TabIndex = 14;
            // 
            // partMinTextBox
            // 
            this.partMinTextBox.Location = new System.Drawing.Point(398, 286);
            this.partMinTextBox.Name = "partMinTextBox";
            this.partMinTextBox.Size = new System.Drawing.Size(100, 20);
            this.partMinTextBox.TabIndex = 15;
            // 
            // partMachineCompanyTextBox
            // 
            this.partMachineCompanyTextBox.Location = new System.Drawing.Point(202, 339);
            this.partMachineCompanyTextBox.Name = "partMachineCompanyTextBox";
            this.partMachineCompanyTextBox.Size = new System.Drawing.Size(100, 20);
            this.partMachineCompanyTextBox.TabIndex = 16;
            // 
            // AddPartSave
            // 
            this.AddPartSave.Location = new System.Drawing.Point(360, 391);
            this.AddPartSave.Name = "AddPartSave";
            this.AddPartSave.Size = new System.Drawing.Size(75, 23);
            this.AddPartSave.TabIndex = 17;
            this.AddPartSave.Text = "Save";
            this.AddPartSave.UseVisualStyleBackColor = true;
            this.AddPartSave.Click += new System.EventHandler(this.AddPartSave_Click);
            // 
            // AddPartCancel
            // 
            this.AddPartCancel.Location = new System.Drawing.Point(492, 391);
            this.AddPartCancel.Name = "AddPartCancel";
            this.AddPartCancel.Size = new System.Drawing.Size(75, 23);
            this.AddPartCancel.TabIndex = 18;
            this.AddPartCancel.Text = "Cancel";
            this.AddPartCancel.UseVisualStyleBackColor = true;
            this.AddPartCancel.Click += new System.EventHandler(this.AddPartCancel_Click);
            // 
            // partIDTextBox
            // 
            this.partIDTextBox.Location = new System.Drawing.Point(202, 84);
            this.partIDTextBox.Name = "partIDTextBox";
            this.partIDTextBox.ReadOnly = true;
            this.partIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.partIDTextBox.TabIndex = 19;
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.partIDTextBox);
            this.Controls.Add(this.AddPartCancel);
            this.Controls.Add(this.AddPartSave);
            this.Controls.Add(this.partMachineCompanyTextBox);
            this.Controls.Add(this.partMinTextBox);
            this.Controls.Add(this.partMaxTextBox);
            this.Controls.Add(this.partCostTextBox);
            this.Controls.Add(this.partInventoryTextBox);
            this.Controls.Add(this.partNameTextBox);
            this.Controls.Add(this.AddPartsMachineORCompanyID);
            this.Controls.Add(this.AddPartsMin);
            this.Controls.Add(this.AddPartsMax);
            this.Controls.Add(this.AddPartsPriceCost);
            this.Controls.Add(this.AddPartsInventory);
            this.Controls.Add(this.AddPartsName);
            this.Controls.Add(this.AddPartsID);
            this.Controls.Add(this.AddPartsORadio);
            this.Controls.Add(this.AddPartsIHRadio);
            this.Controls.Add(this.label1);
            this.Name = "AddPart";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton AddPartsIHRadio;
        private System.Windows.Forms.RadioButton AddPartsORadio;
        private System.Windows.Forms.Label AddPartsID;
        private System.Windows.Forms.Label AddPartsName;
        private System.Windows.Forms.Label AddPartsInventory;
        private System.Windows.Forms.Label AddPartsPriceCost;
        private System.Windows.Forms.Label AddPartsMax;
        private System.Windows.Forms.Label AddPartsMin;
        private System.Windows.Forms.Label AddPartsMachineORCompanyID;
        private System.Windows.Forms.TextBox partNameTextBox;
        private System.Windows.Forms.TextBox partInventoryTextBox;
        private System.Windows.Forms.TextBox partCostTextBox;
        private System.Windows.Forms.TextBox partMaxTextBox;
        private System.Windows.Forms.TextBox partMinTextBox;
        private System.Windows.Forms.TextBox partMachineCompanyTextBox;
        private System.Windows.Forms.Button AddPartSave;
        private System.Windows.Forms.Button AddPartCancel;
        private System.Windows.Forms.TextBox partIDTextBox;
    }
}