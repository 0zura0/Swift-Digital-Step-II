//5.გვაქვს n სართულიანი კიბე, ერთ მოქმედებაში შეგვიძლია ავიდეთ 1 ან 2
//საფეხურით. დაწერეთ ფუნქცია რომელიც დაითვლის n სართულზე ასვლის
//ვარიანტების რაოდენობას.

//int CountVariants(int stairCount);

static int CountVariants(int stairCount)
{
    if (stairCount == 1)
    {
        return 1;
    }
    int first = 1;
    int second = 2;
    for(int i = 3;i<= stairCount;i++)
    {
        int third = first + second;
        first = second;
        second= third;
    }
    return second;
}
//ფიბონაჩის მიმდევრობა დგება საბოლოოდ უბრალოდ ფიბონაჩი რეკურსიულად 
//ბევრ უაზრო ბიჯს აკებეს და ბევრ სტეკ ფრეიმს ქმნის ამიტომ დინამიური 
//ვარიანტი დავწერე, უბრალოდ ფუნქციის აღწერილობამ არ მომცა საშუალება თორე
// ჰეშსეტით და ფიბონაჩით შეიძლებოდა დაწერა...

Console.WriteLine(CountVariants(2)); 






