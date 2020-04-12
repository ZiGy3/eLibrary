﻿namespace eLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double? Rating { get; set; }
        public int Stock { get; set; }
    }
}