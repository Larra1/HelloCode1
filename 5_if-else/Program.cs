Console.WriteLine ("Введите имя пользователя");
string username=Console.ReadLine();
if (username.ToLower()=="маша") //добавил оператор ToLower()=="маша" для избежания ошибок при вводе Маша, маша, МАШа итд
{
    Console.WriteLine("Ура, это Маша");
}
else
{
    Console.WriteLine("Привет,");
    Console.WriteLine(username);
}
