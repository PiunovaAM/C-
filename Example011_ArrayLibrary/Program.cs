void FillArray(int[] collection) // метод заполнения массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // void метод, который ничего не возвращает
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];// создай новый массив в которм будет 10 элементов.

FillArray(array); // заполнили наш массив
PrintArray(array); // распечатывает наш массив
Console.WriteLine();

int pos = IndexOf(array, 44);
Console.WriteLine(pos);