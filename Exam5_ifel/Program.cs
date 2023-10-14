Console.Write("Введи имя: ");
string username = Console.ReadLine ();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Урв, это МАША");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}