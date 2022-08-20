void FillArray(int[] collection)            // заполняет список рандомными значениями
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);         // генерирует рандомные значения
        index++;
    }
}

void PrintArray(int[] col)             // печатает список
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)     //ищет число в массиве, которое соответствует запрашиваемому find
{
    int count = collection.Length;
    int index = 0;
    int position = -1;  //принято выводить, если элемент не найден
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;        //возвращает индекс числа
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();
int pos = IndexOf(array,4);
Console.WriteLine(pos);