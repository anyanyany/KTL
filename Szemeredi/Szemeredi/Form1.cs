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

        public Form1()
        {
            InitializeComponent();
            newGameControl = new NewGameSetupControl();
            gameControl = new GameControl();

            mainPanel.Controls.Add(newGameControl);
            mainPanel.Controls.Add(gameControl);
            newGameControl.Anchor = AnchorStyles.None;
            newGameControl.Left = (mainPanel.Width - newGameControl.Width) / 2;
            newGameControl.Top = (mainPanel.Height - newGameControl.Height) / 2;
            gameControl.Dock = DockStyle.Fill;
            gameControl.Enabled = false;
            gameControl.Visible = false;
        }

        public static void showGameWindow(int n, int k, bool playerFirstMove, Color playerColor, Color computerColor)
        {
            newGameControl.Enabled = false;
            newGameControl.Visible = false;
            gameControl.Enabled = true;
            gameControl.Visible = true;
            gameControl.Reset(n, k, playerFirstMove, playerColor, computerColor);
        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGameControl.Enabled = true;
            newGameControl.Visible = true;
            gameControl.Enabled = false;
            gameControl.Visible = false;
        }
    }
}
