//intro
Console.WriteLine("Welcome to your bank account's credit score checker.");


//getting info
Console.WriteLine("Please enter your name");
string name = Console.ReadLine();

//displaying stolen information 
Console.WriteLine("Thank you " + name + ". " + "Just a few more questions.");
Console.WriteLine();

Console.WriteLine("Please enter your Mother's maiden name.");
string maidenName = Console.ReadLine();
Console.WriteLine("To confirm, your mother's maiden name is " + maidenName  + "." );
Console.WriteLine();

Console.WriteLine("What is your favorite food?");
string favFood = Console.ReadLine();
Console.WriteLine("Really?! " + favFood + " Well I guess to each their own.");
Console.WriteLine();

Console.WriteLine("What is your Credit Card number?");
double creditCardNum = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Please enter your Bank Routing Number");
double routingNum = double.Parse(Console.ReadLine());
Console.WriteLine("Thank you! Almost done.");
Console.WriteLine();

Console.WriteLine("what is your SS number? ");
string socialNum = Console.ReadLine();
Console.WriteLine();


Console.WriteLine("Please enter your home address.");
string address = Console.ReadLine();

Console.WriteLine("Thank you " + name);
Console.WriteLine("You currently live at " + address);
Console.WriteLine("Your favorite food is " + favFood);
Console.WriteLine("Your Social Security number is " + socialNum);
Console.WriteLine("Your Mother's Maiden name is " + maidenName);
Console.WriteLine("Your Routing number is " + routingNum);

Console.WriteLine("Thank you for your time. Your credit score is garbage.");




