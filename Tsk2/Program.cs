//Изменить программу вывода таблицы функции так, чтобы можно было передавать 
//функции типа double (double, double). 
//Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).


public delegate double Fun(double x, double y);
public delegate void Fun1(Fun r, double x, double y);

class Program
{
    static void Main()
    {



        Hy cls3 = new Hy();
        Fun join = cls3.FuncPar;

        Hy cls4 = new Hy();
        Fun1 join01 = cls4.Table;


        Console.WriteLine("Таблица функции a*x^2");
        join01(join, 0, 3);

        Console.WriteLine("Таблица функции a*sin(x):");
        join01(new Fun(join), -2, 2);
    }
}
