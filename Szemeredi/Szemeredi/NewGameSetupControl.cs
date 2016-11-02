﻿using System;
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
    public partial class NewGameSetupControl : UserControl
    {
        private Button playerColorButton;
        private Button computerColorButton;

        public NewGameSetupControl()
        {
            InitializeComponent();
            playerColorButton = null;
            computerColorButton = null;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void playerColorButton_Click(object sender, EventArgs e)
        {
            if (computerColorButton != null)
            {
                if (computerColorButton.BackColor == ((Button)sender).BackColor)
                {
                    return;
                }
            }
        
            if(playerColorButton != null)
            {
                playerColorButton.FlatAppearance.BorderSize = 0;
                if (playerColorButton==(Button)sender)
                {
                    playerColorButton = null;
                    return;
                }
            }
            
            playerColorButton = (Button)sender;
            ((Button)sender).FlatAppearance.BorderSize = 1;
        }

        private void computerColorButton_Click(object sender, EventArgs e)
        {
            if (playerColorButton != null)
            {
                if (playerColorButton.BackColor == ((Button)sender).BackColor)
                {
                    return;
                }
            }

            if (computerColorButton != null)
            {
                computerColorButton.FlatAppearance.BorderSize = 0;
                if (computerColorButton == (Button)sender)
                {
                    computerColorButton = null;
                    return;
                }
            }

            computerColorButton = (Button)sender;
            ((Button)sender).FlatAppearance.BorderSize = 1;
        }
    }
}