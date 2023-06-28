// Console.WriteLine("Привет, Мир!");

// 1. Пример с целыми числами

// int a = 7;
// int b = 5;
// int c = a / b;
// Console.WriteLine(c);

// 2. Пример чисел с плавающей точкой

// double a = 7;
// double b = 5;
// double c = a / b;
// Console.WriteLine(c);

// 3. Пример считывания числа из консоли

// int c = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(c);

// Task_1
// System.Console.Write("Введите число, квадрат которого вы хотите увидеть -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Квадрат числа {num} -> {num*num}");

//Task_2
// 5 - 25 ?
// 25 - 5
// System.Console.Write("Введите первое число -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число -> ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad = num2 * num2;
// if(num1 == quad){
//   System.Console.WriteLine($"Первое числое {num1} является квадратом второго числа {num2}");
// }else{
//   System.Console.WriteLine($"Первое числое {num1} не является квадратом второго числа {num2}");
// }

// Task3
// написать программу которая принимает число N и выводит последовательность чисел от -N до N

// System.Console.Write("Введите второе число N -> ");
// int n = Convert.ToInt32(Console.ReadLine());
// int current = n * (-1);

// while (current <= n)
// {
//   System.Console.WriteLine(current + " ");
//   current ++;
// }

// Task4
// 369

// Дается 3-хзначеное число. Нужно вывести последнюю цифру числа.
// System.Console.Write("Введите трехзначное число число -> ");
// int num = Convert.ToInt32(Console.ReadLine());

// if( num >= 100 && num <= 999){
//   System.Console.WriteLine($"Последняя цифра числа {num} -> {num % 10}");
//   // System.Console.WriteLine($"Последняя цифра числа {num} -> {(num / 10) % 10}");
// }else {
//   System.Console.WriteLine("Вы ввели не трезначное число!");
// }
