//  Написать программу, которая из имеющегося массива строк формируем массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись массивами. 
// Примеры:
// -["hello","2", "world", ":-)"] -> ["2", ":-)"]
// -["1234","1567", "-2", "computer science"] -> ["-2"]
// -["Russia","Denmark", "Kazan"] -> [] */

string[] array = { "hello","2", "world", ":-)"  };
string[] result = new string[array.Length];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) result[i] = array[i];
    else result[i] = string.Empty;
    if (result[i] != string.Empty) Console.Write($"{result[i]} ");
}