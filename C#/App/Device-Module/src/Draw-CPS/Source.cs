using System;
using System.Windows.Forms;

namespace Draw_CPS
{
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();

            //Timer Setting
            Timer.Interval = 1000;
            Timer.Start();
        }

        private DateTime lastClickedTime = DateTime.Now;
        private int clickCount = 0;

        private void ClickButton_Click(object sender, EventArgs e)
        {
            clickCount++;
            var now = DateTime.Now;
            var elapsedSeconds = (now - lastClickedTime).TotalSeconds;
            var cps = (double)clickCount / elapsedSeconds;
            CPSLabel.Text = string.Format("{0:F2}", cps);
            lastClickedTime = now;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var elapsedSeconds = (now - lastClickedTime).TotalSeconds;
            var cps = (double)clickCount / elapsedSeconds;
            CPSLabel.Text = string.Format("{0:F2}", cps);
        }
    }
}