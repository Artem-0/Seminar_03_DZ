// Задача 21. Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние
// между ними в 3D пространстве.

int[] A = new int[3];
System.Console.WriteLine("Введите координату X точки A: ");
A[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки A: ");
A[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z точки A: ");
A[2] = Convert.ToInt32(Console.ReadLine());

int[] B = new int[3];
System.Console.WriteLine("Введите координату X точки B: ");
B[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки B: ");
B[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z точки B: ");
B[2] = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(A[0] - B[0], 2) + Math.Pow(A[1] - B[1], 2) + Math.Pow(A[2] - B[2], 2));
System.Console.WriteLine(Math.Round(distance, 2));