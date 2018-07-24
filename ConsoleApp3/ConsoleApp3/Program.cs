using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Give me a number, any number! I'll multiply it by 50!");
        int fiftyTimes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your number, multiplied by 50 is " + fiftyTimes * 50);
        Console.WriteLine("Now give me a number and I'll add 25 to it! ");
        int addtwentyFive = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Alrighty then! Your number, {0}, plus 25 is {1}", addtwentyFive, addtwentyFive + 25);
        Console.WriteLine("Cool, right?, okay give me another number and I'll divide it by 12.5!");
        double divideTwelveHalf = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Your number, {0} divided by 12.5 is {1}", 
            divideTwelveHalf,
            divideTwelveHalf / 12.5);
        Console.WriteLine("Awesome! Now lets try something a little different. Give me a number and I'll tell if it's greater than 50 (true) or less than 50 (false)");
        int greaterThan50 = Convert.ToInt32(Console.ReadLine());
        bool overFifty = (greaterThan50 > 50);
        Console.WriteLine("Okay! Lets see here... It looks like your number is {0}", overFifty);
        Console.WriteLine("Last but not least! Give me a number, and I'll divide it by 7 AND provide the remainder!");
        int sevenRemainder = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Excellent! Your number, {0}, divided by 7 is {1}, with a remainder of {2}", sevenRemainder, sevenRemainder/7, sevenRemainder%7);
        Console.WriteLine("Pretty cool right? I hope you had fun! I sure did :)");
        Console.ReadLine();
        }
    }
