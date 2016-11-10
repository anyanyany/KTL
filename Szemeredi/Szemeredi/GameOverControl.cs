using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szemeredi
{
    public partial class GameOverControl : UserControl
    {
        public GameOverControl()
        {
            InitializeComponent();
        }

        private void startNewGameButton_Click(object sender, EventArgs e)
        {
            Form1.NewGame();
        }

        public void setText(Engine.Winner winner)
        {
            switch (winner)
            {
                case Engine.Winner.Player:
                    winnerLabel.Text = "WYGRANA!";
                    break;
                case Engine.Winner.Computer:
                    winnerLabel.Text = "PRZEGRANA";
                    break;
                case Engine.Winner.Tie:
                    winnerLabel.Text = "REMIS";
                    break;
            }
        }
    }
}
