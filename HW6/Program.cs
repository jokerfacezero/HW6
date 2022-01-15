//2. Модифицировать программу нахождения минимума функции так, чтобы 
//можно было передавать функцию в виде делегата.
//а) Сделать меню с различными функциями и представить пользователю выбор, 
// для какой функции и на каком отрезке находить минимум. 
//Использовать массив (или список) делегатов, в котором хранятся различные функции.


public delegate void WorkWithFun(string a, double b, double c, double d, WorkWithDel x);
public delegate double WorkWithLoad(string j);
public delegate double WorkWithDel(double Y);
class Program
{

    static void Main()
    {
        Work work = new Work();

        WorkWithFun i = work.SaveFunc;

        WorkWithLoad o = work.Load;


        WorkWithDel[] Mass = new WorkWithDel[] { work.K, work.D, work.F };

        int Value = int.Parse(Console.ReadLine());

        i("String.bin", -100, 100, 0.5, Mass[Value - 1]);
        Console.WriteLine(o("String.bin"));


    }
}
