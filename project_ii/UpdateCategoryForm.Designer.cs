namespace Project_II
{
    partial class UpdateCategoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.categ_name = new System.Windows.Forms.TextBox();
            this.cat_name = new System.Windows.Forms.Label();
            this.cat_color = new System.Windows.Forms.Label();
            this.categ_color = new System.Windows.Forms.TextBox();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category info:";
            // 
            // categ_name
            // 
            this.categ_name.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categ_name.Location = new System.Drawing.Point(87, 64);
            this.categ_name.Name = "categ_name";
            this.categ_name.Size = new System.Drawing.Size(150, 28);
            this.categ_name.TabIndex = 2;
            // 
            // cat_name
            // 
            this.cat_name.AutoSize = true;
            this.cat_name.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat_name.Location = new System.Drawing.Point(29, 71);
            this.cat_name.Name = "cat_name";
            this.cat_name.Size = new System.Drawing.Size(52, 21);
            this.cat_name.TabIndex = 3;
            this.cat_name.Text = "Name";
            // 
            // cat_color
            // 
            this.cat_color.AutoSize = true;
            this.cat_color.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat_color.Location = new System.Drawing.Point(29, 118);
            this.cat_color.Name = "cat_color";
            this.cat_color.Size = new System.Drawing.Size(48, 21);
            this.cat_color.TabIndex = 4;
            this.cat_color.Text = "Color";
            // 
            // categ_color
            // 
            this.categ_color.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categ_color.Location = new System.Drawing.Point(87, 111);
            this.categ_color.Name = "categ_color";
            this.categ_color.Size = new System.Drawing.Size(150, 28);
            this.categ_color.TabIndex = 5;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.White;
            this.btnUpdateCategory.FlatAppearance.BorderSize = 0;
            this.btnUpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(196)))));
            this.btnUpdateCategory.Location = new System.Drawing.Point(159, 174);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(78, 29);
            this.btnUpdateCategory.TabIndex = 33;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(196)))));
            this.btnCancel.Location = new System.Drawing.Point(33, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UpdateCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(270, 215);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.categ_color);
            this.Controls.Add(this.cat_color);
            this.Controls.Add(this.cat_name);
            this.Controls.Add(this.categ_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categ_name;
        private System.Windows.Forms.Label cat_name;
        private System.Windows.Forms.Label cat_color;
        private System.Windows.Forms.TextBox categ_color;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnCancel;
    }
}