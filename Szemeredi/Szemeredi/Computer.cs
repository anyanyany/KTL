using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szemeredi
{
    public static class Computer
    {
        public static void chooseNumbers(Button[] buttons)
        {
            /*
            if (GameState.Instance.level == GameState.Level.Easy)
            {

            }
            else if (GameState.Instance.level == GameState.Level.Hard)
            {

            }
            */

            Thread.Sleep(1000);
            Random r = new Random();
            int number = GameState.Instance.availableNumbers.ElementAt(r.Next(0, GameState.Instance.availableNumbers.Count));
            buttons[number - 1].PerformClick();
            Thread.Sleep(1000);
            number = GameState.Instance.availableNumbers.ElementAt(r.Next(0, GameState.Instance.availableNumbers.Count));
            buttons[number - 1].PerformClick();
        }

        public static void colourNumber(Button first, Button second)
        {
            /*
            if (GameState.Instance.level == GameState.Level.Easy)
            {

            }
            else if (GameState.Instance.level == GameState.Level.Hard)
            {

            }
            */
            Thread.Sleep(1000);
            Random r = new Random();
            int index = r.Next(0, 2);
            if (index == 0)
                first.PerformClick();
            else
                second.PerformClick();
            
        }
    }
}
