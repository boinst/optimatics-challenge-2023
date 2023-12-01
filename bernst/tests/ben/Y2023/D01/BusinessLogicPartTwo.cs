using tests.ben.Common;

namespace tests.ben.Y2023.D01
{
    public class Entry
    {
        public Entry(string key, int value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; } = string.Empty;
        public int Value { get; } = 0;

        public int Progress { get; set; } = 0;
    }

    public static class BusinessLogicPartTwo
    {
        public static string Substitute(string line)
        {
            return
                line.Replace("one", "1")
                    .Replace("two", "2")

                    .Replace("three", "3")

                    .Replace("four", "4")
                    .Replace("five", "5")
                    .Replace("six", "6")
                    .Replace("seven", "7")
                    .Replace("eight", "8")
                    .Replace("nine", "9");
        }

        public static IEnumerable<Entry> Data()
        {
            for (int i = 1; i < 10; i++)
            {
                yield return new Entry(i.ToString(), i);
            }

            yield return new Entry("one", 1);
            yield return new Entry("two", 2);
            yield return new Entry("three", 3);
            yield return new Entry("four", 4);
            yield return new Entry("five", 5);
            yield return new Entry("six", 6);
            yield return new Entry("seven", 7);
            yield return new Entry("eight", 8);
            yield return new Entry("nine", 9);
        }
        

        public static int FirstDigit(string line)
        {
            var data = Data().ToArray();

            for (int i = 0; i < line.Length; i++)
            {
                var c = line[i];
                foreach (var entry in data)
                {
                    if (IsNextCharacterRequired(c, entry))
                    {
                        entry.Progress++;

                        if (IsEntrySatisfied(entry))
                            return entry.Value;
                    }
                }
            }

            throw new Exception("No digits in this line");
        }

        
        public static int LastDigit(string line)
        {
            var data = Data().ToArray();

            for (int i = line.Length - 1; i >= 0; --i)
            {
                var c = line[i];
                foreach (var entry in data)
                {
                    if (IsNextCharacterRequiredReverse(c, entry))
                    {
                        entry.Progress++;

                        if (IsEntrySatisfied(entry))
                            return entry.Value;
                    }
                }
            }

            throw new Exception("No digits in this line");
        }

        private static bool IsEntrySatisfied(Entry entry)
        {
            return entry.Progress == entry.Key.Length;
        }

        public static bool IsNextCharacterRequired(char c, Entry entry)
        {
            return c == entry.Key[entry.Progress];
        }
        public static bool IsNextCharacterRequiredReverse(char c, Entry entry)
        {
            return c == entry.Key[^(entry.Progress+1)];
        }

        public static int DecryptLine(string line)
        {
            int first_digit = FirstDigit(line);
            int last_digit = LastDigit(line);
            return int.Parse(first_digit.ToString() + last_digit.ToString());
        }

        public static IEnumerable<int> DecryptLines(string example_data)
        {
            var lines = InputDataParser.ToLines(example_data);
            foreach (var l in lines)
            {
                yield return DecryptLine(l);
            }
        }

        public static int Solution(string example_data)
        {
            return DecryptLines(example_data).Sum();
        }
    }
}