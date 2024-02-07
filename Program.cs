//Задача 1: Задайте значения M и N.
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//Использовать рекурсию, не использовать циклы.
/*
void WriteDigits(int num1, int num2)
{
    if(num2 == num1-1)
    {
        return;
    }
    WriteDigits(num1,num2-1);
    Console.Write(num2+" ");
}

WriteDigits(-5, 10);
*/


//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
/*
int akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return akkerman(m - 1, 1);
else return akkerman(m - 1, akkerman(m, n - 1));
}

int m = 2;
int n = 3;
Console.Write($"Результат работы фунции Аккермана равен {akkerman(m, n)}.");
*/


//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
//Использовать рекурсию, не использовать циклы.
/*
void WriteElem(int[] A, int n)
{
    if(n > 0)
    {
        Console.Write(A[n] + " "); 
        WriteElem(A, n - 1);
    }
    else Console.WriteLine(A[0]);
}

int[] arr = {1, 2, 5, 10, 6, 30};
WriteElem(arr, arr.Length - 1);
*/
