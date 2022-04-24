/* 6.	Create a structure Book which contains the following members:
bookId, title, price, bookType
Type of the book should an enumerated data type with values as Magazine, Novel, ReferenceBook, Miscellaneous. Write a console based application to do the following tasks.
a.	Accept the details of the book
b.	Display the details of the book. The type of book should be displayed as a string e.g.:
Magazine
 */
public struct Book
{
    public int bookId;
    public string title;
    public int price;
    public string type;
    public enum bookType
    {
        Magazine,
        Novel,
        ReferenceBook,
        Miscellaneous
    }
};
public class bookclass
{
    public Book book;
    public void getBookDetails()
    {
        Console.WriteLine("Enter book id: \n");
        this.book.bookId = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter book title: \n");
        this.book.title = Console.ReadLine();

        Console.WriteLine("Enter book price: \n");
        this.book.price = int.Parse(Console.ReadLine());

        Console.WriteLine("Select book type: \n");

        /*
        Console.WriteLine("0: {0} \n 1: {1} \n 2: {2} \n 3: {3}",
            Book.bookType.Magazine,
            Book.bookType.Novel,
            Book.bookType.ReferenceBook,
            Book.bookType.Miscellaneous
        );

        int bookType = int.Parse(Console.ReadLine());
        
        this.book.type = bookType;
        */

        Console.WriteLine("Enter book type as below: \n");
        foreach (int i in Enum.GetValues(typeof(Book.bookType)))
        {
            Console.WriteLine(i+"\n");
        }
        this.book.type = Console.ReadLine();
    }

    public void displayBookDetails()
    {
        string bookTypes = this.book.type;
        Console.WriteLine("Book type: " + Enum.Parse(typeof(Book.bookType), bookTypes));
    }

    /*
    public static void Main()
    {
        Book books1;
        Book books2;
        Book books3;

        books1.bookId = int.Parse(Console.ReadLine());
        books1.title = Console.ReadLine();
        books1.price = int.Parse(Console.ReadLine());

        books2.bookId = int.Parse(Console.ReadLine());
        books2.title = Console.ReadLine();
        books2.price = int.Parse(Console.ReadLine());

        books3.bookId = int.Parse(Console.ReadLine());
        books3.title = Console.ReadLine();
        books3.price = int.Parse(Console.ReadLine());

        Console.WriteLine("Book 1 title : {0}", books1.bookId);
        Console.WriteLine("Book 1 author : {0}", books1.title);
        Console.WriteLine("Book 1 subject : {0}", books1.price);


        // print Book2 info 
        Console.WriteLine("Book 2 title : {0}", books2.bookId);
        Console.WriteLine("Book 2 author : {0}", books2.title);
        Console.WriteLine("Book 2 subject : {0}", books2.price);

        Console.WriteLine("Book 3 title : {0}", books3.bookId);
        Console.WriteLine("Book 3 author : {0}", books3.title);
        Console.WriteLine("Book 3 subject : {0}", books3.price);
    }
    */
}