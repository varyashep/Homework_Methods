using static System.Console;

// Найти точку пересечения двух прямых y = kx + b

WriteLine("Уравнение прямой вида y = kx + b");
WriteLine("Введите параметры k и b для первой прямой через пробел: ");
string[] parametersFirst = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine("Введите параметры k и b для второй прямой через пробел: ");
string[] parametersSecond = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

double[] intersection = FindIntersection(double.Parse(parametersFirst[0]), double.Parse(parametersFirst[1]), double.Parse(parametersSecond[0]), double.Parse(parametersSecond[1]));

WriteLine($"Координаты точки пересечения: ({intersection[0]}; {intersection[1]})");

double[] FindIntersection(double k1, double b1, double k2, double b2)
{
    double[] intersectionCoord = new double[2];
    double x = (b2 - b1)/(k1 - k2); 
    double y = k1*x + b1; 
    
    intersectionCoord[0] = x;
    intersectionCoord[1] = y;

    return intersectionCoord;
}