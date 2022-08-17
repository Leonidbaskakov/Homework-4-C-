// Программа которая задаёт массив из 8 элементов, заполненный псевдослучайными числами и выводит на экран

int[] result = FillMas(8,1,100);
PrintMas(result);


int[] FillMas(int n, int min, int max)
{
    int [] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min,max);
    }
    return array;
}

void PrintMas(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}