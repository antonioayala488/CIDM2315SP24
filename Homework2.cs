namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a letter grade");
        char grade=Console.ReadLine()[0];
        switch(grade)
        {
        case 'A': 
            Console.WriteLine("GPA point: 4");
            break;
        case 'B':
            Console.WriteLine("GPA point: 3");
            break;
        case 'C':
            Console.WriteLine("GPA point: 2");
            break;
        case 'D':
            Console.WriteLine("GPA point: 1");
            break;
        case 'F':
            Console.WriteLine("GPA point: 0");
            break;

        
        default:
            Console.WriteLine("Wrong Letter Grade!");
            break;
        }
    }
}

class Program2
{
    static void Main2(string[] args)
    {
        Console.WriteLine("Please input the first num:");
        int a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the second num:");
        int b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the third num:");
        int c = Convert.ToInt16(Console.ReadLine());
        int smallest = 0;

        if(a<b){
            if(a<c){
            smallest = a;
            }
    }   if(b<a){
            if(b<c){
                smallest = b;
            }
    }
        if(c<a){
            if(c<b){
                smallest = c;
            }
        }

        Console.WriteLine("The smallest value is: {0}", smallest);
}
}       