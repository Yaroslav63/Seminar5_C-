int [] CreateArray (int length)
{
    int[] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array [i] = new Random().Next(-200, 201);
    }
    return array;
}

int[] FindSumNumber (int[] array)
{
    int[] sumNumber = new int[array.Length];
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(sumNumber[i]%2 == 0)
        {
            Console.WriteLine();
        }
        else
        {
            sum = sumNumber[i]++;
        }
    }
    return sumNumber;
}

int[] arr = CreateArray(7);
int [] res = FindSumNumber(arr);
System.Console.WriteLine(res);