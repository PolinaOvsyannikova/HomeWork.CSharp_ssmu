int SizeArray = 0;
while (SizeArray < 2)
{
    Console.WriteLine("Введите размер массива (массив должен содержать минимум 2 элемента):");
    try
    {
        SizeArray = int.Parse(Console.ReadLine());
        if (SizeArray < 2)
        {
            Console.WriteLine("Размер массива не может быть меньше 2! Попробуйте еще раз\n");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message + " Введен некорректный формат\n");
    }
}
int[] Numbers = new int[SizeArray];

for (int i = 0; i < SizeArray; i++)
{
    bool temp = true;

    while (temp)
    {
        Console.WriteLine($"Введите значение {i + 1} элемента массива:");
        try
        {
            Numbers[i] = int.Parse(Console.ReadLine());
            temp = false;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + " Вы ввели не число!\n");
        }
    }
}

int counter = 0;
for (int i = 0; i < Numbers.Length; i++)
{
    if (Numbers[i] == Numbers[0])
    {
        counter++;
    }
}
if (counter != Numbers.Length)
{
    int max = 0;
    int secondMax = 0;
    for (int i = 0; i < Numbers.Length; i++)
    {
        if (Numbers[i] > max)
        {
            secondMax = max;
            max = Numbers[i];
        }
        else
        {
            if (secondMax < Numbers[i] && Numbers[i] != max)
            {
                secondMax = Numbers[i];
            }
        }
    }
    Console.WriteLine($"Второй наибольший элемент массива равен {secondMax}");
}
else
{
    Console.WriteLine("Все элементы массива равны");
}



