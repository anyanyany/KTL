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
        public GameControl()
        {
            InitializeComponent();
        }

        public void Reset(int n, Color playerColor, Color computerColor)
        {
            buttonsPanel.Controls.Clear();

            playerLabel.BackColor = playerColor;
            playersNumbersLabel.BackColor = playerColor;
            computerLabel.BackColor = computerColor;
            computersNumbersLabel.BackColor = computerColor;

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
                        buttonsPanel.Controls.Add(new Button { Text = counter.ToString(), Dock = DockStyle.Fill }, c, r);
                        counter++;
                    }
                }
            }

        }
    }
}
