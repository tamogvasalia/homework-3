using System;

class HomeWork3
{
    static void Main(string[] args)
    {
        secendTask();
        ThirdTask();
        Forthtask();
        // 1. შექმენით მეთოდი, რომელსაც ექნება სამი გადასაცემი პარამეტრი: სახელი, მიმდინარე თარიღი და
        // ასაკი. სამივე მონაცემი უნდა შევიყვანოთ კონსოლიდან და მეთოდის საშუალებით უნდა დაბრუნდეს
        // მნიშვნელობა; შედეგი კი დაიბეჭდოს კონსოლზე

        Console.Write("enter your name: ");
        string Name = Console.ReadLine();

        Console.Write("enter current data: ");
        string Data = Console.ReadLine();

        Console.Write("enter your age: ");
        int Age = Convert.ToInt32(Console.ReadLine());

        Console.Write("your name: " + Name + " current date: " + Data + " your age: " + Age);

        Console.ReadLine();

    }
    // 2. შექმენით მეთოდი: თუ კონსოლიდან გადავეცი + უნდა დააბრუნოს გადაცემული ორი რიცხვის ჯამი,
    // თუ კონსოლიდან გადავეცი * უნდა დააბრუნოს ორი რიცხვის ნამრავლი.


    static void secendTask()
    {
        Console.Write("enter first name: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter second name: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter math symbol: + or *");
        string mathSymbol = Console.ReadLine();

        if (mathSymbol == "+")
        {
            Console.WriteLine("the result is: " + (firstNumber + secondNumber));
        } else if (mathSymbol == "*")
        {
            Console.WriteLine("the result is: " + (firstNumber * secondNumber));
        }
        else
        {
            Console.WriteLine(" your entered symbol is not corect");
            Console.ReadLine();

        }
    }
    // 3. შექმენით მეთოდი, რომელსაც ექნება ერთი პარამეტრი. თუ გადაცემული რიცხვი იქნება უარყოფითი
    // დააბრუნოს 0, წინააღმდეგ შემთხვევაში დააბრუნოს გადაცემული რიცხვი.

    static void ThirdTask()
    {
        Console.WriteLine("Please Enter thouhgt number:");
        int thoughtNumber = Convert.ToInt32(Console.ReadLine());

        if (thoughtNumber < 0)
        {
            Console.WriteLine("Your result is negative (0)");
        }
        else
        {
            Console.WriteLine("Your result is positive: " + thoughtNumber);
        }
        Console.ReadLine();
    }


    // 4.შექმენით მეთოდი, რომელიც გამოითვლის რამდენი კგ ტვირთი იქნება გადასაზიდი. გადასაცემი
    // პარამეტრები იქნება ერთი ერთეულის წონა და რაოდენობა. წონა იქნება default მნიშვნელობის და მისი
    // მნიშვნელობა იქნება 50.

    static void Forthtask()
    {

        Console.WriteLine("enter the weigh (kg): ");
        double kg = Convert.ToInt32(Console.ReadLine());

        int paramQuantity = 50;
        Console.WriteLine("paramQuantity is: " + paramQuantity);

        Console.WriteLine("the result is: " + (kg * paramQuantity));
        Console.ReadLine();
    }
    // 5.შექმენით ორი გადატვირთული მეთოდი. თუ გადაეცა ორი პარამეტრი, დააბრუნოს სახელი და გვარი.
    // თუ გადაეცა სამი პარამეტრი, დააბრუნოს თქვენი სახელი გვარი და დაბადების წელი.

}
