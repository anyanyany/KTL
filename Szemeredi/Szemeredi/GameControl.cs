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
        private int round;

        public GameControl()
        {
            InitializeComponent();
            firstNumber = null;
            secondNumber = null;
            playerColor = Color.Empty;
            computerColor = Color.Empty;
            round = 1;
        }

        public void Reset(int n, int k, bool playerFirstMove, Color _playerColor, Color _computerColor)
        {
            GameState.Instance.k = k;
            GameState.Instance.n = n;
            playerColor = _playerColor;
            computerColor = _computerColor;
            GameState.Instance.currentMove = playerFirstMove ? GameState.Movement.PlayersChoice : GameState.Movement.ComputersChoice;

            GameState.Instance.availableNumbers.Clear();
            GameState.Instance.player.Clear();
            GameState.Instance.computer.Clear();

            for (int i = 1; i <= n; i++)
                GameState.Instance.availableNumbers.Add(i);

            firstNumber = null;
            secondNumber = null;

            playerLabel.BackColor = playerColor;
            playersNumbersLabel.BackColor = playerColor;
            computerLabel.BackColor = computerColor;
            computersNumbersLabel.BackColor = computerColor;

            KLabel.Text = "k = " + k;
            firstNumberButton.Text = "?";
            secondNumberButton.Text = "?";

            playersNumbersLabel.Text = "?";
            computersNumbersLabel.Text = "?";
            roundLabel.Text = "runda: " + round.ToString();

            updateActionLabel();

            buttonsPanel.Controls.Clear();
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
            if (GameState.Instance.currentMove != GameState.Movement.PlayersChoice && GameState.Instance.currentMove != GameState.Movement.ComputersChoice)
                return;

            Button chosenButton = (Button)sender;

            if (firstNumber == null)
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
            if (firstNumber != null && secondNumber != null)
            {
                if (GameState.Instance.currentMove == GameState.Movement.PlayersChoice)
                    GameState.Instance.currentMove = GameState.Movement.ComputerColouring;
                else if (GameState.Instance.currentMove == GameState.Movement.ComputersChoice)
                    GameState.Instance.currentMove = GameState.Movement.PlayerColouring;
            }
            updateActionLabel();
        }

        private void chooseNumberToColourButton_Click(object sender, EventArgs e)
        {
            if (GameState.Instance.currentMove != GameState.Movement.PlayerColouring && GameState.Instance.currentMove != GameState.Movement.ComputerColouring)
                return;

            Button chosenButton = (Button)sender;
            Color firstColor = Color.Empty;
            Color secondColor = Color.Empty;
            int number1 = 0, number2 = 0;

            if (GameState.Instance.currentMove == GameState.Movement.PlayerColouring)
            {
                firstColor = playerColor;
                secondColor = computerColor;
            }
            else if (GameState.Instance.currentMove == GameState.Movement.ComputerColouring)
            {
                firstColor = computerColor;
                secondColor = playerColor;
            }

            if (chosenButton == firstNumberButton)
            {
                firstNumber.BackColor = firstColor;
                secondNumber.BackColor = secondColor;
                number1 = int.Parse(firstNumber.Text);
                number2 = int.Parse(secondNumber.Text);
            }
            else if (chosenButton == secondNumberButton)
            {
                secondNumber.BackColor = firstColor;
                firstNumber.BackColor = secondColor;
                number1 = int.Parse(secondNumber.Text);
                number2 = int.Parse(firstNumber.Text);
            }

            if (GameState.Instance.currentMove == GameState.Movement.PlayerColouring)
            {
                GameState.Instance.currentMove = GameState.Movement.PlayersChoice;
                GameState.Instance.player.Add(number1);
                GameState.Instance.computer.Add(number2);
            }
            else if (GameState.Instance.currentMove == GameState.Movement.ComputerColouring)
            {
                GameState.Instance.currentMove = GameState.Movement.ComputersChoice;
                GameState.Instance.computer.Add(number1);
                GameState.Instance.player.Add(number2);
            }

            GameState.Instance.availableNumbers.Remove(number1);
            GameState.Instance.availableNumbers.Remove(number2);
            updateNumbersLabels();
            //CheckWinner();
            nextRound();
            updateActionLabel();
        }

        private void nextRound()
        {
            firstNumber = null;
            secondNumber = null;
            firstNumberButton.Text = "?";
            secondNumberButton.Text = "?";
            round++;
            roundLabel.Text = "runda: " + round.ToString();
        }

        private void updateActionLabel()
        {
            switch (GameState.Instance.currentMove)
            {
                case GameState.Movement.PlayersChoice:
                    actionLabel.Text = "ruch: gracz wybiera dwie liczby";
                    break;
                case GameState.Movement.ComputersChoice:
                    actionLabel.Text = "ruch: komputer wybiera dwie liczby";
                    break;
                case GameState.Movement.PlayerColouring:
                    actionLabel.Text = "ruch: gracz koloruje liczbę";
                    break;
                case GameState.Movement.ComputerColouring:
                    actionLabel.Text = "ruch: komputer koloruje liczbę";
                    break;
            }
        }

        private void updateNumbersLabels()
        {
            GameState.Instance.player.Sort();
            GameState.Instance.computer.Sort();

            string numbers = "";
            foreach (int i in GameState.Instance.player)
                numbers = numbers + " " + i.ToString();
            playersNumbersLabel.Text = numbers;

            numbers = "";
            foreach (int i in GameState.Instance.computer)
                numbers = numbers + " " + i.ToString();
            computersNumbersLabel.Text = numbers;
        }
    }
}
