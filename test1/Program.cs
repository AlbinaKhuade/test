string[] array = new string[] { "test", "12", "0", "w" };

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        
            if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
            else Console.Write($"{arr[i]}");
        
    }
    Console.WriteLine("]");
}

string[] CreateNewArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }

    string[] newArr = new string[count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}

string[] newArray = CreateNewArray(array);
PrintArray(newArray);
