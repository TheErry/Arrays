﻿/* int[] numbers = new int[5];

numbers[0] = 4;
numbers[1] = 8;
numbers[2] = 15;
numbers[3] = 16;
numbers[4] = 23;

Console.WriteLine(numbers[1]);
Console.WriteLine(numbers.Length);
Console.ReadLine(); */

//int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

/* string[] names = new string[] { "Eddie", "David", "Adam", "Max Lee"};

foreach (var name in names)
{
    Console.WriteLine(name);
}
Console.ReadLine(); */

/* for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}
Console.ReadLine(); */

string zig = "You can get what you want of life" +
    " if you help enough of other people get what they want";

char[] charArray = zig.ToCharArray();
Array.Reverse(charArray);

foreach (char zigChar in charArray)
{
    Console.Write(zigChar);
}
Console.ReadLine();