void FillArray(int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}
 void PrintArray(int[]col)
 {
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

 }
int IndexOf(int[]collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // создаем переменную для сохранения позиции элемента
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index; // кладем значение индекса нужного числа в отдельно созданную переменную
            break;
        }
        index++;
    }
    return position;
}
int [] massiv1 = new int[10];
FillArray(massiv1);
massiv1[4] = 10;
PrintArray(massiv1);
Console.WriteLine();

int pos = IndexOf(massiv1, 10);
Console.WriteLine(pos);

