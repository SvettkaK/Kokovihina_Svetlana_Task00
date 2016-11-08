using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task01
{
    class Vector
    {
        public double x, y;//координаты вектора
        public Vector(double Ax, double Ay, double Bx, double By)
        {
            //координаты вектора
            x = Ax - Bx;
            y = Ay - By;
        }

        public double Length()//длина вектора
        {
            return Math.Sqrt((x*x) + (y*y));//return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));//todo перед отправкой задания весь закомментированный код удаляем, если только нет какой-то вопроса по этому участку кода
        }

        public double scalarProduct(Vector b)//скалярное произведение векторов
        {
            return (this.x * b.x) + (this.y * b.y);
        }

        public double AngleBetwen(Vector b)//угол между векторами
        {
            return Math.Acos(scalarProduct(b) / (Length() * b.Length()));
        }
    };


    class Program
    {
        public string belongs(double x, double y, string g)
        {
            bool res = false;
            
            if (g == "а" || g == "f")
            {
                if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) res = true;
            }

            if (g == "б" || g == ",")
            {
                if (x * x + y * y <= 1 && x * x + y * y >= 0.5 * 0.5) res = true;
            }

            if (g == "в" || g == "d")
            {
                if (x <= 1 && x >= -1 && y <= 1 && y >= -1) res = true;
            }
 
            if (g == "г" || g == "u")
            {
                Vector a = new Vector(x, y, 0, 1);
                Vector b = new Vector(x, y, 1, 0);
                Vector c = new Vector(x, y, 0, -1);
                Vector d = new Vector(x, y, -1, 0);

                double sumAngle = Math.Abs(a.AngleBetwen(b) + b.AngleBetwen(c) + c.AngleBetwen(d) + d.AngleBetwen(a)) * 180 / Math.PI;

                if (sumAngle == 360 || sumAngle == 180) res = true;
            }
              
            if (g == "д" || g == "l")
            {
                Vector a = new Vector(x, y, 0, 1);
                Vector b = new Vector(x, y, 0.5, 0);
                Vector c = new Vector(x, y, 0, -1);
                Vector d = new Vector(x, y, -0.5, 0);

                double sumAngle = Math.Abs(a.AngleBetwen(b) + b.AngleBetwen(c) + c.AngleBetwen(d) + d.AngleBetwen(a)) * 180 / Math.PI;

                if (sumAngle == 360 || sumAngle == 180) res = true;
            }
            
            if (g == "е" || g == "t")
            {
                Vector a = new Vector(x, y, 0, 1);
                Vector b = new Vector(x, y, -2, 0);
                Vector c = new Vector(x, y, 0, -1);

                double sumAngle = Math.Abs(a.AngleBetwen(b) + b.AngleBetwen(c) + c.AngleBetwen(a)) * 180 / Math.PI;

                if (sumAngle == 360 || sumAngle == 180 || (x * x + y * y <= 1 && x >= 0)) res = true;
            }
            
            if (g == "ж" || g == ";")
            {
                Vector a = new Vector(x, y, 0, 2);
                Vector b = new Vector(x, y, -1, -1);
                Vector c = new Vector(x, y, 1, -1);

                double sumAngle = Math.Abs(a.AngleBetwen(b) + b.AngleBetwen(c) + c.AngleBetwen(a)) * 180 / Math.PI;

                if (sumAngle == 360 || sumAngle == 180) res = true;
            }

            if (g == "з" || g == "p")
            {
                Vector a = new Vector(x, y, -1, 1);
                Vector b = new Vector(x, y, 0, 0);
                Vector c = new Vector(x, y, 1, 1);

                double sumAngle = Math.Abs(a.AngleBetwen(b) + b.AngleBetwen(c) + c.AngleBetwen(a)) * 180 / Math.PI;

                if (x <= 1 && x >= -1 && y <= 0 && y >= -2 && (sumAngle != 360 || sumAngle != 180)) res = true;
            }
              
            if (g == "и" || g == "b")
            {
                Vector a = new Vector(x, y, -1, 1);
                Vector b = new Vector(x, y, -2, -1);
                Vector c = new Vector(x, y, 1, 0);
                Vector d = new Vector(x, y, 0, 0);

                double sumAngle = Math.Abs(a.AngleBetwen(b) + b.AngleBetwen(c) + c.AngleBetwen(a)) * 180 / Math.PI;
                double sumAngle2 = Math.Abs(a.AngleBetwen(d) + d.AngleBetwen(c) + c.AngleBetwen(a)) * 180 / Math.PI;

                if ((sumAngle == 360 || sumAngle == 180) && (sumAngle2 != 360 && sumAngle2 != 180)) res = true;
            }

            if (g == "к" || g == "r")
            {
                Vector a = new Vector(x, y, -1, 1);
                Vector b = new Vector(x, y, 0, 0);
                Vector c = new Vector(x, y, 1, 1);

                double sumAngle = Math.Abs(a.AngleBetwen(b) + b.AngleBetwen(c) + c.AngleBetwen(a)) * 180 / Math.PI;

                if (sumAngle == 360 || sumAngle == 180 || y >= 1) res = true;
            }

            return "Точка (" + x + ";" + y + ") " + (res == true ? "принадлежит" : "НЕ принадлежит") + " фигуре " + g;//todo со string.Format смотрелось бы лучше
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            
            char ans = '+';
            while (ans == '+')
                try
                {
                    Console.WriteLine("Введите координаты точки:");
                    Console.Write("x: ");
                    double x = double.Parse(Console.ReadLine());
                    Console.Write("y: ");
                    double y = double.Parse(Console.ReadLine());

                    Console.Write("Выберите фигуру(а-к): ");
                    string graph = Console.ReadLine();

                    Console.WriteLine(obj.belongs(x, y, graph));

                    Console.WriteLine("\nПовторить(+/-)?");
                    ans = char.Parse(Console.ReadLine());
                    Console.WriteLine("\n\n");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не корректное значение. Повторите попытку...\n\n");
                }
        }


    }
}

