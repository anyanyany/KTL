using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Szemeredi
{
    public static class Engine
    {
        public enum Winner
        {
            Player,
            Computer,
            Tie,
            None
        }

        public static Winner CheckWinner() //TODO
        {
            if (GameState.Instance.player.Count < GameState.Instance.k)
                return Winner.None;

            //GameState.Instance.player
            //GameState.Instance.computer
            //GameState.Instance.k
            return Winner.None;

        }

        public static bool CheckSzemeredisTheorem(int n, int k) //TODO
        {    
            return true;
        }

        public static int ChooseNumberRandomly()
        {           
            Random r = new Random();
            return GameState.Instance.availableNumbers.ElementAt(r.Next(0, GameState.Instance.availableNumbers.Count));
        }

        public static int ChooseNumber() //TODO
        {
            Random r = new Random();
            return GameState.Instance.availableNumbers.ElementAt(r.Next(0, GameState.Instance.availableNumbers.Count));
        }

        public static int ColourNumberRandomly()
        {
            Random r = new Random();
            return r.Next(0, GameState.Instance.chosen.Length);
        }

        public static int ColourNumber() //TODO
        {
            Random r = new Random();
            return r.Next(0, GameState.Instance.chosen.Length);
        }
    }
}
