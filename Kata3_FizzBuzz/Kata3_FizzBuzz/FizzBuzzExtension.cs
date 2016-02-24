using System.Text;

namespace Kata3_FizzBuzz
{
    public static class FizzBuzzExtension
    {
        public static string FizzBuzz(this int self)
        {
            var result = new StringBuilder();
            if (self%3 == 0)
            {
                result.Append("Fizz");
            }

            if (self%5 == 0)
            {
                result.Append("Buzz");
            }

            if (result.Length == 0)
            {
                result.Append(self.ToString());
            }
            return result.ToString();
        }
    }
}
