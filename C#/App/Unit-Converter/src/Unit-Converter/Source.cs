using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Unit_Converter
{
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();
            TabDistanceButton.BackColor = Color.LightSteelBlue;
        }

        private void TabDistanceButton_Click(object sender, EventArgs e)
        {
            TabDistanceButton.BackColor = Color.LightSteelBlue;
            TabCostButton.BackColor = Color.Transparent;
            TabUnicodeButton.BackColor = Color.Transparent;
        }

        private void TabCostButton_Click(object sender, EventArgs e)
        {
            TabCostButton.BackColor = Color.LightSteelBlue;
            TabDistanceButton.BackColor = Color.Transparent;
            TabUnicodeButton.BackColor = Color.Transparent;
        }

        private void TabUnicodeButton_Click(object sender, EventArgs e)
        {
            TabUnicodeButton.BackColor = Color.LightSteelBlue;
            TabDistanceButton.BackColor = Color.Transparent;
            TabCostButton.BackColor = Color.Transparent;
        }

        private void CheckBoxmm_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxmm.Checked)
            {
                this.CheckBoxm.Enabled = false;
                this.CheckBoxkm.Enabled = false;
            }
            else
            {
                this.CheckBoxm.Enabled = true;
                this.CheckBoxkm.Enabled = true;
            }
        }

        private void CheckBoxm_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxm.Checked)
            {
                this.CheckBoxmm.Enabled = false;
                this.CheckBoxkm.Enabled = false;
            }
            else
            {
                this.CheckBoxmm.Enabled = true;
                this.CheckBoxkm.Enabled = true;
            }
        }

        private void CheckBoxkm_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxkm.Checked)
            {
                this.CheckBoxm.Enabled = false;
                this.CheckBoxmm.Enabled = false;
            }
            else
            {
                this.CheckBoxm.Enabled = true;
                this.CheckBoxmm.Enabled = true;
            }
        }
        private void UnChecked()
        {
            this.CheckBoxmm.Checked = false;
            this.CheckBoxm.Checked = false;
            this.CheckBoxkm.Checked = false;
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            if (SourceTextBox.Text.Length == 0)
            {
                MessageBox.Show("数値の入力を完了してください", "Unit Conversions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //ミリメートル
                if (this.CheckBoxmm.Checked)
                {
                    try
                    {
                        double Value = Convert.ToDouble(SourceTextBox.Text);
                        this.ResultTextBox.Text = (Value * 10).ToString() + CheckBoxmm.Text;
                        this.ResultTextBox.SelectAll();
                        this.ResultTextBox.Copy();
                        if (AutoCheckBox.Checked == false)
                        {
                            UnChecked();
                        }
                    }
                    catch (Exception ex)
                    {
                        this.SourceTextBox.Clear();
                        UnChecked();
                        MessageBox.Show(ex.Message, "Unit Conversion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                //メートル
                else if (this.CheckBoxm.Checked)
                {
                    try
                    {
                        double Value = Convert.ToDouble(SourceTextBox.Text);
                        this.ResultTextBox.Text = (Value / 100).ToString() + CheckBoxm.Text;
                        this.ResultTextBox.SelectAll();
                        this.ResultTextBox.Copy();
                        if (AutoCheckBox.Checked == false)
                        {
                            UnChecked();
                        }
                    }
                    catch (Exception ex)
                    {
                        this.SourceTextBox.Clear();
                        UnChecked();
                        MessageBox.Show(ex.Message, "Unit Conversion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                //キロメートル
                else if (this.CheckBoxkm.Checked)
                {
                    try
                    {
                        double Value = Convert.ToDouble(SourceTextBox.Text);
                        this.ResultTextBox.Text = (Value / 100000).ToString() + CheckBoxkm.Text;
                        this.ResultTextBox.SelectAll();
                        this.ResultTextBox.Copy();
                        if (AutoCheckBox.Checked == false)
                        {
                            UnChecked();
                        }
                    }
                    catch (Exception ex)
                    {
                        this.SourceTextBox.Clear();
                        UnChecked();
                        MessageBox.Show(ex.Message, "Unit Conversion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Length == 0)
            {
                this.CopyButton.Enabled = false;
            }
            else
            {
                this.CopyButton.Enabled = true;
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ResultTextBox.SelectAll();
                this.ResultTextBox.Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unit Conversion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //StreamWriter sw = new StreamWriter(this.ResultTextBox.Text);
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "Text Document (*.txt) | *.txt";
                dialog.FileName = "ToResult";
                dialog.ShowDialog();
                File.WriteAllText(dialog.FileName, "<r>" + this.ResultTextBox.Text + "<r>");
            }
        }
    }
}
