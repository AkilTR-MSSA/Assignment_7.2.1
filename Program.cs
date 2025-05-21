int[] nums = {66, 23, 623, 42, 53, 100, 2, 6, 127 };
ShellSort(nums);
Console.WriteLine(string.Join(", ", nums));

void ShellSort(int[] arr)
{
    for (int gap = arr.Length / 2; gap > 0; gap /= 2)
    {
        for (int i = gap; i < arr.Length; i++)
        {
            int temp = arr[i];
            int j = i;
            while (j >= gap && arr[j - gap] > temp)
            {
                arr[j] = arr[j - gap];
                j -= gap;
            }
            arr[j] = temp;
        }
    }
}