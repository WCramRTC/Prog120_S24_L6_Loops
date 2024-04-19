# Prog120_S24_L6_Loops



## **Loops**
Loops are used to repeatedly execute a block of code until a certain condition is met or a specific number of iterations is completed. C# provides several types of loops to suit different scenarios.

## **While Loop**
A `while` loop executes a block of code repeatedly as long as a given condition is true. The loop continues to execute until the condition becomes false.

```csharp
int i = 0;
while (i < 5)
{
    Console.WriteLine($"The value of i is {i}");
    i++;
}
```

**Output:**
```
The value of i is 0
The value of i is 1
The value of i is 2
The value of i is 3
The value of i is 4
```

**Real-world example:** A `while` loop can be used to read data from a file or network stream until the end is reached.

## **Do-While Loop**
A `do-while` loop is similar to a `while` loop, but it guarantees that the code block will be executed at least once, even if the condition is false. The condition is evaluated after executing the code block.

```csharp
int i = 0;
do
{
    Console.WriteLine($"The value of i is {i}");
    i++;
} while (i < 5);
```

**Output:**
```
The value of i is 0
The value of i is 1
The value of i is 2
The value of i is 3
The value of i is 4
```

**Real-world example:** A `do-while` loop can be used to prompt the user for input until a valid value is entered.

## **For Loop**
A `for` loop is used when you know the number of iterations in advance. It consists of three parts: an initializer, a condition, and an iterator.

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"The value of i is {i}");
}
```

**Output:**
```
The value of i is 0
The value of i is 1
The value of i is 2
The value of i is 3
The value of i is 4
```

**Real-world example:** A `for` loop can be used to iterate over elements in an array or collection.

```csharp
string[] names = { "Alice", "Bob", "Charlie" };
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"Hello, {names[i]}!");
}
```

**Output:**
```
Hello, Alice!
Hello, Bob!
Hello, Charlie!
```

These are the fundamental loop constructs in C#. The choice of which loop to use depends on the specific requirements of your program and the condition you want to evaluate. Loops are essential for iterating over collections, performing repeated calculations, and executing code blocks based on certain conditions.

---
# Loop Examples

This code demonstrates various examples of loops in C#, including `while` loops, `do-while` loops, and `for` loops. The examples are organized into separate methods for each loop type.

## While Loop Examples

### `WhileExample()`

This method demonstrates a simple `while` loop that prints numbers from 0 to 9.

1. The `count` variable is initialized to 0.
2. The `end` value is set to 10.
3. The `while` loop executes as long as `count` is less than `end`.
4. Inside the loop, the current value of `count` is printed to the console.
5. The `count` variable is incremented by 1.

### `ValidateUserInput()`

This method demonstrates how to use a `while` loop to validate user input.

1. The `input` string, `number` integer, and `isValid` boolean flag are declared and initialized.
2. The `while` loop executes until `isValid` is `true`.
3. Inside the loop, the user is prompted to enter a number.
4. The `int.TryParse` method is used to attempt to parse the user input as an integer.
5. If the parsing is successful, `isValid` is set to `true`, and the loop exits.
6. If the parsing fails, an error message is displayed, and the loop continues.
7. After a valid input is provided, the entered number is displayed.

### `GameExample()`

This method demonstrates a simple game loop.

1. The `isRunning` boolean flag is set to `true`.
2. The `while` loop executes as long as `isRunning` is `true`.
3. Inside the loop, user input should be handled, game state should be updated, and game graphics should be rendered (not implemented in this example).
4. If the user enters "e" (case-insensitive), `isRunning` is set to `false`, and the loop exits.

## Do-While Loop Examples

### `DoWhileExample()`

This method demonstrates a `do-while` loop that prints numbers from 10 to 6.

1. The `count` variable is initialized to 10.
2. The `end` value is set to 5.
3. The `do-while` loop executes the code block at least once, regardless of the condition.
4. Inside the loop, the current value of `count` is printed to the console.
5. The `count` variable is incremented by 1.
6. The loop continues executing as long as `count` is less than `end`.

### `PasswordValidation()`

This method demonstrates how to use a `do-while` loop for password validation.

1. The `password` string and `isValidPassword` boolean flag are declared.
2. The correct password is set to "Cram".
3. The `do-while` loop executes at least once.
4. Inside the loop, the user is prompted to enter a password.
5. The entered password is compared with the correct password.
6. If the passwords don't match, an error message is displayed.
7. The loop continues executing until a valid password is entered.

### `DefaultName()`

This method demonstrates how to use a `do-while` loop to prompt the user for input with a default value.

1. The `input` string is declared.
2. The `do-while` loop executes at least once.
3. Inside the loop, the user is prompted to enter their name or press Enter to use the default "Guest".
4. The loop continues executing until the user enters a non-empty string.
5. The `name` variable is assigned the user input if it's not empty, or the default value "Guest" if it is empty.
6. A welcome message is displayed with the user's name.

## For Loop Examples

### `ForLoopsExample()`

This method demonstrates a simple `for` loop that prints numbers from 0 to 9.

1. The `for` loop is initialized with `i = 0`.
2. The loop condition checks if `i` is less than 10.
3. Inside the loop, the current value of `i` is printed to the console.
4. The `i` variable is incremented by 1 in the loop iterator.

### `LoopsWithCollection()`

This method demonstrates how to use a `for` loop to iterate over a collection (an array of names).

1. An array of names is defined.
2. The `for` loop iterates over the array using its length as the condition.
3. Inside the loop, the current index and the corresponding name are retrieved.
4. The index and name are printed to the console.

### `SumNumbers()`

This method demonstrates how to use a `for` loop to calculate the sum of numbers from 1 to 100.

1. The `sum` variable is initialized to 0.
2. The `for` loop iterates from 1 to 100 (inclusive).
3. Inside the loop, the current value of `i` is added to the `sum` variable.
4. After the loop, the sum of numbers from 1 to 100 is printed to the console.

### `AverageNumbers()`

This method demonstrates how to use a `for` loop to calculate the average of numbers from 1 to 100.

1. The `sum` and `count` variables are initialized to 0.
2. The `for` loop iterates from 1 to 100 (inclusive).
3. Inside the loop, the current value of `i` is added to the `sum` variable, and `count` is incremented by 1.
4. After the loop, the average is calculated by dividing `sum` by `count` (cast to `double` to avoid integer division).
5. The average is printed to the console.

---

C# Floating Point - Internal

C# primarily uses the IEEE 754 standard to represent floating-point numbers. Here's a breakdown of how it works and the implications:

**IEEE 754 Standard**

This widely used standard defines formats for representing both single-precision (32-bit) and double-precision (64-bit) floating-point numbers.  

* **Components:** A floating-point number under IEEE 754 is divided into three parts:

   1. **Sign Bit:** A single bit indicating whether the number is positive (0) or negative (1).
   2. **Exponent:** A set of bits representing the exponent of a power of two, which determines the scale or magnitude of the number.
   3. **Mantissa (or Fraction):** A set of bits representing the significant digits of the number (think of it as the decimal part, but in binary).

* **How it Works (Simplified):**

    * The exponent and mantissa are combined to determine a number roughly like this:  `(-1)^signBit * 1.mantissa * 2^exponent`
    * Special bit patterns are reserved to represent values like zero, positive/negative infinity, and Not-a-Number (NaN).

**C# Types**

* **float:** Single-precision (32-bit) floating-point number. Provides approximately 6-9 significant digits of precision.
* **double:** Double-precision (64-bit) floating-point number. Provides approximately 15-17 significant digits of precision.

**Implications of Floating-Point Representation**

* **Limited Precision:** Not all real numbers can be represented exactly with finite bits. Some numbers, like 0.1, end up as repeating decimals in binary. This can lead to rounding errors and unexpected results with calculations.
* **Comparisons:**  It's important to avoid direct equality comparisons with floating-point numbers (`==`) due to these rounding errors. Instead, compare whether numbers are within an acceptable tolerance range.
* **Special Values:** Be aware of how to handle NaN (Not-a-Number, usually the result of invalid calculations) and infinities (representing results outside the representable range).

**Example**

Let's imagine a simplified 8-bit floating-point format (C# uses larger formats):

* 1 bit for the sign
* 3 bits for the exponent
* 4 bits for the mantissa

The number 6.25 could be represented like this:

* Sign: 0 (positive)
* Exponent: 101 (bias might be added in actual IEEE 754)
* Fraction: 0101 (represents 1.3125 in this simplified system)

**Let me know if you'd like more details on IEEE 754, specific calculations, or have scenarios where you need to handle floating-point numbers with special care!** 
