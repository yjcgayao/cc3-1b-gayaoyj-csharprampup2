namespace cc3_1b_gayaoyj_csharprampup2
{
    using System;

    class Program
    {
        static void Main()
        {
            // Divider Declaration
            int dividerLength = 35;
            string divider = new string('=', dividerLength);

            Console.WriteLine("Part 1");

            // Task 1: Convert pounds to kilograms
            Console.WriteLine("Task 1: Convert pounds to kilograms");
            double pounds;
            do
            {
                Console.Write("Enter weight in pounds (lbs): ");
                if (!double.TryParse(Console.ReadLine(), out pounds) || pounds <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive number.");
                }
            } while (pounds <= 0);

            double kilograms = pounds * 0.45359237;
            Console.WriteLine($"Weight in Pounds (lbs): {pounds}");
            Console.WriteLine($"Weight converted to Kilograms (kg): {kilograms:F2}");

            Console.WriteLine(divider);

            // Task 2: Convert miles to kilometers
            Console.WriteLine("Task 2: Convert miles to kilometers");
            double miles;
            do
            {
                Console.Write("Enter length in miles (mi): ");
                if (!double.TryParse(Console.ReadLine(), out miles) || miles <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive number.");
                }
            } while (miles <= 0);

            double kilometers = miles * 1.60934;
            Console.WriteLine($"Length in Miles (mi): {miles}");
            Console.WriteLine($"Length in Kilometers (km): {kilometers:F2}");

            Console.WriteLine(divider);

            // Task 3: Convert Fahrenheit to Celsius
            Console.WriteLine("Task 3: Convert Fahrenheit to Celsius");
            double fahrenheit;
            do
            {
                Console.Write("Enter temperature in Fahrenheit (°F): ");
                if (!double.TryParse(Console.ReadLine(), out fahrenheit))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (fahrenheit < -459.67); // Valid range for Fahrenheit temperatures

            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Temperature in Fahrenheit (°F): {fahrenheit}");
            Console.WriteLine($"Temperature in Celsius (°C): {celsius:F2}");

            Console.WriteLine(divider);

            // Task 4: Calculate the average age of students
            Console.WriteLine("Task 4: Calculate the average age of students");
            int[] ages = new int[10];
            for (int i = 0; i < ages.Length; i++)
            {
                do
                {
                    Console.Write($"Enter age of student {i + 1}: ");
                    if (!int.TryParse(Console.ReadLine(), out ages[i]) || ages[i] <= 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid positive integer.");
                    }
                } while (ages[i] <= 0);
            }

            // Function to calculate the average of an array of integers
            double CalculateAverage(int[] array)
            {
                int sum1 = 0;
                foreach (int value in array)
                {
                    sum1 += value;
                }
                return (double)sum1 / array.Length;
            }

            double averageAge = CalculateAverage(ages);
            Console.WriteLine("Ages of Students:");
            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}: {ages[i]} years");
            }
            Console.WriteLine($"The average age of the students is: {averageAge:F1} years");

            Console.WriteLine(divider);

            // Task 5: Output a multiline fantasy story
            Console.WriteLine("Task 5: Output a multiline fantasy story");
            string protagonists = "Chef Ella and her loyal kitchen companions";
            string culinaryWeapon = "<Magic Whisk Wand>";
            string culinaryArmor = "<Apron of Harmony>";
            string culinarySkill = "<Ella's Heartwarming Recipes>";
            string ultimateCulinarySkill = "<Dishes of Unity>";

            string story = $@"
            In a land filled with the aroma of delicious dishes, 
            the benevolent ruler, King Jasper, decided to bring 
            the kingdom together through the joy of cooking. 
            He organized a grand culinary event in the serene 
            Harmony Valley. Our cherished heroes, {protagonists}, 
            were renowned for their culinary talents and their 
            ability to unite people through food. They wholeheartedly 
            embraced the challenge, adorning themselves with the {culinaryArmor},
            and wielding the {culinaryWeapon}, a wand known for its magical stirring abilities. As 
            the competition unfolded, King Jasper showcased his 
            own culinary expertise with an array of unique ingredients, 
            but our heroes, with their {culinarySkill}, crafted 
            dishes that not only delighted the palate but also warmed 
            the hearts of all who tasted them. Ella's cooking brought 
            harmony to the kingdom like never before. However, King 
            Jasper had a heartwarming surprise of his own. He gathered 
            ingredients symbolizing unity and used them to create the {ultimateCulinarySkill},
            a set of dishes that magically brought everyone together and fostered a deep sense of togetherness.";

            Console.WriteLine(story);

            Console.WriteLine(divider);

            // Part 2: Number Patterns
            Console.WriteLine("Part 2: Number Patterns");

            // Number Pattern with Rows
            int rows;
            do
            {
                Console.Write("Enter a positive integer for the number pattern with rows: ");
                if (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
            } while (rows <= 0);

            // Loop for each row in the number pattern
            for (int i = 1; i <= rows; i++)
            {
                // Loop to print numbers in each row
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(divider);

            // Sum of Numbers up to Input
            int sumInput;
            do
            {
                Console.Write("Enter a positive integer for the sum of numbers: ");
                if (!int.TryParse(Console.ReadLine(), out sumInput) || sumInput <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
            } while (sumInput <= 0);

            int sum = 0;
            string formula = "";

            // Loop to calculate the sum and build the formula
            for (int i = 1; i <= sumInput; i++)
            {
                sum += i;
                formula += i;
                if (i < sumInput)
                {
                    formula += "+";
                }
            }

            Console.WriteLine($"Input: {sumInput}");
            Console.WriteLine($"Formula: {formula}");
            Console.WriteLine($"Output: {sum}");

            Console.WriteLine(divider);

            // Number Pattern with Columns
            int columns;
            do
            {
                Console.Write("Enter a positive integer for the number pattern with columns: ");
                if (!int.TryParse(Console.ReadLine(), out columns) || columns <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
            } while (columns <= 0);

            // Loop for each column in the number pattern
            for (int i = columns; i >= 1; i--)
            {
                // Loop to print numbers in each column
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}