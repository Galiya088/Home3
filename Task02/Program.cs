// Задача 21
// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("\n Задача 21");

// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string coorName, string pointName)
// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }

// double Decision(double x1, double x2, 
//                 double y1, double y2, 
//                 double z1, double z2){
//   return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//                    Math.Pow((y2-y1), 2) + 
//                    Math.Pow((z2-z1), 2));
// }

// double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

// Console.WriteLine($"Длина отрезка  {segmentLength}");

// ИЛИ 


    void Distanse(double x1, double y1, double z1, double x2, double y2, double z2)

 {
    Console.Write("Расстояние  между координатами:");
    double result1 = (x2-x1)*(x2-x1);
    double result2 = (y2-y1)*(y2-y1);
    double result3 = (z2-z1)*(z2-z1);
    double result = Math.Sqrt(result1 + result2 + result3);

    Console.Write(result);
 }
    double GetDouble(string text)
  {
    Console.Write(text);
    double num = double.Parse(Console.ReadLine());
    return num;
  }
   // // ввод данных от пользователя x, y, z
     double x1 = GetDouble("Введите значение x1:");
     double y1 = GetDouble("Введите значение y1:");
     double z1 = GetDouble("Введите значение z1:");
     
     double x2 = GetDouble("Введите значение x2:");
     double y2 = GetDouble("Введите значение y2:");
     double z2 = GetDouble("Введите значение z2:");
     Console.Write("Ответ:");
   // // определим результат
 Distanse(x1, y1, z1, x2, y2, z2);


