
namespace OnlineShopping
{
    partial class MainForm
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
            this.admin_button = new System.Windows.Forms.Button();
            this.reg_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // admin_button
            // 
            this.admin_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_button.Location = new System.Drawing.Point(221, 258);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(94, 77);
            this.admin_button.TabIndex = 5;
            this.admin_button.Text = "Admin Mode";
            this.admin_button.UseVisualStyleBackColor = true;
            this.admin_button.Click += new System.EventHandler(this.admin_button_Click);
            // 
            // reg_button
            // 
            this.reg_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_button.Location = new System.Drawing.Point(76, 145);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(176, 55);
            this.reg_button.TabIndex = 4;
            this.reg_button.Text = "Register";
            this.reg_button.UseVisualStyleBackColor = true;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // Login_button
            // 
            this.Login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.Location = new System.Drawing.Point(76, 47);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(176, 55);
            this.Login_button.TabIndex = 3;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 347);
            this.Controls.Add(this.admin_button);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.Login_button);
            this.Name = "MainForm";
            this.Text = "OnlineShopping";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button admin_button;
        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.Button Login_button;
    }
}

