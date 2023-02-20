

string[] array = new string[5];

FillArray(array);
PrintArray(array);
string[] array1 = ThreeCharactersArray(array);
Console.WriteLine("Полученный массив из элементов, длина которых меньше либо равна 3 символа:");
PrintArray(array1);

void FillArray(string[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Ведите элемент массива: ");
        string element = Console.ReadLine();
        arr[i] = element;
    }
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

string[] ThreeCharactersArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    string[] arr1 = new string[count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
            if (arr[i].Length <= 3)
            {
                arr1[j] = arr[i];
                j++;
            }
    }
    return arr1;
}