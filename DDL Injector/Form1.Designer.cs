
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
            this.openProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pid_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
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
            this.inject_button.Location = new System.Drawing.Point(12, 72);
            this.inject_button.Name = "inject_button";
            this.inject_button.Size = new System.Drawing.Size(99, 37);
            this.inject_button.TabIndex = 0;
            this.inject_button.Text = "Inject";
            this.inject_button.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(274, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.injectToolStripMenuItem,
            this.openProcessToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open ";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // injectToolStripMenuItem
            // 
            this.injectToolStripMenuItem.Name = "injectToolStripMenuItem";
            this.injectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.injectToolStripMenuItem.Text = "Inject";
            // 
            // openProcessToolStripMenuItem
            // 
            this.openProcessToolStripMenuItem.Name = "openProcessToolStripMenuItem";
            this.openProcessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openProcessToolStripMenuItem.Text = "Open process";
            // 
            // pid_label
            // 
            this.pid_label.AutoSize = true;
            this.pid_label.Location = new System.Drawing.Point(12, 56);
            this.pid_label.Name = "pid_label";
            this.pid_label.Size = new System.Drawing.Size(28, 13);
            this.pid_label.TabIndex = 3;
            this.pid_label.Text = "PID:";
            this.pid_label.Click += new System.EventHandler(this.pid_label_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 121);
            this.Controls.Add(this.pid_label);
            this.Controls.Add(this.inject_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Dll Injector";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem openProcessToolStripMenuItem;
        private System.Windows.Forms.Label pid_label;
    }
}

