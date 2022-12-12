void task_64()
// Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
// M = 1; N = 9. -> "3, 6, 9"
// M = 13; N = 20. -> "15, 18"
{
    Random rand = new Random();
    int M = rand.Next(10);
    int N = rand.Next(10, 50);
    Console.WriteLine($"M = {M}, N = {N}");
    
    // Console.Write($"Натуральные числа кратные 3-ём от {M} до {N}:\t");
    // while (M <= N)
    // {
    //     if (M % 3 == 0) Console.Write(M + "\t");
    //     M++;
    // }
    // Console.Write(String.Empty);
    
    Console.Write($"Натуральные числа кратные 3-ём от {M} до {N}:\t");
    DivisibleBy3(N, M);
    Console.WriteLine(String.Empty);
}

void DivisibleBy3(int N, int M)
{
    if (M > N) return;
    if (M % 3 == 0) Console.Write(M + "\t");
    M++;
    DivisibleBy3(N, M);
}


task_64();

void task_66()
// Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

{
    Random rand = new Random();
    int M = rand.Next(10);
    int N = rand.Next(10, 20);
    Console.WriteLine($"M = {M}, N = {N}");
    
    // int sum = 0;
    // Console.Write($"Сумма натуральных чисел от {M} до {N}:\t");
    // while (M <= N)
    // {
    //     sum = sum + M;
    //     M++;
    // }
    // Console.Write(sum);
    // Console.WriteLine(String.Empty);

    Console.WriteLine($"Сумма натуральных чисел от {M} до {N}: {numbersSum(N, M)}");
}

int numbersSum(int N, int M, int sum = 0)
{
    if (M > N) return sum;
    sum = sum + M;
    M++;
    return numbersSum(N, M, sum);
}
task_66();

void task_68()
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
{
     Random rand = new Random();
    int M = rand.Next(3);
    int N = rand.Next(3);
    Console.WriteLine($"Функция Аккермана для случайных чисел ({M},{N}) = {AckFunction(M, N)}"); 
}
    
int AckFunction(int M, int N)
{   
    if (M == 0 && N > 0) return N + 1;
    else if (M > 0 && N == 0) return AckFunction(M - 1, 1);
    else if (M > 0 && N > 0) return AckFunction(M - 1, AckFunction(M, N - 1));
    else if (M == 0 && N ==0) return 1;
    return AckFunction(M, N);
}

task_68();
