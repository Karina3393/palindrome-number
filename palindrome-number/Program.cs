namespace palindrome_number
{
   public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0)) return false;

            int reversed = 0;
            while (x > reversed)
            {
                reversed = reversed * 10 + x % 10;
                x /= 10;
            }

            return x == reversed || x == reversed / 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            
            int[] testNumbers = { 121, -121, 10, 12321, 0 };

            foreach (int num in testNumbers)
            {
                bool result = solution.IsPalindrome(num);
                Console.WriteLine($"Is {num} a palindrome? {result}");
            }
        }
    }
} 
