using System;

namespace SP{
    class MainClass{
            public static void Main(string[] args){
            Context context = new Context(new Off());

            while(true){
                Console.WriteLine("Enter 1 to Switch On\nEnter 2 to switch Off\n");
                int input = Console.Read();

                if(input == 1){
                    context.on();
                }

                else if(input == 2){
                    context.off();
                }
            }
            
        }
    }
}