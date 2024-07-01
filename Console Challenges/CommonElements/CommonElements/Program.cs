namespace CommonElements
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 4, 4 };
            int[] array2 = { 2, 5, 4, 3, 4, 4 };
            List<int> list = commonElements(array1, array2);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static List<int> commonElements(int[] arr1, int[] arr2)
        {


            List<int> ListCommon = new List<int>();

            int resultIndex = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        if (!ListCommon.Contains(arr1[i]))
                        {
                            ListCommon.Add(arr1[i]);
                        }
                    }

                }
            }
            return ListCommon;
        }
    }
    }

