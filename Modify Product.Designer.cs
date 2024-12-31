namespace C968
{
    partial class ModifyProduct
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
            this.saveNewProductButton = new System.Windows.Forms.Button();
            this.cancelAddProductbutton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteAssociatedPartButton = new System.Windows.Forms.Button();
            this.modAssociatedPartsGrid = new System.Windows.Forms.DataGridView();
            this.addPartToItemButton = new System.Windows.Forms.Button();
            this.searchPartListButton = new System.Windows.Forms.Button();
            this.modPartSearchTextBox = new System.Windows.Forms.TextBox();
            this.modProductMinTextBox = new System.Windows.Forms.TextBox();
            this.modProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.modProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.modProductInventoryTextBox = new System.Windows.Forms.TextBox();
            this.modProductNameTextBox = new System.Windows.Forms.TextBox();
            this.modProductIDTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.modCandidatePartsGrid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modAssociatedPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modCandidatePartsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // saveNewProductButton
            // 
            this.saveNewProductButton.Location = new System.Drawing.Point(587, 482);
            this.saveNewProductButton.Name = "saveNewProductButton";
            this.saveNewProductButton.Size = new System.Drawing.Size(75, 23);
            this.saveNewProductButton.TabIndex = 67;
            this.saveNewProductButton.Text = "Save";
            this.saveNewProductButton.UseVisualStyleBackColor = true;
            this.saveNewProductButton.Click += new System.EventHandler(this.saveNewProductButton_Click);
            // 
            // cancelAddProductbutton
            // 
            this.cancelAddProductbutton.Location = new System.Drawing.Point(679, 482);
            this.cancelAddProductbutton.Name = "cancelAddProductbutton";
            this.cancelAddProductbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelAddProductbutton.TabIndex = 66;
            this.cancelAddProductbutton.Text = "Cancel";
            this.cancelAddProductbutton.UseVisualStyleBackColor = true;
            this.cancelAddProductbutton.Click += new System.EventHandler(this.cancelAddProductbutton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Parts Associated with this Product";
            // 
            // deleteAssociatedPartButton
            // 
            this.deleteAssociatedPartButton.Location = new System.Drawing.Point(697, 383);
            this.deleteAssociatedPartButton.Name = "deleteAssociatedPartButton";
            this.deleteAssociatedPartButton.Size = new System.Drawing.Size(59, 27);
            this.deleteAssociatedPartButton.TabIndex = 64;
            this.deleteAssociatedPartButton.Text = "Delete";
            this.deleteAssociatedPartButton.UseVisualStyleBackColor = true;
            this.deleteAssociatedPartButton.Click += new System.EventHandler(this.deleteAssociatedPartButton_Click);
            // 
            // modAssociatedPartsGrid
            // 
            this.modAssociatedPartsGrid.AllowUserToAddRows = false;
            this.modAssociatedPartsGrid.AllowUserToDeleteRows = false;
            this.modAssociatedPartsGrid.AllowUserToResizeColumns = false;
            this.modAssociatedPartsGrid.AllowUserToResizeRows = false;
            this.modAssociatedPartsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modAssociatedPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modAssociatedPartsGrid.Location = new System.Drawing.Point(330, 258);
            this.modAssociatedPartsGrid.Name = "modAssociatedPartsGrid";
            this.modAssociatedPartsGrid.RowHeadersVisible = false;
            this.modAssociatedPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modAssociatedPartsGrid.Size = new System.Drawing.Size(426, 119);
            this.modAssociatedPartsGrid.TabIndex = 63;
            // 
            // addPartToItemButton
            // 
            this.addPartToItemButton.Location = new System.Drawing.Point(698, 203);
            this.addPartToItemButton.Name = "addPartToItemButton";
            this.addPartToItemButton.Size = new System.Drawing.Size(58, 28);
            this.addPartToItemButton.TabIndex = 62;
            this.addPartToItemButton.Text = "Add";
            this.addPartToItemButton.UseVisualStyleBackColor = true;
            this.addPartToItemButton.Click += new System.EventHandler(this.addPartToItemButton_Click);
            // 
            // searchPartListButton
            // 
            this.searchPartListButton.Location = new System.Drawing.Point(517, 39);
            this.searchPartListButton.Name = "searchPartListButton";
            this.searchPartListButton.Size = new System.Drawing.Size(55, 20);
            this.searchPartListButton.TabIndex = 61;
            this.searchPartListButton.Text = "Search";
            this.searchPartListButton.UseVisualStyleBackColor = true;
            this.searchPartListButton.Click += new System.EventHandler(this.searchPartListButton_Click);
            // 
            // modPartSearchTextBox
            // 
            this.modPartSearchTextBox.Location = new System.Drawing.Point(587, 39);
            this.modPartSearchTextBox.Name = "modPartSearchTextBox";
            this.modPartSearchTextBox.Size = new System.Drawing.Size(168, 20);
            this.modPartSearchTextBox.TabIndex = 60;
            // 
            // modProductMinTextBox
            // 
            this.modProductMinTextBox.Location = new System.Drawing.Point(203, 296);
            this.modProductMinTextBox.Name = "modProductMinTextBox";
            this.modProductMinTextBox.Size = new System.Drawing.Size(56, 20);
            this.modProductMinTextBox.TabIndex = 59;
            // 
            // modProductMaxTextBox
            // 
            this.modProductMaxTextBox.Location = new System.Drawing.Point(116, 296);
            this.modProductMaxTextBox.Name = "modProductMaxTextBox";
            this.modProductMaxTextBox.Size = new System.Drawing.Size(51, 20);
            this.modProductMaxTextBox.TabIndex = 58;
            // 
            // modProductPriceTextBox
            // 
            this.modProductPriceTextBox.Location = new System.Drawing.Point(116, 264);
            this.modProductPriceTextBox.Name = "modProductPriceTextBox";
            this.modProductPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.modProductPriceTextBox.TabIndex = 57;
            // 
            // modProductInventoryTextBox
            // 
            this.modProductInventoryTextBox.Location = new System.Drawing.Point(116, 222);
            this.modProductInventoryTextBox.Name = "modProductInventoryTextBox";
            this.modProductInventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.modProductInventoryTextBox.TabIndex = 56;
            // 
            // modProductNameTextBox
            // 
            this.modProductNameTextBox.Location = new System.Drawing.Point(116, 182);
            this.modProductNameTextBox.Name = "modProductNameTextBox";
            this.modProductNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.modProductNameTextBox.TabIndex = 55;
            this.modProductNameTextBox.TextChanged += new System.EventHandler(this.modProductNameTextBox_TextChanged);
            // 
            // modProductIDTextBox
            // 
            this.modProductIDTextBox.Location = new System.Drawing.Point(116, 143);
            this.modProductIDTextBox.Name = "modProductIDTextBox";
            this.modProductIDTextBox.ReadOnly = true;
            this.modProductIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.modProductIDTextBox.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "All Candidate Parts";
            // 
            // modCandidatePartsGrid
            // 
            this.modCandidatePartsGrid.AllowUserToAddRows = false;
            this.modCandidatePartsGrid.AllowUserToDeleteRows = false;
            this.modCandidatePartsGrid.AllowUserToResizeColumns = false;
            this.modCandidatePartsGrid.AllowUserToResizeRows = false;
            this.modCandidatePartsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modCandidatePartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modCandidatePartsGrid.Location = new System.Drawing.Point(330, 78);
            this.modCandidatePartsGrid.Name = "modCandidatePartsGrid";
            this.modCandidatePartsGrid.RowHeadersVisible = false;
            this.modCandidatePartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modCandidatePartsGrid.Size = new System.Drawing.Size(426, 119);
            this.modCandidatePartsGrid.TabIndex = 52;
            this.modCandidatePartsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modCandidatePartsGrid_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "Modify Product";
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveNewProductButton);
            this.Controls.Add(this.cancelAddProductbutton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deleteAssociatedPartButton);
            this.Controls.Add(this.modAssociatedPartsGrid);
            this.Controls.Add(this.addPartToItemButton);
            this.Controls.Add(this.searchPartListButton);
            this.Controls.Add(this.modPartSearchTextBox);
            this.Controls.Add(this.modProductMinTextBox);
            this.Controls.Add(this.modProductMaxTextBox);
            this.Controls.Add(this.modProductPriceTextBox);
            this.Controls.Add(this.modProductInventoryTextBox);
            this.Controls.Add(this.modProductNameTextBox);
            this.Controls.Add(this.modProductIDTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.modCandidatePartsGrid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ModifyProduct";
            this.Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)(this.modAssociatedPartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modCandidatePartsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveNewProductButton;
        private System.Windows.Forms.Button cancelAddProductbutton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button deleteAssociatedPartButton;
        private System.Windows.Forms.DataGridView modAssociatedPartsGrid;
        private System.Windows.Forms.Button addPartToItemButton;
        private System.Windows.Forms.Button searchPartListButton;
        private System.Windows.Forms.TextBox modPartSearchTextBox;
        private System.Windows.Forms.TextBox modProductMinTextBox;
        private System.Windows.Forms.TextBox modProductMaxTextBox;
        private System.Windows.Forms.TextBox modProductPriceTextBox;
        private System.Windows.Forms.TextBox modProductInventoryTextBox;
        private System.Windows.Forms.TextBox modProductNameTextBox;
        private System.Windows.Forms.TextBox modProductIDTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView modCandidatePartsGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}