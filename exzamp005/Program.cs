Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "вероника")
{
    Console.WriteLine("Ура, это же ВЕРОНИКА");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
