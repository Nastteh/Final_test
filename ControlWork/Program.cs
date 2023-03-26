// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"]-> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] array = { "hello", "2", "world", ":-)" };
int sizeArray = array.Length;
string[] resultArray = new string[sizeArray];
int sizeResultArray = 0;

for (int i = 0; i < sizeArray; i++)
{
    if (array[i].Length <= 3)
    {
        resultArray[sizeResultArray] = array[i];
        sizeResultArray += 1;
    }
}

Console.Write("[");
Console.Write(string.Join(", ", resultArray, 0, sizeResultArray));
Console.Write("]");
