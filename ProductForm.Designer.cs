namespace OOP_PROJECT_IC_ST82417
{
    partial class ProductForm
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
            this.price_text = new System.Windows.Forms.Panel();
            this.dataGridView_products = new System.Windows.Forms.DataGridView();
            this.refresh_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filter_combox = new System.Windows.Forms.ComboBox();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.category_combox = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.Label();
            this.price_input = new System.Windows.Forms.TextBox();
            this.qa_input = new System.Windows.Forms.TextBox();
            this.name_input = new System.Windows.Forms.TextBox();
            this.id_input = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.category_navbar = new System.Windows.Forms.Button();
            this.price_text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            this.SuspendLayout();
            // 
            // price_text
            // 
            this.price_text.Controls.Add(this.dataGridView_products);
            this.price_text.Controls.Add(this.refresh_button);
            this.price_text.Controls.Add(this.label1);
            this.price_text.Controls.Add(this.filter_combox);
            this.price_text.Controls.Add(this.Delete_button);
            this.price_text.Controls.Add(this.Update_button);
            this.price_text.Controls.Add(this.add_button);
            this.price_text.Controls.Add(this.category_combox);
            this.price_text.Controls.Add(this.Category);
            this.price_text.Controls.Add(this.price_input);
            this.price_text.Controls.Add(this.qa_input);
            this.price_text.Controls.Add(this.name_input);
            this.price_text.Controls.Add(this.id_input);
            this.price_text.Controls.Add(this.price);
            this.price_text.Controls.Add(this.quantity);
            this.price_text.Controls.Add(this.name);
            this.price_text.Controls.Add(this.id);
            this.price_text.Location = new System.Drawing.Point(236, 33);
            this.price_text.Name = "price_text";
            this.price_text.Size = new System.Drawing.Size(1009, 636);
            this.price_text.TabIndex = 1;
            // 
            // dataGridView_products
            // 
            this.dataGridView_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_products.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_products.Location = new System.Drawing.Point(371, 82);
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.Size = new System.Drawing.Size(602, 514);
            this.dataGridView_products.TabIndex = 18;
            this.refresh_button.Location = new System.Drawing.Point(791, 36);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(75, 23);
            this.refresh_button.TabIndex = 17;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Manage Products";
            // 
            // filter_combox
            // 
            this.filter_combox.FormattingEnabled = true;
            this.filter_combox.Location = new System.Drawing.Point(508, 33);
            this.filter_combox.Name = "filter_combox";
            this.filter_combox.Size = new System.Drawing.Size(240, 26);
            this.filter_combox.TabIndex = 14;
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(268, 378);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 13;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(153, 378);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 23);
            this.Update_button.TabIndex = 12;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(48, 378);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 11;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // category_combox
            // 
            this.category_combox.FormattingEnabled = true;
            this.category_combox.Location = new System.Drawing.Point(119, 282);
            this.category_combox.Name = "category_combox";
            this.category_combox.Size = new System.Drawing.Size(173, 26);
            this.category_combox.TabIndex = 10;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(45, 285);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(68, 18);
            this.Category.TabIndex = 8;
            this.Category.Text = "Category";
            // 
            // price_input
            // 
            this.price_input.Location = new System.Drawing.Point(119, 229);
            this.price_input.Name = "price_input";
            this.price_input.Size = new System.Drawing.Size(173, 24);
            this.price_input.TabIndex = 7;
            // 
            // qa_input
            // 
            this.qa_input.Location = new System.Drawing.Point(119, 167);
            this.qa_input.Name = "qa_input";
            this.qa_input.Size = new System.Drawing.Size(173, 24);
            this.qa_input.TabIndex = 6;
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(119, 110);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(173, 24);
            this.name_input.TabIndex = 5;
            // 
            // id_input
            // 
            this.id_input.Location = new System.Drawing.Point(119, 55);
            this.id_input.Name = "id_input";
            this.id_input.Size = new System.Drawing.Size(173, 24);
            this.id_input.TabIndex = 4;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(45, 229);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(40, 18);
            this.price.TabIndex = 3;
            this.price.Text = "price";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(45, 167);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(58, 18);
            this.quantity.TabIndex = 2;
            this.quantity.Text = "quantity";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(45, 110);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 18);
            this.name.TabIndex = 1;
            this.name.Text = "name\r\n";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(45, 55);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(19, 18);
            this.id.TabIndex = 0;
            this.id.Text = "id";
            // 
            // category_navbar
            // 
            this.category_navbar.Location = new System.Drawing.Point(36, 145);
            this.category_navbar.Name = "category_navbar";
            this.category_navbar.Size = new System.Drawing.Size(124, 73);
            this.category_navbar.TabIndex = 18;
            this.category_navbar.Text = "Category";
            this.category_navbar.UseVisualStyleBackColor = true;
            this.category_navbar.Click += new System.EventHandler(this.category_navbar_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 695);
            this.Controls.Add(this.category_navbar);
            this.Controls.Add(this.price_text);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.price_text.ResumeLayout(false);
            this.price_text.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel price_text;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox price_input;
        private System.Windows.Forms.TextBox qa_input;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.TextBox id_input;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.ComboBox category_combox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filter_combox;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button category_navbar;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.DataGridView dataGridView_products;
    }
}