//Вид 1
/*
void Method1() //здесь в скобках мы можем и не указывать ничего в качестве аргументов 
{
    Console.WriteLine("Автор: Пиунова Анастасия");
}

Method1(); // Вызываем метод, только со скобками
// void принимает данные, но не возвращает их
*/
//Вид 2
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg,int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4);
*/
//Вид 3
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/
//Вид 4
/*
int Method4(string count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(count: 10, text: "sweety");
Console.WriteLine(res);

int Method4(string count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(count: 10, text: "sweety");
Console.WriteLine(res);
*/
//Цикл for
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
*/
// Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками
//маленькие буквы "к" заменить большими "К",
//а большие буквы "С" заменить маленькими "с"

/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012345
// s[3] = r то есть третий от нуля символ 

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
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
*/

// Сортировка массива (от min до max)
/*
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1}; //завели массив 

void PrintArray(int[] array) // ввели невозратный метод
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine(); //выводим пустую строку
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary; // 138-140 меняем найденную цифру с самой минимальной местами
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
*/