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
        static int delay = 1500;

        public async static void chooseNumber(Button[] buttons)
        {
            await Task.Delay(delay);
            int number = -1;
            if (GameState.Instance.level == GameState.Level.Easy)
            {
                number = Engine.ChooseNumberRandomly();
            }
            else if (GameState.Instance.level == GameState.Level.Medium)
            {
                number = Engine.ChooseNumberNormally();
            }
            else if (GameState.Instance.level == GameState.Level.Hard)
            {
                number = Engine.ChooseNumberDifficult();
            }
            buttons[number - 1].PerformClick();
        }

        public async static void colourNumber(Button first, Button second)
        {
            await Task.Delay(delay);
            int index = -1;
            if (GameState.Instance.level == GameState.Level.Easy)
            {
                index = Engine.ColourNumberRandomly();
            }
            else if (GameState.Instance.level == GameState.Level.Medium)
            {
                index = Engine.ColourNumberNormally();
            }
            else if (GameState.Instance.level == GameState.Level.Hard)
            {
                index = Engine.ColourNumberDifficult();
            }
            if (index == 0)
                first.PerformClick();
            else
                second.PerformClick();
            
        }
    }
}
