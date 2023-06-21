Console.Clear();
Console.Write("Введите число M: ");
int number_m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int number_n = Convert.ToInt32(Console.ReadLine());
//функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
void showAkkerman(int m, int n)
{
    if(n<0 || m<0)
    {
        Console.WriteLine("Введенное число M или N меньше 0!");
    }
    else
    {
        Console.Write($"Вычисленное значение с помощью функции Аккермана, равно: {Akkerman(m, n)}"); 
    }
}
//Вывод на экран вычисления функции Аккермана
showAkkerman(number_m,number_n);