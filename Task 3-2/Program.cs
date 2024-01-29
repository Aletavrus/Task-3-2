using System.ComponentModel.DataAnnotations.Schema;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Note: ALWAYS answer with lower case letters");
        Console.WriteLine("Enter type of an array");
        Console.WriteLine("Options: one dimension, two dimension, many dimensions");
        string typeArray = Console.ReadLine();
        Console.WriteLine("Do you want to have randomly generated values in array?");
        string getCreationType = Console.ReadLine();
        bool userValues = false;
        if (getCreationType == "no")
        {
            userValues = true;
        }
        if (typeArray == "one dimension")
        {
            OneDimension oneDimension = new OneDimension(userValues);
            oneDimension.Average();
            oneDimension.DeleteOver();
            oneDimension.Unique();
        }
        if (typeArray == "two dimension")
        {
            TwoDimension twoDimension = new TwoDimension(userValues);
            //twoDimension.Average();
            twoDimension.Print();
            Console.WriteLine($"Matrix Determiner = {twoDimension.GetDeterminant()}");
        }
        if (typeArray == "many dimensions")
        {
            ManyDimension manyDimension = new ManyDimension(userValues);
            //manyDimension.EvenNumChange();
            //manyDimension.Print();
            //manyDimension.Average_of_Single();
            //manyDimension.Average_of_All();
        }
    }
}
