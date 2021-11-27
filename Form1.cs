using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace BulkGitClone {
    public partial class Form1 : Form {
        private static string downloadTo;
        public Form1() {
            InitializeComponent();
        }
        private void downloadGitRepo(string url) {
            Process p = new Process();
            p.StartInfo.WorkingDirectory = downloadTo;
            p.StartInfo.FileName = "git";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.Arguments = "clone " + url;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            logBox.Text = logBox.Text + "\n" + p.StandardOutput.ReadToEnd();
        }
        private void startDownloading(string txtFile) {
            var lines = File.ReadLines(txtFile);

            foreach (string line in lines) {
                string[] splitUrl = line.Split('/');
                string ownerName = splitUrl[3];
                string repoName = splitUrl[4];
                string longRepoName = ownerName + "/" + repoName;

                reposListBox.Items.Add(longRepoName);

                downloadGitRepo(line);
            }
            MessageBox.Show("Finished.");
        }
        private void selectTxtButton_Click(object sender, EventArgs e) {
            var openDialog = openText;
            if(openDialog.ShowDialog() == DialogResult.OK) {
                string selectedFile = openDialog.FileName;

                selectedTxtFileBox.Text = selectedFile;

                var browseFolder = openFolder;

                if(browseFolder.ShowDialog() == DialogResult.OK) {
                    downloadTo = browseFolder.SelectedPath;
                    //MessageBox.Show(downloadTo); // for debugging

                    startDownloading(selectedFile);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
