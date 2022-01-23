namespace Math01
{
    public class BitMagic
    {

        /// <summary>
        /// Count the number of bits within a given integer the naive way
        /// </summary>
        /// <param name="number">Integer that should be treated as a bits</param>
        /// <returns></returns>
        public static int CountSetBitsSimple(int number)
        {
            int result = 0; 

            while (number > 0)
            {
                if (number % 2 != 0)
                {
                    result++; 
                }
                number = number / 2;
            }

            return result;
        }

        /// <summary>
        /// Count the number of bits within a given integer using the bitwaise operators
        /// </summary>
        /// <param name="number">Integer that should be treated as a bits</param>
        /// <returns></returns>
        public static int CountSetBitsUsingBitwise(int number)
        {
            int result = 0;

            while (number > 0)
            {
                if ((number & 1) == 1)
                {
                    result++;
                }
                number = number >> 1;
            }

            return result;
        }

        /// <summary>
        /// Calculate the number of set bits using bitwise operators and the algorithms of Brian & Kerningham
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int CountSetBitsUsingBitwiseAdvanced(int number)
        {
            int result = 0;
            while (number > 0)
            {
                number = number & (number - 1);
                result++;
            }
            return result;
        }

        /// <summary>
        /// Calculate the number of set bits using lookup table
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int CountSetBitsUsingLookupTable(int number)
        {
            int result = 0;
         


            return result;
        }
    }
}
