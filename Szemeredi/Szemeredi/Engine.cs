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

        public static Winner CheckWinner(out List<int> winSequence)
        {
            winSequence = new List<int>();
            if (GameState.Instance.player.Count < GameState.Instance.k)
                return Winner.None;

            int difference;
            List<int> pSequence;
            List<int> cSequence;
            int pLength = LengthOfSequence(GameState.Instance.player, out difference, out pSequence);
            int cLength = LengthOfSequence(GameState.Instance.computer, out difference, out cSequence);

            if (pLength < GameState.Instance.k && cLength < GameState.Instance.k)
                return Winner.None;
            if (pLength == cLength)
                return Winner.Tie;
            if (pLength > cLength)
            {
                winSequence = pSequence;
                return Winner.Player;
            }
            winSequence = cSequence;
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

        public static int ChooseNumberNormally() 
        {
            int[] lengths = new int[GameState.Instance.availableNumbers.Count];
            int maxLength = int.MinValue;
            int difference;
            List<int> sequence;
            int chosen = -1;

            for (int i = 0; i < GameState.Instance.availableNumbers.Count; i++)
            {
                int n = GameState.Instance.availableNumbers[i];
                List<int> numbers = new List<int>(GameState.Instance.computer);
                numbers.Add(n);
                int length = LengthOfSequence(numbers, out difference, out sequence);
                lengths[i] = length;
                if (length > maxLength)
                {
                    maxLength = length;
                    chosen = n;
                }
            }

            List<int> maxLengthNumbers = new List<int>();
            for (int i = 0; i < GameState.Instance.availableNumbers.Count; i++)
            {
                if(lengths[i]==maxLength)
                    maxLengthNumbers.Add(GameState.Instance.availableNumbers[i]);

            }
            if(maxLengthNumbers.Count>1)
            {
                Random r = new Random();
                chosen = maxLengthNumbers.ElementAt(r.Next(0, maxLengthNumbers.Count));
            }
            return chosen;
        }

        public static int ChooseNumberDifficult()
        {
            int[] lengths = new int[GameState.Instance.availableNumbers.Count];
            int maxLength = int.MinValue;
            int difference;
            List<int> sequence;
            int chosen = -1;

            var choicesList = new List<Tuple<int, int, int>>(); // <potencjalnie wybierana liczba, liczba p, liczba q
            for (int i = 0; i < GameState.Instance.availableNumbers.Count; i++)
            {
                int n = GameState.Instance.availableNumbers[i];
                List<int> numbers = new List<int>(GameState.Instance.computer);
                numbers.Add(n);
                int p = LengthOfSequence(numbers, out difference, out sequence);

                numbers = new List<int>(GameState.Instance.player);
                numbers.Add(n);
                int q = LengthOfSequence(numbers, out difference, out sequence);

                choicesList.Add(Tuple.Create(n, p, q));
            }

            if (choicesList.Select(t => t.Item2).Max() <= 2)
            {
                return ChooseNumberRandomly();
            }

            var choice = choicesList.Where(t => t.Item2 > t.Item3).OrderByDescending(t => t.Item2).FirstOrDefault();
            if (choice == null)
            {
                choice = choicesList.Where(t => t.Item2 >= t.Item3).OrderByDescending(t => t.Item2).FirstOrDefault();
            }
            if (choice == null)
            {
                choice = choicesList.OrderByDescending(t => t.Item3).Last();
            }
            return choice.Item1;
        }

        public static int ColourNumberRandomly()
        {
            Random r = new Random();
            return r.Next(0, GameState.Instance.chosen.Length);
        }

        public static int ColourNumberNormally()
        {
            List<int> numbers = new List<int>(GameState.Instance.computer);
            numbers.Add(GameState.Instance.chosen[0]);

            int difference;
            List<int> sequence;
            int firstLength = LengthOfSequence(numbers, out difference, out sequence);

            numbers = new List<int>(GameState.Instance.computer);
            numbers.Add(GameState.Instance.chosen[1]);
            int secondLength = LengthOfSequence(numbers, out difference, out sequence);

            if (firstLength > secondLength)
                return 0;
            else if (firstLength < secondLength)
                return 1;

            return ColourNumberRandomly();
        }

        public static int ColourNumberDifficult()
        {
            int difference;
            List<int> sequence;

            List<int> computerNumbers = new List<int>(GameState.Instance.computer);
            List<int> playerNumbers = new List<int>(GameState.Instance.player);

            computerNumbers.Add(GameState.Instance.chosen[0]);          
            playerNumbers.Add(GameState.Instance.chosen[1]);

            int computerFirstLength = LengthOfSequence(computerNumbers, out difference, out sequence);
            int playerFirstLength = LengthOfSequence(playerNumbers, out difference, out sequence);

            computerNumbers = new List<int>(GameState.Instance.computer);
            playerNumbers = new List<int>(GameState.Instance.player);

            computerNumbers.Add(GameState.Instance.chosen[1]);
            playerNumbers.Add(GameState.Instance.chosen[0]);

            int computerSecondLength = LengthOfSequence(computerNumbers, out difference, out sequence);
            int playerSecondLength = LengthOfSequence(playerNumbers, out difference, out sequence);

            int max = (new List<int>() { playerFirstLength, computerFirstLength, playerSecondLength, computerSecondLength }).Max();
            if (playerFirstLength == max || computerFirstLength == max) return 0;
            return 1;
            
        }

        public static int LengthOfSequence(List<int> numbers, out int difference, out List<int> sequence)
        {
            //TODO: use GameState.Instance.playerDifferences and GameState.Instance.computerDifferences
            int length = -1;
            difference = -1;
            sequence = new List<int>();

            if (numbers.Count < 2)
                return length;
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

            dictionary[difference].Reverse();
            sequence.Add(last);
            foreach (Tuple<int, int> pair in dictionary[difference])
            {
                if (pair.Item2 == last)
                {
                    sequence.Add(pair.Item1);
                    last = pair.Item1;
                }
            }
            sequence.Reverse();
            return length;
        }
    }
}
