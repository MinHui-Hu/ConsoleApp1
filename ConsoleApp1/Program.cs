// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//請使用者輸入姓名及密碼,並回傳OK字串

Console.WriteLine("請輸入姓名:");
string name = Console.ReadLine();

Console.WriteLine("請輸入密碼:");
string password = Console.ReadLine();

//若輸入的姓名為admin,密碼為123456,則回傳OK字串,若輸入的姓名為Amy，密碼為321123,則回傳OKOK字串,    否則回傳Error字串
if ((name == "admin" && password == "123456") || (name == "Amy" && password == "321123"))
{
    Console.WriteLine("OK");
}
else
{
    Console.WriteLine("Error");
}
