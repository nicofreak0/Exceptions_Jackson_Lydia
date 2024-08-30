namespace Exceptions_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // numerator for division
            float myFloat = 65.4f;
            // denominator for division
            float myOtherFloat = 0.0f;
            // result of the division
            float result = 0f;

            // random number generator for integers between 2 and 30
            Random rand = new Random();
            int myInt = rand.Next(2, 30);

            try
            {
                // attempts to divide myFloat aned myOtherFloat
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e)
            {
                // Handles exceptions thrown by the divide method and prints to console a prompt to enter another letter
                Console.WriteLine(e.Message);
                Console.WriteLine("Please Enter a Number Other Than Zero.");
                // attempts division with the new number entered
                myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());

                try
                {
                    // attempts to divide myFloat with the new denominator
                    result = Divide(myFloat, myOtherFloat);
                }
                catch (Exception e2)
                {
                    // handles the exceptions of the second attempt at division
                    Console.WriteLine(e2.Message);
                }
            }
                finally
            { 
                // displays the result of the division
                Console.WriteLine("Calculations Completed with a Result Of " + result);
            }

            try
            {
                // attempts to check if the age is older than 17
                CheckAge(myInt);
            }
            catch 
            {
                // prints to console the age of the player and tell them they are not old enough if the number is less than 17
                Console.WriteLine($"You Are {myInt} You Are Not Old Enough.");
            }
        }

        // divides two float numbers 
        static float Divide(float x, float y) 
        { 
            if(y == 0) 
            {
                // throws an exception if attempting to divide by zero
                throw new DivideByZeroException();
            }
            else
            {
                // returns the result
                return x / y;
            }
        }

        // checks if the age is 17 or older
        static void CheckAge(int age) 
        { 
        if(age >= 17)
            {
                // prints to console that the player is old enough to play mature games
                Console.WriteLine($"You Are {age}, You Can Play Mature Games.");
            }
        else
            {
                // throws exception if the user is younger than 17
                throw new ArgumentException();
            }
        }
    }
}