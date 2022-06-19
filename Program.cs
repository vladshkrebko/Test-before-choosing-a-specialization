using System;
using System.Linq;

Console.Clear();

Console.WriteLine("Введи элементы массива через пробел:");
string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
string[] resultArray = GetLenSelectedArray(array, 3);

Console.WriteLine(string.Join(", ", resultArray));

string[] GetLenSelectedArray(string[] arr, int charNumber)
{
    string[] result = new string[arr.Count(x => x.Length <= charNumber)];
    int count = 0;
    foreach (string el in arr)
        if (el.Length <= charNumber)
        {
            result[count] = el;
            count++;
        }
    return result;
}
