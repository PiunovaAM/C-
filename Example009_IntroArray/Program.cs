int Max(int arg1, int arg2, int arg3) // функция
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//               0   1   2   3   4   5   6   7   8
int[] array = { 11, 21, 31, 41, 51, 61, 71, 81, 91 }; //создали массив
//array[0] = 12; // как можно обратиться к массиву и записать в него значение
//Console.WriteLine(array[4]); // как можно обратиться к массиву и получить значение по указанному ИНДЕКСУ

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(result);