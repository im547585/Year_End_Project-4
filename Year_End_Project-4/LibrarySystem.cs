using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

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
        private string no_of_returned_book_from_catalogue; //**
        private string author_of_returned_book; //**
        private string name_of_returned_book; //**

        public string Book_Name { get { return book_name; } set { book_name = value; } }
        public string Author { get { return author; } set { author = value; } }
        public string Publishing_House{ get { return publishing_house; } set { publishing_house = value; } }
        public int Year_Of_Publishing { get { return year_of_publishing; } set { year_of_publishing = value; } }
        public int No_Of_Book_From_Catalogue { get { return no_of_book_from_catalogue;} set { no_of_book_from_catalogue = value; } }
        public string Genre {  get { return genre; } set { genre = value; } }
        public int No_Of_Personal_Card { get { return no_of_personal_card;} set {  no_of_personal_card = value; } }
        public string Names_Of_Reader { get { return names_of_reader; } set {  names_of_reader = value;  }   }
        public long Egn { get { return egn; } set { egn = value; } }
        public string Adress {  get { return adress; } set { adress = value; } }
        public string Phone_Number { get { return phone_number; } set { phone_number = value; } }
        public int Age_Of_Reader { get { return age_of_reader; } set { age_of_reader = value; } }
        public string Date_Of_Creating_Personal_Card { get { return date_of_creating_personal_card; } set { date_of_creating_personal_card = value; }  }
        public string Date_Of_Returning_The_Book { get { return date_of_returning_the_book; } set { date_of_returning_the_book = value; } }
        public string No_Of_Returned_Book_From_Catalogue { get { return no_of_returned_book_from_catalogue; } set { no_of_returned_book_from_catalogue = value; } }
        public string Author_Of_Returned_Book { get { return author_of_returned_book; } set {  author_of_returned_book = value; } }
        public string Name_Of_Returned_Book { get { return name_of_returned_book; } set {  name_of_returned_book = value; } }

    }
}
