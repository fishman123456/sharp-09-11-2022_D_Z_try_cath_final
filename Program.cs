// See https://aka.ms/new-console-template for more information
// Создать свой класс исключения, выводящий сообщение об ошибке и текущую дату.
// Использовать его в теле текущей программы:
// Создан целочисленный массив на 10 чисел, рандомно его заполнить. +
// При переборе массива, в случае если его значение чётное+
// то вывести сообщение об ошибке. Использовать вложенные блоки try ---
// также на проверку неправильного индекса массива.
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

int[] array = new int[10];
Random random = new Random();

for (int i = 0; i < 10; i++)
{
    try
    {
        array[i] = random.Next(1, 99);
        int el_mass = array[i];
        Console.Out.WriteLine("{0} ", el_mass);
        if (el_mass % 2 == 0)
           throw new MyException("делится без остатка");
    }
    catch (MyException e)
    {
        Console.WriteLine(e.TimeExcept);
        Console.WriteLine(e.Message);
    }
}