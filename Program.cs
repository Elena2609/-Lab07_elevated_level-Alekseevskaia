// //Шаг 2. ref — Swap
// void DoubleValue(ref int number)
// {
//     number = number * 2;
// }
// int x = 5;
// DoubleValue(ref x);
// Console.WriteLine(x); // 10 — изменилось 

// void Swap(ref int a, ref int b)
// {
//     int temp = a;
//     a = b;
//     b = temp;
// }
// int a = 10;
// int b = 20;

// Console.WriteLine($"До обмена: a = {a}, b= {b}");

// Swap(ref a, ref b);

// Console.WriteLine($"После обмена: a = {a}, b = {b}");

// //Шаг 3. out — частное и остаток
// bool TryDivide(int a, int b, out int result)
// {
//     if (b == 0)
//     {
//         result = 0;
//         return false;
//     }
//     result = a / b;
//     return true;
// }

// void Quotientandremainder(int a, int b, out int quotient, out int remainder)
// {
//     quotient = a / b;
//     remainder = a % b;
// }

// Console.WriteLine("Деление");

// bool success = TryDivide(10, 2, out int result1);
// Console.WriteLine($"10 / 2 = {result1}, успех {success}");

// bool fail = TryDivide(10, 0, out int result2);
// Console.WriteLine($"10 / 0 = {result2}, успех {fail}");

// Console.WriteLine("Частное и остаток");

// Quotientandremainder(17, 5, out int quotient1, out int remainder1);
// Console.WriteLine($"17 / 5 -> частное {quotient1}, остаток {remainder1}");

// Quotientandremainder(20, 5, out int quotient2, out int remainder2);
// Console.WriteLine($"20 / 5 -> частное {quotient2}, остаток {remainder2}");

// //Шаг 4. in
// CharacterStats myHero;
// myHero.Health = 100;
// myHero.Damage = 25;
// myHero.Armor = 15;

// PrintStats(in myHero);

// void PrintStats(in CharacterStats stats)
// {
//     Console.WriteLine($"HP: {stats.Health}");
//     Console.WriteLine($"Урон: {stats.Damage}");
//     Console.WriteLine($"Броня: {stats.Armor}");
// }

// struct CharacterStats
// {
//     public int Health;
//     public int Damage;
//     public int Armor;
// }

// Шаг 5. Необязательные параметры и именованные аргументы
void FormatHero(string name, int level, string title = "Новичок", string color = "Белый"){
    Console.WriteLine($"Имя: {name}");
    Console.WriteLine($"Уровень: {level}");
    Console.WriteLine($"Титул: {title}");
    Console.WriteLine($"Цвет: {color}");
}
Console.WriteLine ("1. Минимальный набор: ");
FormatHero("Гриша", 10);
Console.WriteLine();

Console.WriteLine("2. Именованный аргумент: ");
FormatHero("Гриша", 10, color: "Розовый");
Console.WriteLine();

Console.WriteLine ("3. Измененный порядок: ");
FormatHero(level: 15, name: "Петя", color: "Черный", title: "Мастер");
Console.WriteLine();

