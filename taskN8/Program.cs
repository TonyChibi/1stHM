﻿Console.Clear();
Console.Write("insert some integer: ");
int num = int.Parse(Console.ReadLine()!);
for(int i=2; i<=num; i+=2)
{Console.Write($"{i}, ");}