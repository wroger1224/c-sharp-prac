//Choose the correct data type
using System.Runtime.InteropServices;
using System.Windows.Markup;

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
    //Exercise - Discover Sort() and Reverse()
    {
        /* string[] pallets = ["B14", "A11", "B12", "A13"];

        Console.WriteLine("Sorted...");
        Array.Sort(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Console.WriteLine("Reversed...");
        Array.Reverse(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        } */
    }

    //Exercise - Explore Clear() and Resize()
    {
        /* string[] pallets = ["B14", "A11", "B12", "A13"];
        Console.WriteLine("");

        /* Console.WriteLine($"Before: {pallets[0].ToLower()}"); */
        /* Array.Clear(pallets, 0, 2);
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets) Console.WriteLine($"-- {pallet}"); */
        /* if (pallets[0] != null)
        {
            Console.WriteLine($"After: {pallets[0].ToLower()}");
        } */

        /* Console.WriteLine("");
        Array.Resize(ref pallets, 6);
        Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

        pallets[4] = "C01";
        pallets[5] = "C02";

        foreach (var pallet in pallets) Console.WriteLine($"-- {pallet}");

        Console.WriteLine("");
        Array.Resize(ref pallets, 3);
        Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

        foreach (var pallet in pallets) Console.WriteLine($"-- {pallet}");  */
    }

    //Exercise - Discover Split() and Join()
    {
        /* string value = "abc123";
        char[] valueArray = value.ToCharArray();
        Array.Reverse(valueArray);
        //string result = new string(valueArray);
        string result = string.Join(",", valueArray);
        Console.WriteLine(result);

        string[] items = result.Split(',');
        foreach (string item in items)
        {
            Console.WriteLine(item);
        } */
    }

    //Exercise - Complete a challenge to reverse words in a sentence
    {
        /* string pangram = "The quick brown fox jumps over the lazy dog";

        char[] pangramArray = pangram.ToCharArray();
        Array.Reverse(pangramArray);
        string partOne = string.Join("", pangramArray);

        string[] words = partOne.Split(' ');
        Array.Reverse(words);

        string final = string.Join(" ", words);
        Console.WriteLine(final); */

        // result: ehT kciuq nworb xof spmuj revo eht yzal god
        //Their answer:
        /*  string pangram = "The quick brown fox jumps over the lazy dog";

        // Step 1
        string[] message = pangram.Split(' ');

        //Step 2
        string[] newMessage = new string[message.Length];

        // Step 3
        for (int i = 0; i < message.Length; i++)
        {
            char[] letters = message[i].ToCharArray();
            Array.Reverse(letters);
            newMessage[i] = new string(letters);
        }

        //Step 4
        string result = String.Join(" ", newMessage);
        Console.WriteLine(result); */
    }

    //Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors
    {
        /* string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

        string[] orderID = orderStream.Split(',');
        Array.Sort(orderID);

        for (int i = 0; i < orderID.Length; i++)
        {
            int count = orderID[i].Count();
            if (count != 4)
            {
                orderID[i] += "\t- Error";
            }
            Console.WriteLine($"{orderID[i]}");
        } */

        //MS Learn Solution:
        /* 
        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
        string[] items = orderStream.Split(',');
        Array.Sort(items);

        foreach (var item in items)
        {
            if (item.Length == 4)
            {
                Console.WriteLine(item);
            }
            else
            {
                Console.WriteLine(item + "\t- Error");
            }
        } */
    }
}

//Format alphanumeric data for presentation in C#
{
    //Exercise - Investigate string formatting basics
    {
        /* decimal price = 67.55m;
        decimal salePrice = 59.99m;

        string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

        yourDiscount += $"A discount of {((price - salePrice) / price):P2}!";
        Console.WriteLine(yourDiscount); */

    }
    //Exercise - Explore string interpolation
    {
        /* int invoiceNumber = 1201;
        decimal productShares = 25.4568m;
        decimal subtotal = 2750.00m;
        decimal taxPercentage = .15825m;
        decimal total = 3185.19m;

        Console.WriteLine($"Invoice Number: {invoiceNumber}");
        Console.WriteLine($"   Shares: {productShares:N3} Product");
        Console.WriteLine($"   Sub Total: {subtotal:C}");
        Console.WriteLine($"         Tax: {taxPercentage:P2}");
        Console.WriteLine($"Total Billed: {total:C}"); */
    }
    //Exercise - Discover padding and alignment
    {
        /* string input = "Pad his";
        Console.WriteLine(input.PadRight(12, '-'));
        Console.WriteLine(input.PadLeft(12, '-')); */

        /* string paymentId = "769C";
        string payeeName = "Mr. Stephen Ortega";
        string paymentAmount = "$5,000.00";

        var formattedLine = paymentId.PadRight(6);
        formattedLine += payeeName.PadRight(24);
        formattedLine += paymentAmount.PadLeft(10);
        Console.WriteLine("1234567890123456789012345678901234567890");
        Console.WriteLine(formattedLine); */
    }
    //Exercise - Complete a challenge to apply string interpolation to a form letter
    {
        /* string customerName = "Ms. Barros";

        string currentProduct = "Magic Yield";
        int currentShares = 2975000;
        decimal currentReturn = 0.1275m;
        decimal currentProfit = 55000000.0m;

        string newProduct = "Glorious Future";
        decimal newReturn = 0.13125m;
        decimal newProfit = 63000000.0m;

        string opening = "Dear ";
        opening += customerName + ",\n";

        string mainMessage = $"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\n";
        string currentVNew = $"Currently, you own {currentShares:C} shares at a return of {currentReturn:P2}.\n\nOur new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.\n";

        string fullLetter = opening + mainMessage + currentVNew;
        Console.WriteLine(fullLetter);

        Console.WriteLine("Here's a quick comparison:\n");

        string comparisonMessage = "";

        comparisonMessage = currentProduct.PadRight(20);
        comparisonMessage += $"{currentReturn:P2}".PadRight(10);
        comparisonMessage += $"{currentProfit:C}\n";
        comparisonMessage += newProduct.PadRight(20);
        comparisonMessage += $"{newReturn:P2}".PadRight(10);
        comparisonMessage += $"{newProfit:C}\n";

        /*Their solution:
        comparisonMessage = currentProduct.PadRight(20);
        comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
        comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

        comparisonMessage += "\n";
        comparisonMessage += newProduct.PadRight(20);
        comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
        comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);*/

        /* Console.WriteLine(comparisonMessage); */
    }

}

{ //Modify the content of strings using built-in string data type methods in C# 
    //Exercise - Use the string's IndexOf() and Substring() helper methods
    {
        /* string message = "What is the value <span>between the tags</span>?";

        const string openSpan = "<span>";
        const string closeSpan = "</span>";

        int openingPosition = message.IndexOf(openSpan);
        int closingPosition = message.IndexOf(closeSpan);

        openingPosition += 6; //this # is the length of <span>. without it, you will be given <span> as part of your answer

        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length)); */

    }
    // Exercise - Use the string's IndexOf() and LastIndexOf() helper methods
    {
        /* string message = "(What if) there are (more than) one (set of parenthesis)?";
        while (true)
        {
            int openingPosition = message.IndexOf('(');
            if (openingPosition == -1) break;

            openingPosition += 1;
            int closingPosition = message.IndexOf(')');
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
            //Note that the overload of the Substring to return only the remaining unprocessed message:
            message = message.Substring(closingPosition + 1);
        } */
        //Work with different types of symbol sets with IndexOfAny()
        /* string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

        // The IndexOfAny() helper method requires a char array of characters. 
        // You want to look for:

        char[] openSymbols = { '[', '{', '(' };

        // You'll use a slightly different technique for iterating through 
        // the characters in the string. This time, use the closing 
        // position of the previous iteration as the starting index for the 
        //next open symbol. So, you need to initialize the closingPosition 
        // variable to zero:

        int closingPosition = 0;

        while (true)
        {
            int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

            if (openingPosition == -1) break;

            string currentSymbol = message.Substring(openingPosition, 1);

            // Now  find the matching closing symbol
            char matchingSymbol = ' ';

            switch (currentSymbol)
            {
                case "[":
                    matchingSymbol = ']';
                    break;
                case "{":
                    matchingSymbol = '}';
                    break;
                case "(":
                    matchingSymbol = ')';
                    break;
            }

            // To find the closingPosition, use an overload of the IndexOf method to specify 
            // that the search for the matchingSymbol should start at the openingPosition in the string. 

            openingPosition += 1;
            closingPosition = message.IndexOf(matchingSymbol, openingPosition);

            // Finally, use the techniques you've already learned to display the sub-string:

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        } */
    }
    //Exercise - Use the Remove() and Replace() methods
    {
        /* string data = "12345John Smith          5000  3  ";
        string updatedData = data.Remove(5, 20);
        Console.WriteLine(updatedData); */

        /* string message = "This--is--ex-amp-le--data";
        message = message.Replace("--", " ");
        message = message.Replace("-", "");
        Console.WriteLine(message); */
    }
    //Exercise - Complete a challenge to extract, replace, and remove data from an input string
    {
        /* string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        string quantity = "";
        string output = "";

        //Work here

        //Extract Quantity
        string open = "<span>";
        string close = "</span>";

        int openingPosition = input.IndexOf(open);
        int closingPosition = input.IndexOf(close);
        openingPosition += 6;

        int length = closingPosition - openingPosition;

        quantity = "Quantity: " + input.Substring(openingPosition, length);

        open = "<div>";
        close = "</div>";

        openingPosition = input.IndexOf(open);
        closingPosition = input.IndexOf(close);
        openingPosition += 5;

        length = closingPosition - openingPosition;

        input = input.Replace("&trade;", "&reg;");

        output = "Output: " + input.Substring(openingPosition, length);

        Console.WriteLine(quantity);
        Console.WriteLine(output); */

        //their answer (you still got it right!):

        /*  const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

         string quantity = "";
         string output = "";

         // Your work here

         // Extract the "quantity"
         const string openSpan = "<span>";
         const string closeSpan = "</span>";

         int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
         int quantityEnd = input.IndexOf(closeSpan);
         int quantityLength = quantityEnd - quantityStart;
         quantity = input.Substring(quantityStart, quantityLength);
         quantity = $"Quantity: {quantity}";

         // Set output to input, replacing the trademark symbol with the registered trademark symbol
         const string tradeSymbol = "&trade;";
         const string regSymbol = "&reg;";
         output = input.Replace(tradeSymbol, regSymbol);

         // Remove the opening <div> tag
         const string openDiv = "<div>";
         int divStart = output.IndexOf(openDiv);
         output = output.Remove(divStart, openDiv.Length);

         // Remove the closing </div> tag and add "Output:" to the beginning
         const string closeDiv = "</div>";
         int divCloseStart = output.IndexOf(closeDiv);
         output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

         Console.WriteLine(quantity);
         Console.WriteLine(output); */
    }
}

//Create Methods in C# Console Applications
{
    //Write your first C# method
    {
        //Exercise - Create your first method
        {
            /* Console.WriteLine("Generating random numbers:");
            DisplayRandomNumbers();

            void DisplayRandomNumbers()
            {
                Random random = new Random();

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{random.Next(1, 100)} ");
                }
                Console.WriteLine();
            } */
        }

        //Exercise - Create reusable methods
        {

            /*  int[] times = { 800, 1200, 1600, 2000 };
             int diff = 0;

             Console.WriteLine("Enter current GMT");
             int currentGMT = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Current Medicine Schedule:");
             DisplayTimes();

             Console.WriteLine("Enter new GMT");
             int newGMT = Convert.ToInt32(Console.ReadLine());

             if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
             {
                 Console.WriteLine("Invalid GMT");
             }
             else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
             {
                 diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
                 AdjustTimes();
             }
             else
             {
                 diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
                 AdjustTimes();
             }

             Console.WriteLine("New Medicine Schedule:");

             DisplayTimes();

             void DisplayTimes()
             {
                 foreach (int val in times)
                 {
                     string time = val.ToString();
                     int len = time.Length;

                     if (len >= 3)
                     {
                         time = time.Insert(len - 2, ":");
                     }
                     else if (len == 2)
                     {
                         time = time.Insert(0, "0:");
                     }
                     else
                     {
                         time = time.Insert(0, "0:0");
                     }

                     Console.Write($"{time} ");
                 }
                 Console.WriteLine();
             }

             void AdjustTimes()
             {
                 /* Adjust the times by adding the difference, keeping the value within 24 hours */
            /*for (int i = 0; i < times.Length; i++)
            {
                times[i] = ((times[i] + diff)) % 2400;
            }
        } */
        }

        // Exercise - Build code with methods
        {
            /*
            if ipAddress consists of 4 numbers
            and
            if each ipAddress number has no leading zeroes
            and
            if each ipAddress number is in range 0 - 255

            then ipAddress is valid

            else ipAddress is invalid
            */
            /*  string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
             string[] address;
             bool validLength, validZeroes, validRange = false;

             foreach (string ip in ipv4Input)
             {
                 address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

                 ValidateLength();
                 ValidateZeroes();
                 ValidateRange();

                 if (validLength && validZeroes && validRange)
                 {
                     Console.WriteLine($"{ip} is a valid IPv4 address");
                 }
                 else Console.WriteLine($"{ip} is an invalid IPv4 address");
             }

             void ValidateLength()
             {
                 validLength = address.Length == 4;
             }

             void ValidateZeroes()
             {
                 foreach (string number in address)
                 {
                     if (number.Length > 1 && number.StartsWith("0"))
                     {
                         validZeroes = false;
                         return;
                     }
                 }
                 validZeroes = true;
             }

             void ValidateRange()
             {
                 foreach (string number in address)
                 {
                     int value = int.Parse(number);
                     if (value < 0 || value > 255)
                     {
                         validRange = false;
                         return;
                     }
                 }
                 validRange = true;
             }*/
        }

        // Exercise - Complete the challenge to create a reusable method
        {
            /*  FortuneTeller();

             void FortuneTeller()
             {
                 Random random = new Random();
                 int luck = random.Next(100);

                 string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
                 string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
                 string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
                 string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

                 Console.WriteLine("A fortune teller whispers the following words:");
                 string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
                 for (int i = 0; i < 4; i++)
                 {
                     Console.Write($"{text[i]} {fortune[i]} ");
                 }
             } */
        }
    }
    //Create C# methods with parameters
    {
        //Exercise - Use parameters in methods
        {
            /*  int[] schedule = { 800, 1200, 1600, 2000 };

             DisplayAdjustedTimes(schedule, 6, -6);

             void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
             {
                 int diff = 0;
                 if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
                 {
                     Console.WriteLine("Invalid GMT");
                 }
                 else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
                 {
                     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
                 }
                 else diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

                 for (int i = 0; i < times.Length; i++)
                 {
                     int newTime = (times[i] + diff) % 2400;
                     Console.WriteLine($"{times[i]} -> {newTime}");
                 }
             } */
        }

        //Exercise - Understand method scope 
        {

            /* double pi = 3.14159;
            PrintCircleInfo(12);
            PrintCircleInfo(24);

            void PrintCircleInfo(int radius)
            {
                Console.WriteLine($"Circle with radius {radius}");
                PrintCircleArea(radius);
                PrintCircleCircumference(radius);
            }

            void PrintCircleCircumference(int radius)
            {
                double circumference = 2 * pi * radius;
                Console.WriteLine($"Circumference = {circumference}");
            }
            void PrintCircleArea(int radius)
            {
                double area = pi * (radius * radius);
                Console.WriteLine($"Area = {area}");
            } */
        }
        //Exercise - Use value and reference type parameters
        {
            /* int a = 3;
            int b = 4;
            int c = 0;

            Multiply(a, b, c);
            Console.WriteLine($"global statement: {a} x {b} = {c}");

            void Multiply(int a, int b, int c)
            {
                c = a * b;
                Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
            } */

            /* int[] array = { 1, 2, 3, 4, 5 };

            PrintArray(array);
            Clear(array);
            PrintArray(array);

            void PrintArray(int[] array)
            {
                foreach (int a in array)
                {
                    Console.Write($"{a} ");
                }
                Console.WriteLine();
            }

            void Clear(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = 0;
                }
            } */

            /* string status = "Healthy";

            Console.WriteLine($"Start: {status}");
            SetHealth(false);
            Console.WriteLine($"End: {status}");

            void SetHealth(bool isHealthy)
            {
                status = (isHealthy ? "Healthy" : "Unhealthy");
                Console.WriteLine($"Middle: {status}");
            } */
        }
        //Exercise - Methods with optional parameters
        {
            /* string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte", };
            string[] rsvps = new string[10];
            int count = 0;

            RSVP("Rebecca");
            RSVP("Nadia", 2, "Nuts");
            RSVP(name: "Linh", partySize: 2, inviteOnly: false);
            RSVP("Tony", inviteOnly: true, allergies: "Jackfruit");
            RSVP("Noor", 4, inviteOnly: false);
            RSVP("Jonte", 2, "Stone fruit", false);
            ShowRSVPs();

            void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
            {
                if (inviteOnly)
                {
                    //search guestList before adding rsvp
                    bool found = false;
                    foreach (string guest in guestList)
                    {
                        if (guest.Equals(name))
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine($"Sorry, {name} is not on the guest list");
                        return;
                    }
                }
                rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
                count++;
            }

            void ShowRSVPs()
            {
                Console.WriteLine("\nTotal RSVPs:");
                for (int i = 0; i < count; i++) Console.WriteLine(rsvps[i]);
            } */
        }
        //Exercise - Complete the challenge to display email addresses
        {
            /* string[,] corporate =
            {
                {"Robert", "Bavin"}, {"Simon", "Bright"},
                {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
                {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
            };

            string[,] external =
            {
                {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
                {"Shay", "Lawrence"}, {"Daren", "Valdes"}
            };

            string externalDomain = "hayworth.com";
            string corporateDomain = "contoso.com";
            string username = "";
            string fullEmailAddress = "";

            for (int i = 0; i < corporate.GetLength(0); i++)
            {
                // display internal email addresses
                Username(corporate[i, 0], corporate[i, 1], length: (corporate[i, 0].Length - 2));
                EmailAddress(username, corporateDomain);
                Console.WriteLine(fullEmailAddress);
            }

            for (int i = 0; i < external.GetLength(0); i++)
            {
                // display external email addresses
                Username(external[i, 0], external[i, 1], length: (external[i, 0].Length - 2));
                EmailAddress(username, externalDomain);
                Console.WriteLine(fullEmailAddress);
            }

            void Username(string firstName, string lastName, int length)
            {
                username = firstName.ToLower().Remove(2, length) + lastName.ToLower();
                return;
            }

            void EmailAddress(string username, string domain)
            {
                fullEmailAddress = username + "@" + domain;
                return;
            } */
            // You got it! Their solution was different:
            {/* string[,] corporate =
                {
        {"Robert", "Bavin"}, {"Simon", "Bright"},
        {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
        {"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

            string[,] external =
            {
        {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
        {"Shay", "Lawrence"}, {"Daren", "Valdes"}
    };

            string externalDomain = "hayworth.com";

            for (int i = 0; i < corporate.GetLength(0); i++)
            {
                DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]);
            }

            for (int i = 0; i < external.GetLength(0); i++)
            {
                DisplayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain);
            }

            void DisplayEmail(string first, string last, string domain = "contoso.com")
            {
                string email = first.Substring(0, 2) + last;
                email = email.ToLower();
                Console.WriteLine($"{email}@{domain}");
            } */
            }
        }

    }
    //Create C# methods that return values
    {
        // Exercise - Understand return type syntax 
        {
            double total = 0;
            double minimumSpend = 30.00;

            double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
            double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

            for (int i = 0; i < items.Length; i++)
            {
                total += GetDiscountedPrice(i);
            }
            total -= TotalMeetsMinimum() ? 5.00 : 0.00;

            Console.WriteLine($"Total: ${FormatDecimal(total)}");

            double GetDiscountedPrice(int itemIndex)
            {
                return items[itemIndex] * (1 - discounts[itemIndex]);
            }

            bool TotalMeetsMinimum()
            {
                return total >= minimumSpend;
            }

            string FormatDecimal(double input)
            {
                return input.ToString().Substring(0, 5);
            }
        }
    }
}



