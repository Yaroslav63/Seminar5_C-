int[] CreateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(99, 1000);
    }
    return array;
}

int[] GetEvenNumber (int[] array)
{
    int[] evenNumber = new int[array.Length];
    int even_sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (evenNumber[i] % 2 == 0)
        {
            even_sum++;
        }
    }
    return evenNumber;
}
int[] arr = CreateArray(1);
GetEvenNumber(arr);
int[] sum = GetEvenNumber(arr);
Console.WriteLine(sum);