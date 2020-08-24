using System;

namespace SP{
    class On : State{
        public void offNow(Context context){
            Console.WriteLine("You are in Off State");
            context.CurrentState = new Off();
        }
    }
}