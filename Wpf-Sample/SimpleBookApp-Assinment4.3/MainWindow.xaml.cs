using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment4._4_SimpleBookApp_
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase database = client.GetDatabase("LibraryDB");
        static IMongoCollection<Book> collection = database.GetCollection<Book>("Book");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            Book b = new Book(titleText.Text, authorText.Text, Double.Parse(priceText.Text));
            collection.InsertOne(b);
            bottomText.Text = "   ***Added successfully***   ";
        }
        private void New_Button_Click(object sender, RoutedEventArgs e)
        {
            titleText.Clear();
            authorText.Clear();
            priceText.Clear();
            bottomText.Text = "  ***Provide details of book for next operation***  ";
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            collection.DeleteOne(b => b.Title == titleText.Text);
            bottomText.Text = "   ***Deleted successfully***  ";
        }

       

        private void FirstButton_Button_Click(object sender, RoutedEventArgs e)
        {
            var firstDocumnet=collection.Find(new BsonDocument()).FirstOrDefault();
            titleText.Text = firstDocumnet.Title;
            authorText.Text = firstDocumnet.Author;
            priceText.Text= firstDocumnet.Price.ToString();
            bottomText.Text = "   ***First Book***  ";
        }

        private void Last_Button_Click(object sender, RoutedEventArgs e)
        {
            var lastDocument = collection.AsQueryable().OrderByDescending(c => c._id).First();
            titleText.Text = lastDocument.Title;
            authorText.Text = lastDocument.Author;
            priceText.Text = lastDocument.Price.ToString();
            bottomText.Text = "   ***Last Book***  ";
        }

        private void Previous_Button_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void Next_Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

       

        
    }
}
