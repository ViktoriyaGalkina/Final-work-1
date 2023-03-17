// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


// void FillResultArray(string[] array1, string[] array2)
// {
//     int count = 0;
//     for (int i = 0; i < array1.Length; i++)
//     {
//         if (array1[i].Length <= 3)
//         {
//             array2[count] = array1[i];
//             count++;
//         }
//     }
// }

// void PrintArray(string[] array)
// {
//     // for (int i = 0; i < array.Length; i++)
//     // {
//     // Console.Write($"{array[i]} ");
//     // System.Console.Write("[" + string.Join(", ", array[i]) + "]");
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]}, ");
//     Console.Write($"{array[array.Length - 1]}]");
// }

// string[] array1 = {"hello", "2", "world", ":-)", "1234", "1567", "Rus",
// "-2", "computer science", "Russia", "Denmark", "Kazan", "GB", "GBU"};
// string[] array2 = new string[array1.Length];
// FillResultArray(array1, array2);
// PrintArray(array2);

int ArrayLengthCheck(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] FillResult(string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[result.Length - count] = array[i];
            count--;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "Rus",
"-2", "computer science", "Russia", "Denmark", "Kazan", "GB", "GBU" };
int count = ArrayLengthCheck(array);
string[] resultArray = FillResult(array, count);
PrintArray(resultArray);