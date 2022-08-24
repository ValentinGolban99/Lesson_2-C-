int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//              0   1   2   3   4   5   6   7   8  (Индекс переменной)(N - 1)
int[] array = {15, 25, 113, 64, 45, 56, 78, 81, 19};//Создание массива
// array[0] = 12;// Присвоил индексу значение

// // int max = Max(
// //     Max(a1, b1, c1),
// //     Max(a2, b2, c2),
// //     Max(a3, b3, c3));
// Console.WriteLine(array[0]);// Попросил вывести на консоль значение определенного индекса([0])
int result = Max(Max(array[0], array[1], array[2]),//Нахождение Max через массив
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);