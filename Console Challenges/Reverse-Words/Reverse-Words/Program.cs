namespace Reverse_Words
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sentence = "csharp is programming language";
            Console.WriteLine();
            Console.WriteLine(reverseSentence(sentence));

        }
        public static string reverseSentence(string sentence)
        {

            string[] splitSentence = sentence.Split(" ");
            List<string> reverseSentence = new List<string> { };
            for (int i = splitSentence.Length - 1; i >= 0; i--)
            {
                reverseSentence.Add(splitSentence[i]);
            }
            return string.Join(" ", reverseSentence);
        }
    }
}
