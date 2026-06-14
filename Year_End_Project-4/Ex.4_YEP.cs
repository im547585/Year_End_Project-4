using System.Drawing;

namespace Year_End_Project_4
{
    internal class Program
    {
        static void MainMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Здравейте, моля изберете една от следните опции: \n\t" +
                "1. Добавяне на книга/и\n\t" +
                "2. Търсене на книга\n\t" +
                "3. Редактиране на книга/и\n\t" +
                "4. Изтриване на книга/и \n\t" +
                "5. Сортиране на книга/и\n\t" +
                "6. Създаване на личен картон \n\t" +
                "7. Регистриране на заета книга\n\t" +
                "8. Преглед на личен картон\n\t" +
                "9. Изтриване на личен картон\n\t" +
                "0. ИЗХОД ОТ ПРОГРАМАТА\n\t");
            Console.ResetColor();
            Console.Write("ИЗБОР: ");
            int Choice = int.Parse(Console.ReadLine());
            if (Choice == 1){ Console.Clear(); AddBook();}
            else if (Choice == 2) { Console.Clear(); SearchBook(); }
            else if (Choice == 0) {ExitProgram();}
            }

        static void ExitProgram()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("МОЛЯ, ИМАЙТРЕ ПРЕДВИД, ЧЕ ПРИ ИЗХОД ОТ ПРОГРАМА ВСИЧКО ЩЕ СЕ ИЗТРИЕ!");
            Console.WriteLine("ИСКАТЕ ЛИ ДА ИЗЛЕЗЕТЕ? ДА/НЕ");
            Console.ResetColor();
            Console.Write("ИЗБОР: ");
            string YesNo = Console.ReadLine().ToUpperInvariant();
            if (YesNo == "ДА")
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(">>>УСПЕШЕН ИЗХОД<<<");
                Console.ResetColor();
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                MainMenu();
            }
        }

        static void MenuHeader()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("МОЛЯ, ИМАЙТРЕ ПРЕДВИД, ЧЕ ПРИ ИЗХОД ОТ ПРОГРАМА ВСИЧКО ЩЕ СЕ ИЗТРИЕ!");
            Console.ResetColor();
            Console.WriteLine("За да се върнете назад, натиснете 'Esc'.");
            var pressedKey = Console.ReadKey();
            if(pressedKey.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                MainMenu();
            }
        }

        static void AddBook()
        {
            
            Console.Write("Колко книги ще добавите?: ");
            LibrarySystem_Books NewBook = new LibrarySystem_Books();
            int Choice = int.Parse(Console.ReadLine());
            for (int i = 0; i < Choice; i++)
            {
                Console.Write("Име на книгата: ");
                NewBook.Book_Name = Console.ReadLine();
                NewBook.BookNames.AddRange(NewBook.Book_Name);
            }
        }





















        static void Main(string[] args)
        {
            MainMenu();
            ////>>> Messages <<<//
            //List<string> ReadyMessagesInfo = new List<string>();
            //ReadyMessagesInfo.Add("Моля, имайте предвид, че при изход от програмата данните ще се изтрият!");
            ////>>> Messages <<<//
            //Console.WriteLine(ReadyMessagesInfo[0]);
            
        }
    }
}
