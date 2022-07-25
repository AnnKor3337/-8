// Задача 54

/*int[,] Random2dArr(int rows, int columns, int minRan, int maxRan)
{
    int[,] newArr = new int[rows,columns];

    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArr[i,j] = new Random().Next(minRan, maxRan + 1);

    return newArr;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void RightArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 1; j < array.GetLength(1); j++)
        {
            for (int x = 0; x < array.GetLength(1) - 1; x++)
            {
                if (array[i, x] > array[i, x + 1])
                {
                    int temp = array[i, x + 1];
                    array[i, x + 1] = array[i, x];
                    array[i, x] = temp;
                }
            }
        }  
    } 
} 


Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение числа для массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение числа для массива: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Заданный массив: ");
int [,] myArray = Random2dArr(m, n, min, max);
Show2dArray(myArray);

Console.WriteLine("Массив с сортировкой: ");
RightArr(myArray);
Show2dArray(myArray); */

// Задача 56

/*int[,] Random2dArr(int rows, int columns, int minRan, int maxRan)
{
    int[,] newArr = new int[rows,columns];

    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArr[i,j] = new Random().Next(minRan, maxRan + 1);

    return newArr;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int MinSumRows (int[,] array)
{
    int minSumm = 0;
    int sumLine = SummRows(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int temp = SummRows(array, i);
        if (sumLine > temp)
        {
            sumLine = temp;
            minSumm = i;
        }
    }
    return minSumm;
}
int SummRows(int[,] array, int i)
{
    int summ = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        summ += array[i, j];
    }
    return summ;
}


Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение числа для массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение числа для массива: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Заданный массив: ");
int [,] myArray = Random2dArr(m, n, min, max);
Show2dArray(myArray);

Console.WriteLine($"\n{MinSumRows(myArray) + 1} - строкa с наименьшей суммой элементов "); */


// Задача 62

/* void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void Loop()
{
    int n = 4;
    int[,] Spiral = new int[n, n];
    int temp = 1, i = 0, j = 0;
    
    while (temp <= Spiral.GetLength(0) * Spiral.GetLength(1))
    {
        Spiral[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < Spiral.GetLength(1) - 1) j++;
        else if (i < j && i + j >= Spiral.GetLength(0) - 1) i++;
        else if (i >= j && i + j > Spiral.GetLength(1) - 1) j--;
        else i--;
    }
    Show2dArray(Spiral);
}
Loop (); */