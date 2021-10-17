﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wpf_Books
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return string.Format("{0} by {1} (Price: ₹ {2})", Title, Author, Price);
        }
    }
}
