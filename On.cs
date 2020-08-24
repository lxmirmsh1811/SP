using System;

namespace SP{
    public class On : State{
        public override void OffNow(Context context){
            Console.WriteLine("You are in Off State");
            // context.CurrentState = new Off();
            context.currentState = new Off();
        }
    }
}