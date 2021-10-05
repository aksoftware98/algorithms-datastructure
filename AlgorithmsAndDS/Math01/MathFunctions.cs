namespace Math01
{
    public class MathFunctions
    {

        #region Prime Number
        /// <summary>
        /// This function indicates if a specific number is a prime or not
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPrime(int number)
        {
            if (number == 1)
                return false;

            if (number == 2 || number == 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }
        #endregion 
    }
}
