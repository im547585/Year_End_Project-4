using System.Drawing;

namespace Year_End_Project_4
{
    internal class Program
    {
        static LibrarySystem_Books NewBook = new LibrarySystem_Books();
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
                "6. Показване на всички книги\n\t" +
                "0. ИЗХОД ОТ ПРОГРАМАТА\n\t");
            Console.ResetColor();
            Console.Write("ИЗБОР: ");
            int Choice = int.Parse(Console.ReadLine());
            if (Choice == 1){ Console.Clear(); AddBook();}
            else if (Choice == 2) { Console.Clear(); SearchBook(); }
            else if (Choice ==3) { Console.Clear(); EditBook(); }
            else if (Choice == 6) { Console.Clear(); ShowAllBooks(); }
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
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("За да продължите натиснете какъвто и да е бутон.");
            Console.ResetColor();
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
            int Choice = int.Parse(Console.ReadLine());
            for (int i = 0; i < Choice; i++)
            {
                Console.Write($"Име на книгата (#{i + 1}): ");
                NewBook.Book_Name = Console.ReadLine().ToUpperInvariant();
                NewBook.BookNamesL.Add(NewBook.Book_Name);
                Console.Write($"Автор на книгата (#{i + 1}): ");
                NewBook.Author = Console.ReadLine().ToUpperInvariant();
                NewBook.AuthorsL.Add(NewBook.Author);
                Console.Write($"Издателство (#{i + 1}): ");
                NewBook.Publishing_House = Console.ReadLine().ToUpperInvariant();
                NewBook.Publishing_HousesL.Add(NewBook.Publishing_House);
                Console.Write($"Година на издаване (#{i + 1}): ");
                NewBook.Year_Of_Publishing = int.Parse(Console.ReadLine());
                NewBook.Year_Of_PublishingL.Add(NewBook.Year_Of_Publishing);
                Console.Write($"№ в каталога (#{NewBook.No_Of_Book_From_Catalogue}): ");
                NewBook.No_Of_Book_From_Catalogue = int.Parse(Console.ReadLine());
                NewBook.No_Of_Book_From_CatalogueL.Add(NewBook.No_Of_Book_From_Catalogue);
                Console.Write($"Жанр/Тип (#{i + 1}): ");
                NewBook.Genre = Console.ReadLine().ToUpperInvariant();
                NewBook.GenreL.Add(NewBook.Genre);
                Console.WriteLine("------------");
            }
            
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"УСПЕШЕНO ДОБАВИХТЕ СЛЕДНИТЕ КНИГИ:");
                Console.ResetColor();
            Console.WriteLine("________________________________________________________________________________________________________________________________________");
            Console.WriteLine("| Име на книгата        | Автор на книгата    | Издателство                   | Година на издаване | № в каталога | Жанр/Тип           |");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < Choice; i++)
            {
                Console.Write("| ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{NewBook.BookNamesL[i],-21}");
                Console.ResetColor();
                Console.WriteLine($" | {NewBook.AuthorsL[i],-19} | {NewBook.Publishing_HousesL[i],-29} | {NewBook.Year_Of_PublishingL[i],-18} | {NewBook.No_Of_Book_From_CatalogueL[i],-12} | {NewBook.GenreL[i],-18} |");
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");

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
                string Search1 = Console.ReadLine();
                int i = NewBook.BookNamesL.FindIndex(x => x.Equals(Search1, StringComparison.OrdinalIgnoreCase));
                if (i != -1)
                {
                    Console.WriteLine("________________________________________________________________________________________________________________________________________");
                    Console.WriteLine("| Име на книгата        | Автор на книгата    | Издателство                   | Година на издаване | № в каталога | Жанр/Тип           |");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");
                    Console.Write("| ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{NewBook.BookNamesL[i],-21}");
                    Console.ResetColor();
                    Console.WriteLine($" | {NewBook.AuthorsL[i],-19} | {NewBook.Publishing_HousesL[i],-29} | {NewBook.Year_Of_PublishingL[i],-18} | {NewBook.No_Of_Book_From_CatalogueL[i],-12} | {NewBook.GenreL[i],-18} |");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");
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
            if (Choice == 2)
            {
                Console.Write("Въведете автор на книгата: ");
                string Search1 = Console.ReadLine();
                int i = NewBook.BookNamesL.FindIndex(x => x.Equals(Search1, StringComparison.OrdinalIgnoreCase));
                if (i != -1)
                {
                    Console.WriteLine("___________________________________________________________________________________________________________________");
                    Console.WriteLine("| Име на книгата        | Автор на книгата    | Издателство                   | № в каталога | Жанр/Тип           |");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
                    Console.Write("| ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{NewBook.BookNamesL[i],-21}");
                    Console.ResetColor();
                    Console.WriteLine($" | {NewBook.AuthorsL[i],-19} | {NewBook.Publishing_HousesL[i],-29} | {NewBook.No_Of_Book_From_CatalogueL[i],-12} | {NewBook.GenreL[i],-18} |");
                    Console.WriteLine("___________________________________________________________________________________________________________________");
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
            if (Choice == 3)
            {
                Console.Write("Въведете издателство на книгата: ");
                string Search1 = Console.ReadLine();
                int i = NewBook.BookNamesL.FindIndex(x => x.Equals(Search1, StringComparison.OrdinalIgnoreCase));
                if (i != -1)
                {
                    Console.WriteLine("___________________________________________________________________________________________________________________");
                    Console.WriteLine("| Име на книгата        | Автор на книгата    | Издателство                   | № в каталога | Жанр/Тип           |");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
                    Console.Write("| ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{NewBook.BookNamesL[i],-21}");
                    Console.ResetColor();
                    Console.WriteLine($" | {NewBook.AuthorsL[i],-19} | {NewBook.Publishing_HousesL[i],-29} | {NewBook.No_Of_Book_From_CatalogueL[i],-12} | {NewBook.GenreL[i],-18} |");
                    Console.WriteLine("___________________________________________________________________________________________________________________");
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
            if (Choice == 4)
            {
                Console.Write("Въведете година на издаване на книгата: ");
                int Search1 = int.Parse(Console.ReadLine());
                int i = NewBook.Year_Of_PublishingL.FindIndex(x => x == Search1);
                if (i != -1)
                {
                    Console.WriteLine("___________________________________________________________________________________________________________________");
                    Console.WriteLine("| Име на книгата        | Автор на книгата    | Издателство                   | № в каталога | Жанр/Тип           |");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
                    Console.Write("| ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{NewBook.BookNamesL[i],-21}");
                    Console.ResetColor();
                    Console.WriteLine($" | {NewBook.AuthorsL[i],-19} | {NewBook.Publishing_HousesL[i],-29} | {NewBook.No_Of_Book_From_CatalogueL[i],-12} | {NewBook.GenreL[i],-18} |");
                    Console.WriteLine("___________________________________________________________________________________________________________________");
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
            if (Choice == 5)
            {
                Console.Write("Въведете № от каталог на книгата: ");
                int Search1 = int.Parse(Console.ReadLine());
                int i = NewBook.No_Of_Book_From_CatalogueL.FindIndex(x => x == Search1);
                if (i != -1)
                {
                    Console.WriteLine("___________________________________________________________________________________________________________________");
                    Console.WriteLine("| Име на книгата        | Автор на книгата    | Издателство                   | № в каталога | Жанр/Тип           |");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
                    Console.Write("| ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{NewBook.BookNamesL[i],-21}");
                    Console.ResetColor();
                    Console.WriteLine($" | {NewBook.AuthorsL[i],-19} | {NewBook.Publishing_HousesL[i],-29} | {NewBook.No_Of_Book_From_CatalogueL[i],-12} | {NewBook.GenreL[i],-18} |");
                    Console.WriteLine("___________________________________________________________________________________________________________________");
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
            if (Choice == 6)
            {
                Console.Write("Въведете жанр на книгата: ");
                string Search1 = Console.ReadLine();
                int i = NewBook.BookNamesL.FindIndex(x => x.Equals(Search1, StringComparison.OrdinalIgnoreCase));
                if (i != -1)
                {
                    Console.WriteLine("___________________________________________________________________________________________________________________");
                    Console.WriteLine("| Име на книгата        | Автор на книгата    | Издателство                   | № в каталога | Жанр/Тип           |");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
                    Console.Write("| ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{NewBook.BookNamesL[i],-21}");
                    Console.ResetColor();
                    Console.WriteLine($" | {NewBook.AuthorsL[i],-19} | {NewBook.Publishing_HousesL[i],-29} | {NewBook.No_Of_Book_From_CatalogueL[i],-12} | {NewBook.GenreL[i],-18} |");
                    Console.WriteLine("___________________________________________________________________________________________________________________");
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

        static void ShowAllBooks()
        {
            MenuHeader();
            if (NewBook.BookNamesL.Count != 0)
            {
                for (int i = 0; i < NewBook.BookNamesL.Count; i++)
                {
                    Console.WriteLine("________________________________________________________________________________________________________________________________________");
                    Console.WriteLine("| Име на книгата        | Автор на книгата    | Издателство                   | Година на издаване | № в каталога | Жанр/Тип           |");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");
                    Console.Write("| ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{NewBook.BookNamesL[i],-21}");
                    Console.ResetColor();
                    Console.WriteLine($" | {NewBook.AuthorsL[i],-19} | {NewBook.Publishing_HousesL[i],-29} | {NewBook.Year_Of_PublishingL[i],-18} | {NewBook.No_Of_Book_From_CatalogueL[i],-12} | {NewBook.GenreL[i],-18} |");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("ИСКАТЕ ЛИ ДА СЕ ВЪРНЕТЕ В ГЛАВНОТО МЕНЮ? ДА/НЕ");
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
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("НЕ СА ОТКРИТИ КНИГИ!");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("ИСКАТЕ ЛИ ДА ДОБАВИТЕ КНИГА/И? ДА/НЕ");
                Console.ResetColor();
                Console.Write("ИЗБОР: ");
                string Choice1 = Console.ReadLine().ToUpperInvariant();
                if (Choice1 == "ДА")
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
            
        }

        static void EditBook()
        {
            MenuHeader();
            Console.Write("Въведете заглавие, за да редактирате книгата: ");
            string answer = Console.ReadLine();
            int i = NewBook.BookNamesL.FindIndex(x => x.Equals(answer, StringComparison.OrdinalIgnoreCase));
            if (i != -1)
            {
                Console.WriteLine("________________________________________________________________________________________________________________________________________");
                Console.WriteLine("| Име на книгата        | Автор на книгата    | Издателство                   | Година на издаване | № в каталога | Жанр/Тип           |");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");
                Console.Write("| ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{NewBook.BookNamesL[i],-21}");
                Console.ResetColor();
                Console.WriteLine($" | {NewBook.AuthorsL[i],-19} | {NewBook.Publishing_HousesL[i],-29} | {NewBook.Year_Of_PublishingL[i],-18} | {NewBook.No_Of_Book_From_CatalogueL[i],-12} | {NewBook.GenreL[i],-18} |");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");

                Console.BackgroundColor= ConsoleColor.DarkCyan;
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine("Изберете параметър на книгата, която искате да редактирате: \n\t" +
                    "1. Име \n\t" +
                    "2. Автор \n\t" +
                    "3. Издателство \n\t" +
                    "4. № в каталог \n\t" +
                    "5. Жанр/Тип");
                Console.ResetColor();
                Console.Write("ИЗБОР: ");
                int Choice = int.Parse(Console.ReadLine());
                if(Choice == 1)
                {
                    Console.Write($"Въведете ново име на книгата: ");
                    NewBook.Book_Name = Console.ReadLine().ToUpperInvariant();
                    NewBook.BookNamesL.Insert(0, NewBook.Book_Name);
                    if (NewBook.Book_Name == NewBook.BookNamesL[0]) {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"УСПЕШЕНO РЕДАКТИРАХТЕ КНИГАТА!");
                        Console.ResetColor();
                        Console.WriteLine("________________________________________________________________________________________________________________________________________");
                        Console.WriteLine("| Име на книгата        | Автор на книгата    | Издателство                   | Година на издаване | № в каталога | Жанр/Тип           |");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");
                        Console.Write("| ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{NewBook.BookNamesL[i],-21}");
                        Console.ResetColor();
                        Console.WriteLine($" | {NewBook.AuthorsL[i],-19} | {NewBook.Publishing_HousesL[i],-29} | {NewBook.Year_Of_PublishingL[i],-18} | {NewBook.No_Of_Book_From_CatalogueL[i],-12} | {NewBook.GenreL[i],-18} |");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Искате ли да редактирате друга книга? ДА/НЕ");
                        string answer2 = Console.ReadLine().ToUpperInvariant();
                        if(answer2 == "ДА")
                        {
                            Console.Clear();
                            EditBook();
                        }
                        else
                        {
                            Console.Clear();
                            MainMenu();
                        }
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
                            EditBook();
                        }
                        else
                        {
                            Console.Clear();
                            MainMenu();
                        }
                    }
                }

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
                Console.WriteLine("ИСКАТЕ ЛИ ДА ВЪВЕДЕТЕ ОТНОВО? ДА/НЕ");
                Console.ResetColor();
                Console.Write("ИЗБОР: ");
                string Choice1 = Console.ReadLine().ToUpperInvariant();
                if (Choice1 == "ДА")
                {
                    Console.Clear();
                    EditBook();
                }
                else
                {
                    Console.Clear();
                    MainMenu();
                }

            }
        }

        static void Main(string[] args)
        {
            MainMenu();
        }
    }
}
