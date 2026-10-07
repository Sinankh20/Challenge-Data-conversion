string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string message="";
decimal total=0m;
foreach (var item in values)
{
    if (decimal.TryParse(item, out decimal number))
    {
        total+=number;
    }
    else
    {
        message+=item;
    }
}
Console.WriteLine("Message: "+message);
Console.WriteLine("Message: "+total);