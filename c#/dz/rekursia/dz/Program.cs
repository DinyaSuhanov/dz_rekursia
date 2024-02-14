//              Задача 1: Задайте значения M и N. Напишите программу, 
//              которая выведет все натуральные числа в промежутке от M до N. 
//              Использовать рекурсию, не использовать циклы.


Console.WriteLine("\tВведите число M:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\tВведите число N:  ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNumber(int start, int end)
{
    if (end > start)
    {
       PrintNumber(start, end -1);
    }
    Console.WriteLine(end);
}
if( m < n)
{
   PrintNumber(m,n); 
}
else
{
    PrintNumber(n,m);
}

//              Задача 2: Напишите программу вычисления функции Аккермана 
//              с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int FuncAkrmn(int m, int n)
// {
// if (m == 0) 
// {
//     return n + 1;
// }
// else if (n == 0) 
// {
//     return FuncAkrmn(m -1, 1);
// }
// else return FuncAkrmn(m -1, FuncAkrmn(m, n -1));
// }

// Console.Write($"При  M = {m} и N = {n} функция Аккермана равняется {FuncAkrmn(m, n)} ");

//              Задача 3: Задайте произвольный массив. Выведете его элементы, 
//              начиная с конца. Использовать рекурсию, не использовать циклы.


// int [] mass = new [] {1,2,5,0,10,34};           
// int i = 6;                                      
// void PrintArrayRewrite(int [] array, int i)     
//         {
//             i= i -1;                            
//             if (i == 0)                         
//             {                                   
//                 Console.Write(array[i]);
//                 return;               
//             }
//             Console.Write($"{array[i]}, ");     
//             PrintArrayRewrite(array, i);        
//         }

// PrintArrayRewrite(mass, i);                     