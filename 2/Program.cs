// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int x_coord = 0;
const int y_coord = 1;

double Promt(string massage)
{
    Console.Write($"{massage} = ");
    return Convert.ToDouble(Console.ReadLine());
}

bool ValidationLines(double k1, double k2)
{
    if (k1 == k2)
    {
        System.Console.WriteLine("Прямые совпадают или паралельны");
        return false;
    }

    return true;
}

double[] GetCrossPoint(double b1, double k1, double b2, double k2)
{
    double[] point = new double[2];
    point[x_coord] = (b2 - b1) / (k1 - k2);
    point[y_coord] = k1 * point [x_coord] + b1;
    return point;
}

double k1 = Promt("k1");
double k2 = Promt("k2");
double b1 = Promt("b1");
double b2 = Promt("b2");

if (ValidationLines(k1, k2))
{
    double[] CrossPoint = GetCrossPoint(b1, k1, b2, k2);
    System.Console.WriteLine($"x = {CrossPoint[x_coord]}\ny = {CrossPoint[y_coord]}");
}