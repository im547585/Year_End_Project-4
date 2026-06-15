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

        // LISTOVE //
        private List<string> booknamesl = new List<string>();
        public List<string> BookNamesL { get { return booknamesl; } set; } = new List<string>();
        //--
        private List<string> authorsl = new List<string>();
        public List<string> AuthorsL { get { return authorsl ; } set; } = new List<string>();
        //--
        private List<string> publishing_housesl  = new List<string>();
        public List<string> Publishing_HousesL { get { return publishing_housesl; } set; } = new List<string>();
        //--
        private List<int> no_of_book_from_cataloguel = new List<int>();
        public List<int> No_Of_Book_From_CatalogueL { get { return no_of_book_from_cataloguel; } set; } = new List<int>();
        //--
        private List<string> genrel = new List<string>();
        public List<string> GenreL { get { return genrel; } set; } = new List<string>();
        //--
        private List<int> year_of_publishingl = new List<int>();
        public List<int> Year_Of_PublishingL { get { return year_of_publishingl; } set; } = new List<int>();
        //--
        private List<int> average_age = new List<int>();
        public List<int> Average_Age { get { return average_age; } set; } = new List<int>();
        //private List<string> old_data = new List<string>();
        //public List<string> Old_DataL { get { return old_data; } set; } = new List<string>();
        // LISTOVE//

        public string Book_Name
        { 
            get { return book_name; }
            set
            {
                
                if (value == null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Полето не може да остане празно!");
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
                    Console.WriteLine("Полето не може да остане празно!");
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
                    Console.WriteLine("Полето не може да остане празно!");
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
                    Console.WriteLine("Полето не може да остане празно!");
                    Console.ResetColor();
                }
                else if (value < 999 || value > 9999)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Годината на издаване трябва да е 4 цифрено число!");
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
                    Console.WriteLine("Полето не може да остане празно!");
                    Console.ResetColor();
                }
                else if (value < 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("№ от каталога трябва да е валиден!");
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
                    Console.WriteLine("Полето не може да остане празно!");
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
     
        public LibrarySystem_Books()
        {
            this.Book_Name = "Neurosurgery";
            this.Author = "Doctor";
            this.Publishing_House = "Prosveta";
            this.Year_Of_Publishing = 1998;
            this.No_Of_Book_From_Catalogue = 1;
            this.Genre = "General neurosurgery";
        }
        
        private int averageageofbooks(int averageAge)
        {
            int totalAge = 0;
            for (int i = 0; i < Year_Of_PublishingL.Count; i++)
            {
                totalAge += 2026 - Year_Of_PublishingL[i];
            }
            averageAge = totalAge / Year_Of_PublishingL.Count;
            if (averageAge < 0)
            {
                return 0;
            }
            else
            {
                return averageAge;
            }
            
        }

        public int AverageAgeOfBooks { 
            get {  return averageageofbooks(1);  } set { averageageofbooks(value); }
        }

        private int oldestbook()
        {
            int oldestBookYOP = Year_Of_PublishingL.Min();

            int index = Year_Of_PublishingL.IndexOf(oldestBookYOP);
            string nameOfOldestBook = BookNamesL[index];
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"НАЙ-СТАРА КНИГА: {nameOfOldestBook}, {oldestBookYOP}");
            Console.ResetColor();
            return oldestBookYOP;
        }
        public int OldestBook
        {
            get { return oldestbook(); }
        }
    }
}
