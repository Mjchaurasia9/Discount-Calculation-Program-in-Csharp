// See https://aka.ms/new-console-template for more information
Console.Write("Enter your Goods Amount for calculate Discount and Payable amount:\t");
int amount = int.Parse(Console.ReadLine());
int amo;
if (amount >= 30000)
{
amo = (amount * 30) / 100;
}
else if (amount >= 20000)
{
amo = (amount * 20) / 100;
}
else if (amount >= 10000) 
{
amo = (amount * 15) / 100;
}
else
{
amo = (amount * 6) / 100;
}
Console.WriteLine($"Your Goods amount is: {amount} and Discounted Price is: {amo} and Payable amount is: {amount - amo}");
