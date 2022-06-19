using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EasyDeleteDirectory
{
    public partial class EasyDeleteDirectoryForm : Form
    {
        public EasyDeleteDirectoryForm() => InitializeComponent();

        private void SelectDirectoryButton_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() is DialogResult.OK)
                TargetDirectoryTextBox.Text = FolderBrowserDialog.SelectedPath;
        }

        private void ClearDirectoryButton_Click(object sender, EventArgs e) => TargetDirectoryTextBox.Text = string.Empty;

        private void DeleteDirectoryButton_Click(object sender, EventArgs e)
        {
            MessageTextBox.Text = string.Empty;

            var selectedDirectory = TargetDirectoryTextBox.Text;

            if (string.IsNullOrEmpty(selectedDirectory))
            {
                MessageBox.Show("First of all, please select your target directory.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var targetDirectoryNames =
                TargetDirectoryNamesTextBox.Text.Split(',', StringSplitOptions.RemoveEmptyEntries);

            foreach (var subDirectory in Directory.GetDirectories(selectedDirectory))
            {
                DeleteDirectoryByNames(subDirectory, targetDirectoryNames);
            }

            MessageTextBox.AppendText("Delete all target directory is completed!");
        }

        private void DeleteDirectoryByNames(string directory, string[] names)
        {
            if (!names.Any()) return;

            foreach (var name in names)
            {
                foreach (var subDirectory in Directory.GetDirectories(directory, name, SearchOption.AllDirectories))
                {
                    DeleteDirectory(subDirectory, true, () => MessageTextBox.AppendText($"{subDirectory} deleted! {Environment.NewLine}"));
                }
            }
        }

        private static void DeleteDirectory(string directory, bool recursive, Action action)
        {
            if (!Directory.Exists(directory)) return;

            Directory.Delete(directory, recursive);

            action();
        }
    }
}
