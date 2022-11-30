//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void Zadanie1()
{
    Console.WriteLine("Введите сколько чисел вы хотите ввести:");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    FillArray(numbers);
    Bolche_0(numbers);
}
void Bolche_0(int[] nums)
{
    int c4et = 0;
    int Length = nums.Length;
    Console.WriteLine();
    Console.Write("Числа больше нуля: ");
    for (int i = 0; i < Length; i++)
    {
        if  (nums[i] > 0)
        {
            Console.Write($"{nums[i]}, ");
            c4et = c4et + 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Всего чисел больше нуля: {c4et}");
}
void FillArray(int[] nums)//Заполнение массива в ручную из N переменных
{
    int Length = nums.Length;
    Console.WriteLine($"Введите {Length} чисел:");
    for (int i = 0; i < Length; i++)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        nums[i] = num;
    }
}
Zadanie1();