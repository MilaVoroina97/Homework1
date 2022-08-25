int[]massiv = {1,12,31,41,15,16,17,18,15,10,15};

int n = massiv.Length;
int find = 10;
int index = 0;
while (index < n)
{
    if (massiv[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}


