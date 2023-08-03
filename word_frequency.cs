class Word{

    public static Dictionary<string, int> GetWordFrequency()
{

    string input = Console.ReadLine();
    // Split the input string into an array of words
    string[] words = input.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

    // Create a dictionary to store the frequency of each word
    Dictionary<string, int> frequency = new Dictionary<string, int>();

    // Loop through each word and update the frequency dictionary
    foreach (string word in words)
    {
        if (frequency.ContainsKey(word))
        {
            frequency[word]++;
        }
        else
        {
            frequency[word] = 1;
        }
    }

    // Return the frequency dictionary
    return frequency;

}
}