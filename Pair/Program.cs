var myPair = new MyPair<string, int>("one", 1);
Console.WriteLine(myPair);
Console.WriteLine(myPair.Key); 
Console.WriteLine(myPair.Value);

var mySecondPair = new MyPair<int, int>(4, 400);
Console.WriteLine(mySecondPair);
Console.WriteLine(mySecondPair.Key);
Console.WriteLine(mySecondPair.Value);