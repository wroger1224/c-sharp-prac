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


