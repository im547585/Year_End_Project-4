namespace Year_End_Project_4
{
    internal class LibrarySystem_Books
    {
        private string book_name; //**
        private string author; //**
        private string publishing_house;//**
        private int year_of_publishing; //**
        private int no_of_book_from_catalogue; //**
        private string genre; //**
        

        public string Book_Name
        {
            get { return book_name; }
            set
            {
                List<string> AddBooks = new List<string>();
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

        public LibrarySystem_Books(string book_name, string author, string publishing_house, int year_of_publishing, int no_of_book_from_catalogue, string genre)
        {
            this.Book_Name = book_name;
            this.Author = author;
            this.Publishing_House = publishing_house;
            this.Year_Of_Publishing = year_of_publishing;
            this.No_Of_Book_From_Catalogue = no_of_book_from_catalogue;
            this.Genre = genre;
        } 
        //private int AverageAgeOfBooks(int age)
        //{
        //    age = 2026 - year_of_publishing;
        //    return age;
        //}
    }
}
