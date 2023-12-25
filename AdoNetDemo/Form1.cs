namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productDal.Add(new Product
                {
                    Name = tbxName.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    StockAmount = Convert.ToInt32(tbxStockAmount.Text),
                });
                LoadProducts();
                MessageBox.Show("Product Added!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Düzgün girsene değerleri kardeşim", exception.Message);
            }

        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                    Name = tbxNameUpdate.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                    StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
                };
                _productDal.Update(product);
                LoadProducts();
                MessageBox.Show("Updated!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Düzgün girsene değerleri kardeşim", exception.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Remove butonuna tiklaninca secili olan id'yi buldum
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            // ilgili id'yi sildik
            _productDal.Delete(id);
            // urunleri ekranda guncelledik
            LoadProducts();
            // ekranda Deleted yazdirdik
            MessageBox.Show("Deleted");
        }
    }
}