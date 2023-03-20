//4.მოცემულია String რომელიც შედგება „(„ და „)“ ელემენტებისგან.დაწერეთ
//ფუნქცია რომელიც აბრუნებს ფრჩხილები არის თუ არა მათემატიკურად
//სწორად დასმული.

//bool IsProperly(string sequence);

string myStr = "((((())";
static bool isProperly(string str)
{
    Stack<char> mystack = new Stack<char>();
    for(int i=0; i<(str.Length); i++)
    {
        if (mystack.Count() == 0)
        {
            mystack.Push(str[i]);
            continue;
        }

        if (str[i].Equals('('))
        {
            mystack.Push(str[i]);
        }
        if (str[i].Equals(')'))
        {
            mystack.Pop();
        }

    }
    if(mystack.Count() == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine(isProperly(myStr)); 

