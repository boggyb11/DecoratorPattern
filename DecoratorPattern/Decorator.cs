using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    //decorator abstract class
    abstract class Decorator : LibraryItem
    {
        protected LibraryItem libraryItem;

        // Constructor
        public Decorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        //Calls the common method for the library item
        public override void Display()
        {
            libraryItem.Display();
        }
    }
}
