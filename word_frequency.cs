class Word {
    public static Dictionary<string, int> GetWordFrequency(string text) {
        Dictionary<string, int> frequency = new Dictionary<string, int>();

        if (text != null) {
            string[] words = text.Split(' ');

            foreach (string word in words) {
                if (!string.IsNullOrEmpty(word)) {
                    if (frequency.ContainsKey(word)) {
                        frequency[word]++;
                    } else {
                        frequency[word] = 1;
                    }
                }
            }
        }

        return frequency;
    }
}