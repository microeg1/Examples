// string[,] table = new string[2,5];
// //string.Empty;
// //table[0,0] //table[0,1] //table[0,2] //table[0,3] //table[0,4]
// //table[1,0] //table[1,1] //table[1,2] //table[1,3] //table[1,4]
// table[1,2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }


void PrintArray(int[,] matr)                  // печатает двумерный массив
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)     //matrix.GetLength(0) возвращает количество строк 
{
    for (int columns = 0; columns < matr.GetLength(1); columns++)    //matrix.GetLength(1) возвращает количество столбцов
    {
        Console.Write($"{matr[rows, columns]} ");
    }
    Console.WriteLine("");
}
}

void FillArray(int[,] matr)     //заполняет числами двумерный массив
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)    
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)    
        {
            matr[rows, columns] = new Random().Next(1,10); //[1; 10)
        }
        Console.WriteLine("");
}   
}


int[,] matrix = new int[3,4];

// PrintArray(matrix);
// FillArray(matrix);
// PrintArray(matrix);

double Factorial (int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }


double Fibonacci(int n)
{
    if (n==1 || n==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}