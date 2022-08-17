// Напишите цикл который принимает на вход два числа (A и B) и возводит А в степень B.
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень ");
int ste= Convert.ToInt32(Console.ReadLine());


int stepSum(int n, int number)
{
    int sum =1;
     for (int i = 1; i <= n ; i++)
     {
     sum = sum * number;
     }
    return sum;
}
stepSum(ste, num);

Console.WriteLine($"Число {num} в степени {ste} = {stepSum(ste, num)}");
