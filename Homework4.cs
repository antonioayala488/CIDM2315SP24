namespace Homework5;

class Program
{
    static int Largest(int a, int b)
    {
       if(a>b)
       {
        return a;
       }
       else
       {
        return b;
       }
    
        
    }
    static void Main(string[] args)
    {  
     int first = Convert.ToInt32(Console.ReadLine());
     int second = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("The largest number is: "+ Largest(first,second));
    
    }
}

class Program2
{
      static int Largest(int a, int b)
    {
       if(a>b)
       {
        return a;
       }
       else
       {
        return b;
       }
    
        
    }

    static int Largest(int a, int b, int c, int d)
    {
        return Largest(Largest(a, b), Largest(c, d));
    }
    static void Main(string[] args)
    {  
     int first = Convert.ToInt32(Console.ReadLine());
     int second = Convert.ToInt32(Console.ReadLine());
     int third = Convert.ToInt32(Console.ReadLine());
     int fourth = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("The largest number is: "+ Largest(first,second, third, fourth));
    
    }
}

class Program3
{
    public static void Main(string[] args)
    {
        createAccount();
    }
     public static bool checkAge(int birth_year){
        int age = 2024 - birth_year;
        if (age>=18){
            return true;
        }
        else{
            return false;
        }
    }

     public static void createAccount(){
        Console.WriteLine("Enter Your Username:");
        string username = Console.ReadLine();
        Console.WriteLine("Enter Your Password:");
        string password1 = Console.ReadLine();

        Console.WriteLine("Enter Your Password Again:");
        string password2 = Console.ReadLine();
        Console.WriteLine("Enter Your Birthyear:");
        int birth_year = Convert.ToInt16(Console.ReadLine());

        if(checkAge(birth_year)){
            if(password1==password2){
                Console.WriteLine("Account is created successfully");
            }else{
                Console.WriteLine("Wrong password");
            }
        }
        else{
            Console.WriteLine("Could not create an account.");
        }
    }
}
