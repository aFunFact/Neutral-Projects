Random random = new Random();
int DUE = random.Next(12);
int discounts;
/* 0 = expired, 1 = renew for 20%, 2-4 = renew for 10%, 5-9 renew, 10-12 do nothing.
 */
Console.WriteLine(DUE);
if (DUE == 0)
{ 
    Console.WriteLine("Your gym subscription has expired.");
}
else if (DUE == 1)
{
    Console.WriteLine("Your gym subscription is expiring in a day");
    discounts = 20;
    Console.WriteLine($"Renew for a {discounts}% discount");
}
else if (DUE < 5)
{
    Console.WriteLine("Your gym subscription is expiring soon");
    discounts = 10;
    Console.WriteLine($"Renew for a {discounts}% discount");
}
else if (DUE <= 10)
{
    Console.WriteLine("Your gym subscription is ending soon");
    Console.WriteLine($"You have {DUE} days to renew it.");
}
else if (DUE > 10)
{
    
}
//ff
