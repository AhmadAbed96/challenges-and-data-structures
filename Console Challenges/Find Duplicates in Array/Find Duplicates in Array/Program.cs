namespace Find_Duplicates_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 3, 2, 1 };
            int[] duplicatsArray = DuplicatesInArray(array);
            foreach (var item in duplicatsArray)
            {
                Console.WriteLine(item);
            }
        }
        public static int[] DuplicatesInArray(int[] array)
        {
            List<int> duoblicateslist = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (IsduplicatsValue(array, array[i], i + 1))
                {
                    duoblicateslist.Add(array[i]);
                }
            }
            return duoblicateslist.ToArray();

        }
        public static bool IsduplicatsValue(int[] array, int value, int index)
        {
            for (int i = index; i < array.Length; i++)
            {
                if (array[i] == value)

                    return true;

            }
            return false;
        }

    }
}
