


//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

int i;
string[] array = new string[4];
void FillArray(string[] array) //Заполняем первоначальный массив с консоли 4-мя строками произвольной длины;
{
    for (i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-е строку");
        array[i] = Console.ReadLine();
    }
}

string[] array1 = new string[array.Length];
void NewShortArray(string[] array1) // Формируем новый массив из строк (элементов) первоначального массива с 3-мя или менее символами;
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array1[j] = array[i];
            j++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

FillArray(array);
PrintArray(array);
NewShortArray(array1);
PrintArray(array1);