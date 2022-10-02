// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void PrintInterval(int m, int n)
        {
            int start = m;
            int end = n;
            if(m > n)
            {
                start = n;
                end = m;
            }
            for(int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
        }
        PrintInterval(4, 8);
        
        Console.WriteLine();

// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.   

int CalculateSumm(int m, int n)
        {
            int start = m;
            int end = n;
            if(m > n)
            {
                start = n;
                end = m;
            }
            return (end + start)*(end - start + 1)/2;
        }
        
        Console.WriteLine(CalculateSumm(1, 15));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.       

int AkkermanRec(int m, int n)
{
if (m == 0) return n + 1;
if (n == 0) return AkkermanRec(m - 1, 1);
return AkkermanRec(m-1, AkkermanRec(m, n-1));
}
Console.WriteLine(AkkermanRec(2,3));
