// Задача 19
//Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.

void FindPalindrom(int input)
{
    int num = 0;
    int[] array = new int[5];
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        num = input % 10;
        array[i] = num;
        input = input / 10; 
    }
    if (array[0] == array[4] || array[1] == array[3])
    {
        Console.WriteLine("Введенное число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Введенное число не является палиндромом.");
    }
}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

FindPalindrom(num);