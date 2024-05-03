namespace DuplicateOperations
{
    public static class DuplicateAlgorithms
    {

        private static readonly int[] inputInt = { 1, 1, 2, 3, 4, 4 };
        private static readonly string inputStr = "duppliccate";


        //Space Complexity = O(n), Time Complexity = O(n)
        public static List<int> ReturnDuplicatesWithHashSet(int[] input)
        {

            HashSet<int> duplicates = new HashSet<int>();
            HashSet<int> seen = new HashSet<int>();
            for (int i = 0; i < input.Length; i++)
            {

                if (seen.Contains(input[i]))
                    duplicates.Add(input[i]);

                else
                    seen.Add(input[i]);
            }
            return duplicates.ToList();

        }


        //Time Complexity = O(n^2), Space Complexity = O(n)
        public static List<int> ReturnDuplicatesFromString(int[] input)
        {
            List<int> duplicates = input.ToList();

            for (int i = 0; i < duplicates.Count; i++)
            {
                int count = 1;
                for (int j = i + 1; j < duplicates.Count; j++)
                {
                    if (duplicates[i] == duplicates[j])
                    {
                        count++;
                        duplicates.RemoveAt(j);
                    }
                }
                if (count < 2)
                {
                    duplicates.RemoveAt(i);
                    i--;
                }
            }

            return duplicates;

        }


        public static string ReturnDuplicatesFromStringWithHashSet(string input)
        {

            HashSet<char> duplicates = new HashSet<char>();
            HashSet<char> seen = new HashSet<char>();

            for (int i = 0; i < input.Length; i++)
            {

                if (seen.Contains(input[i]))
                    duplicates.Add(input[i]);

                else
                    seen.Add(input[i]);
            }
            return string.Join(string.Empty, duplicates);

        }


        public static string RemoveDuplicatesHashSet(string input)
        {

            HashSet<char> duplicates = new HashSet<char>();

            for (int i = 0; i < input.Length; i++)
            {

                if (!duplicates.Contains(input[i]))
                {
                    duplicates.Add(input[i]);
                }
            }
            return string.Join(string.Empty, duplicates);

        }


        static string RemoveDuplicateCharectersHashSet(string input)
        {

            HashSet<char> result = new HashSet<char>();
            HashSet<char> seen = new HashSet<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (seen.Contains(input[i]))
                {
                    result.Remove(input[i]);
                }
                else
                {
                    seen.Add(input[i]);
                    result.Add(input[i]);
                }
            }
            return string.Join(string.Empty, result);

        }

        static string RemoveDuplicateCharecters(string input)
        {
            List<char> chars = input.ToList();
            for (int i = 0; i < chars.Count; i++)
            {
                for (int j = i + 1; j < chars.Count; j++)
                {
                    if (chars[i] == chars[j])
                    {
                        chars.RemoveAt(j);
                    }
                }
            }
            return string.Join(",", chars);

        }
    }
}