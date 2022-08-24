//Функция котороя создает массив с рандомными числами. Длинна массива = 10.
//void = функция которая не возвращает значение из массива
void FillArray(int[] collection)//collection - это название аргумента
{
    int  length = collection.Length;//Длинна массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //Присваем рандомное число индексу в "collection"
        index++;
    }
}
void PrintArray(int[] col)//col - другое название аргумента. Нужно вырабатывать привычку называть все разными именами
{
    int count = col.Length;//Длинна массива "col"
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}
//Создали мфссив который ищет число в массиве "collection" и выдает и ндекс этого(первого) числа:

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;//Будет показывать позицию (-1) если не найдет число в массиве
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;    
    }
    return position;

}
//Определям массив из 10 элементов:
int[] array = new int[10];//Создай новый массив ( = ) в котором будет 10 элементов
//по умолчанию массив будет наполнен нулями
//Метод который заполняет массив значениями:
FillArray(array);
//Метод котрый распечатал массив:
PrintArray(array);
Console.WriteLine();//Пустая строка для разделение массива от массива

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

