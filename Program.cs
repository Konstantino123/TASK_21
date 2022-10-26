// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
 double X1, Y1, Z1, X2, Y2, Z2;
Console.WriteLine("Введите координаты первой точки X1:");
X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки Y1:");
Y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки Z1:");
Z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки X2:");
X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки Y2:");
Y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки Z2:");
Z2 = Convert.ToDouble(Console.ReadLine());
double distance;
distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
                Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
                Console.ReadKey();
            