﻿// Задание1.
// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int FintQuad (int x, int y)
{
  if(x > 0 && y > 0)
  {
    return 1;
  }
  
  if(x < 0 && y > 0)
  {
    return 2;
  }
  
  if(x < 0 && y < 0)
  {
    return 3;
  }
  
  if(x > 0 && y < 0)
  {
    return 4;
  }
  return 0;
}

System.Console.WriteLine("Input X coordinate: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input Y coordinate: ");
int y = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Point with X coordinate ({x}) and Y coordinate ({y}) belongs to {FintQuad(x,y)} quart");