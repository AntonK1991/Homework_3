//Задача 23
//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

void CubeTable(int input)
{
    int i;
    int num = 1;
    int[] array1 = new int[input];
    int[] array2 = new int[input];
    for (i = 0; i < input; i++)
    {
        array1[i] = num;
        array2[i] = (array1[i] * array1[i]) * array1[i];
        num++;
    }
    Console.WriteLine("N -> N^3");
    Console.WriteLine("________");
    for (i = 0; i < input; i++)
    {
        Console.WriteLine(array1[i] +" -> "+ array2[i]);
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

CubeTable(num);