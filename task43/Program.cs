// Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// x = (b2 - b1) / (k1 - k2)

// если прямые параллельны то точек пересечения не будет, 
// соответсвенно нужно сделать проверку, что у прямых есть точка пересечения,
// эта точка пересечения будет при том условии что прямые непараллельны, 
// если паралельны то у них точек пересечения не будет

double Readnumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


(double, double) InterPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}

double b1 = Readnumber("Введите число b1: ");
double k1 = Readnumber("Введите число k1: ");
double b2 = Readnumber("Введите число b2: ");
double k2 = Readnumber("Введите число k2: ");

if (k1 == k2)
{
       Console.WriteLine("Прямые паралельны, точек пересечения нет!");
}
else if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прмые совпадают");
}
else
{
    Console.WriteLine($"Точка пересечения двух прямых = {InterPoint(k1, b1, k2, b2):f2}");
}
                                        