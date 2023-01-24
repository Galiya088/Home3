// Задача 21
// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

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


