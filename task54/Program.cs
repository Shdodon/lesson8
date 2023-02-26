// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();
int lines = UserInput("Введите число строк");
int columns = UserInput("Введите число столбцов");
int[,] newArray = GetArray(lines, columns);
PrintArray(newArray);
Console.WriteLine();
int[,] sort = SortingArray(newArray);
PrintArray(sort);

//Ввод "по сообщению"
int UserInput(string inputMessage)
{
    Console.WriteLine(inputMessage);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Основной генератор двумерного массива
int[,] GetArray(int line, int column)
{
    int[,] outputArray = new int[line, column];
    for (int i = 0; i < outputArray.GetLength(0); i++)
    {
        for (int j = 0; j < outputArray.GetLength(1); j++)
        {
            outputArray[i, j] = new Random().Next(0, 50);
        }
    }
    return outputArray;
}

// печать массива
void PrintArray(int[,] incomArray)
{
    for (int i = 0; i < incomArray.GetLength(0); i++)
    {
        for (int j = 0; j < incomArray.GetLength(1); j++)
        {
            Console.Write($"{incomArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Сортировка строк
int[,] SortingArray(int[,] incArray)
{
    int temp = 0;
    for (int i = 0; i < incArray.GetLength(0); i++)
    {
        for (int j = 0; j < incArray.GetLength(1); j++)
        {
            for (int f = 0; f < incArray.GetLength(1) - 1; f++)
                if (incArray[i, f] < incArray[i, f + 1])
                {
                    temp = incArray[i, f + 1];
                    incArray[i, f + 1] = incArray[i, f];
                    incArray[i, f] = temp;
                }
        }
    }
    return incArray;
}