using System;

namespace LibrarySystem {

public class Book{

    public string bookTitle;
    public int bookPages;
    public string bookAuthor;
   public bool isCheckedOut;

    public void CheckOut(){
        isCheckedOut = true;
    }
    public void ReturnBook(){
        isCheckedOut = false;
    }
    public Book(string title, string author){

        bookTitle = title;
        bookAuthor = author;
        bookPages = 100;
        ReturnBook();
    }
        public Book( string title, string author, int pages){
        bookTitle = title;
        bookAuthor = author;
        bookPages = pages;
        ReturnBook();
        }
        public override string ToString()
        {
        return $"Book name: {bookTitle}, Book author: {bookAuthor}, Number of pages: {bookPages}, Checked out: {isCheckedOut}";
        }
    }
}