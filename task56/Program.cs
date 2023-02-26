// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
//  номер строки с наименьшей суммой элементов: 1 строка


int lines = UserInput("Введите число строк: ");
int columns = UserInput(" Введите число столбцов: ");
int[,] newArr = GetArray(lines, columns);
PrintArray(newArr);
Console.WriteLine();
int temp = LineNumber(newArr);
PrintLineNumber(temp);


int UserInput(string message)
{
    Console.WriteLine(message);
    int userNumber = int.Parse(Console.ReadLine());
    return userNumber;
}

int[,] GetArray(int line, int colum)
{
    int[,] newArray = new int[line, colum];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(0, 10);
        }
    }
    return newArray;
}

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

int LineNumber(int[,] inpArray)
{
    int lineNum = 0;
    int minSum = 0;
    for (int i = 0; i < inpArray.GetLength(1); i++)
    {
        minSum += inpArray[0, i]; // сумма первой строки
    }

    for (int k = 1; k < inpArray.GetLength(0); k++) // начало с 1, т.к. сумма 0 строки учтен ранее
    {
        int sum = 0;
        for (int j = 0; j < inpArray.GetLength(1); j++)
        {
            sum += inpArray[k, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            lineNum = k;
        }

    }

    return lineNum;
}

void PrintLineNumber(int lineNum)
{
    Console.WriteLine($"{lineNum}");
}