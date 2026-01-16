using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisctrictPortal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DisctrictPortal");
            Console.WriteLine("----------------");
            Console.WriteLine("1) Добавить пост(пока заглушка)");
            Console.WriteLine("2) Редактировать пост(пока заглушка)");
            Console.WriteLine("3) Изменить статус поста(пока заглушка)");
            Console.WriteLine("4) Удалить пост(пока заглушка)");
            Console.WriteLine("0) Выход");
            Console.WriteLine("----------------");
            Console.Write("Выберите пункт меню: ");

            var input = Console.ReadLine();
            Console.WriteLine($"Вы выбрали: {input}");
            
        }
    }
}
