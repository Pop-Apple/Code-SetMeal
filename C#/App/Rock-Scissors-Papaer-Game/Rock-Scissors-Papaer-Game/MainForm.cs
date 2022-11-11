using JankenBattle;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rock_Scissors_Papaer_Game
{
    public partial class MainForm : Form
    {
        private int roundCount;
        private int wonCount;
        private int lossCount;

        private PictureBox[] winLossResults;

        private LifeGage playerLifeGage;
        private LifeGage enemyLifeGage;

        private bool InGame
        {
            set
            {
                RockButtonPictureBox.Enabled = value;
                ScissorsButtonPictureBox.Enabled = value;
                PaperButtonPictureBox.Enabled = value;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            winLossResults = new[]
            {
                WinLoss1PictureBox,
                WinLoss2PictureBox,
                WinLoss3PictureBox,
                WinLoss4PictureBox,
                WinLoss5PictureBox
            };
            //HP
            playerLifeGage = new LifeGage(playerLifeProgressbar, 4);
            enemyLifeGage = new LifeGage(enemyLifeProgressbar, 4);
        }
        private void Win()
        {
            MessageBox.Show("あなたの勝ちです","Win", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void Losing()
        {
            MessageBox.Show("あなたの負けです","Lose", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void Even()
        {
            MessageBox.Show("あいこです");
        }
        private void EndGame()
        {
            MessageBox.Show("ゲーム終了！","GameEnd", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void RockButtonPictureBox_Click(object sender, EventArgs e)
        {
            var playerHand = JankenHand.Rock;
            /* Image handImage = GethandImage(playerHand);
             PlayerHandPictureBox.Image = handImage;*/
            Battle(playerHand);
        }
        private void Battle(JankenHand playerHand)
        {
            PlayerHandPictureBox.Image = GethandImage(playerHand);

            var random = new Random();
            var enemyHandValue = random.Next(0, 3);
            var enemyHand = (JankenHand)enemyHandValue;

            EnemyHandPictureBox.Image = GethandImage(enemyHand);

            //勝敗の識別
            JankenResult jankenResult;
            if (playerHand == enemyHand)
            {
                //あいこ
                jankenResult = JankenResult.Even;
            }
            else if ((playerHand == JankenHand.Rock && enemyHand == JankenHand.Scissors) || (playerHand == JankenHand.Scissors && enemyHand == JankenHand.Paper) || (playerHand == JankenHand.Paper && enemyHand == JankenHand.Rock))
            {
                //勝ち
                jankenResult = JankenResult.Win;
            }
            else
            {
                //負け
                jankenResult = JankenResult.Losing;
            }

            switch (jankenResult)
            {
                case JankenResult.Even:
                    /* Even();
                    MessageBox.Show("あいこです" +Environment.NewLine+ "" +Environment.NewLine+ "もう一度手を選んでください","Even", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    */
                    return;
                case JankenResult.Win:
                    //攻撃
                    enemyLifeGage.Attack();
                    //
                    /*Win();
                    wonCount += 1;
                    winLossResults[roundCount - 1].Image = Properties.Resources.Circle;
                    */
                    break;
                case JankenResult.Losing:
                    //攻撃
                    playerLifeGage.Attack();
                    //
                    /*Losing();
                    lossCount += 1;
                    winLossResults[roundCount - 1].Image = Properties.Resources.Cross;
                    */
                    break;
                default:
                    break;
            }

            //ライフが残っていればラウンドの継続
            if(playerLifeGage.Alive && enemyLifeGage.Alive)
            {
                return;
            }
            //どちらかのライフがなのでラウンド終了
            Image winLossResultImage;
            if(playerLifeGage.Alive)
            {
                MessageBox.Show($"{roundCount}回戦はあなたの勝ちです");
                wonCount += 1;
                winLossResultImage = Properties.Resources.Circle;
            }
            else
            {
                MessageBox.Show($"{roundCount}回戦はあなたの負けです");
               lossCount += 1;
                winLossResultImage = Properties.Resources.Cross;
            }
            winLossResults[roundCount - 1].Image = winLossResultImage;

            if (wonCount == 3 || lossCount == 3)
            {
                EndGame();

                string gameResult;
                if(wonCount > lossCount)
                {
                    gameResult = "ゲームクリア！";
                }
                else
                {
                    gameResult = "ゲームオーバー！";
                }
                MessageBox.Show($"{gameResult} ({wonCount} 勝 {lossCount} 敗)","GameStatus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                InGame = false;

                return;
            }

            NextRound();
        }
        private static Image GethandImage(JankenHand hand)
        {
            Image handImage;
            if (hand == JankenHand.Rock)
            {
                handImage = Properties.Resources.Rock;
            }
            else if (hand == JankenHand.Scissors)
            {
                handImage = Properties.Resources.Scissors;
            }
            else
            {
                handImage = Properties.Resources.Paper;
            }

            return handImage;
        }
        private void ScissorsButtonPictureBox_Click(object sender, EventArgs e)
        {
            var playerHand = JankenHand.Scissors;
            Battle(playerHand);
        }
        private void PaperButtonPictureBox_Click(object sender, EventArgs e)
        {
            var playerHand = JankenHand.Paper;
            Battle(playerHand);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //画面の初期化
            //画像の選択を無効化
            /*RockButtonPictureBox.Enabled = false;
            ScissorsButtonPictureBox.Enabled = false;
            PaperButtonPictureBox.Enabled = false;*/
            InGame = false;
        }
        private void NextRound()
        {
            playerLifeGage.ResetLife();
            enemyLifeGage.ResetLife();

            PlayerHandPictureBox.Image = null;
            EnemyHandPictureBox.Image = null;

            //ラウンド数の加算
            roundCount += 1;

            MessageBox.Show($"{roundCount}回戦","RoundCount", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            playerLifeProgressbar.Value = 0;
            enemyLifeProgressbar.Value = 0;
            //画像の選択を有効化
            /*RockButtonPictureBox.Enabled = true;
            ScissorsButtonPictureBox.Enabled = true;
            PaperButtonPictureBox.Enabled = true;*/
            InGame = true;
            //画像のクリア
            PlayerHandPictureBox.Image = null;
            EnemyHandPictureBox.Image = null;
                
            foreach (var pictureBox in winLossResults)
            {
                pictureBox.Image = null;
            }
                ;
            MessageBox.Show("ゲームスタート！","GameStart", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //ラウント数の初期化

            roundCount = 0;

            //勝敗数の初期化
            wonCount = 0;
            lossCount = 0;

            NextRound();
        }
        private void 終了EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void スタートSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnStart_Click(sender, e);
        }

        private void 情報JToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var Information = new AboutBox1())
            {
                Information.ShowDialog();
            }
        }
    }
}
