using System;
using System.IO;
using System.Windows.Forms;

namespace EasyDeleteDirectory
{
    public partial class EasyDeleteDirectoryForm : Form
    {
        public EasyDeleteDirectoryForm() => InitializeComponent();

        private void SelectDirectoryButton_Click(object sender, EventArgs e)
        {
            var result = FolderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
                TargetDirectoryPathTextBox.Text = FolderBrowserDialog.SelectedPath;
        }

        private void DeleteDirectoryButton_Click(object sender, EventArgs e)
        {
            MessageTextBox.Text = string.Empty;

            var selectedDirectoryPath = TargetDirectoryPathTextBox.Text;

            if (!string.IsNullOrEmpty(selectedDirectoryPath))
            {
                var subDirectoryPaths =
                    Directory.GetDirectories(selectedDirectoryPath);

                var targetDirectoryNames =
                    TargetDirectoryNamesTextBox.Text.Split(',', StringSplitOptions.RemoveEmptyEntries);

                foreach (var subDirectoryPath in subDirectoryPaths)
                {
                    foreach (var targetDirectoryName in targetDirectoryNames)
                    {
                        var targetDirectoryPaths =
                            Directory.GetDirectories(subDirectoryPath, targetDirectoryName, SearchOption.AllDirectories);

                        foreach (var targetDirectoryPath in targetDirectoryPaths)
                        {
                            MessageTextBox.AppendText($"Find the target directory: {targetDirectoryPath} ... {Environment.NewLine}");

                            if (Directory.Exists(targetDirectoryPath))
                                Directory.Delete(targetDirectoryPath, true);
                        }
                    }
                }

                MessageTextBox.AppendText($"Delete all target directory is completed!");
            }
            else
            {
                MessageBox.Show("First of all, please select your target directory.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
