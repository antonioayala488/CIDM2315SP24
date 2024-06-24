namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("-------Q1-------");
      Console.WriteLine("Input an integer N:");
      int N = Convert.ToInt16(Console.ReadLine());
      int x = 0;

      for(int i = 1; i<=N; i++){
        if(N %i == 0){
          x++;
        }
      }
      if (x==2){
        Console.WriteLine("N is prime");
      }
      else{
        Console.WriteLine("N is non-prime");
      }
      Console.WriteLine("-----------"); 
    }
}

class Program2
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------Q2-------");
        Console.WriteLine("Assign an int value to N:");
        int N = Convert.ToInt16(Console.ReadLine());
       for(int row = 0; row<N; row++){
    for(int col = 0; col<N; col++)
    {
        Console.Write('#');
    }
    Console.WriteLine("");  
        }
    }
}

class Program3
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------Q3-------");
        Console.WriteLine("Assign an int value to N:");
        int N = Convert.ToInt16(Console.ReadLine());
      for(int row = 0; row<N; row++){
        for(int col = 0; col<N; col++)
        {
            if(row>=col)
                Console.Write('*');
        }
        Console.WriteLine("");
      }
    }
}
