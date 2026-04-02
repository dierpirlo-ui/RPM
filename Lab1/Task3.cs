using System.Diagnostics;

int JumpSearch(int[] array, int target)
{
    int n = array.Length;
    int step = (int)Math.Sqrt(n);
    int previous = 0;

    while (previous < n && array[Math.Min(previous + step, n) - 1] < target)
    {
        previous += step;
    }

    for (int i = previous; i < Math.Min(previous + step, n); i++)
    {
        if (array[i] == target)
            return i;
    }
    return -1;
}

// 1. Поиск в начале
int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
Debug.Assert(JumpSearch(numbers, 1) == 0);

// 2. Поиск в середине
Debug.Assert(JumpSearch(numbers, 11) == 5);

// 3. Поиск в конце
Debug.Assert(JumpSearch(numbers, 19) == 9);

// 4. Поиск отсутствующего элемента
Debug.Assert(JumpSearch(numbers, 20) == -1);

// 5. Пустой массив
int[] emptyArray = { };
Debug.Assert(JumpSearch(emptyArray, 5) == -1);

// 6. Отрицательные числа
int[] negativeNumbers = { -20, -15, -10, -5, 0, 5, 10 };
Debug.Assert(JumpSearch(negativeNumbers, -10) == 2);
Debug.Assert(JumpSearch(negativeNumbers, 0) == 4);

Console.WriteLine("Все тесты поиска прыжками пройдены");
