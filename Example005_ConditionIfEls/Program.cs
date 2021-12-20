Console.Write("Vvedite imja Polzovatelja ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Ura, this is Masha!");
}
else
{
    Console.Write("Privet, ");
    Console.WriteLine(username);
}
