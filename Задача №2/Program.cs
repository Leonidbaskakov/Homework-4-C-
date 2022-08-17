// Принимает на вход число и выдает сумму цифр
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int n)
{
    int counter =0;
    for (;n >=1; n=n/10)
    {
    counter = counter +  (n % 10);
    }
    return counter;
}
SumNumbers(number);

Console.WriteLine($"сумма цифр в числе {number} = {SumNumbers(number)}");
