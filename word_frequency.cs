using System;

string word = "Able was I ere I saw elba.";

Console.WriteLine(PalindromeCheck.Check(word));

class PalindromeCheck {
    static String RemovePunctuation(String word) {
        return String.Concat(word.Where(c => !char.IsPunctuation(c) && c.ToString() != " ").ToArray());
    }
    public static bool Check(string word) {
        String finale = RemovePunctuation(word).ToLower();

        int left = 0;
        int right = finale.Length - 1;

        while (left < right) {
            if (finale[left] != finale[right])
                return false;

            left += 1;
            right -= 1;
        }

        return true;
    }
}