// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int linesFirst = UserInput("Введите число строк первой матрицы: ");
int columnsFirst = UserInput("Введите число столбцов первой  матрицы: ");
// Check(linesFirst, columnsSecond); 
int linesSecond = UserInput("Введите число строк второй матрицы: ");
int columnsSecond = linesFirst; // Число столбцов 1 = Числу строк 2
// Check(columnsFirst, linesSecond);

int[,] arrayFirst = (GetArray(linesFirst, columnsFirst));
int[,] arraySecond = (GetArray(linesSecond, columnsSecond));

GetArray(linesFirst, columnsFirst);
GetArray(linesSecond, columnsSecond);

PrintArray(arrayFirst);
Console.WriteLine();
PrintArray(arraySecond);
Console.WriteLine();
PrintArray(MultiMatrix(arrayFirst, arraySecond));

// ввод числа строк, столбцов
int UserInput(string message)
{
    Console.WriteLine(message);
    int inputNum = int.Parse(Console.ReadLine());
    return inputNum;
}

// генератор "матрицы"
int[,] GetArray(int line, int column)
{
    int[,] newArray = new int[line, column];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(0, 10);
        }
    }
    return newArray;
}

// Печать матрицы
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiMatrix(int[,] firstArray, int[,] secondArray)
{
    int[,] multMatrix = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    if (firstArray.GetLength(1) == secondArray.GetLength(0))
    {
        for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            for (int j = 0; j < secondArray.GetLength(1); j++)
            {
                for (int k = 0; k < firstArray.GetLength(1); k++)
                {
                    multMatrix[i, j] += firstArray[i, k] * secondArray[k, j];
                }
            }
        }
    }
    return multMatrix;
}