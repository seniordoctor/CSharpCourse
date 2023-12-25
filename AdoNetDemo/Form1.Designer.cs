namespace AdoNetDemo
{
    partial class Form1
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
            dgwProducts = new DataGridView();
            lblName = new Label();
            tbxName = new TextBox();
            unitPrice = new Label();
            tbxUnitPrice = new TextBox();
            lblStockAmount = new Label();
            tbxStockAmount = new TextBox();
            gbxAdd = new GroupBox();
            btnAdd = new Button();
            gbxUpdate = new GroupBox();
            btnUpdate = new Button();
            tbxUnitPriceUpdate = new TextBox();
            tbxStockAmountUpdate = new TextBox();
            lblNameUpdate = new Label();
            lblStockAmountUpdate = new Label();
            tbxNameUpdate = new TextBox();
            lblUnitPriceUpdate = new Label();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            gbxAdd.SuspendLayout();
            gbxUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // dgwProducts
            // 
            dgwProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(29, 42);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowTemplate.Height = 25;
            dgwProducts.Size = new Size(971, 174);
            dgwProducts.TabIndex = 0;
            dgwProducts.CellClick += dgwProducts_CellClick;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(28, 39);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 14);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(149, 36);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(129, 22);
            tbxName.TabIndex = 2;
            // 
            // unitPrice
            // 
            unitPrice.AutoSize = true;
            unitPrice.Location = new Point(28, 79);
            unitPrice.Name = "unitPrice";
            unitPrice.Size = new Size(59, 14);
            unitPrice.TabIndex = 3;
            unitPrice.Text = "Unit Price";
            // 
            // tbxUnitPrice
            // 
            tbxUnitPrice.Location = new Point(149, 76);
            tbxUnitPrice.Name = "tbxUnitPrice";
            tbxUnitPrice.Size = new Size(129, 22);
            tbxUnitPrice.TabIndex = 4;
            // 
            // lblStockAmount
            // 
            lblStockAmount.AutoSize = true;
            lblStockAmount.Location = new Point(28, 117);
            lblStockAmount.Name = "lblStockAmount";
            lblStockAmount.Size = new Size(86, 14);
            lblStockAmount.TabIndex = 5;
            lblStockAmount.Text = "Stock Amount";
            // 
            // tbxStockAmount
            // 
            tbxStockAmount.Location = new Point(149, 114);
            tbxStockAmount.Name = "tbxStockAmount";
            tbxStockAmount.Size = new Size(129, 22);
            tbxStockAmount.TabIndex = 6;
            // 
            // gbxAdd
            // 
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(tbxUnitPrice);
            gbxAdd.Controls.Add(tbxStockAmount);
            gbxAdd.Controls.Add(lblName);
            gbxAdd.Controls.Add(lblStockAmount);
            gbxAdd.Controls.Add(tbxName);
            gbxAdd.Controls.Add(unitPrice);
            gbxAdd.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbxAdd.Location = new Point(29, 264);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(284, 190);
            gbxAdd.TabIndex = 7;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "Add a product";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(149, 162);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 22);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbxUpdate
            // 
            gbxUpdate.Controls.Add(btnUpdate);
            gbxUpdate.Controls.Add(tbxUnitPriceUpdate);
            gbxUpdate.Controls.Add(tbxStockAmountUpdate);
            gbxUpdate.Controls.Add(lblNameUpdate);
            gbxUpdate.Controls.Add(lblStockAmountUpdate);
            gbxUpdate.Controls.Add(tbxNameUpdate);
            gbxUpdate.Controls.Add(lblUnitPriceUpdate);
            gbxUpdate.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbxUpdate.Location = new Point(535, 264);
            gbxUpdate.Name = "gbxUpdate";
            gbxUpdate.Size = new Size(284, 190);
            gbxUpdate.TabIndex = 8;
            gbxUpdate.TabStop = false;
            gbxUpdate.Text = "Update a product";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(149, 162);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 22);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbxUnitPriceUpdate
            // 
            tbxUnitPriceUpdate.Location = new Point(149, 76);
            tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            tbxUnitPriceUpdate.Size = new Size(129, 22);
            tbxUnitPriceUpdate.TabIndex = 4;
            // 
            // tbxStockAmountUpdate
            // 
            tbxStockAmountUpdate.Location = new Point(149, 114);
            tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            tbxStockAmountUpdate.Size = new Size(129, 22);
            tbxStockAmountUpdate.TabIndex = 6;
            // 
            // lblNameUpdate
            // 
            lblNameUpdate.AutoSize = true;
            lblNameUpdate.Location = new Point(28, 39);
            lblNameUpdate.Name = "lblNameUpdate";
            lblNameUpdate.Size = new Size(38, 14);
            lblNameUpdate.TabIndex = 1;
            lblNameUpdate.Text = "Name";
            // 
            // lblStockAmountUpdate
            // 
            lblStockAmountUpdate.AutoSize = true;
            lblStockAmountUpdate.Location = new Point(28, 117);
            lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            lblStockAmountUpdate.Size = new Size(86, 14);
            lblStockAmountUpdate.TabIndex = 5;
            lblStockAmountUpdate.Text = "Stock Amount";
            // 
            // tbxNameUpdate
            // 
            tbxNameUpdate.Location = new Point(149, 36);
            tbxNameUpdate.Name = "tbxNameUpdate";
            tbxNameUpdate.Size = new Size(129, 22);
            tbxNameUpdate.TabIndex = 2;
            // 
            // lblUnitPriceUpdate
            // 
            lblUnitPriceUpdate.AutoSize = true;
            lblUnitPriceUpdate.Location = new Point(28, 79);
            lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            lblUnitPriceUpdate.Size = new Size(59, 14);
            lblUnitPriceUpdate.TabIndex = 3;
            lblUnitPriceUpdate.Text = "Unit Price";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(871, 264);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(129, 23);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 548);
            Controls.Add(btnRemove);
            Controls.Add(gbxUpdate);
            Controls.Add(gbxAdd);
            Controls.Add(dgwProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            gbxUpdate.ResumeLayout(false);
            gbxUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwProducts;
        private Label lblName;
        private TextBox tbxName;
        private Label unitPrice;
        private TextBox tbxUnitPrice;
        private Label lblStockAmount;
        private TextBox tbxStockAmount;
        private GroupBox gbxAdd;
        private Button btnAdd;
        private GroupBox gbxUpdate;
        private Button btnUpdate;
        private TextBox tbxUnitPriceUpdate;
        private TextBox tbxStockAmountUpdate;
        private Label lblNameUpdate;
        private Label lblStockAmountUpdate;
        private TextBox tbxNameUpdate;
        private Label lblUnitPriceUpdate;
        private Button btnRemove;
    }
}