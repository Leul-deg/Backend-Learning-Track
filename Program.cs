class Program{

    static void Main(string[] args){

        //checking the palindrome function
        Palindrome palindrome = new Palindrome();
        Console.WriteLine(palindrome.isPalindrome("racecar"));
        Console.WriteLine(palindrome.isPalindrome("hello"));
        Console.WriteLine(palindrome.isPalindrome("madam"));

        //checking the word frequency function
        Dictionary<string, int> frequency = Word.GetWordFrequency();
        foreach (KeyValuePair<string, int> pair in frequency)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }


    Student.StudentGrade();
    
    }

    //checking the student grade function


}