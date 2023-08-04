class Program{

    static void Main(string[] args){

        //checking the palindrome function
        // Palindrome palindrome = new Palindrome();
        // Console.WriteLine(palindrome.isPalindrome("racecar"));
        // Console.WriteLine(palindrome.isPalindrome("hello"));
        // Console.WriteLine(palindrome.isPalindrome("madam"));

        //checking the word frequency function
        // Dictionary<string, int> frequency = Word.GetWordFrequency();
        // foreach (KeyValuePair<string, int> pair in frequency)
        // {
        //     Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        // }


    // checking the student grade function
    // Student.StudentGrade();

    // checking the shapes function
    //  Circle circle = new Circle { Name = "Circle", Radius = 5 };
    // Rectangle rectangle = new Rectangle { Name = "Rectangle", Width = 10, Height = 5 };
    // Triangle triangle = new Triangle { Name = "Triangle", Base = 8, Height = 6 };

    // PrintShapeArea(circle);
    // PrintShapeArea(rectangle);
    // PrintShapeArea(triangle);


    Library myLibrary = new Library("My Library", "123 Main Street");

    // Add some books to the library's collection
    myLibrary.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "978-0743273565", 1925));
    myLibrary.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "978-0446310789", 1960));
    myLibrary.AddBook(new Book("1984", "George Orwell", "978-0451524935", 1949));

    // Add some media items to the library's collection
    myLibrary.AddMediaItem(new MediaItem("The Shawshank Redemption", "DVD", 142));
    myLibrary.AddMediaItem(new MediaItem("The Dark Knight", "Blu-ray", 152));
    myLibrary.AddMediaItem(new MediaItem("Bohemian Rhapsody", "DVD", 134));

    // Display the library's catalog
    myLibrary.PrintCatalog();


    }

    // static void PrintShapeArea(Shape shape) {
    //     Console.WriteLine("{0} area: {1}", shape.Name, shape.Area());
    // }



}




