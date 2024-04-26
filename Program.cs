internal class Program
{
    private static void Main(string[] args)
    {
        string[] words = {"aja", "dad", "noon", "figure", "immense"};
        int count = CountPalindromes(words);
        Console.WriteLine($"No of Palindrome is {count}");
    }

    static int CountPalindromes(string[] words)
    {
      int count = 0;
      foreach (string word in words)
      {
        if (IsPalindrome(word))
        {
          count ++;
        }
      }
      return count;
    }

    static bool IsPalindrome(string word)
    {
      return word.SequenceEqual(word.Reverse());
    }
}