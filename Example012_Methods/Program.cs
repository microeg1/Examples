// Вид 1 ничего не принимают, ничего не возвращают
void Method1()
{
    Console.WriteLine("Автор Гоголь Егор");
}
Method1();

// Вид 2 ничего не возвращают, но принимают аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg:"Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);
Method21(count: 4, msg: "Текст");

// Вид 3 что-то возвращает, ничего не принимает
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);


// Вид 4 что-то принимает, что-то возвращает
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result+text;
        i++;
    }
    return result;
}
string res = Method4(10, "qwerty");
Console.WriteLine(res);
