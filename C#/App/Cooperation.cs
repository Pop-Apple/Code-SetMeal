
//MainFormのコード:

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void btnOpenSubForm_Click(object sender, EventArgs e)
    {
        SubForm subForm = new SubForm(); // SubFormを生成
        subForm.Owner = this; // MainFormをSubFormのオーナーに設定
        subForm.ShowDialog(); // SubFormをモーダルダイアログで表示
    }

    public void SetLabelText(string text)
    {
        lblDisplayText.Text = text; // Labelのテキストを設定
    }
}



//SubFormのコード:

public partial class SubForm : Form
{
    public SubForm()
    {
        InitializeComponent();
    }

    private void btnSetText_Click(object sender, EventArgs e)
    {
        string text = txtInputText.Text; // 入力されたテキストを取得

        MainForm mainForm = (MainForm)this.Owner; // MainFormを取得
        mainForm.SetLabelText(text); // MainFormのメソッドを呼び出して、Labelのテキストを設定
    }
}

/*MainFormには、SubFormを開くためのButtonとLabelが配置されています。btnOpenSubForm_Clickイベントハンドラーでは、SubFormを生成して、OwnerプロパティにMainFormを設定し、SubFormをモーダルダイアログとして表示します。

SubFormには、テキストを入力するためのTextBoxと、テキストを設定するためのButtonがあります。btnSetText_Clickイベントハンドラーでは、入力されたテキストを取得し、OwnerプロパティからMainFormを取得して、SetLabelTextメソッドを呼び出して、Labelのテキストを設定します。

以上のように、MainFormとSubFormの間でデータの受け渡しを行うことができます。Ownerプロパティを使って、親フォームから子フォームを参照できるため、データの受け渡しが簡単に行えます。*/
