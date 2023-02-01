//OutputTextBox1.Text = ToHex(InputTextBox.Text);

public string ToHex (string inp)
{
  string outp = string.Empty;
  char[] value = inp.ToCharArry();
  foreach (char L in value)
  {
    int V = Convert.ToInt32(L);
    outp+=string.Format("{0:x}",V);
  }
  return outp;
}