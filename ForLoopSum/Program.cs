﻿
int sum = 0;

for (int i = 0; i < 10; i++)
{

    Console.WriteLine($"i = {i}"); //ainult kuvamiseks
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i;
}

//Console.WriteLine($"Final total {sum}");