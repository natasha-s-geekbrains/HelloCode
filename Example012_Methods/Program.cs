// Вид 1 не принимает значение и его не возвращает, а делает что-то другое
void Method1()
{
    Console.WriteLine("Автор...");
}

// вызов Method1(); // не забывать скобки в конце вызова метода
//****************************************
// Вид 2 принимает значение но не возвращает его, а просто выводит

void Method2(string msg)
{
    Console.WriteLine(msg);
}

//вызов Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // инкремент - увеличение счетчика на 1; декремент - уменьшение счетчика на 1
    }
}

// вызов метода Method21(msg: "Текст", count: 4); // можно указывать аргументы и двоеточие, а можно - нет
// вызов метода Method21(count: 5, msg: "Новый текст"); // аргументы в любой последовательности

//*****************************************
// Вид 3 не принимает значение, но возвращает

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
// вызов метода Console.WriteLine(year);

//********************************
// Вид 4 принимают аргумент и возвращают
// вариант 1 while

//  string Method4(int count, string text)
//  {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
//  }

//  string res = Method4(3, "R");
//  Console.WriteLine(res);
//-----------
// вариант 2 For

// string Method4(int count, string text)
// {
//     string result = String.Empty;

//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(3, "R");
// Console.WriteLine(res);

//************************************************
// ПРИМЕР 1: вывод таблицы умножения на экран

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }
//*************************************

// ПРИМЕР 2 работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить 
// маленькими “с”.

// Ясна ли задача?

// Что значит “Дан текст”?. 
// Что значит “черточками”?
// Какого алфавита?
// Маленькие буквы “к” заменить большими “К”, а большие “С” заменить 
// маленькими “с”.

// начало кода
// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде, "
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"
// //             012345
// //s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);
// конец кода

//*************************************

// ПРИМЕР 3 упорядочить массив по возрастанию
// 6 8 3 2 1 4 5 7
// 1. Найти позицию минимального элемента
// в неотсортированной части массива
// 2. Произвести обмен этого значения со 
// значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные 
// элементы

//начало кода
// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);
// конец кода

//*************************************

// ПРИМЕР 3 упорядочить массив по убыванию
// 6 8 3 2 1 4 5 7
// 1. Найти позицию МАКСИМАЛЬНОГО элемента
// в неотсортированной части массива
// 2. Произвести обмен этого значения со 
// значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные 
// элементы

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortDown(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSortDown(arr);
PrintArray(arr);

