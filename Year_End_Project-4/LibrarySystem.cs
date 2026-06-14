namespace Year_End_Project_4
{
    internal class LibrarySystem
    {
        private string book_name; //**
        private string author; //**
        private string publishing_house;//**
        private int year_of_publishing; //**
        private int no_of_book_from_catalogue; //**
        private string genre; //**
        private int no_of_personal_card;//**
        private string names_of_reader; //**
        private long egn; //**
        private string adress; //**
        private string phone_number; //**
        private int age_of_reader; //**
        private string date_of_creating_personal_card; //**
        private string date_of_returning_the_book; //**
        private int no_of_returned_book_from_catalogue; //**
        private string author_of_returned_book; //**
        private string name_of_returned_book; //**

        public string Book_Name
        {
            get { return book_name; }
            set
            {
                if (value == null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Полето не може да остане празно!<<<!!");
                    Console.ResetColor();
                }
                else
                {
                    book_name = value;
                }
            }
        }
        public string Author
        {
            get { return author; }
            set
            {
                if (value == null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Полето не може да остане празно!<<<!!");
                    Console.ResetColor();
                }
                else
                {
                    author = value;
                }
            }
        }
        public string Publishing_House
        {
            get { return publishing_house; }
            set
            {
                if (value == null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Полето не може да остане празно!<<<!!");
                    Console.ResetColor();
                }
                else
                {
                    publishing_house = value;
                }
            }
        }
        public int Year_Of_Publishing
        {
            get { return year_of_publishing; }
            set
            {
                if (value == null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Полето не може да остане празно!<<<!!");
                    Console.ResetColor();
                }
                else if (value < 999 || value > 9999)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Годината ба издаване трябва да е 4 цифрено число!<<<!!");
                    Console.ResetColor();
                }
                else
                {
                    year_of_publishing = value;
                }
            }
        }
        public int No_Of_Book_From_Catalogue
        {
            get { return no_of_book_from_catalogue; }
            set
            {
                if (value == null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Полето не може да остане празно!<<<!!");
                    Console.ResetColor();
                }
                else if (value < 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>№ от каталога трябва да е валиден!<<<!!");
                    Console.ResetColor();
                }
                else
                {
                    no_of_book_from_catalogue = value;
                }
            }
        }
        public string Genre { get { return genre; }
            set
            {
                if (value == null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Полето не може да остане празно!<<<!!");
                    Console.ResetColor();
                }
                else
                {
                    genre = value;
                }
            }
        }
        public int No_Of_Personal_Card { get { return no_of_personal_card; }
            set
            {
                if (value == null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Полето не може да остане празно!<<<!!");
                    Console.ResetColor();
                }
                else if (value < 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>№ на личен картон трябва да е валиден!<<<!!");
                    Console.ResetColor();
                }
                else
                {
                    no_of_book_from_catalogue = value;
                }
            }
        }
        public string Names_Of_Reader { get { return names_of_reader; }
            set
            {
                if (value == null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Полето не може да остане празно!<<<!!");
                    Console.ResetColor();
                }
                else
                {
                    book_name = value;
                }
            }
        }
        public long Egn { get { return egn; }
            set
            {
                if (value == null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Полето не може да остане празно!<<<!!");
                    Console.ResetColor();
                }
                else if (value < 999999999 || value > 9999999999)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Въведете валидно ЕГН!<<<!!");
                    Console.ResetColor();
                }
                else
                {
                    egn = value;
                }
            }
        }
        public string Adress { get { return adress; }
            set
            {
                if (value == null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Полето не може да остане празно!<<<!!");
                    Console.ResetColor();
                }
                else
                {
                    adress = value;
                }
            }
        }
        public string Phone_Number { get { return phone_number; }
            set
            {
                if (value == null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Полето не може да остане празно!<<<!!");
                    Console.ResetColor();
                }
                else
                {
                    phone_number = value;
                }
            }
        }
        public int Age_Of_Reader { get { return age_of_reader; }
            set
            {
                if (value == null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Полето не може да остане празно!<<<!!");
                    Console.ResetColor();
                }
                else if (value < 0 || value > 100)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>№ от каталога трябва да е валиден!<<<!!");
                    Console.ResetColor();
                }
                else
                {
                    age_of_reader = value;
                }
            }
        }
        public string Date_Of_Creating_Personal_Card { get { return date_of_creating_personal_card; }
            set
            {
                if (value == null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Полето не може да остане празно!<<<!!");
                    Console.ResetColor();
                }
                else
                {
                    date_of_creating_personal_card = value;
                }
            }
        }
        public string Date_Of_Returning_The_Book { get { return date_of_returning_the_book; }
            set
            {
                if (value == null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Полето не може да остане празно!<<<!!");
                    Console.ResetColor();
                }
                else
                {
                    date_of_returning_the_book = value;
                }
            }
        }
        public int No_Of_Returned_Book_From_Catalogue { get { return no_of_returned_book_from_catalogue; }
            set
            {
                if (value == null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Полето не може да остане празно!<<<!!");
                    Console.ResetColor();
                }
                else if (value < 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>№ от каталога трябва да е валиден!<<<!!");
                    Console.ResetColor();
                }
                else
                {
                    no_of_returned_book_from_catalogue = value;
                }
            }
        }
        public string Author_Of_Returned_Book { get { return author_of_returned_book; }
            set
            {
                if (value == null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Полето не може да остане празно!<<<!!");
                    Console.ResetColor();
                }
                else
                {
                    author_of_returned_book = value;
                }
            }
        }
        public string Name_Of_Returned_Book { get { return name_of_returned_book; }
            set
            {
                if (value == null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("!!>>>Полето не може да остане празно!<<<!!");
                    Console.ResetColor();
                }
                else
                {
                    name_of_returned_book = value;
                }
            }
        }

        public LibrarySystem(string book_name, string author, string publishing_house, int year_of_publishing, int no_of_book_from_catalogue, string genre, int no_of_personal_card, string names_of_reader, long egn, string adress, string phone_number, int age_of_reader, string date_of_creating_personal_card, string date_of_returning_the_book, int no_of_returned_book_from_catalogue, string author_of_returned_book, string name_of_returned_book)
        {
            this.Book_Name = book_name;
            this.Author = author;
            this.Publishing_House = publishing_house;
            this.Year_Of_Publishing = year_of_publishing;
            this.No_Of_Book_From_Catalogue = no_of_book_from_catalogue;
            this.Genre = genre;
            this.No_Of_Personal_Card = no_of_personal_card;
            this.Names_Of_Reader = names_of_reader;
            this.Egn = egn;
            this.Adress = adress;
            this.Phone_Number = phone_number;
            this.Age_Of_Reader = age_of_reader;
            this.Date_Of_Creating_Personal_Card = date_of_creating_personal_card;
            this.Date_Of_Returning_The_Book = date_of_returning_the_book;
            this.No_Of_Returned_Book_From_Catalogue = no_of_returned_book_from_catalogue;
            this.Author_Of_Returned_Book = author_of_returned_book;
            this.Name_Of_Returned_Book = name_of_returned_book;

        } 
    }
}
