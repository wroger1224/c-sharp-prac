﻿//Choose the correct data type
{
    //Discover integral types
    /* Console.WriteLine("Signed integral types:");

    Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
    Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
    Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
    Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

    Console.WriteLine("");
    Console.WriteLine("Unsigned integral types:");

    Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
    Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
    Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
    Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}"); */


    //Discover floating-point types
    /* Console.WriteLine("");
    Console.WriteLine("Floating point types:");
    Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
    Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
    Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)"); */


    //Discover reference types
    // new keyword informs .NET Runtime to create an instance of int array, and then coordinate with the operating system to store the array sized for three int values in memory. 
    /* int[] data = new int[3];

    //Value Type (int)
    int val_A = 2;
    int val_B = val_A;
    val_B = 5;

    Console.WriteLine("--Value Types--");
    Console.WriteLine($"val_A: {val_A}");
    Console.WriteLine($"val_B: {val_B}");

    //Reference Type (array)
    int[] ref_A = new int[1];
    ref_A[0] = 2;
    int[] ref_B = ref_A;
    ref_B[0] = 5;

    Console.WriteLine("--Reference Types--");
    Console.WriteLine($"ref_A[0]: {ref_A[0]}");
    Console.WriteLine($"ref_B[0]: {ref_B[0]}"); */
}

//Convert data types using casting and conversion techniques in C# 
{
    //Exercise - Explore data type casting and conversion
    {
        //Write code that attempts to add an int and a string and save the result in an int
        /* int first = 2;
        string second = "4";
        string result = first + second;
        Console.WriteLine(result); */

        //Is it possible that attempting to change the value's data type would result in a loss of information?
        /* int myInt = 3;
        Console.WriteLine($"int: {myInt}");

        decimal myDecimal = myInt;
        Console.WriteLine($"decimal: {myDecimal}"); */

        //Perform a cast
        /*  decimal myDecimal = 3.14m;
         Console.WriteLine($"decimal: {myDecimal}");
         // To perform a cast, you use the casting operator () to surround a data type, then place it next to the variable you want to convert (example: (int)myDecimal). You perform an explicit conversion to the defined cast data type (int).
         int myInt = (int)myDecimal;
         Console.WriteLine($"int: {myInt}"); */

        //Determine if your conversion is a "widening conversion" or a "narrowing conversion"
        /* decimal myDecimal = 1.23456789m;
        float myFloat = (float)myDecimal;

        Console.WriteLine($"Decimal: {myDecimal}");
        Console.WriteLine($"Float: {myFloat}"); */

        //Use ToString() to convert a number to a string
        /* int first = 5;
        int second = 7;
        string message = first.ToString() + second.ToString();
        Console.WriteLine(message); */

        //Convert a string to an int using the Parse() helper method
        /* string first = "5";
        string second = "7";
        int sum = int.Parse(first) + int.Parse(second);
        Console.WriteLine(sum); */

        //Convert a string to a int using the Convert class
        /* string value1 = "5";
        string value2 = "7";
        int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
        Console.WriteLine(result); */

        //Compare casting and converting a decimal into an int
        /* int value = (int)1.5m; //casting truncates
        Console.WriteLine(value);

        int value2 = Convert.ToInt32(1.5m); // converting rounds up
        Console.WriteLine(value2); */
    }
    //Exercise - Examine the TryParse() method
    /* {
        //TryParse() a string into an int
        string value = "bad";
        int result = 0;
        if (int.TryParse(value, out result))
        {
            Console.WriteLine($"Measurement: {result}");
        }
        else
        {
            Console.WriteLine("Unable to report the measurement");
        }
        if (result > 0)
            Console.WriteLine($"Measurement (w/ offeset): {50 + result}");
    } */
    //Exercise - Complete a challenge to combine string array values as strings and as integers
    {
        /* string[] values = { "12.3", "45", "ABC", "11", "DEF" };
        double result = 0;
        double total = 0;
        string message = "";

        foreach (string value in values)
        {

            if (double.TryParse(value, out result))
            {
                total += result;
            }
            else
            {
                message += value;
            }
        }
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Total: {total}"); */
    }
    //Exercise - Complete a challenge to output math operations as specific number types
    {
        /*         int value1 = 11;
                decimal value2 = 6.2m;
                float value3 = 4.3f;

                int result1 = 0;

                result1 = Convert.ToInt32(value1 / value2); //< correct answer
                //result1 = (int)(value1 / value2); //< incorrect answer (truncates the decimal portion of the result)

                // Hint: You need to round the result to nearest integer (don't just truncate)
                Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

                decimal result2 = 0;
                result2 = value2 / (decimal)value3;

                Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

                float result3 = 0;
                result3 = value3 / (float)value1;

                Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}"); */
    }
}

//Perform operations on arrays using helper methods in C#
{


}

//CodeWars Training
{
    //Implement a function which convert the given boolean value into its string representation.
    //Note: Only valid inputs will be given

    /*   public class kata
  {
      public static string BooleanToString(bool b)
      {
          if (b == true)
          {
              return "True";
          }
          else
          {
              return "False";
          } */
    // => b ? "True" : "False";  <<-- This is a more concise way to write the same logic using a ternary operator. Put it on the same line as the return statement.
    //OR
    //return b.ToString();  <<-- This is a more concise way to write the same logic using the built-in ToString() method of the bool type.
    //}
}

{
    //Calculate BMI
    /* Write function bmi that calculates body mass index (bmi = weight / height2).

if bmi <= 18.5 return "Underweight"

if bmi <= 25.0 return "Normal"

if bmi <= 30.0 return "Overweight"

if bmi > 30 return "Obese" */
    /*    Console.WriteLine("Enter your weight in pounds.");
       double weight = Convert.ToDouble(Console.ReadLine());

       Console.WriteLine("Enter your height in inches.");
       double height = Convert.ToDouble(Console.ReadLine());

       double bmi = (((weight * 703) / height) / height);
       bmi = double.Round(bmi, 2, MidpointRounding.AwayFromZero);
       Console.WriteLine($"Your calculated bmi is: {bmi}");

       switch (bmi)
       {
           case <= 18.5:
               Console.WriteLine("Underweight");
               break;

           case <= 25.0:
               Console.WriteLine("Normal");
               break;
           case <= 30:
               Console.WriteLine("Overweight");
               break;

           case > 30:
               Console.WriteLine("Obese");
               break;
           default:
               Console.WriteLine("Please check your numbers and try again");
               break;
       } */
}


