//Function

private Icon ConvertToIcon(Image image)
{
    Bitmap bmp = new Bitmap(image, new Size(256, 256));
    IntPtr Hicon = bmp.GetHicon();
    Icon icon = Icon.FromHandle(Hicon);
    return icon;
}

//Exaple.cs

try
{
    using (var SaveFileDialog = new SaveFileDialog() { Filter = "Windowsアイコンイメージ形式(*.ico) | *.ico" })
    {
        //Load
        Image pngimage = Image.FromFile(this.FilePathTextBox.Text)
        //Convert
        Icon iconimage = ConvertToIcon(pngimage)
        if (SaveFileDialog.ShowDialog() == DialogResult.OK)
        {
            string savePath = SaveFileDialog.FileName;
            using (FileStream FileStream = new FileStream(savePath, FileMode.Create))
            {
                iconimage.Save(FileStream);
        
            MessageBox.Show("The Icon File was saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
catch(Exception ex)
{
    MessageBox.Show(ex.Message, "Convert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}