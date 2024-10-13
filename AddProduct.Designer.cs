namespace AddProductInventory
{
    partial class AddProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtProductName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtQuantity = new TextBox();
            txtSellPrice = new TextBox();
            cbCategory = new ComboBox();
            datePickerMfgDate = new DateTimePicker();
            datePickerExpDate = new DateTimePicker();
            richTxtDescription = new RichTextBox();
            label8 = new Label();
            gridViewProductList = new DataGridView();
            btnAddProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(110, 46);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(100, 25);
            txtProductName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 47);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 3;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 84);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 4;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 123);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 5;
            label4.Text = "Mfg. Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 161);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 6;
            label5.Text = "Exp. Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(72, 194);
            label6.Name = "label6";
            label6.Size = new Size(32, 17);
            label6.TabIndex = 7;
            label6.Text = "Qty.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(43, 228);
            label7.Name = "label7";
            label7.Size = new Size(61, 17);
            label7.TabIndex = 8;
            label7.Text = "Sell Price";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(110, 188);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 25);
            txtQuantity.TabIndex = 9;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSellPrice.Location = new Point(110, 222);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(100, 25);
            txtSellPrice.TabIndex = 10;
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(110, 83);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(121, 25);
            cbCategory.TabIndex = 11;
            cbCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // datePickerMfgDate
            // 
            datePickerMfgDate.Location = new Point(110, 119);
            datePickerMfgDate.Name = "datePickerMfgDate";
            datePickerMfgDate.Size = new Size(200, 23);
            datePickerMfgDate.TabIndex = 12;
            // 
            // datePickerExpDate
            // 
            datePickerExpDate.Location = new Point(110, 157);
            datePickerExpDate.Name = "datePickerExpDate";
            datePickerExpDate.Size = new Size(200, 23);
            datePickerExpDate.TabIndex = 13;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTxtDescription.Location = new Point(357, 91);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(388, 138);
            richTxtDescription.TabIndex = 14;
            richTxtDescription.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(357, 67);
            label8.Name = "label8";
            label8.Size = new Size(94, 21);
            label8.TabIndex = 15;
            label8.Text = "Description";
            label8.Click += label8_Click;
            // 
            // gridViewProductList
            // 
            gridViewProductList.BackgroundColor = Color.Maroon;
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(33, 279);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(712, 167);
            gridViewProductList.TabIndex = 16;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.Green;
            btnAddProduct.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(605, 235);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(140, 38);
            btnAddProduct.TabIndex = 17;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddProduct);
            Controls.Add(gridViewProductList);
            Controls.Add(label8);
            Controls.Add(richTxtDescription);
            Controls.Add(datePickerExpDate);
            Controls.Add(datePickerMfgDate);
            Controls.Add(cbCategory);
            Controls.Add(txtSellPrice);
            Controls.Add(txtQuantity);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            Name = "AddProduct";
            Text = "Inventory";
            Load += AddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtProductName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtQuantity;
        private TextBox txtSellPrice;
        private ComboBox cbCategory;
        private DateTimePicker datePickerMfgDate;
        private DateTimePicker datePickerExpDate;
        private RichTextBox richTxtDescription;
        private Label label8;
        private DataGridView gridViewProductList;
        private Button btnAddProduct;
    }
}
