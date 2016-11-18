using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Szemeredi.Engine;

namespace Szemeredi
{
    class GameState
    {
        public enum Movement
        {
            PlayersChoice, 
            ComputersChoice, 
            PlayerColouring, 
            ComputerColouring 
        }

        public enum Level
        {
            Easy,
            Hard
        }

        private static GameState instance;

        public int n { get; set; }
        public int k { get; set; }
        public Color playerColor { get; set; }
        public Color computerColor { get; set; }
        public List<int> availableNumbers { get; set; }
        public List<int> player { get; set; }
        public List<int> computer { get; set; }
        public int[] chosen { get; set; }
        public Movement currentMove { get; set; }
        public Level level { get; set; }
        public bool gameOver { get; set; }

        private GameState()
        {
            availableNumbers = new List<int>();
            player = new List<int>();
            computer = new List<int>();
            chosen = new int[2];
        }

        public static GameState Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameState();
                }
                return instance;
            }
        }
    }
}
