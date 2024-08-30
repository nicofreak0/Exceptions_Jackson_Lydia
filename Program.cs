namespace Exceptions_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float myFloat = 65.4f;
            float myOtherFloat = 0.0f;
            float result = 0f;

            Random rand = new Random();
            int myInt = rand.Next(2, 30);

            try
            {
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please Enter a Number Other Than Zero.");
                myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());

                try
                {
                    result = Divide(myFloat, myOtherFloat);
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);
                }
            }
                finally
            { 
                Console.WriteLine("Calculations Completed with a Result Of " + result);
            }

            try
            {
                CheckAge(myInt);
            }
            catch 
            {
                Console.WriteLine($"You Are {myInt} You Are Not Old Enough.");
            }
        }


        static float Divide(float x, float y) 
        { 
            if(y == 0) 
            {
                throw new DivideByZeroException();
            }
            else
            {
                return x / y;
            }
        }

        static void CheckAge(int age) 
        { 
        if(age >= 17)
            {
                Console.WriteLine($"You Are {age}, You Can Play Mature Games.");
            }
        else
            {
                throw new ArgumentException();
            }
        }
    }
}