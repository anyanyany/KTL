using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szemeredi
{
    public partial class Form1 : Form
    {
        static NewGameSetupControl newGameControl;
        static GameControl gameControl;
        static GameOverControl gameOverControl;

        public Form1()
        {
            InitializeComponent();
            newGameControl = new NewGameSetupControl();
            gameControl = new GameControl();
            gameOverControl = new GameOverControl();

            mainPanel.Controls.Add(newGameControl);
            mainPanel.Controls.Add(gameControl);
            mainPanel.Controls.Add(gameOverControl);
            newGameControl.Anchor = AnchorStyles.None;
            newGameControl.Left = (mainPanel.Width - newGameControl.Width) / 2;
            newGameControl.Top = (mainPanel.Height - newGameControl.Height) / 2;
            gameOverControl.Anchor = AnchorStyles.None;
            gameOverControl.Left = (mainPanel.Width - gameOverControl.Width) / 2;
            gameOverControl.Top = (mainPanel.Height - gameOverControl.Height) / 2;
            gameControl.Dock = DockStyle.Fill;
            gameControl.Enabled = false;
            gameControl.Visible = false;
            gameOverControl.Enabled = false;
            gameOverControl.Visible = false;
        }

        public static void showGameWindow(int n, int k, bool playerFirstMove, Color playerColor, Color computerColor, bool easyLevel)
        {
            newGameControl.Enabled = false;
            newGameControl.Visible = false;
            gameOverControl.Enabled = false;
            gameOverControl.Visible = false;
            gameControl.Enabled = true;
            gameControl.Visible = true;
            gameControl.Reset(n, k, playerFirstMove, playerColor, computerColor, easyLevel);
        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        public static void NewGame()
        {
            newGameControl.Enabled = true;
            newGameControl.Visible = true;
            gameControl.Enabled = false;
            gameControl.Visible = false;
            gameOverControl.Enabled = false;
            gameOverControl.Visible = false;
        }

        public static void GameOver(Engine.Winner winner, List<int> sequence=null)
        {
            gameControl.Enabled = false;
            gameControl.Visible = false;
            gameOverControl.setText(winner, sequence);
            gameOverControl.Enabled = true;
            gameOverControl.Visible = true;
        }
    }
}
