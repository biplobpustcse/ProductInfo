using ProductInfo.BLL;
using ProductInfo.Models;

namespace ProductInfo.WinForm
{
    public partial class ProductForm : Form
    {
        private readonly IProductService _service;

        public ProductForm(IProductService service)
        {
            InitializeComponent();
            _service = service;
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = _service.GetProducts().ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var product = new Product { Name = txtProductName.Text,Price = Convert.ToDecimal(txtPrice.Text) };
            _service.AddProduct(product);
            LoadData();
            txtProductName.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                var product = new Product { Id = id, Name = txtProductName.Text, Price = Convert.ToDecimal(txtPrice.Text) };
                _service.UpdateProduct(product);
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a product to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                _service.DeleteProduct(id);
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtProductName.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            }
        }
    }
}
