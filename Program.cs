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
     Circle circle = new Circle { Name = "Circle", Radius = 5 };
    Rectangle rectangle = new Rectangle { Name = "Rectangle", Width = 10, Height = 5 };
    Triangle triangle = new Triangle { Name = "Triangle", Base = 8, Height = 6 };

    PrintShapeArea(circle);
    PrintShapeArea(rectangle);
    PrintShapeArea(triangle);
    }

    static void PrintShapeArea(Shape shape) {
        Console.WriteLine("{0} area: {1}", shape.Name, shape.Area());
    }



}
