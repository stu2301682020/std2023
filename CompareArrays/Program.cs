static int[] initArray()
{
    Console.Write("Enter Array size: ");
    int n = int.Parse(Console.ReadLine());
    int[] array = new int[n];

    for(int i = 0; i < n; i++)
    {
        Console.Write($"Enter element {i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }

    return array;
}

static bool compareArrays(int[] firstArray, int[] secondArray)
{
    if (firstArray.Length != secondArray.Length) return false;

    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i] != secondArray[i]) return false;
    } 
    return true;
}


int[] firstArray = initArray();
int[] secondArray = initArray();

Console.WriteLine(compareArrays(firstArray, secondArray) ? 
    "Arrays match!" : 
    "Arrays do not match");

