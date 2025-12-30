using CSharpEgitimKampi501.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi501
    {
    public partial class Form1 :Form
        {
        public Form1()
            {
            InitializeComponent();
            }

        private void Form1_Load(object sender,EventArgs e)
            {

            }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KM10E7C;Initial Catalog=EgitimKampi501Db;Integrated Security=True");
        private async void BtnList_Click(object sender,EventArgs e)
            {
            string query = "Select * From TblProduct";
            var value = await connection.QueryAsync<ResultProductDto>(query);
            dataGridView1.DataSource = value;
            }

        private async void btnAdd_Click(object sender,EventArgs e)
            {
            string query = "insert into TblProduct (ProductName,ProductStock,ProductPrice,productCategory) values (@ProductName,@ProductStock,@ProductPrice,@ProductCategory)";
            var parameters = new DynamicParameters();
            parameters.Add("@ProductName",txtProductName.Text);
            parameters.Add("@ProductStock",txtProductStoce.Text);
            parameters.Add("@ProductPrice",txtProductPrice.Text);
            parameters.Add("productCategory",txtProductCategory.Text);

            await connection.ExecuteAsync(query,parameters);
            MessageBox.Show("Ürün Eklendi");
            }

        private async void btn_Delete_Click(object sender,EventArgs e)
            {
            string query = "Delete From TblProduct where ProductId=@ProductId";
            var parameters = new DynamicParameters();
            parameters.Add("@ProductId",int.Parse(txtProductID.Text));
            await connection.ExecuteAsync(query,parameters);
            MessageBox.Show("Ürün Silindi");
            }

        private async void btn_Update_Click(object sender,EventArgs e)
            {
            string query = "Update TblProduct Set ProductName = @ProductName, ProductPrice = @ProductPrice, ProductStock = @ProductStock, ProductCategory = @productCategory where ProductId = @ProductId";
            var parameters = new DynamicParameters();
            parameters.Add("@ProductName",txtProductName.Text);
            parameters.Add("@ProductStock",txtProductStoce.Text);
            parameters.Add("@ProductPrice",txtProductPrice.Text);
            parameters.Add("@ProductCategory",txtProductCategory.Text);
            parameters.Add("@ProductId",int.Parse(txtProductID.Text));
            await connection.ExecuteAsync(query,parameters);
            MessageBox.Show("Ürün Güncellendi", "Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
