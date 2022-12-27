// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*Console.WriteLine("Введи х: ");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введи y: ");
int y = int.Parse(Console.ReadLine()!);

if(x > 0 && y > 0){
    Console.WriteLine("Это первая четверть");
}
if(x < 0 && y > 0){
    Console.WriteLine("Это вторая четверть");
}
if(x < 0 && y < 0){
    Console.WriteLine("Это третья четверть");
}
if(x > 0 && y < 0){
    Console.WriteLine("Это четвертая четверть");
}*/

/*Console.WriteLine("Введи номер четверти: ");
int num = int.Parse(Console.ReadLine()!);
switch (num)
{
    case 1: {
        Console.WriteLine("x > 0, y > 0");
        break;
    }
    case 2: {
        Console.WriteLine("x < 0, y > 0");
        break;
    }
    case 3: {
        Console.WriteLine("x < 0, y < 0");
        break;
    }
        case 4: {
        Console.WriteLine("x > 0, y < 0");
        break;
    }
    
    default:{
        Console.WriteLine($"Ошибка");
        break;
    }
    
}*/

/*Console.WriteLine("Введи координаты х точки 1: ");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи координаты y точки 1: ");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи координаты х точки 2: ");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи координаты y точки 2: ");
int yb = int.Parse(Console.ReadLine()!);
double result = Math.Sqrt(Math.Pow(xb - xa, 2)+ Math.Pow(yb - ya, 2));
Console.WriteLine($"Расстояние между точками: {result:f2}");*/

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.*/

Console.WriteLine("Введи число: ");
int n = int.Parse(Console.ReadLine()!);
for (int i =1; i <= n; i++){
    Console.Write($"{Math.Pow(i, 2)} ");
}

