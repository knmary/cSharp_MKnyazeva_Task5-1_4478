//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArr = new int[a];

void massive(int a)
{
    for (int i = 0; i < a; i++)
    {
        randomArr[i] = new Random().Next(99,999);
        Console.Write(randomArr[i] + " ") ;
    }
}

int kol(int [] randomArr)
{
    int kol = 0;
    for (int i = 0; i < randomArr.Length; i++)
    {
        if (randomArr[i] % 2 == 0)
        kol = kol + 1;
    }

    return kol;
}

massive(a);
Console.Write($" -> {kol(randomArr)}");
