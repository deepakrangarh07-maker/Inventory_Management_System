// Console.WriteLine("Hello, World!");
// try
// {
//     int a = 10;
//     int b = 0;

//     int result = a/b;
//     Console.WriteLine(result);
// }
// catch(DivideByZeroException)
// {
//     Console.WriteLine("0");
// }

// try
// {
//     int age = -5;

//     if (age < 0)
//     {
//         throw new Exception("Age Cannot be negative");
//     }
// }
// catch (Exception ex)
// {
//   Console.WriteLine(ex.HelpLink);  
// }

// try
// {
//     int[] numbers = { 10, 20, 30, 40, 50 };

//     Console.WriteLine(numbers[10]);
// }
// catch(Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }

// using System.Security.Cryptography;

// try
// {
//     Console.WriteLine("Enter Your Age");

//     int s = Convert.ToInt32(Console.ReadLine());
//     if (s < 0)
//     {
//         throw new Exception ("AGe not be negative");
//     }
//     Console.WriteLine(s);
// }

// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }
// finally
// {
//     Console.WriteLine("No Exception i am finally");
// }

string operation = Console.ReadLine();

try
{
    Console.WriteLine("Enter Your num1");
    Double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Your num2");
    Double num2 = Convert.ToDouble(Console.ReadLine());

    
    Double result = 0;

    switch (operation)
    {
        case "+":
            result = num1 + num2;
            break;
        case "-":
            result = num1 - num2;
            break;
        case "*":
            result = num1  *num2;
            break;
        case "/":
            result = num1 / num2;
            break;
    }
    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divided by zero");
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.GetType());
}
finally
{
    Console.WriteLine("I run every time");
}