// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using AlgorithmPrograms;
class Program
{
    public static void Main(string[] args)
    {
        bool check = true;
        while (check)
        {
            Console.WriteLine("Welcome to Algorithm Programs");
            Console.WriteLine("Select Option:\n" +
                "1) Find the Anagram Detection\n" +
                "2) Find the Binary Searching\n" +
                "3) Find the BubbleSort\n" +
                "4) Find the Insertion Sort\n" +
                "5) Find the Merge Sorting\n" +
                "6) Find the Delete Last Element\n" +
                "7) Find the Display of elements\n");

            int option = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            switch (option)
            {
                case 1:
                    AnagramDetection anagram = new AnagramDetection();
                    anagram.Anagram();
                    break;

                case 2:
                    BinarySearching binarysearch = new BinarySearching();
                    Console.WriteLine("Enter string value to search:");
                    string UserInput = Console.ReadLine();
                    Console.WriteLine("User input is :"+UserInput);
                    binarysearch.BinarySearch(UserInput);
                    break;

                    case 3:
                    BubbleSort sort = new BubbleSort();
                    sort.BubbleSorting();
                    break;

                    case 4:
                    InsertionSort insertion = new InsertionSort();
                    insertion.InsertionSorting();
                    break;

                    case 5:
                    MergeSorting merge = new MergeSorting();
                    int[] arrPass = { 55, 89, 214, 62, 150, 66, 99, 33, 11, 45 };
                    int len = Convert.ToInt32(arrPass.Length);
                    merge.MergeSort(arrPass, 0, len - 1);
                    for (int i = 0; i < arrPass.Length; i++)
                    {
                        Console.Write(arrPass[i] + " ");
                    }
                    break;
            }
        }
    }
}


