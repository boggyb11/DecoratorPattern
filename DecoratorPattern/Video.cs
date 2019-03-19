﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class Video : LibraryItem
    {
        private string _director;
        private string _title;
        private int _playTime;

        public Video(string director, string title, int playTime, int numCopies)
        {
            _director = director;
            _title = title;
            _playTime = playTime;
            this.NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Director: {0}", _director);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
            Console.WriteLine(" Playtime: {0}\n", _playTime);
        }
    }
}
