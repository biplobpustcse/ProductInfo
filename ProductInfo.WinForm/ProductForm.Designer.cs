namespace ProductInfo.WinForm
{
    partial class ProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtProductName = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblName = new Label();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblProductList = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(436, 200);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(56, 242);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(168, 23);
            txtProductName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 282);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 30);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(105, 282);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 30);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(200, 282);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 245);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 5;
            lblName.Text = "Name:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(235, 242);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(272, 245);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(127, 23);
            txtPrice.TabIndex = 7;
            // 
            // lblProductList
            // 
            lblProductList.AutoSize = true;
            lblProductList.BackColor = SystemColors.Menu;
            lblProductList.Font = new Font("Segoe UI", 10F);
            lblProductList.Location = new Point(12, 9);
            lblProductList.Name = "lblProductList";
            lblProductList.Size = new Size(85, 19);
            lblProductList.TabIndex = 8;
            lblProductList.Text = "Product List:";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 323);
            Controls.Add(lblProductList);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtProductName);
            Controls.Add(dataGridView1);
            Name = "ProductForm";
            Text = "Product Management";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblName;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblProductList;
    }
}
