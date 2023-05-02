//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int len = num.ToString().Length;
int sum=0;
int start;

if (len == 5)
{
    for(start=num; num!=0; num=num/10)
{

sum=sum*10 + num % 10;
}
if(start == sum)
Console.WriteLine("да");
else
Console.WriteLine("нет");
}
else
{
    Console.WriteLine("Введите пятизначное число!");
}

//Задача 21- решено 
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistsnce(double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)), 2);
// }

// Console.WriteLine("Input coordinate X to A:");
// double xa = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate Y to A:");
// double ya = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate Z to A:");
// double za = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate X to B:");
// double xb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate Y to B:");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate Z to B:");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distanse between point A with coordinates ({xa}, {ya}, {za}) and point coordinates ({xb}, {yb}, {zb}) -> {FindDistsnce(xa, ya,za, xb, yb, zb)}");


// Задача 23-решено 
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// System.Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// void Fun(int N)
// {
//     int i = 1;
//     while (i<= N)
//     {
//         System.Console.WriteLine($"{i} -> {i*i*i}");
//         i++;
//     }
// }

// Fun(N);