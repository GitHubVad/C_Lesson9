// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M"); 
int M = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число N"); 
int N = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine(NumRec(N,M)); 
 
string NumRec(int N, int M) 
{ 
    if (N==M) return Convert.ToString(M);
    return NumRec(N-1,M) + N; 
}