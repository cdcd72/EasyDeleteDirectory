using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WK.Libraries.BetterFolderBrowserNS;

namespace EasyDeleteDirectory
{
    public partial class EasyDeleteDirectoryForm : Form
    {
        public EasyDeleteDirectoryForm() => InitializeComponent();

        private void SelectDirectoryButton_Click(object sender, EventArgs e)
        {
            var folderBrowser = new BetterFolderBrowser
            {
                Title = "Select folders...",
                Multiselect = true
            };

            if (folderBrowser.ShowDialog() is DialogResult.OK)
                TargetDirectoryTextBox.Text = string.Join(",", folderBrowser.SelectedFolders);
        }

        private void ClearDirectoryButton_Click(object sender, EventArgs e) => TargetDirectoryTextBox.Text = string.Empty;

        private void DeleteDirectoryButton_Click(object sender, EventArgs e)
        {
            MessageTextBox.Text = string.Empty;

            var selectedDirectories = TargetDirectoryTextBox.Text.Split(new []{ ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (!selectedDirectories.Any())
            {
                MessageBox.Show(@"First of all, please select your target directories.", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var targetDirectoryNames = TargetDirectoryNamesTextBox.Text.Split(new []{ ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach(var selectedDirectory in selectedDirectories)
            {
                foreach (var subDirectory in Directory.GetDirectories(selectedDirectory))
                {
                    DeleteDirectoryByNames(subDirectory, targetDirectoryNames);
                }
            }

            MessageTextBox.AppendText("Delete all target directory is completed!");
        }

        private void DeleteDirectoryByNames(string directory, string[] names)
        {
            if (names.Length == 0) return;

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
