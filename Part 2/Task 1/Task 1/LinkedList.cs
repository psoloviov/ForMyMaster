using System;

namespace Task_1
{
    public class LinkedList
    {
        private int[] array;
        private int index;
        // Код ниже не работает :(
        // public void Input()
        // {
        //     var inputNumber = new int();
        //     do
        //     {
        //         Console.WriteLine("Введите число: ");
        //         var str = Console.ReadLine();
        //         bool result = Int32.TryParse(str, out inputNumber);
        //         if (result)
        //         {
        //             if (inputNumber != 0)
        //             {
        //                 index++;
        //                 int[] tmp = new int[index];
        //                 array = tmp;
        //                 array[index] = inputNumber;
        //             }
        //             else
        //             {
        //                 break;
        //             }
        //         }
        //         else
        //         {
        //             Console.WriteLine("Вы ввели некорректное число! Попробуйте снова.");
        //             Console.WriteLine("Или введите \"0\" Для выхода.");
        //         }
        //         
        //     } while (inputNumber != 0);
        // }
    }
}