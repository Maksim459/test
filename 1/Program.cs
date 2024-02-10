using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 0;
        while (a <= 10) 
       {
            Task.Delay(100).Wait();
            Console.Clear();
            Console.WriteLine("  /\n /\n/");
            
            Task.Delay(100).Wait();
            Console.Clear();
            Console.WriteLine("\\\n \\\n  \\");
            Task.Delay(100).Wait();
            Console.Clear();
            Console.Clear();
           
            a++;
       }

          
       



    } 

       
   
}