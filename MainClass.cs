using System;

namespace SP{
    public class MainClass{
            public static void Main(string[] args){
            
            Context context = new Context(new Off());
            while(true){
                Console.WriteLine("Enter 1 to Switch On\nEnter 2 to switch Off\n");
                var input = Console.ReadLine();
                if(input.Equals("1")){
                    context.on();
                }else if(input.Equals("2")){
                    context.off();
                }
            }
            
        }
    }
}