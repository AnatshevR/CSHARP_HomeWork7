// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

int[] newarray(int[,] matr)
{
    int [] newArray = new int [matr.GetLength(0)];
    for (int i=0;i<matr.GetLength(0);i++)
    {
        int sum = 0;
        for(int j = 0; j< matr.GetLength(1); j++)
        {
            sum = sum + matr [i,j];
        }
        newArray[i] = sum;
    }
    return newArray;
}

int minRow (int [] matr)
{
    int minsum = matr [0];
    int minPosition = 0;
    for (int i = 0; i < matr.Length; i++)
    {
        if( minsum>matr[i]) 
        {
            minsum = matr [i];
            minPosition = i;
        }
    }
    return minPosition;
}

Console.Write("enter amount of rows in array: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("enter amount of columns in array: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[rows, columns];


FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("the summ of elements in each row are...");
int[] sum = newarray(matrix); 
Console.WriteLine(string.Join ("*", sum ));
int minrowsum = minRow (sum);
Console.Write("the minimum sum is in the row: ");
Console.WriteLine(minrowsum+1);




