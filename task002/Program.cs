/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int getCoordFromUser(string message){
    int result = 0;
    while (true){
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result)){
                break;
        }        
        else{
            Console.WriteLine("Вы ввели некоректое значение");
        }
    }
    return result;
}

double getDistance(int ax, int ay, int bx, int by, int az, int bz){
    double result = Math.Sqrt(Math.Pow(ax-bx,2) + Math.Pow(ay-by,2) + Math.Pow(az-bz,2));
    return result;
}

int ax = getCoordFromUser("Введите х координату первой точки");
int ay = getCoordFromUser("Введите y координату первой точки");
int az = getCoordFromUser("Введите z координату первой точки");

int bx = getCoordFromUser("Введите х координату второй точки");
int by = getCoordFromUser("Введите х координату второй точки");
int bz = getCoordFromUser("Введите z координату второй точки");

double distance = getDistance(ax, ay, bx, by, az, bz);

Console.WriteLine($"Расстояние между({ax},{ay}) and ({bx},{by}) and ({az},{bz}) is {distance}");

