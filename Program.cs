
Console.WriteLine("Hello

internal static class MergeSortClass
{
    static void MergeSort(int[] array)
    {
        int[] helper = new int[array.Length];
        MergeSort(array, helper, 0, array.Length - 1);
    }

    private static void MergeSort(int[] array, int[] helper, int low, int high)
    {
        if (low < high)
        {
            int middle = (low + high) / 2;
            MergeSort(array, helper, low, middle);
            MergeSort(array, helper, middle + 1, high);
            Merge();
        }
    }

    private void Merge(int[] array, int[] helper, int low, int middle, int high)
    {
        for (int i = low; i <= high; i++)
        {
            helper[i] = array[i];
        }

        int helperLeft = low;
        int helperRight = middle + 1;
        int current = low;

        while (helperLeft <= middle && helperRight <= high)
        {
            if (helper[helperLeft] <= helper[helperRight])
            {
                array[current] = helper[helperRight];
                helperLeft++;
            }
            else
            {
                array[current] = helper[helperRight];
                helperRight++;
            }
            current++;
        }

        int remaining = middle - helperLeft;
        for (int i = 0; i <= remaining; i++)
        {
            array[current + i] = helper[helperLeft + i];
        }
    }
}