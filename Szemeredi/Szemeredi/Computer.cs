﻿using System;
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
            else if (GameState.Instance.level == GameState.Level.Hard)
            {
                number = Engine.ChooseNumber();
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
            else if (GameState.Instance.level == GameState.Level.Hard)
            {
                index = Engine.ColourNumber();
            }            
            if (index == 0)
                first.PerformClick();
            else
                second.PerformClick();
            
        }
    }
}
