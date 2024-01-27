static int[] initArray()
{

    int[] array = new int[20];

    for (int i = 0; i < 20; i++)
    {
        array[i] = 2 * i;
    }
    return array;
}

int[] numbersBiggerThan20 = initArray().Where(x => x > 20).ToArray();

Console.WriteLine(string.Join(" ", numbersBiggerThan20));
Console.WriteLine(numbersBiggerThan20.Sum());
