

namespace tydz4_lek13
{
    internal class FizzBuzz
    {
        
        public string resultFizzBuzz(int userNumber)
        {

            if (userNumber % 3 == 0 && userNumber % 5 == 0)
                return "FizzBuzz";
            else if (userNumber % 3 == 0)
                return "Fizz";
            else if (userNumber % 5 == 0)
                return "Buzz";
            else
                return userNumber.ToString();
        }
    }
}
