Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "кирилл")
{
    Console.WriteLine("Ура, это же Кирилл!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}