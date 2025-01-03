namespace OOP_PROJECT_IC_ST82417
{
    partial class Category
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
            this.product_navbar = new System.Windows.Forms.Button();
            this.price_text = new System.Windows.Forms.Panel();
            this.dataGridView_category = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.description_text = new System.Windows.Forms.TextBox();
            this.name_text = new System.Windows.Forms.TextBox();
            this.id_text = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.price_text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).BeginInit();
            this.SuspendLayout();
            // 
            // product_navbar
            // 
            this.product_navbar.Location = new System.Drawing.Point(56, 141);
            this.product_navbar.Name = "product_navbar";
            this.product_navbar.Size = new System.Drawing.Size(124, 73);
            this.product_navbar.TabIndex = 22;
            this.product_navbar.Text = "Product";
            this.product_navbar.UseVisualStyleBackColor = true;
            this.product_navbar.Click += new System.EventHandler(this.product_navbar_Click);
            // 
            // price_text
            // 
            this.price_text.Controls.Add(this.dataGridView_category);
            this.price_text.Controls.Add(this.label1);
            this.price_text.Controls.Add(this.Delete_button);
            this.price_text.Controls.Add(this.Update_button);
            this.price_text.Controls.Add(this.add_button);
            this.price_text.Controls.Add(this.description_text);
            this.price_text.Controls.Add(this.name_text);
            this.price_text.Controls.Add(this.id_text);
            this.price_text.Controls.Add(this.description);
            this.price_text.Controls.Add(this.name);
            this.price_text.Controls.Add(this.id);
            this.price_text.Location = new System.Drawing.Point(258, 29);
            this.price_text.Name = "price_text";
            this.price_text.Size = new System.Drawing.Size(1009, 636);
            this.price_text.TabIndex = 20;
            // 
            // dataGridView_category
            // 
            this.dataGridView_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_category.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_category.Location = new System.Drawing.Point(367, 81);
            this.dataGridView_category.Name = "dataGridView_category";
            this.dataGridView_category.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_category.Size = new System.Drawing.Size(602, 514);
            this.dataGridView_category.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Manage Categories";
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(250, 254);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 13;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(144, 254);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 23);
            this.Update_button.TabIndex = 12;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(48, 254);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 11;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // description_text
            // 
            this.description_text.Location = new System.Drawing.Point(119, 167);
            this.description_text.Name = "description_text";
            this.description_text.Size = new System.Drawing.Size(173, 20);
            this.description_text.TabIndex = 6;
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(119, 110);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(173, 20);
            this.name_text.TabIndex = 5;
            // 
            // id_text
            // 
            this.id_text.Location = new System.Drawing.Point(119, 55);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(173, 20);
            this.id_text.TabIndex = 4;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(45, 167);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(58, 13);
            this.description.TabIndex = 2;
            this.description.Text = "description";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(45, 110);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 1;
            this.name.Text = "name\r\n";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(45, 55);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(15, 13);
            this.id.TabIndex = 0;
            this.id.Text = "id";
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(56, 570);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(124, 73);
            this.logout.TabIndex = 24;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 695);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.product_navbar);
            this.Controls.Add(this.price_text);
            this.Name = "Category";
            this.Text = "Category";
            this.price_text.ResumeLayout(false);
            this.price_text.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button product_navbar;
        private System.Windows.Forms.Panel price_text;
        private System.Windows.Forms.DataGridView dataGridView_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox description_text;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button logout;
    }
}