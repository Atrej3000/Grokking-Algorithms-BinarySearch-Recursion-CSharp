namespace BinarySearchRecursion;
class Program
{
    static void Main(string[] args)
    {
        int[] array = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int low = 0;
        int high = array.Length - 1;
        int item = 5;
        Console.WriteLine(BinarySearchRecursion(low, high, item, array));
        Console.ReadLine();
    }
    static int? BinarySearchRecursion(int low, int high, int item, params int[] array)
    {
        if(low > high)
        {
            return null;
        }
        else
        {
            int middle = (low + high) / 2;
            int guess = array[middle];
            if (guess == item)
            {
                return middle;
            }
            if (guess > item)
            {
                return BinarySearchRecursion(low, high - 1, item, array);
            }
            else
            {
                return BinarySearchRecursion(low + 1, high, item, array);
            }
        }
    }
}

