namespace fileCreationOpr
{
    partial class FileHandler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileHandler));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FileTextName = new System.Windows.Forms.TextBox();
            this.drivers = new System.Windows.Forms.ListBox();
            this.Folders = new System.Windows.Forms.ListBox();
            this.Files = new System.Windows.Forms.ListBox();
            this.currentPath = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.READ = new System.Windows.Forms.Button();
            this.CREATE = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deletePrompt = new System.Windows.Forms.Label();
            this.popDelete = new System.Windows.Forms.Panel();
            this.deleteText = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.createFile = new System.Windows.Forms.CheckBox();
            this.createFolder = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.popDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(22, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(745, 459);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // path
            // 
            this.path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.path.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path.ForeColor = System.Drawing.Color.White;
            this.path.Location = new System.Drawing.Point(101, 561);
            this.path.Multiline = true;
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(666, 27);
            this.path.TabIndex = 7;
            this.path.TextChanged += new System.EventHandler(this.path_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "File Path:";
            // 
            // FileTextName
            // 
            this.FileTextName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FileTextName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.FileTextName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileTextName.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileTextName.ForeColor = System.Drawing.Color.White;
            this.FileTextName.Location = new System.Drawing.Point(66, 513);
            this.FileTextName.Multiline = true;
            this.FileTextName.Name = "FileTextName";
            this.FileTextName.Size = new System.Drawing.Size(139, 31);
            this.FileTextName.TabIndex = 9;
            this.FileTextName.TextChanged += new System.EventHandler(this.FileTextName_TextChanged);
            // 
            // drivers
            // 
            this.drivers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.drivers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drivers.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivers.ForeColor = System.Drawing.Color.White;
            this.drivers.FormattingEnabled = true;
            this.drivers.ItemHeight = 18;
            this.drivers.Location = new System.Drawing.Point(779, 56);
            this.drivers.Name = "drivers";
            this.drivers.Size = new System.Drawing.Size(307, 38);
            this.drivers.TabIndex = 14;
            this.drivers.SelectedIndexChanged += new System.EventHandler(this.drivers_SelectedIndexChanged);
            // 
            // Folders
            // 
            this.Folders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Folders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Folders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Folders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Folders.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Folders.ForeColor = System.Drawing.Color.White;
            this.Folders.FormattingEnabled = true;
            this.Folders.ItemHeight = 18;
            this.Folders.Location = new System.Drawing.Point(776, 124);
            this.Folders.Name = "Folders";
            this.Folders.Size = new System.Drawing.Size(312, 200);
            this.Folders.TabIndex = 15;
            this.Folders.SelectedIndexChanged += new System.EventHandler(this.Folders_SelectedIndexChanged);
            // 
            // Files
            // 
            this.Files.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.Files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Files.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Files.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Files.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Files.ForeColor = System.Drawing.Color.White;
            this.Files.FormattingEnabled = true;
            this.Files.HorizontalScrollbar = true;
            this.Files.ItemHeight = 18;
            this.Files.Location = new System.Drawing.Point(775, 352);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(313, 236);
            this.Files.TabIndex = 16;
            this.Files.SelectedIndexChanged += new System.EventHandler(this.Files_SelectedIndexChanged);
            // 
            // currentPath
            // 
            this.currentPath.AutoSize = true;
            this.currentPath.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPath.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.currentPath.Location = new System.Drawing.Point(777, 31);
            this.currentPath.Name = "currentPath";
            this.currentPath.Size = new System.Drawing.Size(46, 19);
            this.currentPath.TabIndex = 17;
            this.currentPath.Text = "Path:";
            this.currentPath.Click += new System.EventHandler(this.currentPath_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button4.BackgroundImage = global::fileCreationOpr.Properties.Resources.copy;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button4.Location = new System.Drawing.Point(706, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 37);
            this.button4.TabIndex = 22;
            this.toolTip1.SetToolTip(this.button4, "Copy");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.clear.BackgroundImage = global::fileCreationOpr.Properties.Resources.clear;
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.Transparent;
            this.clear.Location = new System.Drawing.Point(706, 451);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(36, 31);
            this.clear.TabIndex = 12;
            this.toolTip1.SetToolTip(this.clear, "Clear");
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // done
            // 
            this.done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.done.BackgroundImage = global::fileCreationOpr.Properties.Resources.UpdateDone;
            this.done.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.done.FlatAppearance.BorderSize = 0;
            this.done.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.done.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done.Location = new System.Drawing.Point(388, 507);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(41, 41);
            this.done.TabIndex = 11;
            this.toolTip1.SetToolTip(this.done, "Update");
            this.done.UseVisualStyleBackColor = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.BackgroundImage = global::fileCreationOpr.Properties.Resources.Update;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(347, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 41);
            this.button2.TabIndex = 10;
            this.toolTip1.SetToolTip(this.button2, "Edit");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color);
            this.button2.MouseHover += new System.EventHandler(this.ToolTip);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.BackgroundImage = global::fileCreationOpr.Properties.Resources.Info;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(716, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 43);
            this.button1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button1, "Info");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // DELETE
            // 
            this.DELETE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DELETE.BackgroundImage = global::fileCreationOpr.Properties.Resources.Delete;
            this.DELETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DELETE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DELETE.FlatAppearance.BorderSize = 0;
            this.DELETE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DELETE.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DELETE.Location = new System.Drawing.Point(681, 505);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(38, 43);
            this.DELETE.TabIndex = 5;
            this.toolTip1.SetToolTip(this.DELETE, "Delete");
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // READ
            // 
            this.READ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.READ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.READ.BackgroundImage = global::fileCreationOpr.Properties.Resources.Read;
            this.READ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.READ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.READ.FlatAppearance.BorderSize = 0;
            this.READ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.READ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.READ.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.READ.Location = new System.Drawing.Point(447, 508);
            this.READ.Name = "READ";
            this.READ.Size = new System.Drawing.Size(45, 38);
            this.READ.TabIndex = 3;
            this.toolTip1.SetToolTip(this.READ, "Read");
            this.READ.UseVisualStyleBackColor = false;
            this.READ.Click += new System.EventHandler(this.READ_Click);
            // 
            // CREATE
            // 
            this.CREATE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CREATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CREATE.BackgroundImage = global::fileCreationOpr.Properties.Resources.Add;
            this.CREATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CREATE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CREATE.FlatAppearance.BorderSize = 0;
            this.CREATE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CREATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CREATE.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CREATE.Location = new System.Drawing.Point(20, 508);
            this.CREATE.Name = "CREATE";
            this.CREATE.Size = new System.Drawing.Size(40, 41);
            this.CREATE.TabIndex = 2;
            this.toolTip1.SetToolTip(this.CREATE, "Create");
            this.CREATE.UseVisualStyleBackColor = false;
            this.CREATE.Click += new System.EventHandler(this.CREATE_Click);
            // 
            // SAVE
            // 
            this.SAVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SAVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SAVE.BackgroundImage = global::fileCreationOpr.Properties.Resources.Save;
            this.SAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SAVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SAVE.FlatAppearance.BorderSize = 0;
            this.SAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SAVE.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVE.Location = new System.Drawing.Point(286, 505);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(46, 43);
            this.SAVE.TabIndex = 1;
            this.toolTip1.SetToolTip(this.SAVE, "Save | Append the data");
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button3.BackgroundImage = global::fileCreationOpr.Properties.Resources.BackPre;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1065, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 25);
            this.button3.TabIndex = 20;
            this.toolTip1.SetToolTip(this.button3, "Previous");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(774, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 18;
            this.label1.Tag = "";
            this.label1.Text = "Folders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(773, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 19;
            this.label3.Tag = "";
            this.label3.Text = "Files";
            // 
            // deletePrompt
            // 
            this.deletePrompt.AutoSize = true;
            this.deletePrompt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletePrompt.Location = new System.Drawing.Point(14, 19);
            this.deletePrompt.Name = "deletePrompt";
            this.deletePrompt.Size = new System.Drawing.Size(43, 13);
            this.deletePrompt.TabIndex = 0;
            this.deletePrompt.Text = "label4";
            // 
            // popDelete
            // 
            this.popDelete.Controls.Add(this.Confirm);
            this.popDelete.Controls.Add(this.Cancel);
            this.popDelete.Controls.Add(this.deleteText);
            this.popDelete.Controls.Add(this.deletePrompt);
            this.popDelete.Location = new System.Drawing.Point(447, 124);
            this.popDelete.Name = "popDelete";
            this.popDelete.Size = new System.Drawing.Size(283, 164);
            this.popDelete.TabIndex = 23;
            this.popDelete.Visible = false;
            this.popDelete.Paint += new System.Windows.Forms.PaintEventHandler(this.popDelete_Paint);
            // 
            // deleteText
            // 
            this.deleteText.Location = new System.Drawing.Point(17, 73);
            this.deleteText.Name = "deleteText";
            this.deleteText.Size = new System.Drawing.Size(246, 20);
            this.deleteText.TabIndex = 1;
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(36, 122);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(79, 30);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.LimeGreen;
            this.Confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm.FlatAppearance.BorderSize = 0;
            this.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.ForeColor = System.Drawing.Color.White;
            this.Confirm.Location = new System.Drawing.Point(172, 122);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(79, 30);
            this.Confirm.TabIndex = 3;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // createFile
            // 
            this.createFile.AutoSize = true;
            this.createFile.ForeColor = System.Drawing.Color.White;
            this.createFile.Location = new System.Drawing.Point(210, 510);
            this.createFile.Name = "createFile";
            this.createFile.Size = new System.Drawing.Size(50, 17);
            this.createFile.TabIndex = 24;
            this.createFile.Text = "File";
            this.createFile.UseVisualStyleBackColor = true;
            this.createFile.CheckedChanged += new System.EventHandler(this.createFile_CheckedChanged);
            // 
            // createFolder
            // 
            this.createFolder.AutoSize = true;
            this.createFolder.ForeColor = System.Drawing.Color.White;
            this.createFolder.Location = new System.Drawing.Point(210, 531);
            this.createFolder.Name = "createFolder";
            this.createFolder.Size = new System.Drawing.Size(62, 17);
            this.createFolder.TabIndex = 25;
            this.createFolder.Text = "Folder";
            this.createFolder.UseVisualStyleBackColor = true;
            this.createFolder.CheckedChanged += new System.EventHandler(this.createFolder_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 18.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(328, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 18.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(425, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "|";
            // 
            // FileHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1099, 639);
            this.Controls.Add(this.READ);
            this.Controls.Add(this.done);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createFolder);
            this.Controls.Add(this.createFile);
            this.Controls.Add(this.popDelete);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentPath);
            this.Controls.Add(this.Files);
            this.Controls.Add(this.Folders);
            this.Controls.Add(this.drivers);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.FileTextName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.path);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.CREATE);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FileHandler";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Handling";
            this.Load += new System.EventHandler(this.FileHandler_Load);
            this.popDelete.ResumeLayout(false);
            this.popDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SAVE;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button CREATE;
        private System.Windows.Forms.Button READ;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileTextName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ListBox drivers;
        private System.Windows.Forms.ListBox Folders;
        private System.Windows.Forms.ListBox Files;
        private System.Windows.Forms.Label currentPath;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label deletePrompt;
        private System.Windows.Forms.Panel popDelete;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox deleteText;
        private System.Windows.Forms.CheckBox createFile;
        private System.Windows.Forms.CheckBox createFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

