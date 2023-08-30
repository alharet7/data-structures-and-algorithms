namespace Insertion_Sort
{
    public class Program
    {
        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }
        }

        static void Main(string[] args)
        {
            int[] arrayToSort = { 12, 11, 13, 5, 6 };
            InsertionSort(arrayToSort);

            Console.WriteLine("Sorted array:");
            foreach (int num in arrayToSort)
            {
                Console.Write(num + " ");
            }
            Console.ReadKey();
        }
    }
}
