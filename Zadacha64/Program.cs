Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int min_number = 1;
void recursionNumber(int n, int min)
{
    if(number<0 || number==min_number)
    {
        Console.WriteLine("Введенное число меньше минимального!");
    }
    else
    {
        Console.WriteLine($"Рекурсия числа {number}, равна: ");
        for(int i=number; i>=min;i--){
            Console.Write(i + " ");
        }
    }
}
recursionNumber(number, min_number);