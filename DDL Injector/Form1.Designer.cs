
namespace DDL_Injector
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.inject_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.injectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pid_box = new System.Windows.Forms.TextBox();
            this.lock_on_pid = new System.Windows.Forms.Button();
            this.Pid_label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.name_label = new System.Windows.Forms.Label();
            this.choose_file = new System.Windows.Forms.Button();
            this.file_path = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "*.dll|";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // inject_button
            // 
            this.inject_button.Location = new System.Drawing.Point(256, 170);
            this.inject_button.Name = "inject_button";
            this.inject_button.Size = new System.Drawing.Size(99, 37);
            this.inject_button.TabIndex = 0;
            this.inject_button.Text = "Inject";
            this.inject_button.UseVisualStyleBackColor = true;
            this.inject_button.Click += new System.EventHandler(this.inject_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.injectToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.openToolStripMenuItem.Text = "Open ";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // injectToolStripMenuItem
            // 
            this.injectToolStripMenuItem.Name = "injectToolStripMenuItem";
            this.injectToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.injectToolStripMenuItem.Text = "Inject";
            this.injectToolStripMenuItem.Click += new System.EventHandler(this.injectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pid_box
            // 
            this.pid_box.Location = new System.Drawing.Point(73, 47);
            this.pid_box.Name = "pid_box";
            this.pid_box.Size = new System.Drawing.Size(84, 20);
            this.pid_box.TabIndex = 5;
            this.pid_box.TextChanged += new System.EventHandler(this.pid_box_TextChanged);
            // 
            // lock_on_pid
            // 
            this.lock_on_pid.Location = new System.Drawing.Point(184, 44);
            this.lock_on_pid.Name = "lock_on_pid";
            this.lock_on_pid.Size = new System.Drawing.Size(75, 23);
            this.lock_on_pid.TabIndex = 7;
            this.lock_on_pid.Text = "Refresh";
            this.lock_on_pid.UseVisualStyleBackColor = true;
            this.lock_on_pid.Click += new System.EventHandler(this.lock_on_pid_Click);
            // 
            // Pid_label
            // 
            this.Pid_label.AutoSize = true;
            this.Pid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pid_label.Location = new System.Drawing.Point(12, 47);
            this.Pid_label.Name = "Pid_label";
            this.Pid_label.Size = new System.Drawing.Size(40, 20);
            this.Pid_label.TabIndex = 8;
            this.Pid_label.Text = "PID:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name_label.Location = new System.Drawing.Point(12, 74);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(55, 20);
            this.name_label.TabIndex = 10;
            this.name_label.Text = "Name:";
            // 
            // choose_file
            // 
            this.choose_file.Location = new System.Drawing.Point(311, 48);
            this.choose_file.Name = "choose_file";
            this.choose_file.Size = new System.Drawing.Size(75, 23);
            this.choose_file.TabIndex = 11;
            this.choose_file.Text = "Choose File";
            this.choose_file.UseVisualStyleBackColor = true;
            this.choose_file.Click += new System.EventHandler(this.choose_file_Click);
            // 
            // file_path
            // 
            this.file_path.Enabled = false;
            this.file_path.Location = new System.Drawing.Point(311, 77);
            this.file_path.Name = "file_path";
            this.file_path.Size = new System.Drawing.Size(235, 20);
            this.file_path.TabIndex = 12;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 219);
            this.Controls.Add(this.file_path);
            this.Controls.Add(this.choose_file);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Pid_label);
            this.Controls.Add(this.lock_on_pid);
            this.Controls.Add(this.pid_box);
            this.Controls.Add(this.inject_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dll Injector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button inject_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem injectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Pid_label;
        private System.Windows.Forms.Button lock_on_pid;
        private System.Windows.Forms.TextBox pid_box;
        private System.Windows.Forms.TextBox file_path;
        private System.Windows.Forms.Button choose_file;
    }
}

