using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberingSequence
{
    //Напишите метод, 
    //получающий на вход строку, содержащую целые числа, разделенные пробелами(числа умещаются в int), 
    //удаляющий из данной последовательности четные числа, 
    //и затем возвращающий строку, содержащую первые 3 из оставшихся чисел уменьшенных на 3, 
    //упорядоченных по убыванию их значений, увеличенных на 5. 
    //Примечание: не используйте циклы или условные выражения, задача может быть выполнена одним выражением.Подсказка: используйте LINQ.

    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "483 177 661 992 619 959 641 378 569 317 519 708 961 131 959 266 947 616 883 793";
            string str2 = "101 15 38 8 19 33";
            Console.WriteLine(sequence(str1));
        }

        private static string sequence(string str)
        {
            //var a = str.Split(' ').Select(x => int.Parse(x)).ToArray();
            //var b = a.Where(x => x % 2 == 1);
            //var c = b.Take(3);
            //var d = c.Select(x => x - 3);
            //var e = d.OrderByDescending(x => x);
            //var f = e.Select(x => x + 5);

            string returnStr = string.Join(" ", str.Split(' ')
                .Select(x => int.Parse(x))
                .Where(x => x % 2 != 0)
                .Take(3)
                .Select(x => x - 3)
                .OrderByDescending(x => x)
                .Select(x => x + 5));

            return returnStr;
        }
    }
}
