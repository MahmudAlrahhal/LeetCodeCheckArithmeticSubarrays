using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = new int[] { -12, -9, -3, -12, -6, 15, 20, -25, -20, -15, -10 };
        int[] l = new int[] { 0, 1, 6, 4, 8, 7 };
        int[] r = new int[] { 4, 4, 9, 7, 9, 10 };

        int[] list = new int[] { };
        var answers = new bool[l.Length];

        Array.Fill(answers, true);

        for (var i = 0; i < l.Length; i++)
        {
            int a = 0;
            list = new int[(r[i] - l[i]) + 1];
            for (int p = l[i]; p <= r[i]; p++)
            {
                list[a] = nums[p];
                a++;
            }
            BubbleSort(list);
            var diff = list[1] - list[0];

            for (var j = 2; j < list.Length; j++)
                if (list[j] - list[j - 1] != diff)
                    answers[i] = false;
        }
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    // Compare adjacent elements
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap them if they are in the wrong order
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        foreach (var item in answers)
        {
            Console.Write(item.ToString() + " ");
        }
        Console.ReadKey();
    }
}