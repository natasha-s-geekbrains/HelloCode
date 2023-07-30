// пример 1
// Собрать строку с числами от a до b, где a <= b (по возрастанию)
// пример 1a
// Собрать строку с числами от a до b, где a >= b (по убыванию)
//
// пример2
// Сумма чисел от 1 до n
//
// пример 3
// Вычислить a в степени n
//
// Пример 4
// Перебор слов
// Пусть у нас будет некоторый алфавит, состоящий из
// четырёх букв ("а", "и", "с", "в"), и нас просят показать все возможные слова, 
// состоящие из T букв. Т может равняться 1, 2, 3 и так далее.
//см в самом низу




using System.Globalization;

// ПЕРЕМЕННЫЕ
int x = 10;
int y = 24;
int c = 10;
int d = 3;
int q = 4;

// ПРОГРАММЫ*ПРОГРАММЫ*ПРОГРАММЫ*ПРОГРАММЫ*ПРОГРАММЫ*ПРОГРАММЫ*
// пример 1

string newstring = NumbersForUp(x, y);
Console.WriteLine(newstring);
newstring = NumbersRecursionUp(x, y);
Console.WriteLine(newstring);
newstring = NumbersRecursionUp2(x, y);
Console.WriteLine(newstring);

// пример 1a

string string2 = NumbersForDown(c, d);
Console.WriteLine(string2);
string2 = NumbersRecursionDown(c, d);
Console.WriteLine(string2);
string2 = NumbersRecursionDown2(c, d);
Console.WriteLine(string2);
string2 = NumbersRecursionDown3(c, d);
Console.WriteLine(string2);

// пример 2

int newSum = SumFor(d);
Console.WriteLine(newSum);
newSum = SumRec(d);
Console.WriteLine(newSum);
newSum = SumRec2(d);
Console.WriteLine(newSum);

// пример 3

int newPow = PowerFor(d, q);
Console.WriteLine(newPow);
newPow = PowerRec(d, q);
Console.WriteLine(newPow);
newPow = PowerRec2(d, q);
Console.WriteLine(newPow);
newPow = PowerRecMath(d, q);
Console.WriteLine(newPow);

//МЕТОДЫ*МЕТОДЫ*МЕТОДЫ*МЕТОДЫ*МЕТОДЫ*МЕТОДЫ*МЕТОДЫ*

// пример 1

string NumbersForUp(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRecursionUp(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRecursionUp(a + 1, b);
    else return String.Empty;
}

string NumbersRecursionUp2(int a, int b)
{
    if (a < b) return $"{a} " + NumbersRecursionUp2(a + 1, b);
    else return $"{b}";
}

// пример 1a

string NumbersForDown(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRecursionDown(int a, int b)
{
    if (a >= b) return $"{a} " + NumbersRecursionDown(a - 1, b);
    else return String.Empty;
}

string NumbersRecursionDown2(int a, int b)
{
    if (a >= b) return NumbersRecursionDown2(a, b + 1) + $"{b} ";
    else return String.Empty;
}

string NumbersRecursionDown3(int a, int b)
{
    if (a > b) return NumbersRecursionDown2(a, b + 1) + $"{b} ";
    else return $"{a} ";
}

// пример 2

int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

int SumRec2(int n)
{
    if (n == 1) return 1;
    else return n + SumRec(n - 1);
}

// пример 3

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)

{
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRec2(int a, int n)

{
    return (n == 0) ? 1 : PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

// пример 4

char[] s = { 'а', 'и', 'с', 'в' };
int count = s.Length;
int n = 1;

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"{n++,-5}{s[i]}");
}

Console.WriteLine();

n = 1;
for (int j = 0; j < count; j++)
{
    for (int k = 0; k < count; k++)
    {
        Console.Write($"{n++,-5}-{s[j]}{s[k]} | "); // если многобуквенные слова, то нужно будет много вложенных циклов (плохо)
    }
}
Console.WriteLine();

n = 1;

void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[2]);

