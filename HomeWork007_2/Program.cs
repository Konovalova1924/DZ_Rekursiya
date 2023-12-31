﻿// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int Ackerman(int m, int n){
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Ackerman(m - 1, 1);
    if (m > 0 && n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
return Ackerman(m, n);
}
        
int result = Ackerman(3, 2);
Console.WriteLine(result);          

