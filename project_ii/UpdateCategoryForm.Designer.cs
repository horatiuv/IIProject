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
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.categ_name = new System.Windows.Forms.TextBox();
            this.cat_name = new System.Windows.Forms.Label();
            this.cat_color = new System.Windows.Forms.Label();
            this.categ_color = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(126, 175);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(80, 30);
            this.update.TabIndex = 0;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category info:";
            // 
            // categ_name
            // 
            this.categ_name.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categ_name.Location = new System.Drawing.Point(98, 79);
            this.categ_name.Name = "categ_name";
            this.categ_name.Size = new System.Drawing.Size(150, 28);
            this.categ_name.TabIndex = 2;
            // 
            // cat_name
            // 
            this.cat_name.AutoSize = true;
            this.cat_name.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat_name.Location = new System.Drawing.Point(37, 86);
            this.cat_name.Name = "cat_name";
            this.cat_name.Size = new System.Drawing.Size(52, 21);
            this.cat_name.TabIndex = 3;
            this.cat_name.Text = "Name";
            // 
            // cat_color
            // 
            this.cat_color.AutoSize = true;
            this.cat_color.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat_color.Location = new System.Drawing.Point(37, 130);
            this.cat_color.Name = "cat_color";
            this.cat_color.Size = new System.Drawing.Size(48, 21);
            this.cat_color.TabIndex = 4;
            this.cat_color.Text = "Color";
            // 
            // categ_color
            // 
            this.categ_color.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categ_color.Location = new System.Drawing.Point(98, 123);
            this.categ_color.Name = "categ_color";
            this.categ_color.Size = new System.Drawing.Size(150, 28);
            this.categ_color.TabIndex = 5;
            // 
            // UpdateCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.categ_color);
            this.Controls.Add(this.cat_color);
            this.Controls.Add(this.cat_name);
            this.Controls.Add(this.categ_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Name = "UpdateCategoryForm";
            this.Text = "UpdateCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categ_name;
        private System.Windows.Forms.Label cat_name;
        private System.Windows.Forms.Label cat_color;
        private System.Windows.Forms.TextBox categ_color;
    }
}