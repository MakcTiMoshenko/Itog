// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
//  меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на 
//  старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string[] array = new string[5] {"542", "12", "test", "world", "ok"};
// void EnterText(string text)
// {
//     for(int i = 0, i < 5, i++)
//     {
//         Console.WriteLine($"Введите {i+1} элемент: ");
//         Console.ReadLine()
//     }
// }
string[] result = new string[array.Length];
void SecondArrayWithIF(string[] array, string[] result)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        result[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array);
SecondArrayWithIF(array, result);
PrintArray(result);