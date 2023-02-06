// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
//что это невозможно (в случае, если матрица не квадратная)


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    Random random = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = random.Next(10); 
        }
    }
}

void replacingRC(int[,] matr)
{
    for (int i=0;i<matr.GetLength(0);i++)
    {
        for(int j = i; j< matr.GetLength(1); j++)
        {
            int tempo = matr[i,j];
            matr [i,j] = matr [j,i];
            matr [j,i] = tempo;
        }
    }
}

Console.Write("enter amount of rows in array: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("enter amount of columns in array: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[rows, columns];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("magic happens...");
if (rows==columns)
{
    replacingRC(matrix);
    PrintArray(matrix);
}
else
{
    Console.WriteLine("it is impossible (the matrix is not square)");
}

