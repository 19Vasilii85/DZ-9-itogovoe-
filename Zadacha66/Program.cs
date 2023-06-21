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
            for(int i=m; i<=n;i++){
                sum = sum + i;
            }
            Console.WriteLine($"Сумма чисел между промежутка {number_n} и {number_m}, равна: {sum}");
        }
        else{
            for(int i=n; i<=m;i++){
                sum = sum + i;
            }
            Console.WriteLine($"Сумма чисел между промежутка {number_m} и {number_n}, равна: {sum}");
        }
    }
}
//Выводим сумму
sumOfNaturalNumbers(number_m, number_n);