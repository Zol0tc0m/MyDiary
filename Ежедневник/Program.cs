using System;
using System.Data;

class Program
{
    static void Main ()
    {
        ConsoleKeyInfo klav;
        do
        {

            ConsoleKeyInfo key;
            int position = 2;
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(  dateTime);
            Console.WriteLine("  Выберите действие.");
            Console.WriteLine("  _________________");

            if (dateTime.Date == new DateTime(2023, 10, 17))
            {
                Console.WriteLine("  1. Сходить на пары.");
                Console.WriteLine("  2. Погулять с собакой.");
            }
            else if (dateTime.Date == new DateTime(2023, 10, 18))
            {
                Console.WriteLine("  1. Сделать практос.");
            }
                ConsoleKeyInfo Key = Console.ReadKey();
            while (Key.Key != ConsoleKey.Enter)
                {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");

                if (Key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if (position == 2)
                        position = 3;
                }
                else if (Key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position == 5)
                        position = 4;
                }
                else if (Key.Key == ConsoleKey.RightArrow)
                {
                    dateTime = dateTime.AddDays(1);
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(dateTime);
                }
                else if (Key.Key == ConsoleKey.LeftArrow)
                {
                    dateTime = dateTime.AddDays(-1);
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(dateTime);
                }
                    Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                Key = Console.ReadKey();
            }
            if (position == 3)
            {
                Console.Clear();
                Console.WriteLine(dateTime);
                Console.WriteLine("Выжить");
            }
            if (position == 4)
            {
                Console.Clear();
                Console.WriteLine(dateTime);
                Console.WriteLine("Убрать за ней");
            }

            klav = Console.ReadKey();
            Console.Clear();
        } while (klav.Key != ConsoleKey.Escape);
    }
}