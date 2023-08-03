class Palindrome{

    public bool isPalindrome(string word){
        
        int left = 0 ;
        int right = word.Length - 1;

        while (word[left] == word[right] && left < right){

            left += 1;
            right -= 1;

        }

        return left == right;
    }

}
