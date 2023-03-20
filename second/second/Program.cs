//2.გვაქვს 1,5,10,20 და 50 თეთრიანი მონეტები. დაწერეთ ფუნქცია, რომელსაც
//გადაეცემა თანხა (თეთრებში) და აბრუნებს მონეტების მინიმალურ
//რაოდენობას, რომლითაც შეგვიძლია ეს თანხა დავახურდაოთ.

//int MinSplit(int amount);

static int MinSplit(int money)
{
    int howMany50s = money / 50;
    money=money % 50;
    int howMany20S=money / 20;
    money=money% 20;
    int howMany10S=money / 10;
    money=money%10;
    int howMany5s=money / 5;
    money =money%5;
    int howMany1s = money / 1;
    return howMany50s+howMany20S+howMany10S+howMany5s+howMany1s;
}

Console.WriteLine(MinSplit(276));