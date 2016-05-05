namespace Project_II
{
    partial class MessageBoxClose
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
            this.labelDelete = new System.Windows.Forms.Label();
            this.btnDeleteNO = new System.Windows.Forms.Button();
            this.btnDeleteYES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.labelDelete.Location = new System.Drawing.Point(62, 43);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(193, 21);
            this.labelDelete.TabIndex = 1;
            this.labelDelete.Text = "Do you really want to exit?";
            // 
            // btnDeleteNO
            // 
            this.btnDeleteNO.BackColor = System.Drawing.Color.White;
            this.btnDeleteNO.FlatAppearance.BorderSize = 0;
            this.btnDeleteNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNO.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(196)))));
            this.btnDeleteNO.Location = new System.Drawing.Point(46, 87);
            this.btnDeleteNO.Name = "btnDeleteNO";
            this.btnDeleteNO.Size = new System.Drawing.Size(78, 29);
            this.btnDeleteNO.TabIndex = 36;
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
            this.btnDeleteYES.Location = new System.Drawing.Point(186, 87);
            this.btnDeleteYES.Name = "btnDeleteYES";
            this.btnDeleteYES.Size = new System.Drawing.Size(78, 29);
            this.btnDeleteYES.TabIndex = 35;
            this.btnDeleteYES.Text = "YES";
            this.btnDeleteYES.UseVisualStyleBackColor = false;
            this.btnDeleteYES.Click += new System.EventHandler(this.btnDeleteYES_Click);
            // 
            // MessageBoxClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(304, 140);
            this.Controls.Add(this.btnDeleteNO);
            this.Controls.Add(this.btnDeleteYES);
            this.Controls.Add(this.labelDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MessageBoxClose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Button btnDeleteNO;
        private System.Windows.Forms.Button btnDeleteYES;
    }
}