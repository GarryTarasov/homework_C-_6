// Задача 41: Пользователь вводит с клавиатуры M чисел в одну линию (не используем Enter).
// Числа разделены пробелами. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//1, -7, 567, 89, 223-> 3
//0 7 8 -2 -2 -> 2

Console.Clear();


Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int numb = arr.Count(x => x > 0);
Console.WriteLine($"\n Кол-во элементов которые больше 0: {numb}");