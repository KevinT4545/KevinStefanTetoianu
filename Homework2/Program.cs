using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace LibrarySystem{
 class Program{
static void Main(string[]args){

    Book book1 = new Book ("Metro 2034","Dmitri Gluhovski");
    Console.WriteLine(book1.ToString());

    Book book2 = new Book ("The Lightning Thief","Rick Riordan", 416);
    Console.WriteLine(book2.ToString());
        }
    }
}