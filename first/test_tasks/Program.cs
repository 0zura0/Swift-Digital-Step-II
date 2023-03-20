
//1.დაწერეთ ფუნქცია, რომელსაც გადაეცემა ტექსტი და აბრუნებს
//პალინდრომია თუ არა. (პალინდრომი არის ტექსტი რომელიც ერთნაირად
//იკითხება ორივე მხრიდან).
//bool sPalindrome(string text); 1.დაწერეთ ფუნქცია, რომელსაც გადაეცემა ტექსტი და აბრუნებს
//პალინდრომია თუ არა. (პალინდრომი არის ტექსტი რომელიც ერთნაირად
//იკითხება ორივე მხრიდან).
//bool sPalindrome(string text);


static string sPalindrome(string word)
{
    for(int i=0;i<(word.Length/2+1);i++)
    {
        if (word[i] != word[word.Length-i-1])
        {
            return "not a palindrom";
        }
       
    }
    return "pallindrom";
}

Console.WriteLine(sPalindrome("namxman"));

