/*
 * CPRG 211 D lab 0
 * Author: Jolanta
 * When: Winter 2025
 */

using Lab0;

int low, high;
int diff; // difference between low and high
// get positive low number
low = Utilities.GetPositiveInt("low number");
//Console.WriteLine($"Low number is {low}");

// get high number that is greater than low
high = Utilities.GetIntInRange("high number", low + 1, Int32.MaxValue);
//Console.WriteLine($"High number is {high}");

// calculate and print the difference
diff = high - low;
Console.WriteLine($"The difference between {low} and {high} is {diff}");

// create an array to hold numbers from low to high
int[] numbers = new int[diff + 1];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = low + i;
}

    Console.WriteLine("Numbers in the array:");
for(int i=0;  i<numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

// create a new file "numbers.txt" and write to it the numbers from the array in reverse order
StreamWriter streamWriter = File.CreateText("numbers.txt"); // in the same directory as .exe file
for(int i = numbers.Length - 1; i >= 0; i--)
{
    streamWriter.WriteLine(numbers[i]);
}
streamWriter.Close(); // important to finalize the writing

// read the numbers back from the file into the same array and display
StreamReader streamReader = File.OpenText("numbers.txt");
string nextLine;
for (int i = 0; i < numbers.Length; i++)
{
    nextLine = streamReader.ReadLine()??"";
    numbers[i] = Convert.ToInt32(nextLine);
}
streamReader.Close();

Console.WriteLine("Numbers from the file:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}