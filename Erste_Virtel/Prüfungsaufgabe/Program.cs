/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна
3 символам. Первоначальный массив можно ввести с клавиатуры, либа задать на старте выполнения алгоритма.*/

string[] ArrayErstellen()
{
    string[] array1 = new string[5];
    string[] array2 = {"1", "2", "3", "4", "5"};
    for(int i = 0; i < array1.Length; i++)
    {
        Console.WriteLine($"Введите слово под индексом {array2[i]}: ");
        array1[i] = Console.ReadLine()!;
    }
    return array1;
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} \t");
    }
}

string[] FindeDasWort(string[] eingehendesArray)
{
    string[] arrayAmAusgang = new string[eingehendesArray.Length];
    for(int i = 0; i < eingehendesArray.Length; i++)
    {
        if(eingehendesArray[i].Length <= 3)
        {
            arrayAmAusgang[i] = eingehendesArray[i];
        }
    }
    return arrayAmAusgang;
}


string[] res1 = ArrayErstellen();
Console.WriteLine("Массив до поиска строк искомых длины.");
PrintArray(res1);
string[] res2 = FindeDasWort(res1);
Console.WriteLine();
Console.WriteLine("Массив строк искомой длины.");
PrintArray(res2);
