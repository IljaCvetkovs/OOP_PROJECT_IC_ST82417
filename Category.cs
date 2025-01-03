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
    public partial class Category : Form
    {
        DBClient db = DBClient.Instance;
        public Category()
        {
            InitializeComponent();
            get_data();
        }

        private void get_data()
        {
            string selectQuery = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuery, db.getCon());
            db.openCon();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_category.DataSource = table;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try {
                string insertQuery = "INSERT INTO Category VALUES ('" + name_text.Text + "','" + description_text.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, db.getCon());
                db.openCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category added successfully");
                db.closeCon();
                get_data();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> updates = new List<string>();
                string name = name_text.Text;
                string description = description_text.Text;
                string id = id_text.Text;
                if (!string.IsNullOrEmpty(name)){ updates.Add("name = '" + name + "'");}
                if (!string.IsNullOrEmpty(description)){updates.Add("description = '" + description + "'");}
                string update_query = "UPDATE Category SET " + string.Join(",", updates) + " WHERE id=" + id;
                SqlCommand command = new SqlCommand(update_query, db.getCon());
                db.openCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category deleted successfully");
                db.closeCon();
                get_data();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "DELETE FROM Category WHERE id=" + id_text.Text;
                SqlCommand command = new SqlCommand(delete, db.getCon());
                db.openCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category deleted successfully");
                db.closeCon();
                get_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void product_navbar_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }
    }
}
