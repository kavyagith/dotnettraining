using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._4_SimpleBookApp_
{
    public class Book
    {
        

        public Book(string title, string author, double price)
        {
            Title=title;
            Author=author;
            Price = price;
        }
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElement("Title")]
        public string Title { get; set; }

        [BsonElement("Author")]
        public string Author { get; set; }

        [BsonElement("Price")]
        public double Price { get; set; }

        public DateTime createdAt { get; set; }

       
    }
}
