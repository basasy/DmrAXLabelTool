namespace DmrAXLabelTool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.removeDuplicate = new System.Windows.Forms.Button();
            this.sort = new System.Windows.Forms.Button();
            this.sortAndRemove = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            this.OpenFileManager = new System.Windows.Forms.Button();
            this.labelEditor = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.SaveAndOverWrite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // removeDuplicate
            // 
            this.removeDuplicate.Enabled = false;
            this.removeDuplicate.Location = new System.Drawing.Point(568, 29);
            this.removeDuplicate.Name = "removeDuplicate";
            this.removeDuplicate.Size = new System.Drawing.Size(162, 41);
            this.removeDuplicate.TabIndex = 0;
            this.removeDuplicate.Text = "Remove Duplicate";
            this.removeDuplicate.UseVisualStyleBackColor = true;
            this.removeDuplicate.Click += new System.EventHandler(this.removeDuplicate_Click);
            // 
            // sort
            // 
            this.sort.Enabled = false;
            this.sort.Location = new System.Drawing.Point(568, 78);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(162, 41);
            this.sort.TabIndex = 1;
            this.sort.Text = "Sort";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // sortAndRemove
            // 
            this.sortAndRemove.Enabled = false;
            this.sortAndRemove.Location = new System.Drawing.Point(568, 125);
            this.sortAndRemove.Name = "sortAndRemove";
            this.sortAndRemove.Size = new System.Drawing.Size(162, 41);
            this.sortAndRemove.TabIndex = 2;
            this.sortAndRemove.Text = "Sort and Remove Duplicate";
            this.sortAndRemove.UseVisualStyleBackColor = true;
            this.sortAndRemove.Click += new System.EventHandler(this.sortAndRemove_Click);
            // 
            // fileName
            // 
            this.fileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileName.Location = new System.Drawing.Point(12, 38);
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            this.fileName.Size = new System.Drawing.Size(480, 22);
            this.fileName.TabIndex = 3;
            // 
            // OpenFileManager
            // 
            this.OpenFileManager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenFileManager.BackgroundImage")));
            this.OpenFileManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenFileManager.Location = new System.Drawing.Point(498, 34);
            this.OpenFileManager.Name = "OpenFileManager";
            this.OpenFileManager.Size = new System.Drawing.Size(36, 31);
            this.OpenFileManager.TabIndex = 4;
            this.OpenFileManager.UseVisualStyleBackColor = true;
            this.OpenFileManager.Click += new System.EventHandler(this.OpenFileManager_Click);
            // 
            // labelEditor
            // 
            this.labelEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEditor.Location = new System.Drawing.Point(12, 78);
            this.labelEditor.Multiline = true;
            this.labelEditor.Name = "labelEditor";
            this.labelEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.labelEditor.Size = new System.Drawing.Size(522, 516);
            this.labelEditor.TabIndex = 5;
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(568, 483);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(162, 32);
            this.save.TabIndex = 6;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // SaveAndOverWrite
            // 
            this.SaveAndOverWrite.Enabled = false;
            this.SaveAndOverWrite.Location = new System.Drawing.Point(568, 521);
            this.SaveAndOverWrite.Name = "SaveAndOverWrite";
            this.SaveAndOverWrite.Size = new System.Drawing.Size(162, 32);
            this.SaveAndOverWrite.TabIndex = 7;
            this.SaveAndOverWrite.Text = "Save and Overwrite";
            this.SaveAndOverWrite.UseVisualStyleBackColor = true;
            this.SaveAndOverWrite.Click += new System.EventHandler(this.SaveAndOverWrite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Folder";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(756, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveAndOverWrite);
            this.Controls.Add(this.save);
            this.Controls.Add(this.labelEditor);
            this.Controls.Add(this.OpenFileManager);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.sortAndRemove);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.removeDuplicate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D365 Label Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button OpenFileManager;
        public System.Windows.Forms.TextBox fileName;
        public System.Windows.Forms.TextBox labelEditor;
        public System.Windows.Forms.Button removeDuplicate;
        public System.Windows.Forms.Button sort;
        public System.Windows.Forms.Button sortAndRemove;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button SaveAndOverWrite;
        private System.Windows.Forms.Label label1;
    }
}

