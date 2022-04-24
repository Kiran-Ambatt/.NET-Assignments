//using array;
int[] array = { 1, 4, 5, 8, 9, 7, 6 };
/*

hello arrayobj = new hello();
arrayobj.sum(array);
*/


void abc(int [] array)//not using class
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    Console.WriteLine(sum);
}

abc(array);

bookclass bookclassObj = new bookclass();
bookclassObj.getBookDetails();
bookclassObj.displayBookDetails();

/*namespace array
{
    class printer
    {
        static void Main()
        {
            Console.WriteLine("Executed from Printer -> Main");
        }

        public static void custom()
        {
            Console.WriteLine(100);
        }
    }
}*/
