
namespace challenges_and_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {1,2,3,4,5,7};
            for ( int i = 0; i < array.Length; i++)
            {
                switch (array.Length)
                {
                    case array.Length % 2 == 0:
                        for ( int j = 0; j < array.Length; i++)
                        {
                            if (array[i] != array[array.Length / 2])
                            {
                                Console.WriteLine(array[i])
                            }
                        } 
                        break;

                    case array.Length % 2 != 0:
                        for (int j = 0; j < array.Length; i++)
                        {
                            if (array[i] != array[(array.Length + 1) / 2])
                            {
                                Console.WriteLine(array[i])
                            }
                        }
                        break;
                }
            }
        }
       
           
        
    }
}   
