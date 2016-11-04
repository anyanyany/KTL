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
    public partial class GameControl : UserControl
    {
        private Button firstNumber;
        private Button secondNumber;
        private Color playerColor;
        private Color computerColor;

        public GameControl()
        {
            InitializeComponent();
            firstNumber = null;
            secondNumber = null;
            playerColor = Color.Empty;
            computerColor = Color.Empty;
        }

        public void Reset(int n, int k, bool playerFirstMove, Color _playerColor, Color _computerColor)
        {
            GameState.Instance.k = k;
            GameState.Instance.n = n;
            playerColor = _playerColor;
            computerColor = _computerColor;
            buttonsPanel.Controls.Clear();

            playerLabel.BackColor = playerColor;
            playersNumbersLabel.BackColor = playerColor;
            computerLabel.BackColor = computerColor;
            computersNumbersLabel.BackColor = computerColor;

            KLabel.Text = "k = " + k;

            GameState.Instance.currentMove = playerFirstMove ? GameState.Movement.PlayersChoice : GameState.Movement.ComputersChoice;

            int dim = (int)Math.Ceiling(Math.Sqrt(Math.Ceiling((double)n / 2)));
            int over = (int)Math.Floor((double)((2 * dim * dim - n) / (2 * dim)));
            int columns = 2 * dim;
            int rows = dim - over;
            buttonsPanel.ColumnCount = columns;
            buttonsPanel.RowCount = rows;

            buttonsPanel.ColumnStyles.Clear();
            buttonsPanel.RowStyles.Clear();
            int counter = 1;
            for (int r = 0; r < columns; r++)
                buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columns));
            for (int c = 0; c < rows; c++)
                buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / rows));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (counter <= n)
                    {
                        Button newButton = new Button { Text = counter.ToString(), Dock = DockStyle.Fill };
                        newButton.Click += new EventHandler(this.numberButton_Click);
                        buttonsPanel.Controls.Add(newButton, c, r);
                        counter++;
                    }
                }
            }
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            //TODO: if currentMovement = 1 or 2 ????
            Button chosenButton = (Button)sender;
            if (firstNumber == chosenButton)
            {
                firstNumber.BackColor = Color.White;
                firstNumber = null;
                firstNumberButton.Text = "?";
                //TODO: currentMovement = 1 or 2
            }
            else if (secondNumber == chosenButton)
            {
                secondNumber.BackColor = Color.White;
                secondNumber = null;
                secondNumberButton.Text = "?";
                //TODO: currentMovement = 1 or 2
            }
            else if (firstNumber == null)
            {
                firstNumber = chosenButton;
                firstNumber.BackColor = Color.DimGray;
                firstNumberButton.Text = firstNumber.Text;
            }
            else if (secondNumber == null)
            {
                secondNumber = chosenButton;
                secondNumber.BackColor = Color.DimGray;
                secondNumberButton.Text = secondNumber.Text;
            }

            if(firstNumber!=null && secondNumber!=null)
            {
                //TODO: currentMovement = 3 or 4
            }

        }

        private void chooseNumberToColourButton_Click(object sender, EventArgs e)
        {
            //TODO: if currentMovement = 3 or 4 
            Button chosenButton = (Button)sender;
            Color currentColor = playerColor;
            Color secondColor = computerColor;

            if (chosenButton==firstNumberButton)
            {
                firstNumber.BackColor = currentColor;
                secondNumber.BackColor = secondColor;
            }
            else if(chosenButton==secondNumberButton)
            {
                secondNumber.BackColor = currentColor;
                firstNumber.BackColor = secondColor;
            }
            //GameState.Instance.currentMove = GameState.Movement.PlayersChoice;
        }
    }
}
