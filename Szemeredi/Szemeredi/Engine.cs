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

        public static Winner CheckWinner()
        {
            if (GameState.Instance.player.Count < GameState.Instance.k)
                return Winner.None;

            int difference;
            List<int> sequence;
            int pLength = LengthOfSequence(GameState.Instance.player, out difference, out sequence);
            int cLength = LengthOfSequence(GameState.Instance.computer, out difference, out sequence);

            if (pLength < GameState.Instance.k && cLength < GameState.Instance.k)
                return Winner.None;
            if (pLength == cLength)
                return Winner.Tie;
            if (pLength > cLength)
                return Winner.Player;
            return Winner.Computer;
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

        public static int LengthOfSequence(List<int> numbers, out int difference, out List<int> sequence)
        {
            Dictionary<int, List<Tuple<int, int>>> dictionary = new Dictionary<int, List<Tuple<int, int>>>();
            int n = numbers.Count;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int r = Math.Abs(numbers.ElementAt(i) - numbers.ElementAt(j));
                    if (!dictionary.ContainsKey(r))
                        dictionary.Add(r, new List<Tuple<int, int>>());
                    dictionary[r].Add(new Tuple<int, int>(numbers.ElementAt(i), numbers.ElementAt(j)));
                }
            }
            int length = -1;
            difference = -1;
            sequence = new List<int>();

            List<int> keys = dictionary.Keys.ToList();
            int last = -1;
            foreach (int k in keys)
            {
                Dictionary<int, int> T = new Dictionary<int, int>();
                for (int i = 0; i < n; i++)
                    T.Add(numbers[i], 1);
                foreach (Tuple<int, int> pair in dictionary[k])
                {
                    T[pair.Item2] = T[pair.Item1] + 1;
                }
                if (T.Values.Max() > length)
                {
                    length = T.Values.Max();
                    difference = k;
                    last = T.FirstOrDefault(x => x.Value == T.Values.Max()).Key;
                }
            }

            return length;
        }
    }
}
