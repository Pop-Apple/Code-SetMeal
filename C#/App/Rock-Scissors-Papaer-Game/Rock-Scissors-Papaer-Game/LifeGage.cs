using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Scissors_Papaer_Game
{
    internal class LifeGage
    {
        private ProgressBar progressBar;

        public LifeGage(ProgressBar progressBar, int maxLife)
        {
            this.progressBar = progressBar;
            this.progressBar.Maximum = maxLife;
            this.progressBar.Step = -1;
        }
        public void Attack()
        {
            this.progressBar.PerformStep();
        }

        public bool Alive => this.progressBar.Value > 0;

        public void ResetLife()
        {
            this.progressBar.Value = this.progressBar.Maximum;
        }
    }
}
