namespace TernarySearch;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 34, 21, 2, 432, 27, 22, 342, 2332, 456, 12, 34, 23, 3242, 342, 4342, 342, 34, 7, 45, 322, 546653 };

        Console.WriteLine(array.Search(342));
    }
}

public static class TernarySearch
{
    public static int Search(this int[] array, int searchValue)
    {
        // Sort the array first
        Array.Sort(array);

        // Assign the starting points
        int start = 0;
        int end = array.Length - 1;

        if (array[start] == searchValue) return start;
        if (array[end] == searchValue) return end;

        while(end > start)
        {
            // Calculate the middle points
            int mid1 = start + (end - start) / 3;
            int mid2 = end - (end - start) / 3;

            //Compare if the middle indexes are equal to searched value
            if (searchValue == array[mid1]) return mid1;
            if (searchValue == array[mid2]) return mid2;

            if (searchValue < array[mid1]) end = mid1 - 1;

            else if (searchValue > array[mid2]) start = mid2 + 1;

            else
            {
                start = mid1 + 1;
                end = mid2 - 1;
            }
        }

        return -1;

    }
}

