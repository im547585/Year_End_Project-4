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
                Console.WriteLine("УСПЕШЕН ИЗХОД");
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
            Console.WriteLine("МОЛЯ, ИМАЙТЕ ПРЕДВИД, ЧЕ ПРИ ИЗХОД ОТ ПРОГРАМА ВСИЧКО ЩЕ СЕ ИЗТРИЕ!");
            Console.ResetColor();
            Console.WriteLine("За да се върнете назад, натиснете 'Esc'.");
            var pressedKey = Console.ReadKey();
            if (pressedKey.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                MainMenu();
            }
            else
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("МОЛЯ, ИМАЙТЕ ПРЕДВИД, ЧЕ ПРИ ИЗХОД ОТ ПРОГРАМА ВСИЧКО ЩЕ СЕ ИЗТРИЕ!");
                Console.ResetColor();
            }
        }

        static void AddBook()
        {
            MenuHeader();
            Console.Write("Колко книги ще добавите?: ");
            LibrarySystem_Books NewBook = new LibrarySystem_Books();
            int Choice = int.Parse(Console.ReadLine());
            for (int i = 0; i < Choice; i++)
            {
                Console.Write($"Име на книгата (#{i + 1}): ");
                NewBook.Book_Name = Console.ReadLine().ToUpperInvariant();
                NewBook.BookNamesL.AddRange(NewBook.Book_Name);
                Console.Write($"Автор на книгата (#{i + 1}): ");
                NewBook.Author = Console.ReadLine().ToUpperInvariant();
                NewBook.AuthorsL.AddRange(NewBook.Author);
                Console.Write($"Издателство (#{i + 1}): ");
                NewBook.Publishing_House = Console.ReadLine().ToUpperInvariant();
                NewBook.Publishing_HousesL.AddRange(NewBook.Publishing_House);
                Console.Write($"№ в каталога (#{NewBook.No_Of_Book_From_Catalogue}): ");
                NewBook.No_Of_Book_From_Catalogue = int.Parse(Console.ReadLine());
                NewBook.No_Of_Book_From_CatalogueL.AddRange(NewBook.No_Of_Book_From_Catalogue);
                Console.Write($"Жанр/Тип (#{i + 1}): ");
                NewBook.Genre = Console.ReadLine().ToUpperInvariant();
                NewBook.GenreL.AddRange(NewBook.Genre);
                Console.WriteLine("------------");
            }
            
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($">>>УСПЕШЕНO ДОБАВИХТЕ СЛЕДНИТЕ КНИГИ: <<<");
                Console.ResetColor();
            Console.WriteLine("___________________________________________________________________________________________________________________");
            Console.WriteLine("| Име на книгата        | Автор на книгата    | Издателство                   | № в каталога | Жанр/Тип           |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < Choice; i++)
            {
                Console.Write("| ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{NewBook.BookNamesL[i],-21}");
                Console.ResetColor();
                Console.WriteLine($" | {NewBook.AuthorsL[i],-19} | {NewBook.Publishing_HousesL[i],-29} | {NewBook.No_Of_Book_From_CatalogueL[i],-12} | {NewBook.GenreL[i],-18} |");
            }

            Console.WriteLine("___________________________________________________________________________________________________________________");

            Console.WriteLine("Искате ли да добавите друга/и книга/и? ДА/НЕ");
            string Choice1 = Console.ReadLine().ToUpperInvariant();
            if( Choice1 == "ДА")
            {
                Console.Clear();
                AddBook();
            }
            else
            {
                Console.Clear();
                MainMenu();
            }
        }

        static void SearchBook()
        {
            LibrarySystem_Books NewBook = new LibrarySystem_Books();
            MenuHeader();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Изберете критерий за търсене: \n\t" +
                "1. По Име на книгата \n\t" +
                "2. По Автор на книгата \n\t" +
                "3. По Издателство \n\t" +
                "4. По Година на издаване\n\t" +
                "5. По № от каталог\n\t" +
                "6. По Жанр");
            Console.ResetColor();
            Console.Write("ИЗБОР: ");
            int Choice = int.Parse(Console.ReadLine());
            if (Choice == 1) {
                Console.Write("Въведете име на книгата: ");
                string Search1 = Console.ReadLine().ToUpperInvariant();
                if (NewBook.BookNamesL.Contains(Search1) == true)
                {
                    int index = NewBook.BookNamesL.FindIndex(x => x.Equals(Search1, StringComparison.OrdinalIgnoreCase));


                    Console.WriteLine("___________________________________________________________________________________________________________________");
                    Console.WriteLine("| Име на книгата        | Автор на книгата    | Издателство                   | № в каталога | Жанр/Тип           |");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
                    Console.Write("| ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{NewBook.BookNamesL[index],-21}");
                    Console.ResetColor();
                    Console.WriteLine($" | {NewBook.AuthorsL[index],-19} | {NewBook.Publishing_HousesL[index],-29} | {NewBook.No_Of_Book_From_CatalogueL[index],-12} | {NewBook.GenreL[index],-18} |");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("НЕ Е ОТКРИТА КНИГА, С ГОРЕПОСОЧЕН КРИТЕРИЙ! \n" +
                        "МОЛЯ, ПРОВЕРЕТЕ НАПИСАНОТО/ИЗБРАНОТО ОТ ВАС.\n");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("ИСКАТЕ ЛИ ДА ТЪРСИТЕ ОТНОВО? ДА/НЕ");
                    Console.ResetColor();
                    Console.Write("ИЗБОР: ");
                    string Choice1 = Console.ReadLine().ToUpperInvariant();
                    if (Choice1 == "ДА")
                    {
                        Console.Clear();
                        SearchBook();
                    }
                    else
                    {
                        Console.Clear();
                        MainMenu();
                    }

                }
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
