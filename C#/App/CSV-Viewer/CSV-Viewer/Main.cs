using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSV_Viewer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        string Path;

        private void OpenButton_Click(object sender, EventArgs e)
        {
            using (var Dialog = new OpenFileDialog() { Filter = "CSVデータテーブル形式(*.csv) | *.csv" })
            {
                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    Path = Dialog.FileName;
                    this.FilePathTextBox.Text = Path;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar.Value = 0;
                CSVListBox.Items.Clear();

                string[] lines = System.IO.File.ReadAllLines(Path);
                int rowCount = lines.Length;

                progressBar.Minimum = 0;
                progressBar.Maximum = rowCount;

                foreach (string line in lines)
                {
                    CSVListBox.Items.Add(line);
                    progressBar.Value++;
                }

                //MessageBox.Show("Successfully", "Entry CSV", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
