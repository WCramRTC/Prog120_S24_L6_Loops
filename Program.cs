namespace Prog120_S24_L6_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string student1Name = "Coby";
            string student2Name = "Hoang";
            string student3Name = "Vicky";

            string[] students = new string[7];
            students[0] = "Coby";
            students[1] = "Brian";
            students[2] = "Vitalli";
            students[3] = "Vicky";
            students[4] = "Carla";
            students[5] = "Hoang";
            students[6] = "Will";

            // index

            for (int i = 0; i < students.Length; i += 2)
            {
                int index = i;
                string currentStudent = students[index];
                Console.WriteLine($"{index} : {currentStudent}");
            }

        } // Main

        // While
        public static void WhileLoopExample()
        {
            int count = 0;

            // while(condition)       
            while (count <= 10)
            {
                Console.WriteLine(count);
                count++; // Incrementer

            } // while
        }

        // While Example
        // Validating Numbers

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


          // Try Parse

        // Do While

        public static void DoWhileExample()
        {
            int count = 11;
            // do while
            do
            {
                Console.WriteLine(count);
            } while (count <= 10);

            Console.WriteLine("This is after our while loop");
        }

        // Do While Example
        // Password Checker
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

        // For Loop



        // For Loop Example
        public static void ForLoopExample()
        {
            //// Declared our variable
            //int count = 0;

            //// Checked our condition ( if true, it ran )
            //while(count < 10)
            //{
            //    // Code to run
            //    Console.WriteLine($"Count: {count}");

            //    // Incremented our variable
            //    count++;
            //}

            // keyword for
            //for(
            //    int i = 0; // Declare our variable
            //    i < 10; // Condition
            //    i++ // Increment
            //    )
            //{
            //    Console.WriteLine(i);
            //} // for

            // Start at 450
            // End at - 25
            // - 4

            for (int i = 450; i > -25; i -= 5)
            {
                Console.WriteLine(i);
            }
        } // For Loop Example()


        // Sum and Average Numbers
        public static void SumAndAverageNumbers()
        {
            // For Loop
            int sum = 0;
            int count = 0;

            // To get the average: sum of of numbers / count of numbers

            for (int i = 0; i < 300; i += 4)
            {
                // Adding i to the sum variable
                sum += i;
                // count is keep track of how many times we loop
                count++;
            }


            Console.WriteLine($"Sum: {sum} - Count: {count}");
            double avg = (double)sum / count;

            Console.WriteLine($"Average: {sum % count}");


        }


        // --------------------------------------------
        // Method
        public static void MathClassExample()
        {
            // Math Library ( Class )

            double radius = 2.5;
            int radiusInt = (int)radius;

            double areaDouble = Math.PI * (Math.Pow(radius, 2));
            double areaInt = Math.PI * (Math.Pow(radiusInt, 2));

            Console.WriteLine("Area with Double: " + areaDouble);
            Console.WriteLine("Area with Int: " + areaInt);
        } // MathClassExample


    } // class

} // namespace
