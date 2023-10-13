/*Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает
 на вход координаты двух точек pointA и pointB в виде массива целых чисел, и возвращает 
 расстояние между ними в 3D пространстве.


A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/ 


System.Console.WriteLine("Ведите координаты точки A (x, y, z): ");
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());
int userAz = Convert.ToInt32(Console.ReadLine());
System.Console.Clear();
Console.WriteLine("Ведите координаты точки B (x, y, z): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());
int userBz = Convert.ToInt32(Console.ReadLine());

//int squareX = (userBx - userAx) * (userBx - userAx);
double squareX = Math.Pow(userBx - userAx, 2);// Math.Pow(a, 3) функция возведения в степень,(что возводим в степень, в какую степень)
double squareY = Math.Pow(userBy - userAy, 2);
double squareZ = Math.Pow(userBz - userAz, 2);
double rootXYZ = Math.Sqrt(squareX + squareY + squareZ);//Math.Sqrt() находит квадратный корень
System.Console.WriteLine(Math.Round(rootXYZ, 2));//Math.Round(a, 2) округление чисел после запятой(число, сколько чисел после запятой оставить)