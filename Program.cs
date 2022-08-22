// 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//25.1
// Console.WriteLine("Введите число A: " );
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B: " );
// int numberB = Convert.ToInt32(Console.ReadLine());
// double result = Math.Pow(numberA, numberB);
// Console.WriteLine(result);

//25.2

// Console.Write("Введите A: ");
// double A = Convert.ToDouble(Console.ReadLine());
// double B = 1;
// Console.Write("Введите кол-во повторов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < n; i++)
//  {
//     B *= A;
//  }
// Console.WriteLine(B);


// 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = n; i > 0; i = i / 10)
// {
// sum = sum + i % 10;
// }
// Console.WriteLine(sum);
// Console.ReadLine();



// 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] array = new int[8];
// Random x = new Random();
// for (int i = 0; i < 8; i++)
// {
//     array[i] = x.Next(0,39);
//     Console.Write(array[i] +",");
// }