void Peresech (double b1, double k1, double b2, double k2){
    if ((k1 ==k2) && (b1 == b2)) Console.WriteLine("Прямые совпадают");
    else 
       if (k1 ==k2) Console.WriteLine("Прямые параллельны");
    else {   
     double x = (b2-b1) / (k1 - k2);
     double y = k1* x + b1;
     Console.WriteLine($"Точка пересечения ( {x} ; {y})");

}
}

Console.WriteLine("Введите значение b1:");
double.TryParse(Console.ReadLine(), out double b1);
Console.WriteLine("Введите значение k1:");
double.TryParse(Console.ReadLine(), out double k1);
Console.WriteLine("Введите значение b2:");
double.TryParse(Console.ReadLine(), out double b2);
Console.WriteLine("Введите значение k2:");
double.TryParse(Console.ReadLine(), out double k2);
Peresech(b1, k1, b2, k2);

