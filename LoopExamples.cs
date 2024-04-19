using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog120_S24_L6_Loops
{
    public static class LoopExamples
    {
        // While Loop Examples
        public static void WhileExample()
        {
            // Initialize the count variable to 0
            int count = 0;
            // Set the end value to 10
            int end = 10;

            // The while loop will execute as long as count is less than end
            while (count < end)
            {
                // Print the current value of count
                Console.WriteLine(count);
                // Increment count by 1
                count++;
            }

        } // WhileExample

        public static void ValidateUserInput()
        {
            // Declare variables to store user input and a boolean flag for valid input
            string input;
            int number = 0;
            bool isValid = false;

            // The while loop will execute until a valid input is provided
            while (!isValid)
            {
                // Prompt the user to enter a number
                Console.Write("Enter a number: ");
                // Get the user input and store it in the input variable
                input = Console.ReadLine();

                // Try to parse the input string to an integer
                // Try parse type.TryParse(string, out expected output variable)
                if (int.TryParse(input, out number))
                {
                    // If the parsing is successful, set the isValid flag to true
                    isValid = true;
                }
                else
                {
                    // If the parsing fails, display an error message
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }

            // After a valid input is provided, display the entered number
            Console.WriteLine($"You entered: {number}");
        } // ValidateUserInput

        public static void GameExample()
        {
            // Set a flag to keep the game running
            bool isRunning = true;

            // The while loop will execute as long as the game is running
            while (isRunning)
            {
                // Handle user input
                // Update game state
                // Render game graphics

                // Check if the game should exit
                // In this example, the game will exit when the user enters "e"
                if (Console.ReadLine().ToLower() == "e")
                {
                    // Set the isRunning flag to false to exit the loop
                    isRunning = false;
                }
            }

        } // GameExample()


        // Do-While Loop Examples
        public static void DoWhileExample()
        {
            // Initialize the count variable to 10
            int count = 10;
            // Set the end value to 5
            int end = 5;

            // The do-while loop will execute the code block at least once
            do
            {
                // Print the current value of count
                Console.WriteLine(count);
                // Increment count by 1
                count++;
            } while (count < end); // The loop will continue executing as long as count is less than end

        }

        public static void PasswordValidation()
        {
            // Declare variables to store the password and a boolean flag for valid password
            string password;
            bool isValidPassword;

            // Set the correct password as "Cram"
            string myPassword = "Cram";

            // The do-while loop will execute at least once
            do
            {
                // Prompt the user to enter a password
                Console.Write("Enter a password (minimum 8 characters, at least one uppercase letter and one number): ");
                // Get the user input and store it in the password variable
                password = Console.ReadLine();

                // Check if the entered password matches the correct password
                isValidPassword = myPassword == password;
                if (!isValidPassword)
                {
                    // If the password is incorrect, display an error message
                    Console.WriteLine("Invalid password. Please try again.");
                }
            } while (!isValidPassword); // The loop will continue executing until a valid password is entered
        } // PasswordValidation

        public static void DefaultName()
        {
            // Declare a variable to store the user input
            string input;

            // The do-while loop will execute at least once
            do
            {
                // Prompt the user to enter their name
                Console.Write("Enter your name (or press Enter to use the default 'Guest'): ");
                // Get the user input and store it in the input variable
                input = Console.ReadLine();
            } while (input.Length == 0); // The loop will continue executing until the user enters a non-empty string

            // Assign the user input to the name variable if it's not empty, otherwise use the default value "Guest"
            string name = input.Length > 0 ? input : "Guest";
            // Display a welcome message with the user's name
            Console.WriteLine($"Welcome, {name}!");
        } // DefaultName


        // For Loop Examples
        public static void ForLoopsExample()
        {
            // The for loop will execute 10 times
            for (int i = 0; i < 10; i++)
            {
                // Print the current value of i
                Console.WriteLine(i);
            }
        }

        public static void LoopsWithCollection()
        {
            // Define an array of names
            string[] names = { "Hoang", "Vitalli", "Coby", "Vicky", "Brian" };

            // The for loop will iterate over the names in the array
            for (int i = 0; i < names.Length; i++)
            {
                // Get the current index and the corresponding name
                int currentIndex = i;
                string currentName = names[currentIndex];
                // Print the index and the name
                Console.WriteLine($"{i} : {currentName}");
            }
        }

        public static void SumNumbers()
        {
            // Initialize the sum variable to 0
            int sum = 0;

            // The for loop will iterate from 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                // Add the current value of i to the sum
                sum += i;
            }

            // After the loop, display the sum of numbers from 1 to 100
            Console.WriteLine($"The sum of numbers from 1 to 100 is: {sum}");
        }

        public static void AverageNumbers()
        {
            // Initialize the sum and count variables
            int sum = 0;
            int count = 0;

            // The for loop will iterate from 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                // Add the current value of i to the sum
                sum += i;
                // Increment the count
                count++;
            }

            // Calculate the average by dividing the sum by the count
            double average = sum / (double)count;
            // Display the average
            Console.WriteLine($"The average is {average}");
        }


        // Menu Structure
        public static void Menu()
        {
            // Set a flag to keep the main menu running
            bool showMenu = true;

            // The while loop will execute until the user chooses to exit
            while (showMenu)
            {
                // Display the main menu options
                Console.WriteLine("\nLoop Examples");
                Console.WriteLine("1. While Loops");
                Console.WriteLine("2. Do-While Loops");
                Console.WriteLine("3. For Loops");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                // Get the user's choice and store it in the choice variable
                string choice = Console.ReadLine();

                // Check the user's choice and call the corresponding menu or exit the program
                if (choice == "1")
                {
                    WhileLoopMenu();
                }
                else if (choice == "2")
                {
                    DoWhileLoopMenu();
                }
                else if (choice == "3")
                {
                    ForLoopMenu();
                }
                else if (choice == "4")
                {
                    // Exit the main menu loop
                    showMenu = false;
                }
                else
                {
                    // If the choice is invalid, display an error message
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }

        private static void WhileLoopMenu()
        {
            // Set a flag to keep the while loop menu running
            bool showWhileMenu = true;

            // The while loop will execute until the user chooses to go back to the main menu
            while (showWhileMenu)
            {
                // Display the while loop menu options
                Console.WriteLine("\nWhile Loop Examples");
                Console.WriteLine("1. While Example");
                Console.WriteLine("2. Validate User Input");
                Console.WriteLine("3. Game Example");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("Enter your choice: ");

                // Get the user's choice and store it in the choice variable
                string choice = Console.ReadLine();

                // Check the user's choice and call the corresponding method or go back to the main menu
                if (choice == "1")
                {
                    WhileExample();
                }
                else if (choice == "2")
                {
                    ValidateUserInput();
                }
                else if (choice == "3")
                {
                    GameExample();
                }
                else if (choice == "4")
                {
                    // Exit the while loop menu
                    showWhileMenu = false;
                }
                else
                {
                    // If the choice is invalid, display an error message
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }

        private static void DoWhileLoopMenu()
        {
            // Set a flag to keep the do-while loop menu running
            bool showDoWhileMenu = true;

            // The while loop will execute until the user chooses to go back to the main menu
            while (showDoWhileMenu)
            {
                // Display the do-while loop menu options
                Console.WriteLine("\nDo-While Loop Examples");
                Console.WriteLine("1. Do-While Example");
                Console.WriteLine("2. Password Validation");
                Console.WriteLine("3. Default Name");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("Enter your choice: ");

                // Get the user's choice and store it in the choice variable
                string choice = Console.ReadLine();

                // Check the user's choice and call the corresponding method or go back to the main menu
                if (choice == "1")
                {
                    DoWhileExample();
                }
                else if (choice == "2")
                {
                    PasswordValidation();
                }
                else if (choice == "3")
                {
                    DefaultName();
                }
                else if (choice == "4")
                {
                    // Exit the do-while loop menu
                    showDoWhileMenu = false;
                }
                else
                {
                    // If the choice is invalid, display an error message
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }

        private static void ForLoopMenu()
        {
            // Set a flag to keep the for loop menu running
            bool showForMenu = true;

            // The while loop will execute until the user chooses to go back to the main menu
            while (showForMenu)
            {
                // Display the for loop menu options
                Console.WriteLine("\nFor Loop Examples");
                Console.WriteLine("1. For Loop Example");
                Console.WriteLine("2. Loops with Collection");
                Console.WriteLine("3. Sum Numbers");
                Console.WriteLine("4. Average Numbers");
                Console.WriteLine("5. Back to Main Menu");
                Console.Write("Enter your choice: ");

                // Get the user's choice and store it in the choice variable
                string choice = Console.ReadLine();

                // Check the user's choice and call the corresponding method or go back to the main menu
                if (choice == "1")
                {
                    ForLoopsExample();
                }
                else if (choice == "2")
                {
                    LoopsWithCollection();
                }
                else if (choice == "3")
                {
                    SumNumbers();
                }
                else if (choice == "4")
                {
                    AverageNumbers();
                }
                else if (choice == "5")
                {
                    // Exit the for loop menu
                    showForMenu = false;
                }
                else
                {
                    // If the choice is invalid, display an error message
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }

    } // class
}