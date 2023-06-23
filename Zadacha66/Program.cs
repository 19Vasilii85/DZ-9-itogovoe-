Console.Clear();
Console.Write("Введите число M: ");
int number_m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int number_n = Convert.ToInt32(Console.ReadLine());

void sumOfNaturalNumbers(int m, int n)
{
    if(n<0 || m<0)
    {
        Console.WriteLine("Введенное число M или N меньше 0!");
    }
    else
    {
        int sum = 0;
        if(m<n){
            sum = SumNumberMAndNumberN(m - 1, n);
            Console.WriteLine($"Сумма чисел между промежутка {number_m} и {number_n}, равна: {sum}");
        }
        else{
            sum = SumNumberMAndNumberN(n - 1, m);
            Console.WriteLine($"Сумма чисел между промежутка {number_n} и {number_m}, равна: {sum}");

        }
    }
}
//Сумма чисел между промежутка от M до N
int SumNumberMAndNumberN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumNumberMAndNumberN(m, n);
        return res;
    }
}

//Выводим сумму
sumOfNaturalNumbers(number_m, number_n);