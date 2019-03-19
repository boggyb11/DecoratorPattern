﻿using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// The Component abstract class
/// </summary>
namespace DecoratorPattern
{
    abstract class LibraryItem
    {
        private int _numCopies;

        public int NumCopies
        {
            get { return _numCopies; }
            set { _numCopies = value; }
        }

        public abstract void Display();
    }
}
