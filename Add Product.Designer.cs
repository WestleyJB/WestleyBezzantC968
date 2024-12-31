namespace C968
{
    partial class AddProduct
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
            this.saveNewProductButton = new System.Windows.Forms.Button();
            this.cancelAddProductbutton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteAssociatedPartButton = new System.Windows.Forms.Button();
            this.addAssociatedPartsGrid = new System.Windows.Forms.DataGridView();
            this.addPartToItemButton = new System.Windows.Forms.Button();
            this.searchPartListButton = new System.Windows.Forms.Button();
            this.addPartSearchTextBox = new System.Windows.Forms.TextBox();
            this.addProductMinTextBox = new System.Windows.Forms.TextBox();
            this.addProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.addProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.addProductInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addProductNameTextBox = new System.Windows.Forms.TextBox();
            this.addProductIDTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addCandidatePartsGrid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addAssociatedPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCandidatePartsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 91;
            this.label2.Text = "Add Product";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // saveNewProductButton
            // 
            this.saveNewProductButton.Location = new System.Drawing.Point(605, 456);
            this.saveNewProductButton.Name = "saveNewProductButton";
            this.saveNewProductButton.Size = new System.Drawing.Size(75, 23);
            this.saveNewProductButton.TabIndex = 90;
            this.saveNewProductButton.Text = "Save";
            this.saveNewProductButton.UseVisualStyleBackColor = true;
            this.saveNewProductButton.Click += new System.EventHandler(this.saveNewProductButton_Click);
            // 
            // cancelAddProductbutton
            // 
            this.cancelAddProductbutton.Location = new System.Drawing.Point(697, 456);
            this.cancelAddProductbutton.Name = "cancelAddProductbutton";
            this.cancelAddProductbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelAddProductbutton.TabIndex = 89;
            this.cancelAddProductbutton.Text = "Cancel";
            this.cancelAddProductbutton.UseVisualStyleBackColor = true;
            this.cancelAddProductbutton.Click += new System.EventHandler(this.cancelAddProductbutton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 88;
            this.label9.Text = "Parts Associated with this Product";
            // 
            // deleteAssociatedPartButton
            // 
            this.deleteAssociatedPartButton.Location = new System.Drawing.Point(715, 357);
            this.deleteAssociatedPartButton.Name = "deleteAssociatedPartButton";
            this.deleteAssociatedPartButton.Size = new System.Drawing.Size(59, 27);
            this.deleteAssociatedPartButton.TabIndex = 87;
            this.deleteAssociatedPartButton.Text = "Delete";
            this.deleteAssociatedPartButton.UseVisualStyleBackColor = true;
            this.deleteAssociatedPartButton.Click += new System.EventHandler(this.deleteAssociatedPartButton_Click);
            // 
            // addAssociatedPartsGrid
            // 
            this.addAssociatedPartsGrid.AllowUserToAddRows = false;
            this.addAssociatedPartsGrid.AllowUserToDeleteRows = false;
            this.addAssociatedPartsGrid.AllowUserToResizeColumns = false;
            this.addAssociatedPartsGrid.AllowUserToResizeRows = false;
            this.addAssociatedPartsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addAssociatedPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addAssociatedPartsGrid.Location = new System.Drawing.Point(348, 232);
            this.addAssociatedPartsGrid.Name = "addAssociatedPartsGrid";
            this.addAssociatedPartsGrid.RowHeadersVisible = false;
            this.addAssociatedPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addAssociatedPartsGrid.Size = new System.Drawing.Size(426, 119);
            this.addAssociatedPartsGrid.TabIndex = 86;
            this.addAssociatedPartsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addAssociatedPartsGrid_CellContentClick);
            // 
            // addPartToItemButton
            // 
            this.addPartToItemButton.Location = new System.Drawing.Point(716, 177);
            this.addPartToItemButton.Name = "addPartToItemButton";
            this.addPartToItemButton.Size = new System.Drawing.Size(58, 28);
            this.addPartToItemButton.TabIndex = 85;
            this.addPartToItemButton.Text = "Add";
            this.addPartToItemButton.UseVisualStyleBackColor = true;
            this.addPartToItemButton.Click += new System.EventHandler(this.addPartToItemButton_Click);
            // 
            // searchPartListButton
            // 
            this.searchPartListButton.Location = new System.Drawing.Point(535, 13);
            this.searchPartListButton.Name = "searchPartListButton";
            this.searchPartListButton.Size = new System.Drawing.Size(55, 20);
            this.searchPartListButton.TabIndex = 84;
            this.searchPartListButton.Text = "Search";
            this.searchPartListButton.UseVisualStyleBackColor = true;
            this.searchPartListButton.Click += new System.EventHandler(this.searchPartListButton_Click);
            // 
            // addPartSearchTextBox
            // 
            this.addPartSearchTextBox.Location = new System.Drawing.Point(605, 13);
            this.addPartSearchTextBox.Name = "addPartSearchTextBox";
            this.addPartSearchTextBox.Size = new System.Drawing.Size(168, 20);
            this.addPartSearchTextBox.TabIndex = 83;
            // 
            // addProductMinTextBox
            // 
            this.addProductMinTextBox.Location = new System.Drawing.Point(221, 270);
            this.addProductMinTextBox.Name = "addProductMinTextBox";
            this.addProductMinTextBox.Size = new System.Drawing.Size(56, 20);
            this.addProductMinTextBox.TabIndex = 82;
            // 
            // addProductMaxTextBox
            // 
            this.addProductMaxTextBox.Location = new System.Drawing.Point(134, 270);
            this.addProductMaxTextBox.Name = "addProductMaxTextBox";
            this.addProductMaxTextBox.Size = new System.Drawing.Size(51, 20);
            this.addProductMaxTextBox.TabIndex = 81;
            // 
            // addProductPriceTextBox
            // 
            this.addProductPriceTextBox.Location = new System.Drawing.Point(134, 238);
            this.addProductPriceTextBox.Name = "addProductPriceTextBox";
            this.addProductPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.addProductPriceTextBox.TabIndex = 80;
            // 
            // addProductInventoryTextBox
            // 
            this.addProductInventoryTextBox.Location = new System.Drawing.Point(134, 196);
            this.addProductInventoryTextBox.Name = "addProductInventoryTextBox";
            this.addProductInventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.addProductInventoryTextBox.TabIndex = 79;
            // 
            // addProductNameTextBox
            // 
            this.addProductNameTextBox.Location = new System.Drawing.Point(134, 156);
            this.addProductNameTextBox.Name = "addProductNameTextBox";
            this.addProductNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.addProductNameTextBox.TabIndex = 78;
            // 
            // addProductIDTextBox
            // 
            this.addProductIDTextBox.Location = new System.Drawing.Point(134, 117);
            this.addProductIDTextBox.Name = "addProductIDTextBox";
            this.addProductIDTextBox.ReadOnly = true;
            this.addProductIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.addProductIDTextBox.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "All Candidate Parts";
            // 
            // addCandidatePartsGrid
            // 
            this.addCandidatePartsGrid.AllowUserToAddRows = false;
            this.addCandidatePartsGrid.AllowUserToDeleteRows = false;
            this.addCandidatePartsGrid.AllowUserToResizeColumns = false;
            this.addCandidatePartsGrid.AllowUserToResizeRows = false;
            this.addCandidatePartsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addCandidatePartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addCandidatePartsGrid.Location = new System.Drawing.Point(348, 52);
            this.addCandidatePartsGrid.Name = "addCandidatePartsGrid";
            this.addCandidatePartsGrid.RowHeadersVisible = false;
            this.addCandidatePartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addCandidatePartsGrid.Size = new System.Drawing.Size(426, 119);
            this.addCandidatePartsGrid.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "ID";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveNewProductButton);
            this.Controls.Add(this.cancelAddProductbutton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deleteAssociatedPartButton);
            this.Controls.Add(this.addAssociatedPartsGrid);
            this.Controls.Add(this.addPartToItemButton);
            this.Controls.Add(this.searchPartListButton);
            this.Controls.Add(this.addPartSearchTextBox);
            this.Controls.Add(this.addProductMinTextBox);
            this.Controls.Add(this.addProductMaxTextBox);
            this.Controls.Add(this.addProductPriceTextBox);
            this.Controls.Add(this.addProductInventoryTextBox);
            this.Controls.Add(this.addProductNameTextBox);
            this.Controls.Add(this.addProductIDTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addCandidatePartsGrid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.addAssociatedPartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCandidatePartsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveNewProductButton;
        private System.Windows.Forms.Button cancelAddProductbutton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button deleteAssociatedPartButton;
        private System.Windows.Forms.DataGridView addAssociatedPartsGrid;
        private System.Windows.Forms.Button addPartToItemButton;
        private System.Windows.Forms.Button searchPartListButton;
        private System.Windows.Forms.TextBox addPartSearchTextBox;
        private System.Windows.Forms.TextBox addProductMinTextBox;
        private System.Windows.Forms.TextBox addProductMaxTextBox;
        private System.Windows.Forms.TextBox addProductPriceTextBox;
        private System.Windows.Forms.TextBox addProductInventoryTextBox;
        private System.Windows.Forms.TextBox addProductNameTextBox;
        private System.Windows.Forms.TextBox addProductIDTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView addCandidatePartsGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}