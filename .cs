// See https://aka.ms/new-console-template for more information
bool Bflag = false;

string name;
int IntegerBalace = 0, WithDraw = 0, Deposit = 0;
int totalWithDraws = 0, TotalDeposists = 0;
String Balance, Answer,Answer2;

Console.WriteLine("Please enter your name : ");
name = Console.ReadLine();

Console.WriteLine($"\nHello {name}");
Console.WriteLine("\nWhat is your current balance ");
IntegerBalace = Convert.ToInt32(Console.ReadLine());

while(Bflag == false)
{
    Console.WriteLine("\n----------------------------");
    Console.WriteLine("Would you like to Deposit ot Withdraw? (D/W)");
    //String Answer;
    Answer = Console.ReadLine();

    if (Answer == "D")
    {
        Console.WriteLine("How much would you like to Deposit?");
        Deposit = Convert.ToInt32(Console.ReadLine());
        IntegerBalace = IntegerBalace + Deposit;
        TotalDeposists = TotalDeposists + Deposit;

    }
    else if (Answer == "W")
    {
        Console.WriteLine("How much would you like to Withdraw : ");
        WithDraw = Convert.ToInt32(Console.ReadLine());
        IntegerBalace = IntegerBalace - WithDraw;
        totalWithDraws = totalWithDraws + WithDraw;
    }

    Console.WriteLine("\nWoud you like to continue doing transactions? (Y/N) ");
    Answer2 = Console.ReadLine();

   if (Answer2 == "N")
    {

        Bflag = true;

    } 

}

Console.WriteLine($"\nAccount Total : R{IntegerBalace}\nTotal Withdrawls : R{totalWithDraws} \nTotal Deposists : R{TotalDeposists}");
