namespace C968
{
    partial class Root
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
            this.label2 = new System.Windows.Forms.Label();
            this.PartsSearchButtonRoot = new System.Windows.Forms.Button();
            this.PartsSearchBarRoot = new System.Windows.Forms.TextBox();
            this.partGridView = new System.Windows.Forms.DataGridView();
            this.AddPartRoot = new System.Windows.Forms.Button();
            this.ModifyPartRoot = new System.Windows.Forms.Button();
            this.DeletePartRoot = new System.Windows.Forms.Button();
            this.DeleteProductRoot = new System.Windows.Forms.Button();
            this.ModifyProductRoot = new System.Windows.Forms.Button();
            this.AddProductRoot = new System.Windows.Forms.Button();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.ProductsSearchBarRoot = new System.Windows.Forms.TextBox();
            this.ProductsSearchButtonRoot = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ExitRoot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventory Management";
            // 
            // PartsSearchButtonRoot
            // 
            this.PartsSearchButtonRoot.Location = new System.Drawing.Point(141, 73);
            this.PartsSearchButtonRoot.Name = "PartsSearchButtonRoot";
            this.PartsSearchButtonRoot.Size = new System.Drawing.Size(75, 23);
            this.PartsSearchButtonRoot.TabIndex = 2;
            this.PartsSearchButtonRoot.Text = "Search";
            this.PartsSearchButtonRoot.UseVisualStyleBackColor = true;
            this.PartsSearchButtonRoot.Click += new System.EventHandler(this.PartsSearchButtonRoot_Click);
            // 
            // PartsSearchBarRoot
            // 
            this.PartsSearchBarRoot.Location = new System.Drawing.Point(222, 76);
            this.PartsSearchBarRoot.Name = "PartsSearchBarRoot";
            this.PartsSearchBarRoot.Size = new System.Drawing.Size(189, 20);
            this.PartsSearchBarRoot.TabIndex = 3;
            // 
            // partGridView
            // 
            this.partGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partGridView.Location = new System.Drawing.Point(32, 120);
            this.partGridView.Name = "partGridView";
            this.partGridView.Size = new System.Drawing.Size(379, 218);
            this.partGridView.TabIndex = 4;
            // 
            // AddPartRoot
            // 
            this.AddPartRoot.Location = new System.Drawing.Point(174, 358);
            this.AddPartRoot.Name = "AddPartRoot";
            this.AddPartRoot.Size = new System.Drawing.Size(75, 23);
            this.AddPartRoot.TabIndex = 5;
            this.AddPartRoot.Text = "Add";
            this.AddPartRoot.UseVisualStyleBackColor = true;
            this.AddPartRoot.Click += new System.EventHandler(this.AddPartRoot_Click);
            // 
            // ModifyPartRoot
            // 
            this.ModifyPartRoot.Location = new System.Drawing.Point(255, 358);
            this.ModifyPartRoot.Name = "ModifyPartRoot";
            this.ModifyPartRoot.Size = new System.Drawing.Size(75, 23);
            this.ModifyPartRoot.TabIndex = 6;
            this.ModifyPartRoot.Text = "Modify";
            this.ModifyPartRoot.UseVisualStyleBackColor = true;
            this.ModifyPartRoot.Click += new System.EventHandler(this.ModifyPartRoot_Click);
            // 
            // DeletePartRoot
            // 
            this.DeletePartRoot.Location = new System.Drawing.Point(336, 358);
            this.DeletePartRoot.Name = "DeletePartRoot";
            this.DeletePartRoot.Size = new System.Drawing.Size(75, 23);
            this.DeletePartRoot.TabIndex = 7;
            this.DeletePartRoot.Text = "Delete";
            this.DeletePartRoot.UseVisualStyleBackColor = true;
            this.DeletePartRoot.Click += new System.EventHandler(this.DeletePartRoot_Click);
            // 
            // DeleteProductRoot
            // 
            this.DeleteProductRoot.Location = new System.Drawing.Point(772, 358);
            this.DeleteProductRoot.Name = "DeleteProductRoot";
            this.DeleteProductRoot.Size = new System.Drawing.Size(75, 23);
            this.DeleteProductRoot.TabIndex = 14;
            this.DeleteProductRoot.Text = "Delete";
            this.DeleteProductRoot.UseVisualStyleBackColor = true;
            this.DeleteProductRoot.Click += new System.EventHandler(this.DeleteProductRoot_Click);
            // 
            // ModifyProductRoot
            // 
            this.ModifyProductRoot.Location = new System.Drawing.Point(691, 358);
            this.ModifyProductRoot.Name = "ModifyProductRoot";
            this.ModifyProductRoot.Size = new System.Drawing.Size(75, 23);
            this.ModifyProductRoot.TabIndex = 13;
            this.ModifyProductRoot.Text = "Modify";
            this.ModifyProductRoot.UseVisualStyleBackColor = true;
            this.ModifyProductRoot.Click += new System.EventHandler(this.ModifyProductRoot_Click);
            // 
            // AddProductRoot
            // 
            this.AddProductRoot.Location = new System.Drawing.Point(610, 358);
            this.AddProductRoot.Name = "AddProductRoot";
            this.AddProductRoot.Size = new System.Drawing.Size(75, 23);
            this.AddProductRoot.TabIndex = 12;
            this.AddProductRoot.Text = "Add";
            this.AddProductRoot.UseVisualStyleBackColor = true;
            this.AddProductRoot.Click += new System.EventHandler(this.AddProductRoot_Click);
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToAddRows = false;
            this.productGridView.AllowUserToDeleteRows = false;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(468, 120);
            this.productGridView.Name = "productGridView";
            this.productGridView.Size = new System.Drawing.Size(379, 218);
            this.productGridView.TabIndex = 11;
            // 
            // ProductsSearchBarRoot
            // 
            this.ProductsSearchBarRoot.Location = new System.Drawing.Point(658, 76);
            this.ProductsSearchBarRoot.Name = "ProductsSearchBarRoot";
            this.ProductsSearchBarRoot.Size = new System.Drawing.Size(189, 20);
            this.ProductsSearchBarRoot.TabIndex = 10;
            // 
            // ProductsSearchButtonRoot
            // 
            this.ProductsSearchButtonRoot.Location = new System.Drawing.Point(577, 73);
            this.ProductsSearchButtonRoot.Name = "ProductsSearchButtonRoot";
            this.ProductsSearchButtonRoot.Size = new System.Drawing.Size(75, 23);
            this.ProductsSearchButtonRoot.TabIndex = 9;
            this.ProductsSearchButtonRoot.Text = "Search";
            this.ProductsSearchButtonRoot.UseVisualStyleBackColor = true;
            this.ProductsSearchButtonRoot.Click += new System.EventHandler(this.ProductsSearchButtonRoot_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Products";
            // 
            // ExitRoot
            // 
            this.ExitRoot.Location = new System.Drawing.Point(772, 415);
            this.ExitRoot.Name = "ExitRoot";
            this.ExitRoot.Size = new System.Drawing.Size(75, 23);
            this.ExitRoot.TabIndex = 15;
            this.ExitRoot.Text = "Exit";
            this.ExitRoot.UseVisualStyleBackColor = true;
            this.ExitRoot.Click += new System.EventHandler(this.ExitRoot_Click);
            // 
            // Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.ExitRoot);
            this.Controls.Add(this.DeleteProductRoot);
            this.Controls.Add(this.ModifyProductRoot);
            this.Controls.Add(this.AddProductRoot);
            this.Controls.Add(this.productGridView);
            this.Controls.Add(this.ProductsSearchBarRoot);
            this.Controls.Add(this.ProductsSearchButtonRoot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeletePartRoot);
            this.Controls.Add(this.ModifyPartRoot);
            this.Controls.Add(this.AddPartRoot);
            this.Controls.Add(this.partGridView);
            this.Controls.Add(this.PartsSearchBarRoot);
            this.Controls.Add(this.PartsSearchButtonRoot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Root";
            this.Text = "Inventory Management";
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PartsSearchButtonRoot;
        private System.Windows.Forms.TextBox PartsSearchBarRoot;
        private System.Windows.Forms.DataGridView partGridView;
        private System.Windows.Forms.Button AddPartRoot;
        private System.Windows.Forms.Button ModifyPartRoot;
        private System.Windows.Forms.Button DeletePartRoot;
        private System.Windows.Forms.Button DeleteProductRoot;
        private System.Windows.Forms.Button ModifyProductRoot;
        private System.Windows.Forms.Button AddProductRoot;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.TextBox ProductsSearchBarRoot;
        private System.Windows.Forms.Button ProductsSearchButtonRoot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExitRoot;
    }
}

