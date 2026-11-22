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
// void FormatHero(string name, int level, string title = "Новичок", string color = "Белый"){
//     Console.WriteLine($"Имя: {name}");
//     Console.WriteLine($"Уровень: {level}");
//     Console.WriteLine($"Титул: {title}");
//     Console.WriteLine($"Цвет: {color}");
// }
// Console.WriteLine ("1. Минимальный набор: ");
// FormatHero("Гриша", 10);
// Console.WriteLine();

// Console.WriteLine("2. Именованный аргумент: ");
// FormatHero("Гриша", 10, color: "Розовый");
// Console.WriteLine();

// Console.WriteLine ("3. Измененный порядок: ");
// FormatHero(level: 15, name: "Петя", color: "Черный", title: "Мастер");
// Console.WriteLine();

//Итоговая задача. Проектирование системы персонажа
// Выбран ref, потому что метод должен изменить исходную переменную здоровья у вызывающего кода 
void ChangeHealth(ref int health, int damage)
{
    health = health - damage;
}

// Обычные параметры по значению: метод только читает входные данные и возвращает результат через return
int CalculateDamage(int damage, int level)
{
    return damage + level * 2;
}

// Выбран out, потому что метод возвращает два значения: признак успеха и величину эффекта
bool TryUseSkill(int energy, int energyCost, out int effect)
{
    if (energy < energyCost)
    {
        effect = 0;
        return false;
    }
    effect = energyCost * 3;
    return true;
}

// Выбран in, потому что характеристики struct, и передача по значению копировала бы все поля, а in дает ссылку без копирования и без возможности изменить структуру внутри метода.
void PrintStats(in CharacterStats stats)
{
    Console.WriteLine($"HP: {stats.Health}");
    Console.WriteLine($"Урон: {stats.Damage}");
    Console.WriteLine($"Броня: {stats.Armor}");
}

// detailed - необязательный параметр со значением по умолчанию false, он стоит после обязательного
void PrintHero(Hero hero, bool detailed = false)
{
    if (detailed)
    {
        Console.WriteLine($"Герой: {hero.Name} (подробный режим)");
    }
    else
    {
        Console.WriteLine($"Герой: {hero.Name}");
    }

} 

Hero hero = new Hero();
hero.Name = "Рыцарь";

CharacterStats stats;
stats.Health = 100;
stats.Damage = 25;
stats.Armor = 10;

int health = 100;
int energy = 40;

PrintHero(hero);
PrintStats(in stats);

Console.WriteLine($"Здоровье до атаки: {health}");
ChangeHealth(ref health, 30);
Console.WriteLine($"Здоровье после атаки: {health}");

int total = CalculateDamage(stats.Damage, 5);
Console.WriteLine($"Итоговый урон: {total}");

if (TryUseSkill(energy, 20, out int effect))
{
    Console.WriteLine($"Умение применено! Эффект: {effect}");
}
else
{
    Console.WriteLine("Недостаточно энергии");
}
PrintHero(hero, detailed: true);

struct CharacterStats
{
    public int Health;
    public int Damage;
    public int Armor;
}

class Hero
{
    public string Name = "Игрок";
} 


