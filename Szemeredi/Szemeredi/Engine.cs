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

        public enum Who
        {
            Player,
            Computer
        }

        public static Winner CheckWinner(out List<int> winSequence)
        {
            winSequence = new List<int>();
            if (GameState.Instance.player.Count < GameState.Instance.k)
                return Winner.None;

            List<int> pSequence;
            List<int> cSequence;
            int pLength = LengthOfSequence(Who.Player, out pSequence);
            int cLength = LengthOfSequence(Who.Computer, out cSequence);

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

        public static int ChooseNumberRandomly()
        {
            Random r = new Random();
            return GameState.Instance.availableNumbers.ElementAt(r.Next(0, GameState.Instance.availableNumbers.Count));
        }

        public static int ChooseNumberNormally()
        {
            int[] lengths = new int[GameState.Instance.availableNumbers.Count];
            int maxLength = int.MinValue;
            int chosen = -1;
            List<int> sequence;

            for (int i = 0; i < GameState.Instance.availableNumbers.Count; i++)
            {
                int n = GameState.Instance.availableNumbers[i];
                int length = LengthOfSequence(Who.Computer, out sequence, n);
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
                if (lengths[i] == maxLength)
                    maxLengthNumbers.Add(GameState.Instance.availableNumbers[i]);
            }

            if (maxLengthNumbers.Count > 1)
            {
                Random r = new Random();
                chosen = maxLengthNumbers.ElementAt(r.Next(0, maxLengthNumbers.Count));
            }
            return chosen;
        }

        public static int ChooseNumberDifficult()
        {
            int[] lengths = new int[GameState.Instance.availableNumbers.Count];
            var choicesList = new List<Tuple<int, int, int>>(); // <potencjalnie wybierana liczba, liczba p, liczba q
            List<int> sequence;

            for (int i = 0; i < GameState.Instance.availableNumbers.Count; i++)
            {
                int n = GameState.Instance.availableNumbers[i];
                int p = LengthOfSequence(Who.Computer, out sequence, n);
                int q = LengthOfSequence(Who.Player, out sequence, n);
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

            var considerated = choicesList.Where(t => t.Item2 == choice.Item2 && t.Item3 == choice.Item3);
            var rand = new Random();
            choice = considerated.ElementAt(rand.Next(0, considerated.Count()));
            return choice.Item1;
        }

        public static int ColourNumberRandomly()
        {
            Random r = new Random();
            return r.Next(0, GameState.Instance.chosen.Length);
        }

        public static int ColourNumberNormally()
        {
            List<int> sequence;
            int firstLength = LengthOfSequence(Who.Computer, out sequence, GameState.Instance.chosen[0]);
            int secondLength = LengthOfSequence(Who.Computer, out sequence, GameState.Instance.chosen[1]);

            if (firstLength > secondLength)
                return 0;
            else if (firstLength < secondLength)
                return 1;
            return ColourNumberRandomly();
        }

        public static int ColourNumberDifficult()
        {
            List<int> sequence;
            int computerFirstLength = LengthOfSequence(Who.Computer, out sequence, GameState.Instance.chosen[0]);
            int playerFirstLength = LengthOfSequence(Who.Player, out sequence, GameState.Instance.chosen[1]);
            int computerSecondLength = LengthOfSequence(Who.Computer, out sequence, GameState.Instance.chosen[1]);
            int playerSecondLength = LengthOfSequence(Who.Player, out sequence, GameState.Instance.chosen[0]);
            int max = (new List<int>() { playerFirstLength, computerFirstLength, playerSecondLength, computerSecondLength }).Max();
            if (playerFirstLength == max || computerFirstLength == max) return 0;
            return 1;
        }

        public static int LengthOfSequence(Who who, out List<int> sequence, int? addedNumber=null)
        {
            int length = -1;
            int difference = -1;
            sequence = new List<int>();
            List<int> numbers;
            Dictionary<int, List<Tuple<int, int>>> dictionary;

            if (who == Who.Computer)
            {
                numbers = new List<int>(GameState.Instance.computer);
                dictionary = new Dictionary<int, List<Tuple<int, int>>>(GameState.Instance.computerDifferences);
            }
            else
            {
                numbers = new List<int>(GameState.Instance.player);
                dictionary = new Dictionary<int, List<Tuple<int, int>>>(GameState.Instance.playerDifferences);
            }

            foreach (var key in dictionary.Keys.ToList())
            {
                dictionary[key] = new List<Tuple<int, int>>(dictionary[key]);
            }

            if (numbers.Count == 0)
                return length;


            if(addedNumber.HasValue)
            {
                updateDictionary(numbers, dictionary, addedNumber.Value);
                numbers.Add(addedNumber.Value);
            }

            int n = numbers.Count;

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

            if (!addedNumber.HasValue)
            {
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
            }
            return length;
        }
        

        public static void updateDictionary(List<int> numbers, Dictionary<int, List<Tuple<int, int>>> dictionary, int addedNumber)
        {
            int n = numbers.Count;
            if (n < 1)
                return;

            for (int i = 0; i < n; i++)
            {
                int element = numbers.ElementAt(i);
                int difference = element - addedNumber;
                int r = Math.Abs(difference);
                if (!dictionary.ContainsKey(r))
                    dictionary.Add(r, new List<Tuple<int, int>>());
                if (difference > 0)
                    dictionary[r].Add(new Tuple<int, int>(addedNumber, element));
                else
                    dictionary[r].Add(new Tuple<int, int>(element, addedNumber));
                dictionary[r].Sort((x, y) => x.Item1.CompareTo(y.Item1));
            }
        }
    }
}
