using System;

namespace SP{
    public class Off : State
    {
        public override void OnNow(Context context){
            Console.WriteLine("You are in On State");
            // context.CurrentState = new On();
            context.currentState = new On();
        }

    }
}