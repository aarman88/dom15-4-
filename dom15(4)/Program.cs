using System;
using System.Collections.Generic;
using System.Reflection;

class Program
{
    static void Main()
    {
        // Получаем тип класса List<T>
        Type listType = typeof(List<>);

        // Получаем массив конструкторов
        ConstructorInfo[] constructors = listType.GetConstructors();

        // Выводим на экран список конструкторов
        Console.WriteLine("Конструкторы класса List<T>:");
        foreach (ConstructorInfo constructor in constructors)
        {
            Console.WriteLine(constructor);
        }
    }
}
