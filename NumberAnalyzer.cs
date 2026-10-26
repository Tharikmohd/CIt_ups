using System;


class NumberAnalyzer
{
    public static void Main()
    {
        int[] num = new int[8];
        int count = 0;

        while (count < 8)
        {
            Console.Write($"Enter the number {count + 1} of 8 : ");
            string? value = Console.ReadLine();

            if (int.TryParse(value, out int parsedvalue))
            {
                num[count] = parsedvalue;
                count++;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid input");
            }

        }
        int eventcount = 0;
            int oddCount = 0;
            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;

            foreach (int n in num)
            {
                if (n % 2 == 0)
                {
                    eventcount++;
                }
                else
                {
                    oddCount++;
                }

                if (n > 0)
                {
                    positiveCount++;
                }
                else if (n < 0)
                {
                    negativeCount++;
                }
                else
                {
                    zeroCount++;
                }

            }

            Console.WriteLine("Result of given input value");
            Console.WriteLine($"Total even number count in user input is {eventcount}");
            Console.WriteLine($"Total odd number count in user input is {oddCount}");
            Console.WriteLine($"Total positive number count in user input is {positiveCount}");
            Console.WriteLine($"Total number number count in user input is {negativeCount}");
            Console.WriteLine($"Total zero value count in user input is {zeroCount}");
        int? largest = null;
            int? secondlargest = null;

            foreach (int n in num)
            {
                if (largest == null || n > largest.Value)
                {
                    secondlargest = largest;
                    largest = n;

                }
                else if (n < largest.Value && (secondlargest == null || n > secondlargest.Value))
                {
                    secondlargest = n;
                }

            }

            Console.WriteLine($"Largest number: {largest}");

            if (secondlargest.HasValue)
            {
                Console.WriteLine($"Second largest distinct number: {secondlargest}");
            }
            else
            {
                Console.WriteLine("No distinct second-largest number exists.");
            }

            //Reversed Array
            int[] reversedArray = new int[num.Length];

            for(int i = 0; i < num.Length; i++)
            {
                reversedArray[i] = num[num.Length - 1 - i];
            }

            Console.WriteLine("Original array: " + string.Join(", ", num));
            Console.WriteLine("Reversed array: " + string.Join(", ", reversedArray));
        }

    }


