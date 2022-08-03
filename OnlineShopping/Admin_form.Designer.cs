
namespace OnlineShopping
{
    partial class Admin_form
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
            this.label5 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.t1 = new System.Windows.Forms.TabPage();
            this.add = new System.Windows.Forms.Button();
            this.add_category_item = new System.Windows.Forms.TextBox();
            this.add_price_item = new System.Windows.Forms.TextBox();
            this.add_des_item = new System.Windows.Forms.TextBox();
            this.add_name_item = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t0 = new System.Windows.Forms.TabPage();
            this.Find_button = new System.Windows.Forms.Button();
            this.view_category = new System.Windows.Forms.TextBox();
            this.view_description = new System.Windows.Forms.TextBox();
            this.view_price = new System.Windows.Forms.TextBox();
            this.view_item_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.TabPage();
            this.change_button = new System.Windows.Forms.Button();
            this.newval = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.edit_text = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.t3 = new System.Windows.Forms.TabPage();
            this.delete_text = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.t1.SuspendLayout();
            this.t0.SuspendLayout();
            this.t2.SuspendLayout();
            this.t3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Item Name";
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(181, 151);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(218, 53);
            this.delete_button.TabIndex = 17;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.t1);
            this.tabControl1.Controls.Add(this.t0);
            this.tabControl1.Controls.Add(this.t2);
            this.tabControl1.Controls.Add(this.t3);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 458);
            this.tabControl1.TabIndex = 2;
            // 
            // t1
            // 
            this.t1.Controls.Add(this.add);
            this.t1.Controls.Add(this.add_category_item);
            this.t1.Controls.Add(this.add_price_item);
            this.t1.Controls.Add(this.add_des_item);
            this.t1.Controls.Add(this.add_name_item);
            this.t1.Controls.Add(this.label4);
            this.t1.Controls.Add(this.label3);
            this.t1.Controls.Add(this.label2);
            this.t1.Controls.Add(this.label1);
            this.t1.Location = new System.Drawing.Point(4, 25);
            this.t1.Name = "t1";
            this.t1.Padding = new System.Windows.Forms.Padding(3);
            this.t1.Size = new System.Drawing.Size(640, 429);
            this.t1.TabIndex = 0;
            this.t1.Text = "Add";
            this.t1.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(148, 310);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(277, 58);
            this.add.TabIndex = 8;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // add_category_item
            // 
            this.add_category_item.Location = new System.Drawing.Point(166, 242);
            this.add_category_item.Name = "add_category_item";
            this.add_category_item.Size = new System.Drawing.Size(291, 22);
            this.add_category_item.TabIndex = 7;
            // 
            // add_price_item
            // 
            this.add_price_item.Location = new System.Drawing.Point(166, 172);
            this.add_price_item.Name = "add_price_item";
            this.add_price_item.Size = new System.Drawing.Size(77, 22);
            this.add_price_item.TabIndex = 6;
            // 
            // add_des_item
            // 
            this.add_des_item.Location = new System.Drawing.Point(166, 111);
            this.add_des_item.Name = "add_des_item";
            this.add_des_item.Size = new System.Drawing.Size(291, 22);
            this.add_des_item.TabIndex = 5;
            // 
            // add_name_item
            // 
            this.add_name_item.Location = new System.Drawing.Point(166, 51);
            this.add_name_item.Name = "add_name_item";
            this.add_name_item.Size = new System.Drawing.Size(291, 22);
            this.add_name_item.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // t0
            // 
            this.t0.Controls.Add(this.Find_button);
            this.t0.Controls.Add(this.view_category);
            this.t0.Controls.Add(this.view_description);
            this.t0.Controls.Add(this.view_price);
            this.t0.Controls.Add(this.view_item_name);
            this.t0.Controls.Add(this.label8);
            this.t0.Controls.Add(this.label7);
            this.t0.Controls.Add(this.label6);
            this.t0.Controls.Add(this.label5);
            this.t0.Location = new System.Drawing.Point(4, 25);
            this.t0.Name = "t0";
            this.t0.Size = new System.Drawing.Size(640, 429);
            this.t0.TabIndex = 3;
            this.t0.Text = "View";
            this.t0.UseVisualStyleBackColor = true;
            // 
            // Find_button
            // 
            this.Find_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find_button.Location = new System.Drawing.Point(195, 108);
            this.Find_button.Name = "Find_button";
            this.Find_button.Size = new System.Drawing.Size(218, 53);
            this.Find_button.TabIndex = 8;
            this.Find_button.Text = "Find";
            this.Find_button.UseVisualStyleBackColor = true;
            this.Find_button.Click += new System.EventHandler(this.Find_button_Click);
            // 
            // view_category
            // 
            this.view_category.Location = new System.Drawing.Point(146, 324);
            this.view_category.Name = "view_category";
            this.view_category.Size = new System.Drawing.Size(244, 22);
            this.view_category.TabIndex = 7;
            // 
            // view_description
            // 
            this.view_description.Location = new System.Drawing.Point(146, 269);
            this.view_description.Name = "view_description";
            this.view_description.Size = new System.Drawing.Size(244, 22);
            this.view_description.TabIndex = 6;
            // 
            // view_price
            // 
            this.view_price.Location = new System.Drawing.Point(119, 217);
            this.view_price.Name = "view_price";
            this.view_price.Size = new System.Drawing.Size(59, 22);
            this.view_price.TabIndex = 5;
            // 
            // view_item_name
            // 
            this.view_item_name.Location = new System.Drawing.Point(184, 55);
            this.view_item_name.Name = "view_item_name";
            this.view_item_name.Size = new System.Drawing.Size(244, 22);
            this.view_item_name.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Price";
            // 
            // t2
            // 
            this.t2.Controls.Add(this.change_button);
            this.t2.Controls.Add(this.newval);
            this.t2.Controls.Add(this.label12);
            this.t2.Controls.Add(this.label11);
            this.t2.Controls.Add(this.label10);
            this.t2.Controls.Add(this.comboBox1);
            this.t2.Controls.Add(this.edit_text);
            this.t2.Controls.Add(this.label9);
            this.t2.Location = new System.Drawing.Point(4, 25);
            this.t2.Name = "t2";
            this.t2.Padding = new System.Windows.Forms.Padding(3);
            this.t2.Size = new System.Drawing.Size(640, 429);
            this.t2.TabIndex = 1;
            this.t2.Text = "Update";
            this.t2.UseVisualStyleBackColor = true;
            // 
            // change_button
            // 
            this.change_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_button.Location = new System.Drawing.Point(186, 331);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(218, 53);
            this.change_button.TabIndex = 15;
            this.change_button.Text = "Change";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // newval
            // 
            this.newval.AutoCompleteCustomSource.AddRange(new string[] {
            "price",
            "describiton",
            "category",
            "name"});
            this.newval.Location = new System.Drawing.Point(169, 253);
            this.newval.Name = "newval";
            this.newval.Size = new System.Drawing.Size(218, 22);
            this.newval.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "New Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 25);
            this.label10.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "describtion",
            "price ",
            "category"});
            this.comboBox1.Location = new System.Drawing.Point(160, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // edit_text
            // 
            this.edit_text.Location = new System.Drawing.Point(160, 50);
            this.edit_text.Name = "edit_text";
            this.edit_text.Size = new System.Drawing.Size(244, 22);
            this.edit_text.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Item Name";
            // 
            // t3
            // 
            this.t3.Controls.Add(this.delete_button);
            this.t3.Controls.Add(this.delete_text);
            this.t3.Controls.Add(this.label13);
            this.t3.Location = new System.Drawing.Point(4, 25);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(640, 429);
            this.t3.TabIndex = 2;
            this.t3.Text = "Delete";
            this.t3.UseVisualStyleBackColor = true;
            // 
            // delete_text
            // 
            this.delete_text.Location = new System.Drawing.Point(164, 53);
            this.delete_text.Name = "delete_text";
            this.delete_text.Size = new System.Drawing.Size(244, 22);
            this.delete_text.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Item Name";
            // 
            // Admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 462);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin_form";
            this.Text = "Admin_form";
            this.tabControl1.ResumeLayout(false);
            this.t1.ResumeLayout(false);
            this.t1.PerformLayout();
            this.t0.ResumeLayout(false);
            this.t0.PerformLayout();
            this.t2.ResumeLayout(false);
            this.t2.PerformLayout();
            this.t3.ResumeLayout(false);
            this.t3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage t1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox add_category_item;
        private System.Windows.Forms.TextBox add_price_item;
        private System.Windows.Forms.TextBox add_des_item;
        private System.Windows.Forms.TextBox add_name_item;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage t0;
        private System.Windows.Forms.Button Find_button;
        private System.Windows.Forms.TextBox view_category;
        private System.Windows.Forms.TextBox view_description;
        private System.Windows.Forms.TextBox view_price;
        private System.Windows.Forms.TextBox view_item_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage t2;
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.TextBox newval;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox edit_text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage t3;
        private System.Windows.Forms.TextBox delete_text;
        private System.Windows.Forms.Label label13;
    }
}