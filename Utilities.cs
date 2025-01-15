using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    /// <summary>
    /// A repository of methods for reading and validating data and useful calculations
    /// </summary>
    internal static class Utilities
    {
        /// <summary>
        /// read and validate positive decimal value
        /// </summary>
        /// <param name="prompt">name used in error messages</param>
        /// <returns>positive decimal</returns>
        public static decimal GetPositiveDecimal(string prompt)
        {
            bool gotIt = false;
            decimal result = 0;

            while (!gotIt) // while gotIt is false
            {
                Console.WriteLine($"Enter {prompt}");
                string input = Console.ReadLine() ?? "";
                if (Decimal.TryParse(input, out result))
                {
                    if(result > 0)
                    {
                        gotIt = true; // success
                    }
                    else
                    {
                        Console.WriteLine($"Error: {prompt} must be positive");
                    }
                }
                else
                {
                    Console.WriteLine($"Error: {prompt} must be a number");
                } 
            }
            return result;
        }

        /// <summary>
        /// read and validate positive int value
        /// </summary>
        /// <param name="prompt">name used in error messages</param>
        /// <returns>positive int</returns>
        public static int GetPositiveInt(string prompt)
        {
            bool gotIt = false;
            int result = 0;

            while (!gotIt) // while gotIt is false
            {
                Console.WriteLine($"Enter {prompt}");
                string input = Console.ReadLine() ?? "";
                if (Int32.TryParse(input, out result))
                {
                    if (result > 0)
                    {
                        gotIt = true; // success
                    }
                    else
                    {
                        Console.WriteLine($"Error: {prompt} must be positive");
                    }
                }
                else
                {
                    Console.WriteLine($"Error: {prompt} must be a whole number");
                }
            }
            return result;
        }

        /// <summary>
        /// reads and validates int value within given range
        /// </summary>
        /// <param name="prompt">name used in error messages</param>
        /// <param name="minValue">minimum value for the range</param>
        /// <param name="maxValue">maximum value for the range</param>
        /// <returns></returns>
        public static int GetIntInRange(string prompt, int minValue, int maxValue)
        {

            bool gotIt = false;
            int result = 0;

            while (!gotIt) // while gotIt is false
            {
                Console.WriteLine($"Enter {prompt}");
                string input = Console.ReadLine() ?? "";
                if (Int32.TryParse(input, out result))
                {
                    if (result >= minValue && result <= maxValue)
                    {
                        gotIt = true; // success
                    }
                    else
                    {
                        if(minValue == Int32.MinValue)
                            Console.WriteLine($"Error: {prompt} must be less than or equal to {maxValue}");
                        else if(maxValue == Int32.MaxValue)
                            Console.WriteLine($"Error: {prompt} must be greater than or equal to {minValue}");
                        else
                            Console.WriteLine($"Error: {prompt} must be between {minValue} and {maxValue}");
                    }
                }
                else
                {
                    Console.WriteLine($"Error: {prompt} must be a whole number");
                }
            }
            return result;
        }


    } // class
} // namespace
