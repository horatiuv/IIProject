namespace Project_II
{
    partial class DeleteCategoryForm
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
            this.btnDeleteNO = new System.Windows.Forms.Button();
            this.btnDeleteYES = new System.Windows.Forms.Button();
            this.labelDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteNO
            // 
            this.btnDeleteNO.BackColor = System.Drawing.Color.White;
            this.btnDeleteNO.FlatAppearance.BorderSize = 0;
            this.btnDeleteNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNO.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(196)))));
            this.btnDeleteNO.Location = new System.Drawing.Point(67, 59);
            this.btnDeleteNO.Name = "btnDeleteNO";
            this.btnDeleteNO.Size = new System.Drawing.Size(78, 29);
            this.btnDeleteNO.TabIndex = 37;
            this.btnDeleteNO.Text = "NO";
            this.btnDeleteNO.UseVisualStyleBackColor = false;
            this.btnDeleteNO.Click += new System.EventHandler(this.btnDeleteNO_Click);
            // 
            // btnDeleteYES
            // 
            this.btnDeleteYES.BackColor = System.Drawing.Color.White;
            this.btnDeleteYES.FlatAppearance.BorderSize = 0;
            this.btnDeleteYES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteYES.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteYES.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(196)))));
            this.btnDeleteYES.Location = new System.Drawing.Point(169, 59);
            this.btnDeleteYES.Name = "btnDeleteYES";
            this.btnDeleteYES.Size = new System.Drawing.Size(78, 29);
            this.btnDeleteYES.TabIndex = 36;
            this.btnDeleteYES.Text = "YES";
            this.btnDeleteYES.UseVisualStyleBackColor = false;
            this.btnDeleteYES.Click += new System.EventHandler(this.btnDeleteYES_Click);
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDelete.Location = new System.Drawing.Point(12, 27);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(310, 14);
            this.labelDelete.TabIndex = 35;
            this.labelDelete.Text = "Are you sure you want to delete the category ? ";
            // 
            // DeleteCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(332, 104);
            this.Controls.Add(this.btnDeleteNO);
            this.Controls.Add(this.btnDeleteYES);
            this.Controls.Add(this.labelDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteNO;
        private System.Windows.Forms.Button btnDeleteYES;
        private System.Windows.Forms.Label labelDelete;
    }
}