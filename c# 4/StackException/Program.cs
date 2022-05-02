// See https://aka.ms/new-console-template for more information
using ArrayHandler;

Console.WriteLine("Welcome to Array Hanlder!");

myArray myArrayObj = new myArray();


try
{
    myArrayObj.print();
    myArrayObj.push(10);
    myArrayObj.push(20);
    myArrayObj.push(30);
    myArrayObj.push(40);
    myArrayObj.push(50);

    // except exception
    myArrayObj.push(60);

    myArrayObj.print();

}
catch(StackFullException error)
{
    Console.WriteLine (error.Message);
}

try
{
    myArrayObj.pop();
    myArrayObj.pop();
    myArrayObj.pop();
    myArrayObj.pop();
    myArrayObj.pop();

    // expect exception
    myArrayObj.pop();

    myArrayObj.print();
}
catch (StackEmptyException error)
{
    Console.WriteLine(error.Message);
}




