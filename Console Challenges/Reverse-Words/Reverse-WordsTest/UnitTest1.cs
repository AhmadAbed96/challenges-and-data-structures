using Reverse_Words;
namespace Reverse_WordsTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            string sentence1 = "csharp is programming language";
            string sentence2 = "Reverse the words in this sentence";
            string sentence3 = "challenges and data structures";

            string result1 = "language programming is csharp";
            string result2 = "sentence this in words the Reverse";
            string result3 = "structures data and challenges";
            //Act
            string reversed1 = Program.reverseSentence(sentence1);
            string reversed2 = Program.reverseSentence(sentence2);
            string reversed3 = Program.reverseSentence(sentence3);

            //Assert
            Assert.Equal(result1, reversed1);
            Assert.Equal(result2, reversed2);
            Assert.Equal(result3, reversed3);
        }
    }
}