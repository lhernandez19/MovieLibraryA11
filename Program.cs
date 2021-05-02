using System;
using MovieLibraryA11.Menus;

namespace MovieLibraryA11
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            menu.DisplayMenu();

            Console.WriteLine("Thanks for using the Movie Library!");
        }
    }
}
