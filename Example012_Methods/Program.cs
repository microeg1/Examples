﻿// Вид 1 ничего не принимают, ничего не возвращают
void Method1()
{
    Console.WriteLine("Автор Гоголь Егор");
}
// Method1();

// Вид 2 ничего не возвращают, но принимают аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg:"Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст", 4);
// Method21(count: 4, msg: "Текст");

// Вид 3 что-то возвращает, ничего не принимает
int Method3()
{
    return DateTime.Now.Year;
}

// int year = Method3();
// Console.WriteLine(year);


// Вид 4 что-то принимает, что-то возвращает
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;

//     while (i < count)
//     {
//         result = result+text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "qwerty");
// Console.WriteLine(res);

//цикл фор то же самое что и прошлая функция
string Method5(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    for( i = 0; i < count; i++)
    {
        result = result+text;
    }
    return result;
}
// string res = Method5(10, "qwerty");
// Console.WriteLine(res);


//цикл в цикле
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

//===Работа с текстом
// Дан текст. В тексте нужно все пробелмы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             123456
// s[3]  получим r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
// string newText = Replace(text, ' ', '|');
// Console.WriteLine();
// Console.WriteLine(newText);        

// newText = Replace(text, 'к', 'К');
// Console.WriteLine();
// Console.WriteLine(newText);   

// newText = Replace(text, 'с', 'С');
// Console.WriteLine();
// Console.WriteLine(newText);   


// Сортировка массива

int[] arr = {1,5,8,2,9,3,5,6};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if(array[minPosition] < array[j]) minPosition =j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
SelectionSort(arr);
PrintArray(arr);