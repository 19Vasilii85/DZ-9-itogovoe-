Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int min_number = 1;
void recursionNumber(int n, int min)
{
    if (min > n)
    {
        return;
    }
    else
    {
        recursionNumber(n, min + 1);
        Console.Write(min + " ");
    }
}
if(number<0)
{
    Console.WriteLine("Введенное число меньше 0!");

}
else
{
       Console.WriteLine($"Рекурсия числа {number}, равна: ");
    recursionNumber(number, min_number);
}