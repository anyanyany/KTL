using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Szemeredi
{
    public partial class GameControl : UserControl
    {
        private Button firstNumberButton;
        private Button secondNumberButton;
        private int round;
        private Button[] buttons;

        public GameControl()
        {
            InitializeComponent();
            firstNumberButton = null;
            secondNumberButton = null;
            round = 0;
        }

        public void Reset(int n, int k, bool playerFirstMove, Color playerColor, Color computerColor, GameState.Level level)
        {
            GameState.Instance.k = k;
            GameState.Instance.n = n;
            GameState.Instance.playerColor = playerColor;
            GameState.Instance.computerColor = computerColor;
            GameState.Instance.availableNumbers.Clear();
            GameState.Instance.player.Clear();
            GameState.Instance.computer.Clear();
            GameState.Instance.chosen = new int[2];
            GameState.Instance.currentMove = playerFirstMove ? GameState.Movement.PlayersChoice : GameState.Movement.ComputersChoice;

            GameState.Instance.level = level;
            GameState.Instance.gameOver = false;

            for (int i = 1; i <= n; i++)
                GameState.Instance.availableNumbers.Add(i);

            playerLabel.BackColor = playerColor;
            playersNumbersLabel.BackColor = playerColor;
            computerLabel.BackColor = computerColor;
            computersNumbersLabel.BackColor = computerColor;

            KLabel.Text = "k: " + k;
            if (level == GameState.Level.Easy)
                levelLabel.Text = "łatwy";
            else if (level == GameState.Level.Medium)
                levelLabel.Text = "średni";
            else
                levelLabel.Text = "trudny";

            playersNumbersLabel.Text = "?";
            computersNumbersLabel.Text = "?";
            round = 0;

            buttons = new Button[n];
            buttonsPanel.Controls.Clear();
            int dim = (int)Math.Ceiling(Math.Sqrt(Math.Ceiling((double)n / 2)));
            int over = (int)Math.Floor((double)((2 * dim * dim - n) / (2 * dim)));
            int columns = 2 * dim;
            int rows = dim - over;
            buttonsPanel.ColumnCount = columns;
            buttonsPanel.RowCount = rows;

            buttonsPanel.ColumnStyles.Clear();
            buttonsPanel.RowStyles.Clear();

            for (int r = 0; r < columns; r++)
                buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columns));
            for (int c = 0; c < rows; c++)
                buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / rows));
            int counter = 1;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (counter <= n)
                    {
                        Button newButton = new Button { Text = counter.ToString(), Dock = DockStyle.Fill };
                        newButton.Click += new EventHandler(this.numberButton_Click);
                        buttonsPanel.Controls.Add(newButton, c, r);
                        buttons[counter - 1] = newButton;
                        counter++;
                    }
                }
            }

            nextRound();
            updateAction();
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            Button chosenButton = (Button)sender;
            if (GameState.Instance.currentMove == GameState.Movement.PlayersChoice || GameState.Instance.currentMove == GameState.Movement.ComputersChoice)
            {
                chooseNumber(chosenButton);
            }
            else if (GameState.Instance.currentMove == GameState.Movement.PlayerColouring || GameState.Instance.currentMove == GameState.Movement.ComputerColouring)
            {
                colourNumber(chosenButton);
            }
            updateAction();
        }

        private void chooseNumber(Button chosenButton)
        {
            if (firstNumberButton == null)
            {
                firstNumberButton = chosenButton;
                firstNumberButton.BackColor = Color.DimGray;
                GameState.Instance.chosen[0] = int.Parse(firstNumberButton.Text);
                GameState.Instance.availableNumbers.Remove(int.Parse(firstNumberButton.Text));
            }
            else if (secondNumberButton == null && chosenButton != firstNumberButton)
            {
                secondNumberButton = chosenButton;
                secondNumberButton.BackColor = Color.DimGray;
                GameState.Instance.chosen[1] = int.Parse(secondNumberButton.Text);
                GameState.Instance.availableNumbers.Remove(int.Parse(secondNumberButton.Text));
            }
            if (firstNumberButton != null && secondNumberButton != null)
            {
                if (GameState.Instance.currentMove == GameState.Movement.PlayersChoice)
                    GameState.Instance.currentMove = GameState.Movement.ComputerColouring;
                else if (GameState.Instance.currentMove == GameState.Movement.ComputersChoice)
                    GameState.Instance.currentMove = GameState.Movement.PlayerColouring;
            }
        }

        private void colourNumber(Button chosenButton)
        {
            if (chosenButton != firstNumberButton && chosenButton != secondNumberButton)
                return;

            Color firstColor = Color.Empty;
            Color secondColor = Color.Empty;
            int number1 = 0, number2 = 0;
            List<int> sequence = new List<int>();

            if (GameState.Instance.currentMove == GameState.Movement.PlayerColouring)
            {
                firstColor = GameState.Instance.playerColor;
                secondColor = GameState.Instance.computerColor;
            }
            else if (GameState.Instance.currentMove == GameState.Movement.ComputerColouring)
            {
                firstColor = GameState.Instance.computerColor;
                secondColor = GameState.Instance.playerColor;
            }

            if (chosenButton == firstNumberButton)
            {
                firstNumberButton.BackColor = firstColor;
                secondNumberButton.BackColor = secondColor;
                number1 = int.Parse(firstNumberButton.Text);
                number2 = int.Parse(secondNumberButton.Text);
            }
            else if (chosenButton == secondNumberButton)
            {
                secondNumberButton.BackColor = firstColor;
                firstNumberButton.BackColor = secondColor;
                number1 = int.Parse(secondNumberButton.Text);
                number2 = int.Parse(firstNumberButton.Text);
            }

            if (GameState.Instance.currentMove == GameState.Movement.PlayerColouring)
            {
                GameState.Instance.currentMove = GameState.Movement.PlayersChoice;
                AddNumbers(number1, number2);
            }
            else if (GameState.Instance.currentMove == GameState.Movement.ComputerColouring)
            {
                GameState.Instance.currentMove = GameState.Movement.ComputersChoice;
                AddNumbers(number2, number1);
            }

            firstNumberButton.Enabled = false;
            secondNumberButton.Enabled = false;
            updateNumbersLabels();
            Engine.Winner winner = Engine.CheckWinner(out sequence);
            if (winner != Engine.Winner.None)
            {
                Form1.GameOver(winner, sequence);
                GameState.Instance.gameOver = true;
                return;
            }
            nextRound();
        }

        private void AddNumbers(int playerNumber, int computerNumber)
        {
            updateDictionary(GameState.Instance.player, GameState.Instance.playerDifferences, playerNumber);
            updateDictionary(GameState.Instance.computer, GameState.Instance.computerDifferences, computerNumber);

            GameState.Instance.player.Add(playerNumber);
            GameState.Instance.computer.Add(computerNumber);
        }

        private void updateDictionary(List<int> numbers, Dictionary<int, List<Tuple<int, int>>> dictionary, int addedNumber)
        {
            int n = numbers.Count;
            if (n < 1)
                return;

            for (int i = 0; i < n; i++)
            {
                int difference = numbers.ElementAt(i) - addedNumber;
                int r = Math.Abs(difference);
                if (!dictionary.ContainsKey(r))
                    dictionary.Add(r, new List<Tuple<int, int>>());
                if (difference > 0)
                    dictionary[r].Add(new Tuple<int, int>(addedNumber, numbers.ElementAt(i)));
                else
                    dictionary[r].Add(new Tuple<int, int>(numbers.ElementAt(i), addedNumber));
            }
        }

        private void nextRound()
        {
            firstNumberButton = null;
            secondNumberButton = null;
            GameState.Instance.chosen = new int[2];
            round++;
            roundLabel.Text = "runda: " + round.ToString();
            if (GameState.Instance.availableNumbers.Count < 2)
            {
                Form1.GameOver(Engine.Winner.None);
            }
        }

        private void updateAction()
        {
            if (GameState.Instance.gameOver)
                return;
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

            if (GameState.Instance.currentMove == GameState.Movement.ComputersChoice)
                Computer.chooseNumber(buttons);
            if (GameState.Instance.currentMove == GameState.Movement.ComputerColouring)
                Computer.colourNumber(firstNumberButton, secondNumberButton);
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
