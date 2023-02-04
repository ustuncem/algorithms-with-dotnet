namespace JumpSearch;
class Program
{
    static void Main(string[] args)
    {
        int[] array = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 };

        Console.WriteLine(array.JumpSearch(55));

    }
}

public static class SearcAgorithms
{
    public static int JumpSearch(this int[] array, int searchValue)
    {
        // First sort the array
        Array.Sort(array);

        // Determine the step size
        int stepSize = (int) Math.Sqrt(array.Length);
        int stepCount = 0;

        while(stepCount < array.Length)
        {
            if (searchValue < array[stepCount]) break;
            else stepCount += stepSize;
        }

        //Console.WriteLine(stepCount);
        for(int i = stepCount - stepSize; i < stepCount; i++)
        {
            if (searchValue == array[i]) return i;
        }

        return -1;
    }
}

