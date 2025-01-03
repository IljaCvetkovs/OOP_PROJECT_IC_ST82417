using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOP_PROJECT_IC_ST82417
{
    public partial class ProductForm : Form
    {
        DBClient db = DBClient.Instance;

        public ProductForm()
        {
            InitializeComponent();
            get_data();
            get_category();
        }

        private void get_data()
        {
            string selectQuery = "SELECT * FROM Products";
            SqlCommand command = new SqlCommand(selectQuery, db.getCon());
            db.openCon();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_products.DataSource = table;
        }

        private void get_category()
        {
            string selectQuery = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuery, db.getCon());
            db.openCon();
           SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            category_combox.DataSource = table;
            category_combox.DisplayMember = "name";
            category_combox.ValueMember = "name";
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Products (name, price, quantity, category) VALUES ('" + name_input.Text + "','" + price_input.Text + "','" + qa_input.Text + "','" + category_combox.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, db.getCon());
                db.openCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product added successfully");
                db.closeCon();
                get_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> updates = new List<string>();
                string name = name_input.Text;
                string price = price_input.Text;
                string quantity = qa_input.Text;
                string category = category_combox.Text;
                string id = id_input.Text;
                if (!string.IsNullOrEmpty(name)) { updates.Add("name = '" + name + "'"); }
                if (!string.IsNullOrEmpty(price)) { updates.Add("price = '" + price + "'"); }
                if (!string.IsNullOrEmpty(quantity)) { updates.Add("quantity = '" + quantity + "'"); }
                if (!string.IsNullOrEmpty(category)) { updates.Add("category = '" + category + "'"); }
                string update_query = "UPDATE Products SET " + string.Join(",", updates) + " WHERE Id=" + id;
                SqlCommand command = new SqlCommand(update_query, db.getCon());
                db.openCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product updated successfully");
                db.closeCon();
                get_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "DELETE FROM Products WHERE Id=" + id_input.Text;
                SqlCommand command = new SqlCommand(delete, db.getCon());
                db.openCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product deleted successfully");
                db.closeCon();
                get_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void category_navbar_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }
    }
}
