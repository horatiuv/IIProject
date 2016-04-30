namespace Project_II
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewNext = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.next = new System.Windows.Forms.Label();
            this.listViewToday = new System.Windows.Forms.ListView();
            this.date = new System.Windows.Forms.Label();
            this.panelHomeAddaTask = new System.Windows.Forms.Panel();
            this.btnAddaTaskHomeForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.today = new System.Windows.Forms.Label();
            this.lB_separator = new System.Windows.Forms.Label();
            this.categories = new System.Windows.Forms.ListBox();
            this.btnToday = new System.Windows.Forms.Button();
            this.newCategory = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel_user = new System.Windows.Forms.LinkLabel();
            this.lB_greet = new System.Windows.Forms.Label();
            this.b_notes = new System.Windows.Forms.Button();
            this.p_profile = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.b_back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.b_profile_update = new System.Windows.Forms.Button();
            this.tB_profile_pass2 = new System.Windows.Forms.TextBox();
            this.l_profile_email = new System.Windows.Forms.Label();
            this.tB_profile_pass = new System.Windows.Forms.TextBox();
            this.l_profile_user = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panelHomeAddaTask.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.p_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.listViewNext);
            this.panel1.Controls.Add(this.next);
            this.panel1.Controls.Add(this.listViewToday);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.panelHomeAddaTask);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.today);
            this.panel1.Controls.Add(this.lB_separator);
            this.panel1.Location = new System.Drawing.Point(281, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 583);
            this.panel1.TabIndex = 0;
            // 
            // listViewNext
            // 
            this.listViewNext.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewNext.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewNext.HideSelection = false;
            this.listViewNext.Location = new System.Drawing.Point(23, 353);
            this.listViewNext.MultiSelect = false;
            this.listViewNext.Name = "listViewNext";
            this.listViewNext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listViewNext.Size = new System.Drawing.Size(575, 99);
            this.listViewNext.SmallImageList = this.imageList1;
            this.listViewNext.TabIndex = 11;
            this.listViewNext.UseCompatibleStateImageBehavior = false;
            this.listViewNext.View = System.Windows.Forms.View.Details;
            this.listViewNext.Click += new System.EventHandler(this.listViewNext_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "check_button.png");
            this.imageList1.Images.SetKeyName(1, "undo_button.png");
            // 
            // next
            // 
            this.next.AutoSize = true;
            this.next.Font = new System.Drawing.Font("Microsoft New Tai Lue", 16.2F);
            this.next.Location = new System.Drawing.Point(18, 321);
            this.next.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(58, 29);
            this.next.TabIndex = 10;
            this.next.Text = "Next";
            // 
            // listViewToday
            // 
            this.listViewToday.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewToday.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewToday.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewToday.HideSelection = false;
            this.listViewToday.Location = new System.Drawing.Point(23, 79);
            this.listViewToday.MultiSelect = false;
            this.listViewToday.Name = "listViewToday";
            this.listViewToday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listViewToday.Size = new System.Drawing.Size(575, 207);
            this.listViewToday.SmallImageList = this.imageList1;
            this.listViewToday.TabIndex = 9;
            this.listViewToday.UseCompatibleStateImageBehavior = false;
            this.listViewToday.View = System.Windows.Forms.View.Details;
            this.listViewToday.Click += new System.EventHandler(this.listViewToday_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.date.Location = new System.Drawing.Point(490, 38);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(40, 21);
            this.date.TabIndex = 5;
            this.date.Text = "date";
            // 
            // panelHomeAddaTask
            // 
            this.panelHomeAddaTask.Controls.Add(this.btnAddaTaskHomeForm);
            this.panelHomeAddaTask.Location = new System.Drawing.Point(0, 483);
            this.panelHomeAddaTask.Name = "panelHomeAddaTask";
            this.panelHomeAddaTask.Size = new System.Drawing.Size(625, 100);
            this.panelHomeAddaTask.TabIndex = 3;
            // 
            // btnAddaTaskHomeForm
            // 
            this.btnAddaTaskHomeForm.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddaTaskHomeForm.Location = new System.Drawing.Point(479, 24);
            this.btnAddaTaskHomeForm.Name = "btnAddaTaskHomeForm";
            this.btnAddaTaskHomeForm.Size = new System.Drawing.Size(119, 54);
            this.btnAddaTaskHomeForm.TabIndex = 0;
            this.btnAddaTaskHomeForm.Text = "Add a task";
            this.btnAddaTaskHomeForm.UseVisualStyleBackColor = true;
            this.btnAddaTaskHomeForm.Click += new System.EventHandler(this.btnAddaTaskHomeForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(76, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 2;
            // 
            // today
            // 
            this.today.AutoSize = true;
            this.today.Font = new System.Drawing.Font("Microsoft New Tai Lue", 16.2F);
            this.today.Location = new System.Drawing.Point(18, 30);
            this.today.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(73, 29);
            this.today.TabIndex = 1;
            this.today.Text = "Today";
            // 
            // lB_separator
            // 
            this.lB_separator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lB_separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lB_separator.Location = new System.Drawing.Point(0, 63);
            this.lB_separator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lB_separator.Name = "lB_separator";
            this.lB_separator.Size = new System.Drawing.Size(626, 2);
            this.lB_separator.TabIndex = 0;
            // 
            // categories
            // 
            this.categories.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categories.FormattingEnabled = true;
            this.categories.ItemHeight = 21;
            this.categories.Location = new System.Drawing.Point(16, 156);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(248, 130);
            this.categories.TabIndex = 11;
            this.categories.SelectedIndexChanged += new System.EventHandler(this.categories_SelectedIndexChanged);
            // 
            // btnToday
            // 
            this.btnToday.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.Location = new System.Drawing.Point(16, 79);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(248, 35);
            this.btnToday.TabIndex = 12;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // newCategory
            // 
            this.newCategory.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCategory.Location = new System.Drawing.Point(16, 302);
            this.newCategory.Name = "newCategory";
            this.newCategory.Size = new System.Drawing.Size(248, 28);
            this.newCategory.TabIndex = 13;
            this.newCategory.Text = "Add new category...";
            this.newCategory.Click += new System.EventHandler(this.newCategory_Click);
            this.newCategory.TextChanged += new System.EventHandler(this.newCategory_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 56);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // linkLabel_user
            // 
            this.linkLabel_user.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkLabel_user.AutoSize = true;
            this.linkLabel_user.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_user.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel_user.Location = new System.Drawing.Point(100, 30);
            this.linkLabel_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_user.Name = "linkLabel_user";
            this.linkLabel_user.Size = new System.Drawing.Size(95, 25);
            this.linkLabel_user.TabIndex = 24;
            this.linkLabel_user.TabStop = true;
            this.linkLabel_user.Text = "username";
            this.linkLabel_user.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_user_LinkClicked);
            // 
            // lB_greet
            // 
            this.lB_greet.AutoSize = true;
            this.lB_greet.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lB_greet.Location = new System.Drawing.Point(11, 30);
            this.lB_greet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lB_greet.Name = "lB_greet";
            this.lB_greet.Size = new System.Drawing.Size(85, 25);
            this.lB_greet.TabIndex = 23;
            this.lB_greet.Text = "Greeting";
            // 
            // b_notes
            // 
            this.b_notes.BackgroundImage = global::Project_II.Properties.Resources.notes_icon;
            this.b_notes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b_notes.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.b_notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_notes.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_notes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.b_notes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_notes.Location = new System.Drawing.Point(16, 469);
            this.b_notes.Name = "b_notes";
            this.b_notes.Size = new System.Drawing.Size(248, 30);
            this.b_notes.TabIndex = 25;
            this.b_notes.Text = "     Notes";
            this.b_notes.UseVisualStyleBackColor = true;
            // 
            // p_profile
            // 
            this.p_profile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.p_profile.BackColor = System.Drawing.SystemColors.Control;
            this.p_profile.Controls.Add(this.label1);
            this.p_profile.Controls.Add(this.linkLabel1);
            this.p_profile.Controls.Add(this.b_back);
            this.p_profile.Controls.Add(this.label3);
            this.p_profile.Controls.Add(this.b_profile_update);
            this.p_profile.Controls.Add(this.tB_profile_pass2);
            this.p_profile.Controls.Add(this.l_profile_email);
            this.p_profile.Controls.Add(this.tB_profile_pass);
            this.p_profile.Controls.Add(this.l_profile_user);
            this.p_profile.Location = new System.Drawing.Point(281, 0);
            this.p_profile.Name = "p_profile";
            this.p_profile.Size = new System.Drawing.Size(625, 583);
            this.p_profile.TabIndex = 26;
            this.p_profile.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(300, 439);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Want to sign out?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(430, 439);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 20);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // b_back
            // 
            this.b_back.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_back.BackgroundImage = global::Project_II.Properties.Resources.back_button;
            this.b_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_back.ForeColor = System.Drawing.SystemColors.Control;
            this.b_back.Location = new System.Drawing.Point(80, 86);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(22, 28);
            this.b_back.TabIndex = 25;
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Click += new System.EventHandler(this.b_back_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F);
            this.label3.Location = new System.Drawing.Point(138, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 27);
            this.label3.TabIndex = 24;
            this.label3.Text = "Profile";
            // 
            // b_profile_update
            // 
            this.b_profile_update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_profile_update.BackColor = System.Drawing.Color.DodgerBlue;
            this.b_profile_update.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.b_profile_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_profile_update.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_profile_update.ForeColor = System.Drawing.SystemColors.Window;
            this.b_profile_update.Location = new System.Drawing.Point(144, 369);
            this.b_profile_update.Margin = new System.Windows.Forms.Padding(2);
            this.b_profile_update.Name = "b_profile_update";
            this.b_profile_update.Size = new System.Drawing.Size(349, 40);
            this.b_profile_update.TabIndex = 22;
            this.b_profile_update.TabStop = false;
            this.b_profile_update.Text = "Update password";
            this.b_profile_update.UseVisualStyleBackColor = false;
            this.b_profile_update.Click += new System.EventHandler(this.b_profile_update_Click);
            // 
            // tB_profile_pass2
            // 
            this.tB_profile_pass2.AcceptsReturn = true;
            this.tB_profile_pass2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tB_profile_pass2.BackColor = System.Drawing.SystemColors.Window;
            this.tB_profile_pass2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_profile_pass2.ForeColor = System.Drawing.Color.Gray;
            this.tB_profile_pass2.Location = new System.Drawing.Point(144, 304);
            this.tB_profile_pass2.Margin = new System.Windows.Forms.Padding(2);
            this.tB_profile_pass2.MinimumSize = new System.Drawing.Size(350, 32);
            this.tB_profile_pass2.Name = "tB_profile_pass2";
            this.tB_profile_pass2.Size = new System.Drawing.Size(350, 32);
            this.tB_profile_pass2.TabIndex = 20;
            this.tB_profile_pass2.Text = "re-enter password";
            this.tB_profile_pass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_profile_pass2.TextChanged += new System.EventHandler(this.tB_profile_pass2_TextChanged);
            // 
            // l_profile_email
            // 
            this.l_profile_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_profile_email.AutoSize = true;
            this.l_profile_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_profile_email.Location = new System.Drawing.Point(140, 223);
            this.l_profile_email.Name = "l_profile_email";
            this.l_profile_email.Size = new System.Drawing.Size(41, 16);
            this.l_profile_email.TabIndex = 19;
            this.l_profile_email.Text = "email";
            this.l_profile_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tB_profile_pass
            // 
            this.tB_profile_pass.AcceptsReturn = true;
            this.tB_profile_pass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tB_profile_pass.BackColor = System.Drawing.SystemColors.Window;
            this.tB_profile_pass.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_profile_pass.ForeColor = System.Drawing.Color.Gray;
            this.tB_profile_pass.Location = new System.Drawing.Point(143, 265);
            this.tB_profile_pass.Margin = new System.Windows.Forms.Padding(2);
            this.tB_profile_pass.MinimumSize = new System.Drawing.Size(350, 32);
            this.tB_profile_pass.Name = "tB_profile_pass";
            this.tB_profile_pass.Size = new System.Drawing.Size(350, 32);
            this.tB_profile_pass.TabIndex = 17;
            this.tB_profile_pass.Text = "new password";
            this.tB_profile_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_profile_pass.TextChanged += new System.EventHandler(this.tB_profile_pass_TextChanged);
            // 
            // l_profile_user
            // 
            this.l_profile_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_profile_user.AutoSize = true;
            this.l_profile_user.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_profile_user.ForeColor = System.Drawing.Color.DodgerBlue;
            this.l_profile_user.Location = new System.Drawing.Point(137, 191);
            this.l_profile_user.Name = "l_profile_user";
            this.l_profile_user.Size = new System.Drawing.Size(120, 32);
            this.l_profile_user.TabIndex = 0;
            this.l_profile_user.Text = "username";
            this.l_profile_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 583);
            this.Controls.Add(this.p_profile);
            this.Controls.Add(this.b_notes);
            this.Controls.Add(this.linkLabel_user);
            this.Controls.Add(this.lB_greet);
            this.Controls.Add(this.newCategory);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelHomeAddaTask.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.p_profile.ResumeLayout(false);
            this.p_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lB_separator;
        public System.Windows.Forms.Label today;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelHomeAddaTask;
        private System.Windows.Forms.Button btnAddaTaskHomeForm;
        public System.Windows.Forms.ListView listViewToday;
        private System.Windows.Forms.Label date;
        public System.Windows.Forms.ListBox categories;
        public System.Windows.Forms.Button btnToday;
        public System.Windows.Forms.TextBox newCategory;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        public System.Windows.Forms.ListView listViewNext;
        public System.Windows.Forms.Label next;
        private System.Windows.Forms.LinkLabel linkLabel_user;
        private System.Windows.Forms.Label lB_greet;
        private System.Windows.Forms.Button b_notes;
        private System.Windows.Forms.Panel p_profile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button b_back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_profile_update;
        private System.Windows.Forms.TextBox tB_profile_pass2;
        private System.Windows.Forms.Label l_profile_email;
        private System.Windows.Forms.TextBox tB_profile_pass;
        private System.Windows.Forms.Label l_profile_user;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}