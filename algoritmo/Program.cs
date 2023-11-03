static double algoritmo(double a, double b, double c) {
    return (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
}

double resultado = algoritmo(1, 4, 2);
Console.WriteLine(resultado);