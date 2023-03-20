//3.მოცემულია მასივი, რომელიც შედგება მთელი რიცხვებისგან. დაწერეთ
//ფუნქცია რომელსაც გადაეცემა ეს მასივი და აბრუნებს მინიმალურ მთელ
//რიცხვს, რომელიც 0-ზე მეტია და ამ მასივში არ შედის.

//int NotContains(int[] array);

int[] arr = { 7, 5, 8, 8, 9, 0, 1, 2 , 3 , 4 };
static int NotContains(int[] array)
{
    HashSet<int> myset = new HashSet<int>(array);
    int i = 1;
    while (true)
    {
        if (!myset.Contains(i))
        {
            return i;
        }
        i++;
    }
}

Console.WriteLine(NotContains(arr));
