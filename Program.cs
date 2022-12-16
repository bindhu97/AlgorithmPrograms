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
                "3) Find the Appending elements in LinkedList\n" +
                "4) Find the Ability to insert between number\n" +
                "5) Find the Delete First Element\n" +
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
            }
        }
    }
}


