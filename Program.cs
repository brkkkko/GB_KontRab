// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.Clear();

Console.WriteLine("Enter the ammount of strings: "); // вводим количество строк
int n = Convert.ToInt32(Console.ReadLine());
string[] a = new string[n];

Console.WriteLine("Enter the strings: "); // вводим сами строки
PrintString(a);

Console.WriteLine("Strings with 3 or less symbols: ");
ThreeOrLess(a);

void PrintString(string[] a) // метод для печати строк
{
    for (int i = 0; i < a.Length; i++)
        a[i] = Convert.ToString(Console.ReadLine());
}

void ThreeOrLess(string[] a) // метод для вывода строки с 3 или меньше символами
{
    for (int i = 0; i < a.Length; i++)
        if (a[i].Length <= 3)
            Console.WriteLine(a[i]);
}

