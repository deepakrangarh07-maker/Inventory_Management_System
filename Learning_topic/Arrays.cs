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

// string operation = Console.ReadLine();

// try
// {
//     Console.WriteLine("Enter Your num1");
//     Double num1 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Enter Your num2");
//     Double num2 = Convert.ToDouble(Console.ReadLine());


//     Double result = 0;

//     switch (operation)
//     {
//         case "+":
//             result = num1 + num2;
//             break;
//         case "-":
//             result = num1 - num2;
//             break;
//         case "*":
//             result = num1  *num2;
//             break;
//         case "/":
//             result = num1 / num2;
//             break;
//     }
//     Console.WriteLine(result);
// }
// catch (DivideByZeroException)
// {
//     Console.WriteLine("Cannot divided by zero");
// }
// catch (FormatException ex)
// {
//     Console.WriteLine(ex.Message);
//     Console.WriteLine(ex.GetType());
// }
// finally
// {
//     Console.WriteLine("I run every time");
// }


// int[] numbers = { 25, 10, 50, 5, 40 };

// // for (int i = 0; i < numbers.Length; i++)
// // {
// //     Console.WriteLine(numbers[i]);
// // }

// Console.WriteLine(numbers.Length-1);
// Console.WriteLine(numbers[0]);
// Console.WriteLine(numbers[numbers.Length-1]);


using System.Globalization;
using System.Security.AccessControl;

// int[] numbers = { 25, 10, 50, 5, 40};

// int search = 40;
// bool found = false;

// for (int i=0; i<numbers.Length; i++)
// {
//     if(numbers[i] == search)
//     {
//         search = i;
//         found = true;
//         Console.WriteLine(search);
//         break;
//     }
// }

// if (found)
// {
//     Console.WriteLine("found");
// }
// else
// {
//     Console.WriteLine("NOT Found");
// }

// int[] numbers = { 50, 20, 70, 10, 40 };

// int min = numbers[0];

// for (int i=0; i<numbers.Length; i++)
// {
//       if(numbers[i] < min)
//     {
//         min = numbers[i];
//     }
// }

// Console.WriteLine(min);



// int[] numbers = { 50, 20, 70, 10, 40 };

// // int asc1 = numbers[0];
// // int asc2 = numbers[1];

// for (int i=0; i<numbers.Length-1; i++)
// {
//     for (int j=i; j<numbers.Length; j++)
//     {
//         if(numbers[i] > numbers[j])
//         {
//             int temp = numbers[i];
//             numbers[i] = numbers[j];
//             numbers[j]= temp;
//         }

//     }
// }

// foreach(int number in numbers)
// {
//     Console.WriteLine(number);
// }   



// int[] numbers = { 50, 20, 70, 10, 40 };

// int first = 0;
// int last = numbers.Length - 1;

// while (first < last)
// {
//     int temp = numbers[first];
//     numbers[first] = numbers[last];
//     numbers[last] = temp;
//     first++;
//     last--;
// }

// foreach (int number in numbers)
// {
//     Console.WriteLine(number);
// }


// int[] numbers = { 25, 10, 40, 5, 40 };

// int target = 40;
// int count = 0;

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] == target)
//     {
//         count = count + 1;
//     }

// }
// Console.WriteLine(count);