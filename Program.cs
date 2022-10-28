
/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/

Console.WriteLine("Ввведите число или слово для его проверки на значение Паллиндрома");
var pallInput = Console.ReadLine();
var reversedPallInput = new string(pallInput.Reverse().ToArray());

if (reversedPallInput == pallInput)
{
    Console.WriteLine(" - Да, это паллиндром");
}
else 
{
    Console.WriteLine(" - Нет, это не паллиндром");
}

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
*/

int NumberXandYandZ(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}
double GetDistance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    return result;
}

int x1 = NumberXandYandZ("Введите координаты отрезка х1");
int y1 = NumberXandYandZ("Введите координаты отрезка y1");
int z1 = NumberXandYandZ("Введите координаты отрезка z1");
int x2 = NumberXandYandZ("Введите координаты отрезка x2");
int y2 = NumberXandYandZ("Введите координаты отрезка y2");
int z2 = NumberXandYandZ("Введите координаты отрезка z2");


Console.WriteLine(GetDistance(x1,x2,y1,y2,z1,z2));

/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

int Number(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}

int number = Number("Введите число");

for(var i = 1; i <= number; i++)
{
    double result = Math.Pow(i, 3);
    if (i < number)
    {
            Console.Write(result + ",");
    }
    else 
    {
        Console.Write(result);
    }
}