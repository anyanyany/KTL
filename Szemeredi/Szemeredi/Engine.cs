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

            int difference;
            List<int> pSequence;
            List<int> cSequence;
            int pLength = LengthOfSequence(GameState.Instance.player, out difference, out pSequence);
            int cLength = LengthOfSequence(GameState.Instance.computer, out difference, out cSequence);
            //int pLength = LengthOfSequence(Who.Player, out difference, out pSequence);
            //int cLength = LengthOfSequence(Who.Computer, out difference, out cSequence);
            //Console.WriteLine("CHECK WINNER ---> player: " + pLength + "  computer: " + cLength);

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

            for (int i = 0; i < GameState.Instance.availableNumbers.Count; i++)
            {
                int n = GameState.Instance.availableNumbers[i];
                int length = LengthOfExpandedSequence(Who.Computer, n);
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

            for (int i = 0; i < GameState.Instance.availableNumbers.Count; i++)
            {
                int n = GameState.Instance.availableNumbers[i];
                int p = LengthOfExpandedSequence(Who.Computer, n);
                int q = LengthOfExpandedSequence(Who.Player, n);
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
            int firstLength = LengthOfExpandedSequence(Who.Computer, GameState.Instance.chosen[0]);
            int secondLength = LengthOfExpandedSequence(Who.Computer, GameState.Instance.chosen[1]);
            //Console.WriteLine("COLOUR ---> n= "+ GameState.Instance.chosen[0] +" len= "+ firstLength + " *** n= "+GameState.Instance.chosen[1] + " len= " + secondLength);

            if (firstLength > secondLength)
                return 0;
            else if (firstLength < secondLength)
                return 1;
            return ColourNumberRandomly();
        }

        public static int ColourNumberDifficult()
        {
            int computerFirstLength = LengthOfExpandedSequence(Who.Computer, GameState.Instance.chosen[0]);
            int playerFirstLength = LengthOfExpandedSequence(Who.Player, GameState.Instance.chosen[1]);
            int computerSecondLength = LengthOfExpandedSequence(Who.Computer, GameState.Instance.chosen[1]);
            int playerSecondLength = LengthOfExpandedSequence(Who.Player, GameState.Instance.chosen[0]);
            int max = (new List<int>() { playerFirstLength, computerFirstLength, playerSecondLength, computerSecondLength }).Max();
            if (playerFirstLength == max || computerFirstLength == max) return 0;
            return 1;
        }

        public static int LengthOfSequence(List<int> numbers, out int difference, out List<int> sequence)
        {
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
                    int d = numbers.ElementAt(j) - numbers.ElementAt(i);
                    int r = Math.Abs(d);
                    if (!dictionary.ContainsKey(r))
                        dictionary.Add(r, new List<Tuple<int, int>>());
                    if (d > 0)
                        dictionary[r].Add(new Tuple<int, int>(numbers.ElementAt(i), numbers.ElementAt(j)));
                    else
                        dictionary[r].Add(new Tuple<int, int>(numbers.ElementAt(j), numbers.ElementAt(i)));
                    dictionary[r].Sort((x, y) => x.Item1.CompareTo(y.Item1));
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

        public static int LengthOfExpandedSequence(Who who, int addedNumber)
        {
            int length = -1;
            int difference = -1;
            List<int> sequence = new List<int>();
            List<int> numbers;

            if (who == Who.Computer)
                numbers = new List<int>(GameState.Instance.computer);
            else
                numbers = new List<int>(GameState.Instance.player);

            if (numbers.Count == 0)
                return length;

            numbers.Add(addedNumber);

            return LengthOfSequence(numbers, out difference, out sequence);
        }

        /*
        public static int LengthOfExpandedSequence(Who who, int addedNumber)
        {
            int length = -1;
            int difference = -1;
            List<int> sequence = new List<int>();
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

            if (numbers.Count == 0)
                return length;

            updateDictionary(numbers, dictionary, addedNumber);
            numbers.Add(addedNumber);

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
        

        public static int LengthOfSequence(Who who, out int difference, out List<int> sequence)
        {
            int length = -1;
            difference = -1;
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

            if (numbers.Count == 0)
                return length;

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
        */

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
