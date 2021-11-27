
namespace BulkGitClone {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.selectTxtButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedTxtFileBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reposListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.openText = new System.Windows.Forms.OpenFileDialog();
            this.openFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectTxtButton
            // 
            this.selectTxtButton.Location = new System.Drawing.Point(12, 8);
            this.selectTxtButton.Name = "selectTxtButton";
            this.selectTxtButton.Size = new System.Drawing.Size(137, 23);
            this.selectTxtButton.TabIndex = 0;
            this.selectTxtButton.Text = "Select TXT && Download";
            this.selectTxtButton.UseVisualStyleBackColor = true;
            this.selectTxtButton.Click += new System.EventHandler(this.selectTxtButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected: ";
            // 
            // selectedTxtFileBox
            // 
            this.selectedTxtFileBox.Location = new System.Drawing.Point(75, 37);
            this.selectedTxtFileBox.Name = "selectedTxtFileBox";
            this.selectedTxtFileBox.Size = new System.Drawing.Size(249, 20);
            this.selectedTxtFileBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reposListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Git repositories to download";
            // 
            // reposListBox
            // 
            this.reposListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reposListBox.FormattingEnabled = true;
            this.reposListBox.Location = new System.Drawing.Point(3, 16);
            this.reposListBox.Name = "reposListBox";
            this.reposListBox.Size = new System.Drawing.Size(309, 81);
            this.reposListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 141);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // logBox
            // 
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.Location = new System.Drawing.Point(3, 16);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(309, 122);
            this.logBox.TabIndex = 0;
            this.logBox.Text = "";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(241, 316);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // openText
            // 
            this.openText.FileName = "repositories.txt";
            this.openText.Filter = "Text files|*.txt|All files|*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 345);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.selectedTxtFileBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectTxtButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bulk Git Clone v0.6.6b (Log broken)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectTxtButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selectedTxtFileBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListBox reposListBox;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.OpenFileDialog openText;
        private System.Windows.Forms.FolderBrowserDialog openFolder;
    }
}

