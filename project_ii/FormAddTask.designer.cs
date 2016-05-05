namespace Project_II
{
    partial class FormAddTask
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.checkMon = new System.Windows.Forms.CheckBox();
            this.checkTue = new System.Windows.Forms.CheckBox();
            this.checkSun = new System.Windows.Forms.CheckBox();
            this.checkSat = new System.Windows.Forms.CheckBox();
            this.checkFri = new System.Windows.Forms.CheckBox();
            this.checkThu = new System.Windows.Forms.CheckBox();
            this.checkWed = new System.Windows.Forms.CheckBox();
            this.labelLocation = new System.Windows.Forms.TextBox();
            this.cmbBoxPriority = new System.Windows.Forms.ComboBox();
            this.labelIsYourTaskRecurrent = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.comboBoxChooseCategory = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelAddNewTask = new System.Windows.Forms.Label();
            this.textBoxTaskTitle = new System.Windows.Forms.TextBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.labelChooseCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.datePicker.CustomFormat = "dd MM yyyy HH : mm";
            this.datePicker.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F);
            this.datePicker.Location = new System.Drawing.Point(28, 195);
            this.datePicker.Name = "datePicker";
            this.datePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datePicker.Size = new System.Drawing.Size(164, 29);
            this.datePicker.TabIndex = 2;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // checkMon
            // 
            this.checkMon.AutoSize = true;
            this.checkMon.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkMon.Location = new System.Drawing.Point(30, 314);
            this.checkMon.Name = "checkMon";
            this.checkMon.Size = new System.Drawing.Size(49, 17);
            this.checkMon.TabIndex = 6;
            this.checkMon.Text = "Mon";
            this.checkMon.UseVisualStyleBackColor = true;
            this.checkMon.CheckedChanged += new System.EventHandler(this.checkMon_CheckedChanged);
            // 
            // checkTue
            // 
            this.checkTue.AutoSize = true;
            this.checkTue.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkTue.Location = new System.Drawing.Point(83, 314);
            this.checkTue.Name = "checkTue";
            this.checkTue.Size = new System.Drawing.Size(46, 17);
            this.checkTue.TabIndex = 9;
            this.checkTue.Text = "Tue";
            this.checkTue.UseVisualStyleBackColor = true;
            this.checkTue.CheckedChanged += new System.EventHandler(this.checkTue_CheckedChanged);
            // 
            // checkSun
            // 
            this.checkSun.AutoSize = true;
            this.checkSun.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkSun.Location = new System.Drawing.Point(334, 314);
            this.checkSun.Name = "checkSun";
            this.checkSun.Size = new System.Drawing.Size(48, 17);
            this.checkSun.TabIndex = 11;
            this.checkSun.Text = "Sun";
            this.checkSun.UseVisualStyleBackColor = true;
            this.checkSun.CheckedChanged += new System.EventHandler(this.checkSun_CheckedChanged);
            // 
            // checkSat
            // 
            this.checkSat.AutoSize = true;
            this.checkSat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkSat.Location = new System.Drawing.Point(286, 314);
            this.checkSat.Name = "checkSat";
            this.checkSat.Size = new System.Drawing.Size(45, 17);
            this.checkSat.TabIndex = 12;
            this.checkSat.Text = "Sat";
            this.checkSat.UseVisualStyleBackColor = true;
            this.checkSat.CheckedChanged += new System.EventHandler(this.checkSat_CheckedChanged);
            // 
            // checkFri
            // 
            this.checkFri.AutoSize = true;
            this.checkFri.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkFri.Location = new System.Drawing.Point(240, 314);
            this.checkFri.Name = "checkFri";
            this.checkFri.Size = new System.Drawing.Size(40, 17);
            this.checkFri.TabIndex = 13;
            this.checkFri.Text = "Fri";
            this.checkFri.UseVisualStyleBackColor = true;
            this.checkFri.CheckedChanged += new System.EventHandler(this.checkFri_CheckedChanged);
            // 
            // checkThu
            // 
            this.checkThu.AutoSize = true;
            this.checkThu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkThu.Location = new System.Drawing.Point(189, 314);
            this.checkThu.Name = "checkThu";
            this.checkThu.Size = new System.Drawing.Size(47, 17);
            this.checkThu.TabIndex = 14;
            this.checkThu.Text = "Thu";
            this.checkThu.UseVisualStyleBackColor = true;
            this.checkThu.CheckedChanged += new System.EventHandler(this.checkThu_CheckedChanged);
            // 
            // checkWed
            // 
            this.checkWed.AutoSize = true;
            this.checkWed.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkWed.Location = new System.Drawing.Point(134, 314);
            this.checkWed.Name = "checkWed";
            this.checkWed.Size = new System.Drawing.Size(50, 17);
            this.checkWed.TabIndex = 15;
            this.checkWed.Text = "Wed";
            this.checkWed.UseVisualStyleBackColor = true;
            this.checkWed.CheckedChanged += new System.EventHandler(this.checkWed_CheckedChanged);
            // 
            // labelLocation
            // 
            this.labelLocation.BackColor = System.Drawing.SystemColors.MenuBar;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F);
            this.labelLocation.Location = new System.Drawing.Point(28, 231);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(379, 29);
            this.labelLocation.TabIndex = 16;
            this.labelLocation.Text = "Task location";
            this.labelLocation.TextChanged += new System.EventHandler(this.labelLocation_TextChanged);
            this.labelLocation.Enter += new System.EventHandler(this.labelLocation_Enter);
            // 
            // cmbBoxPriority
            // 
            this.cmbBoxPriority.AccessibleDescription = "";
            this.cmbBoxPriority.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F);
            this.cmbBoxPriority.FormattingEnabled = true;
            this.cmbBoxPriority.Location = new System.Drawing.Point(328, 266);
            this.cmbBoxPriority.Name = "cmbBoxPriority";
            this.cmbBoxPriority.Size = new System.Drawing.Size(79, 29);
            this.cmbBoxPriority.TabIndex = 17;
            this.cmbBoxPriority.Text = "Priority";
            this.cmbBoxPriority.SelectedIndexChanged += new System.EventHandler(this.cmbBoxPriority_SelectedIndexChanged);
            // 
            // labelIsYourTaskRecurrent
            // 
            this.labelIsYourTaskRecurrent.AutoSize = true;
            this.labelIsYourTaskRecurrent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIsYourTaskRecurrent.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelIsYourTaskRecurrent.Location = new System.Drawing.Point(25, 289);
            this.labelIsYourTaskRecurrent.Name = "labelIsYourTaskRecurrent";
            this.labelIsYourTaskRecurrent.Size = new System.Drawing.Size(147, 13);
            this.labelIsYourTaskRecurrent.TabIndex = 18;
            this.labelIsYourTaskRecurrent.Text = "Is your task recurrent ? ";
            // 
            // btnAddTask
            // 
            this.btnAddTask.AutoEllipsis = true;
            this.btnAddTask.BackgroundImage = global::Project_II.Properties.Resources.plus_icon;
            this.btnAddTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(373, 355);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(25, 25);
            this.btnAddTask.TabIndex = 19;
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // comboBoxChooseCategory
            // 
            this.comboBoxChooseCategory.Font = new System.Drawing.Font("Microsoft NeoGothic", 10F);
            this.comboBoxChooseCategory.FormattingEnabled = true;
            this.comboBoxChooseCategory.Location = new System.Drawing.Point(240, 75);
            this.comboBoxChooseCategory.Name = "comboBoxChooseCategory";
            this.comboBoxChooseCategory.Size = new System.Drawing.Size(167, 25);
            this.comboBoxChooseCategory.TabIndex = 22;
            this.comboBoxChooseCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseCategory_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(196)))));
            this.btnCancel.Location = new System.Drawing.Point(28, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelAddNewTask
            // 
            this.labelAddNewTask.AutoSize = true;
            this.labelAddNewTask.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAddNewTask.Location = new System.Drawing.Point(24, 25);
            this.labelAddNewTask.Name = "labelAddNewTask";
            this.labelAddNewTask.Size = new System.Drawing.Size(115, 21);
            this.labelAddNewTask.TabIndex = 24;
            this.labelAddNewTask.Text = "Add a new task";
            // 
            // textBoxTaskTitle
            // 
            this.textBoxTaskTitle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxTaskTitle.Font = new System.Drawing.Font("Microsoft NeoGothic", 11F);
            this.textBoxTaskTitle.Location = new System.Drawing.Point(28, 105);
            this.textBoxTaskTitle.Multiline = true;
            this.textBoxTaskTitle.Name = "textBoxTaskTitle";
            this.textBoxTaskTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTaskTitle.Size = new System.Drawing.Size(379, 84);
            this.textBoxTaskTitle.TabIndex = 25;
            this.textBoxTaskTitle.Text = "Task description";
            this.textBoxTaskTitle.TextChanged += new System.EventHandler(this.textBoxTaskTitle_TextChanged);
            this.textBoxTaskTitle.Enter += new System.EventHandler(this.textBoxTaskTitle_Enter);
            // 
            // timePicker
            // 
            this.timePicker.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F);
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(198, 195);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(65, 29);
            this.timePicker.TabIndex = 29;
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
            // 
            // labelChooseCategory
            // 
            this.labelChooseCategory.AutoSize = true;
            this.labelChooseCategory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChooseCategory.Location = new System.Drawing.Point(25, 81);
            this.labelChooseCategory.Name = "labelChooseCategory";
            this.labelChooseCategory.Size = new System.Drawing.Size(204, 13);
            this.labelChooseCategory.TabIndex = 30;
            this.labelChooseCategory.Text = "Choose the category for your task";
            // 
            // FormAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(442, 412);
            this.Controls.Add(this.labelChooseCategory);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.textBoxTaskTitle);
            this.Controls.Add(this.labelAddNewTask);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.comboBoxChooseCategory);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.labelIsYourTaskRecurrent);
            this.Controls.Add(this.cmbBoxPriority);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.checkWed);
            this.Controls.Add(this.checkThu);
            this.Controls.Add(this.checkFri);
            this.Controls.Add(this.checkSat);
            this.Controls.Add(this.checkSun);
            this.Controls.Add(this.checkTue);
            this.Controls.Add(this.checkMon);
            this.Controls.Add(this.datePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "FormAddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormAddTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox taskTitle;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.CheckBox checkMon;
        private System.Windows.Forms.CheckBox checkTue;
        private System.Windows.Forms.CheckBox checkSun;
        private System.Windows.Forms.CheckBox checkSat;
        private System.Windows.Forms.CheckBox checkFri;
        private System.Windows.Forms.CheckBox checkThu;
        private System.Windows.Forms.CheckBox checkWed;
        private System.Windows.Forms.TextBox labelLocation;
        private System.Windows.Forms.ComboBox cmbBoxPriority;
        private System.Windows.Forms.Label labelIsYourTaskRecurrent;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.ComboBox comboBoxChooseCategory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelAddNewTask;
        private System.Windows.Forms.TextBox textBoxTaskTitle;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label labelChooseCategory;
    }
}

