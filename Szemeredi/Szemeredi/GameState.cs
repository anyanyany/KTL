using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private static GameState instance;
        public int n { get; set; }
        public int k { get; set; }
        public List<int> availableNumbers { get; set; }
        public List<int> player { get; set; }
        public List<int> computer { get; set; }
        public int[] chosen { get; set; }
        public Movement currentMove { get; set; }

        private GameState() { }

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
