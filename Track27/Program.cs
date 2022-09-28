// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];
int[] resArray = GetArray(array);
// GetArray(array);
// PrintArray(array);

PrintArray(resArray);

int[] GetArray(int[] arr)
{
    int length = arr.Length;
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}





// int[] arr = new int[8];
// int[] arr1 = new int[8] {1, 7, 4, 3, 2, 6, 4, 3};
// int[] arr2 = {1, 7, 4, 3, 2, 6, 4, 3};

// var
// arr[0] = 1;

// for(int i = 0; i < arr.Length; i++)
// {
//     arr[i] = 34;
// }